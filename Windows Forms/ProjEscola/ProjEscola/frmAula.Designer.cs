namespace WindowsFormsApplication1
{
    partial class frmAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAula));
            System.Windows.Forms.Label idAulaLabel;
            System.Windows.Forms.Label idAlunoLabel;
            System.Windows.Forms.Label idProfessorLabel;
            System.Windows.Forms.Label dataAulaLabel;
            System.Windows.Forms.Label horaInicioLabel;
            System.Windows.Forms.Label horaFimLabel;
            System.Windows.Forms.Label observacaoAulaLabel;
            this.dBCadastrarAulaDataSet = new WindowsFormsApplication1.DBCadastrarAulaDataSet();
            this.aulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulaTableAdapter = new WindowsFormsApplication1.DBCadastrarAulaDataSetTableAdapters.AulaTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DBCadastrarAulaDataSetTableAdapters.TableAdapterManager();
            this.aulaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aulaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idAulaLabel1 = new System.Windows.Forms.Label();
            this.idAlunoComboBox = new System.Windows.Forms.ComboBox();
            this.idProfessorComboBox = new System.Windows.Forms.ComboBox();
            this.dataAulaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaFimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.observacaoAulaTextBox = new System.Windows.Forms.TextBox();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new WindowsFormsApplication1.DBCadastrarAulaDataSetTableAdapters.AlunoTableAdapter();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professorTableAdapter = new WindowsFormsApplication1.DBCadastrarAulaDataSetTableAdapters.ProfessorTableAdapter();
            idAulaLabel = new System.Windows.Forms.Label();
            idAlunoLabel = new System.Windows.Forms.Label();
            idProfessorLabel = new System.Windows.Forms.Label();
            dataAulaLabel = new System.Windows.Forms.Label();
            horaInicioLabel = new System.Windows.Forms.Label();
            horaFimLabel = new System.Windows.Forms.Label();
            observacaoAulaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCadastrarAulaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingNavigator)).BeginInit();
            this.aulaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dBCadastrarAulaDataSet
            // 
            this.dBCadastrarAulaDataSet.DataSetName = "DBCadastrarAulaDataSet";
            this.dBCadastrarAulaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aulaBindingSource
            // 
            this.aulaBindingSource.DataMember = "Aula";
            this.aulaBindingSource.DataSource = this.dBCadastrarAulaDataSet;
            // 
            // aulaTableAdapter
            // 
            this.aulaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunoTableAdapter = this.alunoTableAdapter;
            this.tableAdapterManager.AulaTableAdapter = this.aulaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProfessorTableAdapter = this.professorTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DBCadastrarAulaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aulaBindingNavigator
            // 
            this.aulaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aulaBindingNavigator.BindingSource = this.aulaBindingSource;
            this.aulaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aulaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aulaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aulaBindingNavigatorSaveItem});
            this.aulaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aulaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aulaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aulaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aulaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aulaBindingNavigator.Name = "aulaBindingNavigator";
            this.aulaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aulaBindingNavigator.Size = new System.Drawing.Size(302, 25);
            this.aulaBindingNavigator.TabIndex = 0;
            this.aulaBindingNavigator.Text = "bindingNavigator1";
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
            // aulaBindingNavigatorSaveItem
            // 
            this.aulaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aulaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aulaBindingNavigatorSaveItem.Image")));
            this.aulaBindingNavigatorSaveItem.Name = "aulaBindingNavigatorSaveItem";
            this.aulaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.aulaBindingNavigatorSaveItem.Text = "Save Data";
            this.aulaBindingNavigatorSaveItem.Click += new System.EventHandler(this.aulaBindingNavigatorSaveItem_Click);
            // 
            // idAulaLabel
            // 
            idAulaLabel.AutoSize = true;
            idAulaLabel.Location = new System.Drawing.Point(12, 38);
            idAulaLabel.Name = "idAulaLabel";
            idAulaLabel.Size = new System.Drawing.Size(42, 13);
            idAulaLabel.TabIndex = 1;
            idAulaLabel.Text = "id Aula:";
            // 
            // idAulaLabel1
            // 
            this.idAulaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulaBindingSource, "idAula", true));
            this.idAulaLabel1.Location = new System.Drawing.Point(71, 38);
            this.idAulaLabel1.Name = "idAulaLabel1";
            this.idAulaLabel1.Size = new System.Drawing.Size(100, 23);
            this.idAulaLabel1.TabIndex = 2;
            this.idAulaLabel1.Text = "label1";
            // 
            // idAlunoLabel
            // 
            idAlunoLabel.AutoSize = true;
            idAlunoLabel.Location = new System.Drawing.Point(6, 67);
            idAlunoLabel.Name = "idAlunoLabel";
            idAlunoLabel.Size = new System.Drawing.Size(48, 13);
            idAlunoLabel.TabIndex = 3;
            idAlunoLabel.Text = "id Aluno:";
            // 
            // idAlunoComboBox
            // 
            this.idAlunoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.aulaBindingSource, "idAluno", true));
            this.idAlunoComboBox.DataSource = this.alunoBindingSource;
            this.idAlunoComboBox.DisplayMember = "nomeAluno";
            this.idAlunoComboBox.FormattingEnabled = true;
            this.idAlunoComboBox.Location = new System.Drawing.Point(71, 64);
            this.idAlunoComboBox.Name = "idAlunoComboBox";
            this.idAlunoComboBox.Size = new System.Drawing.Size(121, 21);
            this.idAlunoComboBox.TabIndex = 4;
            this.idAlunoComboBox.ValueMember = "IdAluno";
            // 
            // idProfessorLabel
            // 
            idProfessorLabel.AutoSize = true;
            idProfessorLabel.Location = new System.Drawing.Point(6, 102);
            idProfessorLabel.Name = "idProfessorLabel";
            idProfessorLabel.Size = new System.Drawing.Size(65, 13);
            idProfessorLabel.TabIndex = 5;
            idProfessorLabel.Text = "id Professor:";
            // 
            // idProfessorComboBox
            // 
            this.idProfessorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.aulaBindingSource, "idProfessor", true));
            this.idProfessorComboBox.DataSource = this.professorBindingSource;
            this.idProfessorComboBox.DisplayMember = "nomeProfessor";
            this.idProfessorComboBox.FormattingEnabled = true;
            this.idProfessorComboBox.Location = new System.Drawing.Point(71, 99);
            this.idProfessorComboBox.Name = "idProfessorComboBox";
            this.idProfessorComboBox.Size = new System.Drawing.Size(121, 21);
            this.idProfessorComboBox.TabIndex = 6;
            this.idProfessorComboBox.ValueMember = "idProfessor";
            // 
            // dataAulaLabel
            // 
            dataAulaLabel.AutoSize = true;
            dataAulaLabel.Location = new System.Drawing.Point(6, 138);
            dataAulaLabel.Name = "dataAulaLabel";
            dataAulaLabel.Size = new System.Drawing.Size(55, 13);
            dataAulaLabel.TabIndex = 7;
            dataAulaLabel.Text = "data Aula:";
            // 
            // dataAulaDateTimePicker
            // 
            this.dataAulaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aulaBindingSource, "dataAula", true));
            this.dataAulaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataAulaDateTimePicker.Location = new System.Drawing.Point(71, 132);
            this.dataAulaDateTimePicker.Name = "dataAulaDateTimePicker";
            this.dataAulaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataAulaDateTimePicker.TabIndex = 8;
            // 
            // horaInicioLabel
            // 
            horaInicioLabel.AutoSize = true;
            horaInicioLabel.Location = new System.Drawing.Point(6, 180);
            horaInicioLabel.Name = "horaInicioLabel";
            horaInicioLabel.Size = new System.Drawing.Size(59, 13);
            horaInicioLabel.TabIndex = 9;
            horaInicioLabel.Text = "hora Inicio:";
            // 
            // horaInicioDateTimePicker
            // 
            this.horaInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aulaBindingSource, "horaInicio", true));
            this.horaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaInicioDateTimePicker.Location = new System.Drawing.Point(71, 176);
            this.horaInicioDateTimePicker.Name = "horaInicioDateTimePicker";
            this.horaInicioDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.horaInicioDateTimePicker.TabIndex = 10;
            // 
            // horaFimLabel
            // 
            horaFimLabel.AutoSize = true;
            horaFimLabel.Location = new System.Drawing.Point(6, 216);
            horaFimLabel.Name = "horaFimLabel";
            horaFimLabel.Size = new System.Drawing.Size(50, 13);
            horaFimLabel.TabIndex = 11;
            horaFimLabel.Text = "hora Fim:";
            // 
            // horaFimDateTimePicker
            // 
            this.horaFimDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aulaBindingSource, "horaFim", true));
            this.horaFimDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaFimDateTimePicker.Location = new System.Drawing.Point(71, 210);
            this.horaFimDateTimePicker.Name = "horaFimDateTimePicker";
            this.horaFimDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.horaFimDateTimePicker.TabIndex = 12;
            // 
            // observacaoAulaLabel
            // 
            observacaoAulaLabel.AutoSize = true;
            observacaoAulaLabel.Location = new System.Drawing.Point(12, 248);
            observacaoAulaLabel.Name = "observacaoAulaLabel";
            observacaoAulaLabel.Size = new System.Drawing.Size(90, 13);
            observacaoAulaLabel.TabIndex = 13;
            observacaoAulaLabel.Text = "observacao Aula:";
            // 
            // observacaoAulaTextBox
            // 
            this.observacaoAulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulaBindingSource, "observacaoAula", true));
            this.observacaoAulaTextBox.Location = new System.Drawing.Point(108, 245);
            this.observacaoAulaTextBox.Multiline = true;
            this.observacaoAulaTextBox.Name = "observacaoAulaTextBox";
            this.observacaoAulaTextBox.Size = new System.Drawing.Size(154, 67);
            this.observacaoAulaTextBox.TabIndex = 14;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "Aluno";
            this.alunoBindingSource.DataSource = this.dBCadastrarAulaDataSet;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
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
            // frmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 324);
            this.Controls.Add(observacaoAulaLabel);
            this.Controls.Add(this.observacaoAulaTextBox);
            this.Controls.Add(horaFimLabel);
            this.Controls.Add(this.horaFimDateTimePicker);
            this.Controls.Add(horaInicioLabel);
            this.Controls.Add(this.horaInicioDateTimePicker);
            this.Controls.Add(dataAulaLabel);
            this.Controls.Add(this.dataAulaDateTimePicker);
            this.Controls.Add(idProfessorLabel);
            this.Controls.Add(this.idProfessorComboBox);
            this.Controls.Add(idAlunoLabel);
            this.Controls.Add(this.idAlunoComboBox);
            this.Controls.Add(idAulaLabel);
            this.Controls.Add(this.idAulaLabel1);
            this.Controls.Add(this.aulaBindingNavigator);
            this.Name = "frmAula";
            this.Text = "Cadastrar Aula";
            this.Load += new System.EventHandler(this.frmAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCadastrarAulaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingNavigator)).EndInit();
            this.aulaBindingNavigator.ResumeLayout(false);
            this.aulaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBCadastrarAulaDataSet dBCadastrarAulaDataSet;
        private System.Windows.Forms.BindingSource aulaBindingSource;
        private DBCadastrarAulaDataSetTableAdapters.AulaTableAdapter aulaTableAdapter;
        private DBCadastrarAulaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aulaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aulaBindingNavigatorSaveItem;
        private DBCadastrarAulaDataSetTableAdapters.AlunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.Label idAulaLabel1;
        private System.Windows.Forms.ComboBox idAlunoComboBox;
        private System.Windows.Forms.ComboBox idProfessorComboBox;
        private System.Windows.Forms.DateTimePicker dataAulaDateTimePicker;
        private System.Windows.Forms.DateTimePicker horaInicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker horaFimDateTimePicker;
        private System.Windows.Forms.TextBox observacaoAulaTextBox;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private DBCadastrarAulaDataSetTableAdapters.ProfessorTableAdapter professorTableAdapter;
        private System.Windows.Forms.BindingSource professorBindingSource;
    }
}