namespace WindowsFormsApplication1
{
    partial class frmMostPat
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
            this.cboAnimais = new System.Windows.Forms.ComboBox();
            this.lblAnimais = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pctAnimais = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAnimais
            // 
            this.cboAnimais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnimais.FormattingEnabled = true;
            this.cboAnimais.Location = new System.Drawing.Point(73, 59);
            this.cboAnimais.Name = "cboAnimais";
            this.cboAnimais.Size = new System.Drawing.Size(150, 21);
            this.cboAnimais.TabIndex = 0;
            // 
            // lblAnimais
            // 
            this.lblAnimais.AutoSize = true;
            this.lblAnimais.Location = new System.Drawing.Point(24, 62);
            this.lblAnimais.Name = "lblAnimais";
            this.lblAnimais.Size = new System.Drawing.Size(43, 13);
            this.lblAnimais.TabIndex = 1;
            this.lblAnimais.Text = "Animais";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(42, 129);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(148, 129);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pctAnimais
            // 
            this.pctAnimais.Location = new System.Drawing.Point(27, 193);
            this.pctAnimais.Name = "pctAnimais";
            this.pctAnimais.Size = new System.Drawing.Size(225, 163);
            this.pctAnimais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAnimais.TabIndex = 4;
            this.pctAnimais.TabStop = false;
            // 
            // frmMostPat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 401);
            this.ControlBox = false;
            this.Controls.Add(this.pctAnimais);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblAnimais);
            this.Controls.Add(this.cboAnimais);
            this.Name = "frmMostPat";
            this.Text = "Mostrar Patas";
            this.Load += new System.EventHandler(this.frmMostPat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAnimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAnimais;
        private System.Windows.Forms.Label lblAnimais;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pctAnimais;
    }
}

