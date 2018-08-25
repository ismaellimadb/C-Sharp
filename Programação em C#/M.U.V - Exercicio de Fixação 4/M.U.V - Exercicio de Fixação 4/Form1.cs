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
    public partial class frmMuv : Form
    {
        public frmMuv()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declaração das variaveis
            double velocidadeinicial, aceleracao, tempo, velocidade;
            //entrada de dados
            velocidadeinicial = Convert.ToDouble(txtVelocidadeInicial.Text);
            aceleracao = Convert.ToDouble(txtAceleracao.Text);
            tempo = Convert.ToDouble(txtTempo.Text);
            //processamento
            velocidade = velocidadeinicial + (aceleracao * tempo);
            //saida de dados
            txtVelocidade.Text = velocidade.ToString();
        }
    }
}
