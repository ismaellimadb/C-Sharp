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
    public partial class frmVolume : Form
    {
        public frmVolume()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double volume,raio;
            raio = Convert.ToDouble(txtRaio.Text);
            volume = (4 / 3) * 3.14 * (raio * raio * raio);
            txtVolume.Text = volume.ToString();
        }
    }
}
