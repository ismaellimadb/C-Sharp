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
    public partial class frmAula : Form
    {
        public frmAula()
        {
            InitializeComponent();
        }

        private void aulaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aulaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBCadastrarAulaDataSet);

        }

        private void frmAula_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBCadastrarAulaDataSet.Professor' table. You can move, or remove it, as needed.
            this.professorTableAdapter.Fill(this.dBCadastrarAulaDataSet.Professor);
            // TODO: This line of code loads data into the 'dBCadastrarAulaDataSet.Aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.dBCadastrarAulaDataSet.Aluno);
            // TODO: This line of code loads data into the 'dBCadastrarAulaDataSet.Aula' table. You can move, or remove it, as needed.
            this.aulaTableAdapter.Fill(this.dBCadastrarAulaDataSet.Aula);

        }
    }
}
