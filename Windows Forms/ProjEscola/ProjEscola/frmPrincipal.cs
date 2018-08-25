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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAluno aluno = new frmAluno();
            aluno.ShowDialog();
        }

        private void tsbProfessor_Click(object sender, EventArgs e)
        {
            frmProfessor professor = new frmProfessor();
            professor.ShowDialog();
        }

        private void tsbAula_Click(object sender, EventArgs e)
        {
            frmAula aula = new frmAula();
            aula.ShowDialog();
        }
    }
}
