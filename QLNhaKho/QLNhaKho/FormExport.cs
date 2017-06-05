using QLNhaKho.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLNhaKho
{
    public partial class FormExport : Form
    {

        public static decimal quantity;
        public static string productName;
        public static decimal currentQuantity;

        public FormExport()
        {
            InitializeComponent();
            Load += Form3_Load;
            dgvList.CellClick += DgvList_CellClick;
            btnSubmit.Click += BtnSubmit_Click;
            btnCancel.Click += BtnCancel_Click;
            dgvList.DataError += DgvList_DataError;
            dgvSelectedList.CellClick += DgvSelectedList_CellClick;
            btnCancelAll.Click += BtnCancelAll_Click;
            btnSearch.Click += BtnSearch_Click;
            txtSearchBox.KeyDown += TxtSearchBox_KeyDown;
            btnReload.Click += BtnReload_Click;
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        //tim kiem
        private void SearchResult()
        {
            using (var db = new QLKhoDbContext())
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

        //enter nut search
        private void TxtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && txtSearchBox.Text != string.Empty)
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

        private void BtnCancelAll_Click(object sender, EventArgs e)
        {
            dgvSelectedList.Rows.Clear();
        }
        //bo chon sp
        private void DgvSelectedList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex < dgvSelectedList.Rows.Count - 1
                && MessageBox.Show("Bỏ chọn xuất sản phẩm này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvSelectedList.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void DgvList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // do nothing here
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //nút ok
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int res = 0;
                using (var db = new QLKhoDbContext())
                {
                    foreach (DataGridViewRow row in dgvSelectedList.Rows)
                    {
                        if (row.Index < dgvSelectedList.Rows.Count - 1)
                        {
                            object[] obj =
                            {
                            new SqlParameter("@makh",(int)cmbCustomerID.SelectedValue),
                            new SqlParameter("@mahh",(int)row.Cells[4].Value), // product ID
                            new SqlParameter("@soluong",(decimal)row.Cells[2].Value), // selected quantity
                            new SqlParameter("@ngayxuat",(DateTime)dtpExportDate.Value),
                            new SqlParameter("@ngaynhan",(DateTime)dtpReceiveDate.Value),
                            new SqlParameter("@ghichu",rtbNote.Text),
                            new SqlParameter("@danhan",chkReceived.Checked ? 1:0),
                            new SqlParameter("@makho",(int)row.Cells[5].Value) // storage ID
                        };

                            res = db.Database.ExecuteSqlCommand("sp_hh_xuat @makh,@mahh," +
                                "@soluong,@ngayxuat,@ngaynhan,@ghichu,@danhan,@makho", obj);
                        }
                    }

                    if (res > 0)
                    {
                        MessageBox.Show($"da cap nhat");
                        LoadData();
                        dgvSelectedList.Rows.Clear();
                        FormRefresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //click nut cong tren gridview
            if (e.ColumnIndex == 0)
            {
                quantity = 0;
                currentQuantity = (int)dgvList.Rows[e.RowIndex].Cells["soluongton"].Value;
                productName = dgvList.Rows[e.RowIndex].Cells["tenhh"].Value.ToString();
                FormQuantity frm = new FormQuantity();
                frm.ShowDialog();
                frm.Focus();

                // 
                if (quantity > 0)
                {
                    DataGridViewRow row = dgvSelectedList.Rows[0].Clone() as DataGridViewRow;
                    row.Cells[1].Value = dgvList.Rows[e.RowIndex].Cells["tenhh"].Value; // product name
                    row.Cells[2].Value = quantity; // selected quantity
                    row.Cells[3].Value = dgvList.Rows[e.RowIndex].Cells["tinhtrang"].Value; // performance
                    row.Cells[4].Value = dgvList.Rows[e.RowIndex].Cells["mahh"].Value; // product ID
                    row.Cells[5].Value = dgvList.Rows[e.RowIndex].Cells["makho"].Value; // storage ID
                    dgvSelectedList.Rows.Add(row);
                }
            }
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
                cmbCustomerID.DataSource = db.KhachHangs.ToList();
                cmbCustomerID.DisplayMember = "tenkh";
                cmbCustomerID.ValueMember = "makh";
            }
            LoadData();
        }

        private void FormRefresh()
        {
            rtbNote.Text = string.Empty;
            chkReceived.Checked = false;
        }

    }
}
