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
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1,nota2,nota3,media;
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);
            media = (nota1 + nota2 + nota3) / 3;
            if (media >= 7)
            {
                MessageBox.Show("Aluno Aprovado!\nMédia: " + media.ToString("#.#"));
            }
            else
            {
                MessageBox.Show("REPROVADO!!!!\nMédia: " + media.ToString("#.#"));
            }
        }

        private void txtMedia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}