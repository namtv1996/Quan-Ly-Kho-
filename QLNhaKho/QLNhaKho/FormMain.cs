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
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "Xem")
            {
                FormView form1 = new FormView();
                form1.Show();
            }
            else if (e.Node.Name == "Nhap")
            {
                FormImport form2 = new FormImport();
                form2.Show();

            }
            else if (e.Node.Name == "Xuat")
            {
                FormExport form3 = new FormExport();
                form3.Show();
            }
            else if (e.Node.Name == "Help")
            {
                // helping here

            }
            else if (e.Node.Name == "ThongTinNguoiDung")
            {
                // user info here
            }
            else if (e.Node.Name == "ThemNguoiDung")
            {
                // adding new user here
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (var db = new QLKhoDbContext())
            {
                using (var conn = db.Database.Connection)
                {
                    conn.Open();
                    var cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    // load importing report
                    cmd.CommandText = "select top 7 cast(ngaynhap as date) ngaynhap, count(*) soluong " +
                        "from phieunhap group by cast(ngaynhap as date)";
                    SqlDataAdapter da = new SqlDataAdapter((SqlCommand)cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        chart1.Series["Import"].Points.AddXY(row.Field<DateTime>("ngaynhap"),
                            new object[] { row.Field<int>("soluong") });
                    }

                    // load exporting report
                    cmd.CommandText = "select top 10 cast(ngayxuat as date) ngayxuat, count(*) soluong "
                        + "from phieuxuat group by cast(ngayxuat as date)";
                    da.SelectCommand = (SqlCommand)cmd;
                    dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        chart1.Series["Export"].Points.AddXY(row.Field<DateTime>("ngayxuat"),
                            new object[] { row.Field<int>("soluong") });
                    }

                    conn.Close();
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
