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
    public partial class frmAreaTrapezio : Form
    {
        public frmAreaTrapezio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declaração de variaveis
            double basemaior, basemenor, altura, area;
            //entrada de dados
            basemaior = Convert.ToDouble(txtBaseMaior.Text);
            basemenor = Convert.ToDouble(txtBaseMenor.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            //processamento
            area = (basemaior * basemenor) / 2 * altura;
            //saida de dados
            txtArea.Text = area.ToString();
        }
    }
}
