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
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int num = 1,ac=0;
            while (num <= 400) { 
                if((num % 4 ==0) && (num % 3==0)){
                    ac += num;
                }
                num++;
            }
            lblResult.Text = ac.ToString();
            MessageBox.Show("" + ac, "Resultado");
        }
    }
}
