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
    public partial class frmProfessor : Form
    {
        public frmProfessor()
        {
            InitializeComponent();
        }

        private void professorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBCadastrarAulaDataSet);

        }

        private void frmProfessor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBCadastrarAulaDataSet.Professor' table. You can move, or remove it, as needed.
            this.professorTableAdapter.Fill(this.dBCadastrarAulaDataSet.Professor);

        }
    }
}
