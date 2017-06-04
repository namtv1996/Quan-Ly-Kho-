using QLNhaKho.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaKho
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Load += Form4_Load;
            treeView1.NodeMouseClick += TreeView1_NodeMouseClick;
            FormClosed += FormMain_FormClosed;
            this.Activated += FormMain_Activated;
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            Form4_Load(sender, e);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.Hide();
            if (e.Node.Name == "Xem")
            {
                FormView form1 = new FormView();
                form1.ShowDialog();
            }
            else if (e.Node.Name == "Nhap")
            {
                FormImport form2 = new FormImport();
                form2.ShowDialog();

            }
            else if (e.Node.Name == "Xuat")
            {
                FormExport form3 = new FormExport();
                form3.ShowDialog();
            }
            else if (e.Node.Name == "Help")
            {
                // helping here

            }
            else if (e.Node.Name == "NhanSu")
            {
                FormEmployee frm = new FormEmployee();
                frm.ShowDialog();
            }
            else if (e.Node.Name == "KhachHang")
            {
                FormCustomer frmcus = new FormCustomer();
                frmcus.ShowDialog();
            }
            this.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (var db = new QLKhoDbContext())
            {
                try
                {
                    // thong ke hang hoa nhap
                    foreach (var item in db.Database.SqlQuery<ThongKeNhap>("sp_hh_thongkenhap", 
                        new object[] { }))
                    {
                        chart1.Series["Import"].Points.AddXY(item.ngaynhap.Day,
                            new object[] { item.soluong });
                    }

                    // thong ke hoang hoa xuat
                    foreach (var item in db.Database.SqlQuery<ThongKeXuat>("sp_hh_thongkexuat",
                        new object[] { }))
                    {
                        chart1.Series["Export"].Points.AddXY(item.ngayxuat.Day,
                            new object[] { item.soluong });
                    }


                    foreach (var item in db.Database.SqlQuery<ThongKeHH>("sp_hh_thongkesoluong",
                        new object[] { }))
                    {
                        chart1.Series["Storage"].Points.AddXY(item.ngaynhap.Day,
                            new object[] { item.soluongton });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
