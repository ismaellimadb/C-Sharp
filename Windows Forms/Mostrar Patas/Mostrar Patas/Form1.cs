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
    public partial class frmMostPat : Form
    {
        public frmMostPat()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMostPat_Load(object sender, EventArgs e)
        {
            cboAnimais.Items.Add("Gato");
            cboAnimais.Items.Add("Cachorro");
            cboAnimais.Items.Add("Passaro");
            cboAnimais.Items.Add("Cavalo");
            cboAnimais.Items.Add("Centopeia");
            cboAnimais.Items.Add("Cobra");
            cboAnimais.SelectedItem = "Gato";
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string Animais;
            Animais = cboAnimais.Text;
            switch(Animais){
            case "Gato":
            pctAnimais.Load("gato.jpg");
            MessageBox.Show("Esse animal possui 4 patas", "Animais");
            break;
            case "Cachorro":
            pctAnimais.Load("cachorro.jpg");
            MessageBox.Show("Esse animal possui 4 patas", "Animais");
            break;
            case "Cavalo":
            pctAnimais.Load("cavalo.jpg");
            MessageBox.Show("Esse animal possui 4 patas","Animais");
            break;
            case "Centopeia":
            pctAnimais.Load("centopeia.jpg");
            MessageBox.Show("Esse animal possui 100 patas","Animais");
            break;
            case "Cobra":
            pctAnimais.Load("cobra.jpg");
            MessageBox.Show("Esse animal não possui patas","Animais");
            break;
            case "Passaro":
            pctAnimais.Load("passaro.jpg");
            MessageBox.Show("Esse animal possui duas patas","Animais");
            break;
        }
      }
    }
}
