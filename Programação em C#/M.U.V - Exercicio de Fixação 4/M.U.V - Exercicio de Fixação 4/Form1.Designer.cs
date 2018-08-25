namespace WindowsFormsApplication1
{
    partial class frmMuv
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
            this.lblVelocidadeInicial = new System.Windows.Forms.Label();
            this.lblAceleracao = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.txtVelocidadeInicial = new System.Windows.Forms.TextBox();
            this.txtAceleracao = new System.Windows.Forms.TextBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVelocidadeInicial
            // 
            this.lblVelocidadeInicial.AutoSize = true;
            this.lblVelocidadeInicial.Location = new System.Drawing.Point(12, 40);
            this.lblVelocidadeInicial.Name = "lblVelocidadeInicial";
            this.lblVelocidadeInicial.Size = new System.Drawing.Size(88, 13);
            this.lblVelocidadeInicial.TabIndex = 0;
            this.lblVelocidadeInicial.Text = "Velocidade Incial";
            // 
            // lblAceleracao
            // 
            this.lblAceleracao.AutoSize = true;
            this.lblAceleracao.Location = new System.Drawing.Point(25, 80);
            this.lblAceleracao.Name = "lblAceleracao";
            this.lblAceleracao.Size = new System.Drawing.Size(61, 13);
            this.lblAceleracao.TabIndex = 1;
            this.lblAceleracao.Text = "Aceleração";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(37, 121);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(40, 13);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Tempo";
            // 
            // txtVelocidadeInicial
            // 
            this.txtVelocidadeInicial.Location = new System.Drawing.Point(106, 37);
            this.txtVelocidadeInicial.Name = "txtVelocidadeInicial";
            this.txtVelocidadeInicial.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidadeInicial.TabIndex = 3;
            // 
            // txtAceleracao
            // 
            this.txtAceleracao.Location = new System.Drawing.Point(106, 73);
            this.txtAceleracao.Name = "txtAceleracao";
            this.txtAceleracao.Size = new System.Drawing.Size(100, 20);
            this.txtAceleracao.TabIndex = 4;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(106, 114);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(100, 20);
            this.txtTempo.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(95, 157);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.AutoSize = true;
            this.lblVelocidade.Location = new System.Drawing.Point(25, 199);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(60, 13);
            this.lblVelocidade.TabIndex = 7;
            this.lblVelocidade.Text = "Velocidade";
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(106, 196);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.ReadOnly = true;
            this.txtVelocidade.Size = new System.Drawing.Size(100, 20);
            this.txtVelocidade.TabIndex = 8;
            // 
            // frmMuv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtVelocidade);
            this.Controls.Add(this.lblVelocidade);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.txtAceleracao);
            this.Controls.Add(this.txtVelocidadeInicial);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblAceleracao);
            this.Controls.Add(this.lblVelocidadeInicial);
            this.Name = "frmMuv";
            this.Text = "M.U.V";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVelocidadeInicial;
        private System.Windows.Forms.Label lblAceleracao;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox txtVelocidadeInicial;
        private System.Windows.Forms.TextBox txtAceleracao;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblVelocidade;
        private System.Windows.Forms.TextBox txtVelocidade;
    }
}

