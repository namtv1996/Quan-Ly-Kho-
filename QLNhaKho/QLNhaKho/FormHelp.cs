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
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
            webBrowser1.Navigate(@"");
        }

        private void FormHelp_Load(object sender, EventArgs e)
        {
            
        }

        private void FormHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain u = new FormMain();
            u.Show();
           
        }
    }
}
