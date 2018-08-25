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
    public partial class frmVerificarAnoBissexto7241 : Form
    {
        public frmVerificarAnoBissexto7241()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //declaração de variaveis
            int ano7241;
            //processamento
            ano7241 = Convert.ToInt32(txtAno7241.Text);
            //verificar ano bissexto
            if (((ano7241 % 400) == 0 || (ano7241 % 4 == 0 && ano7241 % 100 != 0)))
            {
                lblResultado7241.Text = "Ano Bissexto";
            }
            else
            {
                lblResultado7241.Text = "Ano não Bissexto";
            }
        }

        private void frmVerificarAnoBissexto7241_Load(object sender, EventArgs e)
        {
            lblResultado7241.ResetText();
        }
    }
}
