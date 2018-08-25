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
    public partial class frmConverterTemperatura : Form
    {
        public frmConverterTemperatura()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            //declaração de variaveis
            double celsius7241, farenheit7241;
            //entrada de dados
            celsius7241 = Convert.ToDouble(txtGrausCelsius7241.Text);
            //processamento
            farenheit7241 = (9 * celsius7241 + 160) / 5;
            //Validação
            if (farenheit7241 > 45 && farenheit7241 < 90)
            {
                MessageBox.Show("Temperatura Normal");
            }
            //saida de dados
            txtGrausFarenheit7241.Text = farenheit7241.ToString();
        }
    }
}
