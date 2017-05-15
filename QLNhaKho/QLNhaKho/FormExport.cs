using QLNhaKho.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLNhaKho
{
    public partial class FormExport : Form
    {
        public FormExport()
        {
            InitializeComponent();
            Load += Form3_Load;
            dgvList.CellClick += DgvList_CellClick;
            nudSelect.ValueChanged += NudAmountOfCommodities_ValueChanged;
            btnSubmit.Click += BtnSubmit_Click;
            btnCancel.Click += BtnCancel_Click;
            dgvList.DataError += DgvList_DataError;
        }

        private void DgvList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // do nothing here
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int res = 0;
                using (var db = new QLKhoDbContext())
                {
                    foreach(DataGridViewRow row in dgvList.Rows)
                    {
                        DataGridViewCheckBoxCell cell = row.Cells["Chon"] as DataGridViewCheckBoxCell;
                        if ((bool)cell.EditedFormattedValue == true)
                        {
                            object[] obj =
                            {
                            new SqlParameter("@makh",(int)cmbCustomerID.SelectedValue),
                            new SqlParameter("@mahh",(int)row.Cells["mahh"].Value),
                            new SqlParameter("@soluong",(int)row.Cells["soluong"].Value),
                            new SqlParameter("@ngayxuat",(DateTime)dtpExportDate.Value),
                            new SqlParameter("@ngaynhan",(DateTime)dtpReceiveDate.Value),
                            new SqlParameter("@ghichu",rtbNote.Text),
                            new SqlParameter("@danhan",chkReceived.Checked ? 1:0),
                            new SqlParameter("@makho",(int)row.Cells["makho"].Value)
                            };

                            res = db.Database.ExecuteSqlCommand("sp_hh_xuat @makh,@mahh," +
                                "@soluong,@ngayxuat,@ngaynhan,@ghichu,@danhan,@makho", obj);
                        }
                    }
                    
                    if (res > 0)
                    {
                        MessageBox.Show($"da cap nhat");
                        LoadData();
                        FormRefresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private int currentIndex = 0;
        private bool isCurrentRow;

        private void NudAmountOfCommodities_ValueChanged(object sender, EventArgs e)
        {
            if (isCurrentRow)
                dgvList.Rows[currentIndex].Cells["soluong"].Value = int.Parse(nudSelect.Text);
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCurrentRow = false;
            nudTotal.Text = dgvList.Rows[e.RowIndex].Cells["soluongton"].Value.ToString();
            if (dgvList.Rows[e.RowIndex].Cells["soluong"].Value != null)
                nudSelect.Text = dgvList.Rows[e.RowIndex].Cells["soluong"].Value.ToString();
            else
                nudSelect.Text = "0";
            nudSelect.Maximum = (int)dgvList.Rows[e.RowIndex].Cells["soluongton"].Value;
            txtCommodityID.Text = dgvList.Rows[e.RowIndex].Cells["mahh"].Value.ToString();
            if (dgvList.Rows[e.RowIndex].Cells["tenhh"].Value != null)
                txtCommodityName.Text = dgvList.Rows[e.RowIndex].Cells["tenhh"].Value.ToString();
            txtStorageID.Text = dgvList.Rows[e.RowIndex].Cells["makho"].Value.ToString();

            isCurrentRow = true;
            currentIndex = e.RowIndex;

        }

        private void LoadData()
        {
            using (var db = new QLKhoDbContext())
            {
                dgvList.DataSource = db.Database.SqlQuery<XemHangHoa>("sp_hh_xem",
                    new object[] { }).ToList();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            using (var db = new QLKhoDbContext())
            {
                cmbCustomerID.DataSource = (db.KhachHangs.Select(x => x)).ToList();
                cmbCustomerID.DisplayMember = "tenkh";
                cmbCustomerID.ValueMember = "makh";
            }
            LoadData();
        }

        private void FormRefresh()
        {
            nudTotal.ResetText();
            nudSelect.ResetText();
            txtCommodityID.Text = string.Empty;
            txtCommodityName.Text = string.Empty;
            txtStorageID.Text = string.Empty;
            rtbNote.Text = string.Empty;
            chkReceived.Checked = false;
        }
    }
}
