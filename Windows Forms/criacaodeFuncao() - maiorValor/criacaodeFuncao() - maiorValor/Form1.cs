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
    public partial class frmMaiorNumero : Form
    {
        int verificaMaior(int num1, int num2) 
        {
            if (num1 > num2)
            {
                return num1;
            }
            else {
                return num2;
            }
        }

        void limparControles()
        {
            txtA.Clear();
            txtB.Clear();
            txtMaior.Clear();
            txtA.Focus();
        }

        public frmMaiorNumero()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int a, b;

            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            txtMaior.Text = verificaMaior(a, b).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparControles();
        }
    }
}
