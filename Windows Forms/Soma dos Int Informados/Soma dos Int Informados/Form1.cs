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
    public partial class frmSomNum : Form
    {
        public frmSomNum()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*
              Elaborar um programa que efetue e apresente o somatório dos N primeiros números inteiros
              (1+2+3,....,+N), no qual o usuário determina o valor de N.
             */
            int num, n, ac = 0;
            n = Convert.ToInt32(txtValor.Text);
            for (num = 0; num <= n; num++) {
                    ac += num;
                }
            MessageBox.Show("" + ac, "Resultado");
        }
    }
}
