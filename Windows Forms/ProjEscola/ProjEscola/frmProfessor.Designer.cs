namespace WindowsFormsApplication1
{
    partial class frmProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessor));
            System.Windows.Forms.Label idProfessorLabel;
            System.Windows.Forms.Label nomeProfessorLabel;
            System.Windows.Forms.Label sobrenomeProfessorLabel;
            System.Windows.Forms.Label formacaoLabel;
            this.dBCadastrarAulaDataSet = new WindowsFormsApplication1.DBCadastrarAulaDataSet();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professorTableAdapter = new WindowsFormsApplication1.DBCadastrarAulaDataSetTableAdapters.ProfessorTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DBCadastrarAulaDataSetTableAdapters.TableAdapterManager();
            this.professorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.professorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idProfessorLabel1 = new System.Windows.Forms.Label();
            this.nomeProfessorTextBox = new System.Windows.Forms.TextBox();
            this.sobrenomeProfessorTextBox = new System.Windows.Forms.TextBox();
            this.formacaoTextBox = new System.Windows.Forms.TextBox();
            idProfessorLabel = new System.Windows.Forms.Label();
            nomeProfessorLabel = new System.Windows.Forms.Label();
            sobrenomeProfessorLabel = new System.Windows.Forms.Label();
            formacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCadastrarAulaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingNavigator)).BeginInit();
            this.professorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dBCadastrarAulaDataSet
            // 
            this.dBCadastrarAulaDataSet.DataSetName = "DBCadastrarAulaDataSet";
            this.dBCadastrarAulaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataMember = "Professor";
            this.professorBindingSource.DataSource = this.dBCadastrarAulaDataSet;
            // 
            // professorTableAdapter
            // 
            this.professorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunoTableAdapter = null;
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProfessorTableAdapter = this.professorTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DBCadastrarAulaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // professorBindingNavigator
            // 
            this.professorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.professorBindingNavigator.BindingSource = this.professorBindingSource;
            this.professorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.professorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.professorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.professorBindingNavigatorSaveItem});
            this.professorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.professorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.professorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.professorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.professorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.professorBindingNavigator.Name = "professorBindingNavigator";
            this.professorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.professorBindingNavigator.Size = new System.Drawing.Size(306, 25);
            this.professorBindingNavigator.TabIndex = 0;
            this.professorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // professorBindingNavigatorSaveItem
            // 
            this.professorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.professorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("professorBindingNavigatorSaveItem.Image")));
            this.professorBindingNavigatorSaveItem.Name = "professorBindingNavigatorSaveItem";
            this.professorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.professorBindingNavigatorSaveItem.Text = "Save Data";
            this.professorBindingNavigatorSaveItem.Click += new System.EventHandler(this.professorBindingNavigatorSaveItem_Click);
            // 
            // idProfessorLabel
            // 
            idProfessorLabel.AutoSize = true;
            idProfessorLabel.Location = new System.Drawing.Point(12, 50);
            idProfessorLabel.Name = "idProfessorLabel";
            idProfessorLabel.Size = new System.Drawing.Size(65, 13);
            idProfessorLabel.TabIndex = 1;
            idProfessorLabel.Text = "id Professor:";
            // 
            // idProfessorLabel1
            // 
            this.idProfessorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorBindingSource, "idProfessor", true));
            this.idProfessorLabel1.Location = new System.Drawing.Point(83, 50);
            this.idProfessorLabel1.Name = "idProfessorLabel1";
            this.idProfessorLabel1.Size = new System.Drawing.Size(100, 23);
            this.idProfessorLabel1.TabIndex = 2;
            this.idProfessorLabel1.Text = "label1";
            // 
            // nomeProfessorLabel
            // 
            nomeProfessorLabel.AutoSize = true;
            nomeProfessorLabel.Location = new System.Drawing.Point(12, 88);
            nomeProfessorLabel.Name = "nomeProfessorLabel";
            nomeProfessorLabel.Size = new System.Drawing.Size(83, 13);
            nomeProfessorLabel.TabIndex = 3;
            nomeProfessorLabel.Text = "nome Professor:";
            // 
            // nomeProfessorTextBox
            // 
            this.nomeProfessorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorBindingSource, "nomeProfessor", true));
            this.nomeProfessorTextBox.Location = new System.Drawing.Point(101, 85);
            this.nomeProfessorTextBox.Name = "nomeProfessorTextBox";
            this.nomeProfessorTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeProfessorTextBox.TabIndex = 4;
            // 
            // sobrenomeProfessorLabel
            // 
            sobrenomeProfessorLabel.AutoSize = true;
            sobrenomeProfessorLabel.Location = new System.Drawing.Point(12, 125);
            sobrenomeProfessorLabel.Name = "sobrenomeProfessorLabel";
            sobrenomeProfessorLabel.Size = new System.Drawing.Size(109, 13);
            sobrenomeProfessorLabel.TabIndex = 5;
            sobrenomeProfessorLabel.Text = "sobrenome Professor:";
            // 
            // sobrenomeProfessorTextBox
            // 
            this.sobrenomeProfessorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorBindingSource, "sobrenomeProfessor", true));
            this.sobrenomeProfessorTextBox.Location = new System.Drawing.Point(127, 122);
            this.sobrenomeProfessorTextBox.Name = "sobrenomeProfessorTextBox";
            this.sobrenomeProfessorTextBox.Size = new System.Drawing.Size(100, 20);
            this.sobrenomeProfessorTextBox.TabIndex = 6;
            // 
            // formacaoLabel
            // 
            formacaoLabel.AutoSize = true;
            formacaoLabel.Location = new System.Drawing.Point(12, 169);
            formacaoLabel.Name = "formacaoLabel";
            formacaoLabel.Size = new System.Drawing.Size(54, 13);
            formacaoLabel.TabIndex = 7;
            formacaoLabel.Text = "formacao:";
            // 
            // formacaoTextBox
            // 
            this.formacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professorBindingSource, "formacao", true));
            this.formacaoTextBox.Location = new System.Drawing.Point(72, 166);
            this.formacaoTextBox.Name = "formacaoTextBox";
            this.formacaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.formacaoTextBox.TabIndex = 8;
            // 
            // frmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 261);
            this.Controls.Add(formacaoLabel);
            this.Controls.Add(this.formacaoTextBox);
            this.Controls.Add(sobrenomeProfessorLabel);
            this.Controls.Add(this.sobrenomeProfessorTextBox);
            this.Controls.Add(nomeProfessorLabel);
            this.Controls.Add(this.nomeProfessorTextBox);
            this.Controls.Add(idProfessorLabel);
            this.Controls.Add(this.idProfessorLabel1);
            this.Controls.Add(this.professorBindingNavigator);
            this.Name = "frmProfessor";
            this.Text = "Cadastrar Professor";
            this.Load += new System.EventHandler(this.frmProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCadastrarAulaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingNavigator)).EndInit();
            this.professorBindingNavigator.ResumeLayout(false);
            this.professorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBCadastrarAulaDataSet dBCadastrarAulaDataSet;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private DBCadastrarAulaDataSetTableAdapters.ProfessorTableAdapter professorTableAdapter;
        private DBCadastrarAulaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator professorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton professorBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idProfessorLabel1;
        private System.Windows.Forms.TextBox nomeProfessorTextBox;
        private System.Windows.Forms.TextBox sobrenomeProfessorTextBox;
        private System.Windows.Forms.TextBox formacaoTextBox;
    }
}