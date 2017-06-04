using QLNhaKho.Model;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLNhaKho
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            Load += FormEmployee_Load;
            dgvList.CellClick += DgvList_CellClick;
            dgvList.DataError += DgvList_DataError;
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnReload.Click += BtnReload_Click;
            btnSearch.Click += BtnSearch_Click;
            txtSearchBox.KeyDown += TxtSearchBox_KeyDown;
        }

        private bool isEdit;

        private void SearchResult()
        {
            try
            {
                using(var db=new QLKhoDbContext())
                {
                    dgvList.DataSource = db.Nhansus.SqlQuery("sp_nhansu_timkiem @value",
                        new SqlParameter("@value", txtSearchBox.Text)).ToList();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}!");
            }
        }

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

        private void BtnReload_Click(object sender, EventArgs e)
        {
            ControlResetText();
            LockControl();
            LoadData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new QLKhoDbContext())
                {
                    var id = int.Parse(txtEmployeeID.Text);
                    var emp = db.Nhansus.Find(id);
                    if (emp != null && MessageBox.Show("Xoa thong tin?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.Nhansus.Remove(emp);
                        if (db.SaveChanges() > 0)
                        {
                            MessageBox.Show("Da xoa thong tin!");
                            LoadData();
                            ControlResetText();
                            //LockControl();
                        }
                        else
                        {
                            MessageBox.Show("Error!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == string.Empty && txtEmployeeID.Text.IsNumber())
            {
                return;
            }

            try
            {
                using (var db = new QLKhoDbContext())
                {
                    int res = 0;
                    if (isEdit)
                    {
                        var id = int.Parse(txtEmployeeID.Text);
                        var emp = db.Nhansus.Find(id);
                        if (emp != null)
                        {
                            emp.hoten = txtEmployeeName.Text;
                            emp.gioitinh = rbnMale.Checked ? "Nam" : "Nu";
                            emp.diachi = txtAddress.Text;
                            emp.ngaysinh = (DateTime)dtpDOB.Value;
                            emp.makho = (int)cmbStorage.SelectedValue;
                            emp.macv = (int)cmbOfficer.SelectedValue;
                            emp.sdt = txtContact.Text;

                            res = db.SaveChanges();
                        }
                    }
                    else
                    {
                        var emp = new Nhansu()
                        {
                            hoten = txtEmployeeName.Text,
                            gioitinh = rbnMale.Checked ? "Nam" : "Nu",
                            diachi = txtAddress.Text,
                            ngaysinh = (DateTime)dtpDOB.Value,
                            makho = (int)cmbStorage.SelectedValue,
                            macv = (int)cmbOfficer.SelectedValue,
                            sdt = txtContact.Text
                        };

                        db.Nhansus.Add(emp);
                        res = db.SaveChanges();
                    }
                    if (res > 0)
                    {
                        MessageBox.Show("Da cap nhat!");
                        LockControl();
                        LoadData();
                        ControlResetText();
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            isEdit = true;
            UnlockControl();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            isEdit = false;
            UnlockControl();
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (DataGridViewRow row = dgvList.Rows[e.RowIndex])
                {
                    if(row.Cells["diachi"].Value!=null)
                    txtAddress.Text = row.Cells["diachi"].Value.ToString();
                    if (row.Cells["sdt"].Value != null)
                        txtContact.Text = row.Cells["sdt"].Value.ToString();
                    txtEmployeeID.Text = row.Cells["mans"].Value.ToString();
                    if (row.Cells["hoten"].Value != null)
                        txtEmployeeName.Text = row.Cells["hoten"].Value.ToString();
                    cmbOfficer.SelectedValue = row.Cells["macv"].Value;
                    cmbStorage.SelectedValue = row.Cells["makho"].Value;
                    if (row.Cells["ngaysinh"].Value != null)
                        dtpDOB.Value = (DateTime)row.Cells["ngaysinh"].Value;
                    if (row.Cells["gioitinh"].Value.ToString().Equals("Nam"))
                    {
                        rbnMale.Checked = true;
                    }
                    else
                    {
                        rbnFemale.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void DgvList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // DO NOTHING HERE
        }

        private void LoadData()
        {
            try
            {
                using (var db = new QLKhoDbContext())
                {
                    dgvList.DataSource = db.Nhansus.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;

            LockControl();

            //
            LoadData();
            try
            {
                using (var db = new QLKhoDbContext())
                {
                    cmbOfficer.DataSource = db.ChucVus.ToList();
                    cmbOfficer.DisplayMember = "tencv";
                    cmbOfficer.ValueMember = "macv";

                    cmbStorage.DataSource = db.Khoes.ToList();
                    cmbStorage.DisplayMember = "tenkho";
                    cmbStorage.ValueMember = "makho";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UnlockControl()
        {
            txtAddress.Enabled = true;
            txtContact.Enabled = true;
            txtEmployeeName.Enabled = true;
            cmbOfficer.Enabled = true;
            cmbStorage.Enabled = true;
            dtpDOB.Enabled = true;
            rbnFemale.Enabled = true;
            rbnMale.Enabled = true;
        }

        private void LockControl()
        {
            txtEmployeeID.Enabled = false;
            txtEmployeeName.Enabled = false;
            txtAddress.Enabled = false;
            txtContact.Enabled = false;
            cmbOfficer.Enabled = false;
            cmbStorage.Enabled = false;
            dtpDOB.Enabled = false;
            rbnFemale.Enabled = false;
            rbnMale.Enabled = false;
        }

        private void ControlResetText()
        {
            txtAddress.ResetText();
            txtContact.ResetText();
            txtEmployeeID.ResetText();
            txtEmployeeName.ResetText();
        }
    }
}
