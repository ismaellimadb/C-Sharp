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
    public partial class frmSomaCem : Form
    {
        public frmSomaCem()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        { 
           //Apresentar o total da soma obtida dos cem primeiros números inteiros: (1+2+3+4+....+100).
            int num,ac=0;
            for (num = 0; num <= 100;num++)
            {
                ac += num;
            }
            txtResult.Text = ac.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Focus();
        }
    }
}
