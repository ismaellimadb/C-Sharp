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
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent();
        }

        private void alunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBCadastrarAulaDataSet);

        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBCadastrarAulaDataSet.Aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.dBCadastrarAulaDataSet.Aluno);

        }
    }
}
