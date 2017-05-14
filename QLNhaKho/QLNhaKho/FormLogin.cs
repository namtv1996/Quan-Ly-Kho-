using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKho
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            btnExit.Click += BtnExit_Click;
            llblRegister.Click += LlblRegister_Click;
        }

        private void LlblRegister_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "1234" && txtUsername.Text == "ttnhom")
            {
                this.Hide();
                FormMain form4 = new FormMain();
                form4.Show();
            }
            else
            {
                MessageBox.Show("Invalid user name or password!");
                return;
            }
        }
    }
}
