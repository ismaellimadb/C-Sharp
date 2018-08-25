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

        private void grpAritimetica_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtY.Clear();
            txtX.Clear();
            txtTotal.Clear();
            txtX.Focus();
            rdbSoma.Checked = true;
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            rdbSoma.Checked = true;
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double x, y, total;
            x = Convert.ToDouble(txtX.Text);
            y = Convert.ToDouble(txtY.Text);
            if (rdbSoma.Checked == true) {
                total = x + y;
                txtTotal.Text = total.ToString();
            }
            else if (rdbSubtrai.Checked == true) {
                total = x - y;
                txtTotal.Text = Convert.ToString(total);
            }
            else if (rdbMultiplica.Checked == true)
            {
                total = x * y;
                txtTotal.Text = total.ToString();
            }
            else {
                total = x / y;
                if (y == 0)
                {
                    txtTotal.Text = "Divisão por Zero";
                    return;
                }
                txtTotal.Text = Convert.ToString(total);
            }
        }
    }
}
