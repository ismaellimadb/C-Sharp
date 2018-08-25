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
    public partial class frmPotencia : Form
    {
        public frmPotencia()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBas.Clear();
            txtExp.Clear();
            lblResultado.ResetText();
            txtBas.Focus();
        }

        private void txtCalcular_Click(object sender, EventArgs e)
        {
            int bas, exp, pot = 1, c = 0;
            bas = Convert.ToInt32(txtBas.Text);
            exp = Convert.ToInt32(txtExp.Text);
            while (c != exp) {
                pot = pot * bas;
                c++;
            }
            lblResultado.Text = pot.ToString();
        }

        private void frmPotencia_Load(object sender, EventArgs e)
        {
            lblResultado.ResetText();
        }
    }
}
