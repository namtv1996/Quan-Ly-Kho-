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
    public partial class FormQuantity : Form
    {
        public FormQuantity()
        {
            InitializeComponent();
            Load += FormQuantity_Load;
            btnSubmit.Click += BtnSubmit_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (nudQuantity.Value < 0 || nudQuantity.Value > FormExport.currentQuantity)
            {
                MessageBox.Show($"Số lượng sản phẩm hiện tại tối đa = {FormExport.currentQuantity}!");
            }
            else
            {
                FormExport.quantity = nudQuantity.Value;
                Close();
            }
        }

        private void FormQuantity_Load(object sender, EventArgs e)
        {
            label1.Text = $"Sản phẩm: {FormExport.productName}";
        }
    }
}
