namespace WindowsFormsApplication1
{
    partial class frmRaio
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
            this.lblraio = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.txtraio = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblcomprimento = new System.Windows.Forms.Label();
            this.txtcomprimento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblraio
            // 
            this.lblraio.AutoSize = true;
            this.lblraio.Location = new System.Drawing.Point(52, 34);
            this.lblraio.Name = "lblraio";
            this.lblraio.Size = new System.Drawing.Size(29, 13);
            this.lblraio.TabIndex = 0;
            this.lblraio.Text = "Raio";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(52, 80);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(29, 13);
            this.lblarea.TabIndex = 1;
            this.lblarea.Text = "Area";
            // 
            // txtraio
            // 
            this.txtraio.Location = new System.Drawing.Point(123, 34);
            this.txtraio.Name = "txtraio";
            this.txtraio.Size = new System.Drawing.Size(100, 20);
            this.txtraio.TabIndex = 2;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(123, 77);
            this.txtarea.Name = "txtarea";
            this.txtarea.ReadOnly = true;
            this.txtarea.Size = new System.Drawing.Size(100, 20);
            this.txtarea.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(89, 160);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblcomprimento
            // 
            this.lblcomprimento.AutoSize = true;
            this.lblcomprimento.Location = new System.Drawing.Point(39, 121);
            this.lblcomprimento.Name = "lblcomprimento";
            this.lblcomprimento.Size = new System.Drawing.Size(68, 13);
            this.lblcomprimento.TabIndex = 5;
            this.lblcomprimento.Text = "Comprimento";
            // 
            // txtcomprimento
            // 
            this.txtcomprimento.Location = new System.Drawing.Point(123, 121);
            this.txtcomprimento.Name = "txtcomprimento";
            this.txtcomprimento.ReadOnly = true;
            this.txtcomprimento.Size = new System.Drawing.Size(100, 20);
            this.txtcomprimento.TabIndex = 6;
            // 
            // frmRaio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtcomprimento);
            this.Controls.Add(this.lblcomprimento);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtraio);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblraio);
            this.Name = "frmRaio";
            this.Text = "Raio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblraio;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.TextBox txtraio;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblcomprimento;
        private System.Windows.Forms.TextBox txtcomprimento;
    }
}

