namespace WindowsFormsApplication1
{
    partial class frmPotencia
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
            this.txtCalcular = new System.Windows.Forms.Button();
            this.txtBas = new System.Windows.Forms.TextBox();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.lblBas = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCalcular
            // 
            this.txtCalcular.Location = new System.Drawing.Point(27, 154);
            this.txtCalcular.Name = "txtCalcular";
            this.txtCalcular.Size = new System.Drawing.Size(75, 23);
            this.txtCalcular.TabIndex = 0;
            this.txtCalcular.Text = "Calcular";
            this.txtCalcular.UseVisualStyleBackColor = true;
            this.txtCalcular.Click += new System.EventHandler(this.txtCalcular_Click);
            // 
            // txtBas
            // 
            this.txtBas.Location = new System.Drawing.Point(93, 52);
            this.txtBas.Name = "txtBas";
            this.txtBas.Size = new System.Drawing.Size(167, 20);
            this.txtBas.TabIndex = 1;
            // 
            // txtExp
            // 
            this.txtExp.Location = new System.Drawing.Point(93, 93);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(167, 20);
            this.txtExp.TabIndex = 2;
            // 
            // lblBas
            // 
            this.lblBas.AutoSize = true;
            this.lblBas.Location = new System.Drawing.Point(24, 55);
            this.lblBas.Name = "lblBas";
            this.lblBas.Size = new System.Drawing.Size(31, 13);
            this.lblBas.TabIndex = 3;
            this.lblBas.Text = "Base";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(24, 96);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(52, 13);
            this.lblExp.TabIndex = 4;
            this.lblExp.Text = "Expoente";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(136, 159);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(197, 154);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(112, 193);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPotencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblBas);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.txtBas);
            this.Controls.Add(this.txtCalcular);
            this.Name = "frmPotencia";
            this.Text = "Potencia";
            this.Load += new System.EventHandler(this.frmPotencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtCalcular;
        private System.Windows.Forms.TextBox txtBas;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.Label lblBas;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

