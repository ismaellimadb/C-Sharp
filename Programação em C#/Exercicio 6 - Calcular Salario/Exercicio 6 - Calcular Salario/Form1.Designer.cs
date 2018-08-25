namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lblHorasdeTrabalho = new System.Windows.Forms.Label();
            this.lblVlrHr = new System.Windows.Forms.Label();
            this.lblPerDesc = new System.Windows.Forms.Label();
            this.txtHrdeTrab = new System.Windows.Forms.TextBox();
            this.txtVlrHr = new System.Windows.Forms.TextBox();
            this.txtPerDesc = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHorasdeTrabalho
            // 
            this.lblHorasdeTrabalho.AutoSize = true;
            this.lblHorasdeTrabalho.Location = new System.Drawing.Point(23, 39);
            this.lblHorasdeTrabalho.Name = "lblHorasdeTrabalho";
            this.lblHorasdeTrabalho.Size = new System.Drawing.Size(144, 13);
            this.lblHorasdeTrabalho.TabIndex = 0;
            this.lblHorasdeTrabalho.Text = "Quantas Horas de Trabalho?";
            // 
            // lblVlrHr
            // 
            this.lblVlrHr.AutoSize = true;
            this.lblVlrHr.Location = new System.Drawing.Point(23, 96);
            this.lblVlrHr.Name = "lblVlrHr";
            this.lblVlrHr.Size = new System.Drawing.Size(112, 13);
            this.lblVlrHr.TabIndex = 1;
            this.lblVlrHr.Text = "Qual o Valor da Hora?";
            // 
            // lblPerDesc
            // 
            this.lblPerDesc.AutoSize = true;
            this.lblPerDesc.Location = new System.Drawing.Point(23, 151);
            this.lblPerDesc.Name = "lblPerDesc";
            this.lblPerDesc.Size = new System.Drawing.Size(176, 13);
            this.lblPerDesc.TabIndex = 2;
            this.lblPerDesc.Text = "Qual o percentual de desconto? (%)";
            // 
            // txtHrdeTrab
            // 
            this.txtHrdeTrab.Location = new System.Drawing.Point(208, 36);
            this.txtHrdeTrab.Name = "txtHrdeTrab";
            this.txtHrdeTrab.Size = new System.Drawing.Size(100, 20);
            this.txtHrdeTrab.TabIndex = 3;
            // 
            // txtVlrHr
            // 
            this.txtVlrHr.Location = new System.Drawing.Point(208, 89);
            this.txtVlrHr.Name = "txtVlrHr";
            this.txtVlrHr.Size = new System.Drawing.Size(100, 20);
            this.txtVlrHr.TabIndex = 4;
            // 
            // txtPerDesc
            // 
            this.txtPerDesc.Location = new System.Drawing.Point(208, 144);
            this.txtPerDesc.Name = "txtPerDesc";
            this.txtPerDesc.Size = new System.Drawing.Size(100, 20);
            this.txtPerDesc.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(130, 194);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(26, 227);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(119, 227);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(220, 227);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 274);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtPerDesc);
            this.Controls.Add(this.txtVlrHr);
            this.Controls.Add(this.txtHrdeTrab);
            this.Controls.Add(this.lblPerDesc);
            this.Controls.Add(this.lblVlrHr);
            this.Controls.Add(this.lblHorasdeTrabalho);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorasdeTrabalho;
        private System.Windows.Forms.Label lblVlrHr;
        private System.Windows.Forms.Label lblPerDesc;
        private System.Windows.Forms.TextBox txtHrdeTrab;
        private System.Windows.Forms.TextBox txtVlrHr;
        private System.Windows.Forms.TextBox txtPerDesc;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
    }
}

