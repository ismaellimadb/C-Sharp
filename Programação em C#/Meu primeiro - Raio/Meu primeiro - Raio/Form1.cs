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
    public partial class frmRaio : Form
    {
        public frmRaio()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //declaração das variaveis
            double raio, area, comprimento;
            //entrada de dados
            raio = Convert.ToDouble(txtraio.Text);
            //processamento
            area = 3.14 * (raio * raio);
            comprimento = (3.14 * 3.14) * raio;
            //saida de dados
            txtarea.Text = area.ToString();
            txtcomprimento.Text = comprimento.ToString();
        }
    }
}
