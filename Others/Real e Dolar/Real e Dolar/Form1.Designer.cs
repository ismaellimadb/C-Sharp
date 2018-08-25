namespace WindowsFormsApplication1
{
    partial class frmConverterMoeda
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
            this.txtReal = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.lblReal = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(81, 52);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(100, 20);
            this.txtReal.TabIndex = 0;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(81, 149);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolar.TabIndex = 1;
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Location = new System.Drawing.Point(28, 55);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(29, 13);
            this.lblReal.TabIndex = 2;
            this.lblReal.Text = "Real";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(28, 156);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 13);
            this.lblDolar.TabIndex = 3;
            this.lblDolar.Text = "Dolar";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(81, 98);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // frmConverterMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblReal);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtReal);
            this.Name = "frmConverterMoeda";
            this.Text = "Converter Moeda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Button btnConverter;
    }
}

