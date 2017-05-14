using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLNhaKho
{
    public partial class FormImport : Form
    {
        public FormImport()
        {
            InitializeComponent();
            Load += Form2_Load;
            btnAdd.Click += BtnAdd_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refresh");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var db=new QLKhoDbContext())
            {
                object[] obj =
                {
                    new SqlParameter("@makho",(int)cmbStorage.SelectedValue),
                    new SqlParameter("@mancc",(int)cmbSupplier.SelectedValue),
                    new SqlParameter("@ngaynhap",dtpImportingDate.Value),
                    new SqlParameter("@soluong",int.Parse(nudAmount.Text)),
                    new SqlParameter("@danhan",cbxReceived.Checked ? 1:0),
                    new SqlParameter("@ghichu",rtbNote.Text),
                    new SqlParameter("@ten",txtCommodityName.Text),
                    new SqlParameter("@tinhtrang",rtbState.Text),
                    new SqlParameter("@ngaysx",dtpProductingDate.Value),
                    new SqlParameter("@hansd",dtpExpiringDate.Value),
                    new SqlParameter("@nhasx",txtProducer.Text)
                };
                int res = db.Database.ExecuteSqlCommand(@"dbo.commodity_insertion @makho,@mancc,
                @ngaynhap,@soluong,@danhan,@ghichu,@ten,@tinhtrang,@ngaysx,@hansd,@nhasx",obj);
                if(res > 0)
                    MessageBox.Show($"Đã thêm hàng hóa!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using(var db=new QLKhoDbContext())
            {
                cmbSupplier.DataSource = (db.NhaCungCaps.Select(x => x)).ToList();
                cmbSupplier.ValueMember = "mancc";
                cmbSupplier.DisplayMember = "tenncc";

                cmbStorage.DataSource = (db.Khoes.Select(x => x)).ToList();
                cmbStorage.ValueMember = "makho";
                cmbStorage.DisplayMember = "tenkho";
            }
        }
    }
}
