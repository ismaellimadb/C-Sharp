namespace WindowsFormsApplication1
{
    partial class frmVerificarAnoBissexto7241
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
            this.btnVerificar7241 = new System.Windows.Forms.Button();
            this.txtAno7241 = new System.Windows.Forms.TextBox();
            this.lblAno7241 = new System.Windows.Forms.Label();
            this.lblResultado7241 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerificar7241
            // 
            this.btnVerificar7241.Location = new System.Drawing.Point(77, 100);
            this.btnVerificar7241.Name = "btnVerificar7241";
            this.btnVerificar7241.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar7241.TabIndex = 0;
            this.btnVerificar7241.Text = "Verificar Ano";
            this.btnVerificar7241.UseVisualStyleBackColor = true;
            this.btnVerificar7241.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtAno7241
            // 
            this.txtAno7241.Location = new System.Drawing.Point(90, 51);
            this.txtAno7241.Name = "txtAno7241";
            this.txtAno7241.Size = new System.Drawing.Size(100, 20);
            this.txtAno7241.TabIndex = 1;
            // 
            // lblAno7241
            // 
            this.lblAno7241.AutoSize = true;
            this.lblAno7241.Location = new System.Drawing.Point(49, 54);
            this.lblAno7241.Name = "lblAno7241";
            this.lblAno7241.Size = new System.Drawing.Size(26, 13);
            this.lblAno7241.TabIndex = 2;
            this.lblAno7241.Text = "Ano";
            // 
            // lblResultado7241
            // 
            this.lblResultado7241.AutoSize = true;
            this.lblResultado7241.Location = new System.Drawing.Point(87, 154);
            this.lblResultado7241.Name = "lblResultado7241";
            this.lblResultado7241.Size = new System.Drawing.Size(55, 13);
            this.lblResultado7241.TabIndex = 3;
            this.lblResultado7241.Text = "Resultado";
            // 
            // frmVerificarAnoBissexto7241
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 229);
            this.Controls.Add(this.lblResultado7241);
            this.Controls.Add(this.lblAno7241);
            this.Controls.Add(this.txtAno7241);
            this.Controls.Add(this.btnVerificar7241);
            this.Name = "frmVerificarAnoBissexto7241";
            this.Text = "Verificar Ano Bissexto";
            this.Load += new System.EventHandler(this.frmVerificarAnoBissexto7241_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar7241;
        private System.Windows.Forms.TextBox txtAno7241;
        private System.Windows.Forms.Label lblAno7241;
        private System.Windows.Forms.Label lblResultado7241;
    }
}

