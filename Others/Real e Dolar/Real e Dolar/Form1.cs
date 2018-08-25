using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmConverterMoeda : Form
    {
        public frmConverterMoeda()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double real;
            real = Convert.ToDouble(txtReal.Text);
            real += real * 300 / 100;
            txtDolar.Text = real.ToString();
        }
    }
}
