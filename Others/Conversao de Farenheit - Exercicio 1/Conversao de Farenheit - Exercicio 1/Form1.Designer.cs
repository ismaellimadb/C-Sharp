namespace WindowsFormsApplication1
{
    partial class frmConverterTemperatura
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
            this.lblGrausCelsius7241 = new System.Windows.Forms.Label();
            this.txtGrausCelsius7241 = new System.Windows.Forms.TextBox();
            this.btnConverter7241 = new System.Windows.Forms.Button();
            this.lblGrausFarenheit7241 = new System.Windows.Forms.Label();
            this.txtGrausFarenheit7241 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGrausCelsius7241
            // 
            this.lblGrausCelsius7241.AutoSize = true;
            this.lblGrausCelsius7241.Location = new System.Drawing.Point(12, 43);
            this.lblGrausCelsius7241.Name = "lblGrausCelsius7241";
            this.lblGrausCelsius7241.Size = new System.Drawing.Size(71, 13);
            this.lblGrausCelsius7241.TabIndex = 0;
            this.lblGrausCelsius7241.Text = "Graus Celsius";
            // 
            // txtGrausCelsius7241
            // 
            this.txtGrausCelsius7241.Location = new System.Drawing.Point(110, 40);
            this.txtGrausCelsius7241.Name = "txtGrausCelsius7241";
            this.txtGrausCelsius7241.Size = new System.Drawing.Size(100, 20);
            this.txtGrausCelsius7241.TabIndex = 1;
            // 
            // btnConverter7241
            // 
            this.btnConverter7241.Location = new System.Drawing.Point(80, 95);
            this.btnConverter7241.Name = "btnConverter7241";
            this.btnConverter7241.Size = new System.Drawing.Size(75, 23);
            this.btnConverter7241.TabIndex = 2;
            this.btnConverter7241.Text = "Converter";
            this.btnConverter7241.UseVisualStyleBackColor = true;
            this.btnConverter7241.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblGrausFarenheit7241
            // 
            this.lblGrausFarenheit7241.AutoSize = true;
            this.lblGrausFarenheit7241.Location = new System.Drawing.Point(12, 162);
            this.lblGrausFarenheit7241.Name = "lblGrausFarenheit7241";
            this.lblGrausFarenheit7241.Size = new System.Drawing.Size(82, 13);
            this.lblGrausFarenheit7241.TabIndex = 3;
            this.lblGrausFarenheit7241.Text = "Graus Farenheit";
            // 
            // txtGrausFarenheit7241
            // 
            this.txtGrausFarenheit7241.Location = new System.Drawing.Point(110, 155);
            this.txtGrausFarenheit7241.Name = "txtGrausFarenheit7241";
            this.txtGrausFarenheit7241.ReadOnly = true;
            this.txtGrausFarenheit7241.Size = new System.Drawing.Size(100, 20);
            this.txtGrausFarenheit7241.TabIndex = 4;
            // 
            // frmConverterTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtGrausFarenheit7241);
            this.Controls.Add(this.lblGrausFarenheit7241);
            this.Controls.Add(this.btnConverter7241);
            this.Controls.Add(this.txtGrausCelsius7241);
            this.Controls.Add(this.lblGrausCelsius7241);
            this.Name = "frmConverterTemperatura";
            this.Text = "Converter Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrausCelsius7241;
        private System.Windows.Forms.TextBox txtGrausCelsius7241;
        private System.Windows.Forms.Button btnConverter7241;
        private System.Windows.Forms.Label lblGrausFarenheit7241;
        private System.Windows.Forms.TextBox txtGrausFarenheit7241;
    }
}

