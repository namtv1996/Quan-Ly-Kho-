using QLNhaKho.Model;
using System;
using System.Collections.Generic;
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
            btnImport.Click += BtnImport_Click;
            btnSave.Click += BtnSave_Click;
            btnEdit.Click += BtnEdit_Click;
            btnExport.Click += BtnExport_Click;
            dgvList.CellClick += DgvList_CellClick;
            Activated += Form1_Activated;
            btnReport.Click += BtnReport_Click;
            btnSearch.Click += BtnSearch_Click;
            txtSearchBox.KeyDown += TxtSearchBox_KeyDown;
        }

        private void SearchResult()
        {
            using (QLKhoDbContext db = new QLKhoDbContext())
            {
                try
                {
                    List<XemHangHoa> res = new List<XemHangHoa>();
                    res = db.Database.SqlQuery<XemHangHoa>("sp_hh_search @value",
                        new object[]
                        {
                                    new SqlParameter("@value", txtSearchBox.Text)
                        }).ToList();


                    dgvList.DataSource = res;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void TxtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && txtSearchBox.Text != string.Empty)
            {
                SearchResult();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchBox.Text != string.Empty)
            {
                SearchResult();
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
            var row = dgvList.CurrentRow;

            txtID.Text = row.Cells["mahh"].Value.ToString();
            txtName.Text = row.Cells["tenhh"].Value.ToString();
            rtbState.Text = row.Cells["tinhtrang"].Value.ToString();
            txtProducer.Text = row.Cells["nhasx"].Value.ToString();
            nudAmount.Text = row.Cells["soluongton"].Value.ToString();
            dtpEntryDate.Value = (DateTime)row.Cells["ngaynhap"].Value;
            cmbSupplier.SelectedValue = row.Cells["mancc"].Value;
            cbxGoodsType.SelectedValue = row.Cells["maloaihh"].Value;
            cbxStorage.SelectedValue = row.Cells["makho"].Value;

            LockControls();
            btnEdit.Enabled = true;
        }

        private void BtnExport_Click(object sender, EventArgs e)
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
                    new SqlParameter("@maloaihh", (int)cbxGoodsType.SelectedValue),
                    new SqlParameter("@soluongton",int.Parse(nudAmount.Text)),
                    new SqlParameter("@ngaynhap",dtpEntryDate.Value),
                    new SqlParameter("@nhasx",txtProducer.Text)
                };
                int res = db.Database.ExecuteSqlCommand("sp_hh_sua @makho,@mahh,@tenhh,@tinhtrang," +
                    "@mancc,@maloaihh,@soluongton,@ngaynhap,@nhasx", obj);
                MessageBox.Show($"result = {res}");
                if (res > 0)
                {
                    LoadData();
                    LockControls();
                }
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
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
                //try
                //{
                   var res = db.Database.SqlQuery<XemHangHoa>("sp_hh_xem",
                        new object[] { });
                    dgvList.DataSource = res.ToList();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error: " + ex.Message);
                //}
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (QLKhoDbContext db = new QLKhoDbContext())
            {
                cbxStorage.DataSource = db.Khoes.ToList();
                cbxStorage.ValueMember = "makho";
                cbxStorage.DisplayMember = "tenkho";

                cmbSupplier.DataSource = db.NhaCungCaps.ToList();
                cmbSupplier.ValueMember = "mancc";
                cmbSupplier.DisplayMember = "tenncc";

                cbxGoodsType.DataSource = db.LoaiHangHoas.ToList();
                cbxGoodsType.DisplayMember = "tenloaihh";
                cbxGoodsType.ValueMember = "maloaihh";
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
            nudAmount.Enabled = false;
            dtpEntryDate.Enabled = false;
            txtProducer.Enabled = false;
            cbxGoodsType.Enabled = false;

            btnEdit.Enabled = false;
            btnSave.Enabled = false;
        }

        private void UnlockControls()
        {
            txtName.Enabled = true;
            rtbState.Enabled = true;
            cmbSupplier.Enabled = true;
            nudAmount.Enabled = true;
            dtpEntryDate.Enabled = true;
            txtProducer.Enabled = true;
            cbxGoodsType.Enabled = true;

            btnSave.Enabled = true;
        }
    }
}
