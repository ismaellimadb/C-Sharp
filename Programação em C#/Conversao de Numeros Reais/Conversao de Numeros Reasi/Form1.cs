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
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            //declaração das variaveis
            int a, b, soma;
            //entrada de dados
            a = Int32.Parse(txtA.Text);
            
            b = Int32.Parse(txtB.Text);
            //processamento
            soma = a + b;
            //saida de dados
            txtResult.Text = soma.ToString();
        }

        private void btnReais_Click(object sender, EventArgs e)
        {
            //declaração de variaveis
            double a, b, soma;
            //entrada de dados
            a = Convert.ToDouble(txtA.Text);
            b = double.Parse(txtB.Text);
            //processamento
            soma = a + b;
            //saida de dados
            txtResult.Text = soma.ToString();
        }
    }
}
