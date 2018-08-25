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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ht, vh, pd,sl,sb,td;
            ht = Convert.ToDouble(txtHrdeTrab.Text);
            vh = Convert.ToDouble(txtVlrHr.Text);
            pd = Convert.ToDouble(txtPerDesc.Text);
            sb = ht * vh;
            td = (pd / 100) * sb;
            sl = sb - pd;
            lblResultado.Text = sl.ToString(); 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtHrdeTrab.Text = String.Empty;
            txtPerDesc.Text = String.Empty;
            txtVlrHr.Text = String.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
