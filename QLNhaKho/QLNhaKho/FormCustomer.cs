using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKho
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
            Load += Form6_Load;
            btnRefresh.Click += BtnRefresh_Click;
            btnAdd.Click += BtnAdd_Click;
            dgvList.DataError += DgvList_DataError;
            btnEdit.Click += BtnEdit_Click;
            cbxMonthOfBirth.SelectedValueChanged += CbxMonthOfBirth_SelectedValueChanged;
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
            dgvList.CellClick += DgvList_CellClick;

            for (int k = 1980; k <= 2017; k++)
            {
                cbxYearOfBirth.Items.Add($"{k}\n");
            }

        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvList.CurrentRow;
            txtCustomerID.Text = row.Cells["makh"].Value.ToString();
            txtCustomerName.Text = row.Cells["tenkh"].Value.ToString();
            if(row.Cells["makh"].Value.ToString().Equals("Nam"))
            {
                rbnMale.Checked = true;
            }
            else
            {
                rbnFemale.Checked = true;
            }
            var dob = (DateTime)row.Cells["ngaysinh"].Value;
            cbxMonthOfBirth.Text = dob.Month.ToString();
            cbxDayOfBirth.Text = dob.Day.ToString();
            cbxYearOfBirth.Text = dob.Year.ToString();
            rtbCustomerAddress.Text = row.Cells["diachi"].Value.ToString();
            txtCustomerPN.Text = row.Cells["sdt"].Value.ToString();

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private bool edit;

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == string.Empty || cbxDayOfBirth.Text == string.Empty
                || !cbxDayOfBirth.Text.IsPhoneNumber())
            {
                MessageBox.Show("Nhap thong tin");
                return;
            }
            int res = 0;
            try
            {
                string dob = $"{cbxMonthOfBirth.Text}/{cbxDayOfBirth.Text}/{cbxYearOfBirth.Text}";
                using (QLKhoDbContext db = new QLKhoDbContext())
                {
                    object[] obj =
                    {
                        new SqlParameter("@tenkh", txtCustomerName.Text),
                        new SqlParameter("@gioitinh", rbnFemale.Checked ? "Nu" : "Nam"),
                        new SqlParameter("@ngaysinh", DateTime.Parse(dob)),
                        new SqlParameter("@diachi", rtbCustomerAddress.Text),
                        new SqlParameter("@sdt", txtCustomerPN.Text)
                    };
                    if(!edit)
                        res = db.Database.ExecuteSqlCommand("sp_customer_insert " +
                            "@tenkh, @gioitinh, @ngaysinh, @diachi, @sdt", obj);
                    else
                    {
                        obj = new object[]
                        {
                            new SqlParameter("@makh", txtCustomerID.Text),
                            new SqlParameter("@tenkh", txtCustomerName.Text),
                            new SqlParameter("@gioitinh", rbnFemale.Checked ? "Nu" : "Nam"),
                            new SqlParameter("@ngaysinh", DateTime.Parse(dob)),
                            new SqlParameter("@diachi", rtbCustomerAddress.Text),
                            new SqlParameter("@sdt", txtCustomerPN.Text)
                        };
                        res = db.Database.ExecuteSqlCommand("sp_customer_update " +
                            "@makh, @tenkh, @gioitinh, @ngaysinh, @diachi, @sdt", obj);
                    }
                }
                if (res > 0)
                {
                    MessageBox.Show($"Da cap nhat");
                    Form6_Load(sender, e);
                    LockControll();
                    BtnRefresh_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == string.Empty)
            {
                MessageBox.Show("Chon thong tin de xoa!");
                return;
            }
            using (QLKhoDbContext db = new QLKhoDbContext())
            {
                try
                {
                    int id = int.Parse(txtCustomerID.Text);
                    var customer = db.KhachHangs.Find(id);
                    db.KhachHangs.Remove(customer);
                    db.SaveChanges();
                    MessageBox.Show("Da xoa!");
                    Form6_Load(sender, e);
                    LockControll();
                    BtnRefresh_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void CbxMonthOfBirth_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (int.Parse(cbxMonthOfBirth.Text))
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    cbxDayOfBirth.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                    {
                        cbxDayOfBirth.Items.Add(i);
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    cbxDayOfBirth.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                    {
                        cbxDayOfBirth.Items.Add(i);
                    }
                    break;
                case 2:
                    cbxDayOfBirth.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                    {
                        cbxDayOfBirth.Items.Add(i);
                    }
                    if (int.Parse(cbxYearOfBirth.Text) % 4 == 0 && int.Parse(cbxYearOfBirth.Text) % 100 != 0)
                    {
                        cbxDayOfBirth.Items.Add(29);
                        if (int.Parse(cbxDayOfBirth.Text) == 29)
                            cbxDayOfBirth.Text = "28";
                    }
                    break;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            edit = true;
            UnlockControll();
        }

        private void DgvList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // DO NOTHING HERE
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            edit = false;
            UnlockControll();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            cbxDayOfBirth.Text = string.Empty;
            rtbCustomerAddress.Text = string.Empty;
            txtCustomerPN.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            using (QLKhoDbContext db = new QLKhoDbContext())
            {
                dgvList.DataSource = db.KhachHangs.ToList();
            }
        }

        private void LockControll()
        {
            txtCustomerID.Enabled = false;
            txtCustomerName.Enabled = false;
            txtCustomerPN.Enabled = false;
            cbxDayOfBirth.Enabled = false;
            cbxMonthOfBirth.Enabled = false;
            cbxYearOfBirth.Enabled = false;
            rbnFemale.Enabled = false;
            rbnMale.Enabled = false;
            rtbCustomerAddress.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void UnlockControll()
        {
            txtCustomerName.Enabled = true;
            txtCustomerPN.Enabled = true;
            cbxDayOfBirth.Enabled = true;
            cbxMonthOfBirth.Enabled = true;
            cbxYearOfBirth.Enabled = true;
            rbnFemale.Enabled = true;
            rbnMale.Enabled = true;
            rtbCustomerAddress.Enabled = true;
            btnSave.Enabled = true;
        }
    }
}
