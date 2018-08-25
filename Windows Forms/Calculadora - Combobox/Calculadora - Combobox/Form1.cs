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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            cboOperations.Items.Add("Soma");
            cboOperations.Items.Add("Subtração");
            cboOperations.Items.Add("Multiplicação");
            cboOperations.Items.Add("Divisão");
            cboOperations.SelectedItem = "Soma";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtX.ResetText();
            txtY.Text = (" ");
            txtResultado.Text = String.Empty;
            txtX.Focus();
            cboOperations.SelectedItem = "Soma";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x, y, resultado;
            x = Convert.ToDouble(txtX.Text);
            y = Convert.ToDouble(txtY.Text);
            if (cboOperations.SelectedItem.ToString() == "Soma") {
                resultado = x + y;
                txtResultado.Text = resultado.ToString();
            }
            else if (cboOperations.SelectedItem.ToString() == "Subtração") {
                resultado = x - y;
                txtResultado.Text = resultado.ToString();
            }
            else if (cboOperations.SelectedItem.ToString() == "Multiplicação")
            {
                resultado = x * y;
                txtResultado.Text = resultado.ToString();
            }
            else {
                resultado = x / y;
                if(y == 0){
                    txtResultado.Text = "Divisão por zero";
                    return;
                }
                txtResultado.Text = resultado.ToString();
            }
        }
    }
}
