using QLNhaKho.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLNhaKho
{
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
            LockControls();
            Load += Form1_Load;
            dgvList.DataError += DgvList_DataError;
            btnImport.Click += BtnAdd_Click;
            btnSave.Click += BtnSave_Click;
            btnEdit.Click += BtnEdit_Click;
            btnExport.Click += BtnDelete_Click;
            dgvList.CellClick += DgvList_CellClick;
            Activated += Form1_Activated;
            btnReport.Click += BtnReport_Click;
            btnSearch.Click += BtnSearch_Click;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearchBox.Text==string.Empty)
            {
                return;
            }
            using (QLKhoDbContext db=new QLKhoDbContext())
            {
                try
                {
                    var res = db.Database.SqlQuery<CommodityView>("commodity_view @makho",
                        new object[]
                        {
                            new SqlParameter("@makho", cbxStorage.SelectedValue)
                        });
                    dgvList.DataSource = res;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FormMain form4 = new FormMain();
            form4.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.Rows[e.RowIndex].Cells[0].Value != null)
                txtID.Text = dgvList.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (dgvList.Rows[e.RowIndex].Cells[1].Value != null)
                txtName.Text = dgvList.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dgvList.Rows[e.RowIndex].Cells[2].Value != null)
                rtbState.Text = dgvList.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dgvList.Rows[e.RowIndex].Cells[3].Value != null)
                dtpProductDate.Value = (DateTime)dgvList.Rows[e.RowIndex].Cells[3].Value;
            if (dgvList.Rows[e.RowIndex].Cells[4].Value != null)
                dtpExpireDate.Value = (DateTime)dgvList.Rows[e.RowIndex].Cells[4].Value;
            if (dgvList.Rows[e.RowIndex].Cells[5].Value != null)
                txtProducer.Text = dgvList.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (dgvList.Rows[e.RowIndex].Cells[6].Value != null)
                nudAmount.Text = dgvList.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (dgvList.Rows[e.RowIndex].Cells[7].Value != null)
                dtpEntryDate.Value = (DateTime)dgvList.Rows[e.RowIndex].Cells[7].Value;
            if (dgvList.Rows[e.RowIndex].Cells[8].Value != null)
                cmbSupplier.SelectedValue = dgvList.Rows[e.RowIndex].Cells[8].Value;

            LockControls();
            btnEdit.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            FormExport form3 = new FormExport();
            form3.Show();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            UnlockControls();
            btnExport.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (var db = new QLKhoDbContext())
            {
                object[] obj =
                {
                    new SqlParameter("@makho",(int)cbxStorage.SelectedValue),
                    new SqlParameter("@mahh",int.Parse(txtID.Text)),
                    new SqlParameter("@tenhh",txtName.Text),
                    new SqlParameter("@tinhtrang",rtbState.Text),
                    new SqlParameter("@mancc",(int)cmbSupplier.SelectedValue),
                    new SqlParameter("@ngaysx",dtpProductDate.Value),
                    new SqlParameter("@hansd",dtpExpireDate.Value),
                    new SqlParameter("@soluongton",int.Parse(nudAmount.Text)),
                    new SqlParameter("@ngaynhap",dtpEntryDate.Value),
                    new SqlParameter("@nhasx",txtProducer.Text)
                };
                int res = db.Database.ExecuteSqlCommand("dbo.commodity_modification @makho,@mahh,@tenhh,@tinhtrang," +
                    "@mancc,@ngaysx,@hansd,@soluongton,@ngaynhap,@nhasx", obj);
                MessageBox.Show($"result = {res}");
                if (res > 0)
                {
                    LoadData();
                    LockControls();
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormImport form2 = new FormImport();
            form2.Show();
        }

        private void CmbStorage_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DgvList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // do nothing here
            //throw new Exception();
        }

        private void LoadData()
        {
            using (var db = new QLKhoDbContext())
            {
                try
                {
                    //var res = db.Database.SqlQuery<CommodityView>("commodity_view @makho",
                    //    new object[]
                    //    {
                    //        new SqlParameter("@makho", cbxStorage.SelectedValue)
                    //    });
                    //dgvList.DataSource = res;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (QLKhoDbContext db = new QLKhoDbContext())
            {
                cbxStorage.DataSource = (db.Khoes.Select(x => x)).ToList();
                cbxStorage.ValueMember = "makho";
                cbxStorage.DisplayMember = "tenkho";

                cmbSupplier.DataSource = (db.NhaCungCaps.Select(x => x)).ToList();
                cmbSupplier.ValueMember = "mancc";
                cmbSupplier.DisplayMember = "tenncc";

                var madd = db.Khoes.SingleOrDefault(x => x.makho == (int)cbxStorage.SelectedValue).madd;
                txtPlace.Text = db.DiaDiems.SingleOrDefault(x => x.madd == madd).tendd;
            }
            LoadData();
            cbxStorage.SelectedValueChanged += CmbStorage_SelectedValueChanged;
        }

        private void LockControls()
        {
            txtID.Enabled = false;
            txtName.Enabled = false;
            rtbState.Enabled = false;
            cmbSupplier.Enabled = false;
            dtpProductDate.Enabled = false;
            dtpExpireDate.Enabled = false;
            nudAmount.Enabled = false;
            dtpEntryDate.Enabled = false;
            txtProducer.Enabled = false;

            btnEdit.Enabled = false;
            btnSave.Enabled = false;
        }

        private void UnlockControls()
        {
            txtName.Enabled = true;
            rtbState.Enabled = true;
            cmbSupplier.Enabled = true;
            dtpProductDate.Enabled = true;
            dtpExpireDate.Enabled = true;
            nudAmount.Enabled = true;
            dtpEntryDate.Enabled = true;
            txtProducer.Enabled = true;

            btnSave.Enabled = true;
        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain u = new FormMain();
            u.Show();
        }
    }
}
