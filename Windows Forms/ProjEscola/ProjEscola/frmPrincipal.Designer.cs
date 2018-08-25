namespace WindowsFormsApplication1
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAluno = new System.Windows.Forms.ToolStripButton();
            this.tsbProfessor = new System.Windows.Forms.ToolStripButton();
            this.tsbAula = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAluno,
            this.tsbProfessor,
            this.tsbAula});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(306, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAluno
            // 
            this.tsbAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAluno.Image = ((System.Drawing.Image)(resources.GetObject("tsbAluno.Image")));
            this.tsbAluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAluno.Name = "tsbAluno";
            this.tsbAluno.Size = new System.Drawing.Size(43, 22);
            this.tsbAluno.Text = "Aluno";
            this.tsbAluno.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbProfessor
            // 
            this.tsbProfessor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbProfessor.Image = ((System.Drawing.Image)(resources.GetObject("tsbProfessor.Image")));
            this.tsbProfessor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProfessor.Name = "tsbProfessor";
            this.tsbProfessor.Size = new System.Drawing.Size(60, 22);
            this.tsbProfessor.Text = "Professor";
            this.tsbProfessor.Click += new System.EventHandler(this.tsbProfessor_Click);
            // 
            // tsbAula
            // 
            this.tsbAula.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAula.Image = ((System.Drawing.Image)(resources.GetObject("tsbAula.Image")));
            this.tsbAula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAula.Name = "tsbAula";
            this.tsbAula.Size = new System.Drawing.Size(35, 22);
            this.tsbAula.Text = "Aula";
            this.tsbAula.Click += new System.EventHandler(this.tsbAula_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 86);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPrincipal";
            this.Text = "Cadastrar";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAluno;
        private System.Windows.Forms.ToolStripButton tsbProfessor;
        private System.Windows.Forms.ToolStripButton tsbAula;
    }
}

