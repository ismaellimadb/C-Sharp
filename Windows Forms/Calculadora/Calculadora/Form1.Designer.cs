namespace WindowsFormsApplication1
{
    partial class frmCalculadora
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpAritimetica = new System.Windows.Forms.GroupBox();
            this.rdbSoma = new System.Windows.Forms.RadioButton();
            this.rdbSubtrai = new System.Windows.Forms.RadioButton();
            this.rdbMultiplica = new System.Windows.Forms.RadioButton();
            this.rdbDividi = new System.Windows.Forms.RadioButton();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.grpAritimetica.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(12, 24);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(12, 58);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 87);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(63, 21);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(133, 20);
            this.txtX.TabIndex = 3;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(63, 51);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(133, 20);
            this.txtY.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(63, 80);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(133, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // grpAritimetica
            // 
            this.grpAritimetica.Controls.Add(this.rdbDividi);
            this.grpAritimetica.Controls.Add(this.rdbMultiplica);
            this.grpAritimetica.Controls.Add(this.rdbSubtrai);
            this.grpAritimetica.Controls.Add(this.rdbSoma);
            this.grpAritimetica.Location = new System.Drawing.Point(15, 136);
            this.grpAritimetica.Name = "grpAritimetica";
            this.grpAritimetica.Size = new System.Drawing.Size(200, 134);
            this.grpAritimetica.TabIndex = 6;
            this.grpAritimetica.TabStop = false;
            this.grpAritimetica.Text = "Operações";
            this.grpAritimetica.Enter += new System.EventHandler(this.grpAritimetica_Enter);
            // 
            // rdbSoma
            // 
            this.rdbSoma.AutoSize = true;
            this.rdbSoma.Location = new System.Drawing.Point(19, 27);
            this.rdbSoma.Name = "rdbSoma";
            this.rdbSoma.Size = new System.Drawing.Size(55, 17);
            this.rdbSoma.TabIndex = 0;
            this.rdbSoma.TabStop = true;
            this.rdbSoma.Text = "Somar";
            this.rdbSoma.UseVisualStyleBackColor = true;
            // 
            // rdbSubtrai
            // 
            this.rdbSubtrai.AutoSize = true;
            this.rdbSubtrai.Location = new System.Drawing.Point(19, 50);
            this.rdbSubtrai.Name = "rdbSubtrai";
            this.rdbSubtrai.Size = new System.Drawing.Size(61, 17);
            this.rdbSubtrai.TabIndex = 1;
            this.rdbSubtrai.TabStop = true;
            this.rdbSubtrai.Text = "Subtrair";
            this.rdbSubtrai.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplica
            // 
            this.rdbMultiplica.AutoSize = true;
            this.rdbMultiplica.Location = new System.Drawing.Point(19, 73);
            this.rdbMultiplica.Name = "rdbMultiplica";
            this.rdbMultiplica.Size = new System.Drawing.Size(72, 17);
            this.rdbMultiplica.TabIndex = 2;
            this.rdbMultiplica.TabStop = true;
            this.rdbMultiplica.Text = "Multiplicar";
            this.rdbMultiplica.UseVisualStyleBackColor = true;
            // 
            // rdbDividi
            // 
            this.rdbDividi.AutoSize = true;
            this.rdbDividi.Location = new System.Drawing.Point(19, 96);
            this.rdbDividi.Name = "rdbDividi";
            this.rdbDividi.Size = new System.Drawing.Size(54, 17);
            this.rdbDividi.TabIndex = 3;
            this.rdbDividi.TabStop = true;
            this.rdbDividi.Text = "Dividir";
            this.rdbDividi.UseVisualStyleBackColor = true;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(34, 298);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 7;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(98, 344);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(75, 23);
            this.btnFecha.TabIndex = 8;
            this.btnFecha.Text = "Sair";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(153, 298);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 9;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 400);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.grpAritimetica);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.grpAritimetica.ResumeLayout(false);
            this.grpAritimetica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox grpAritimetica;
        private System.Windows.Forms.RadioButton rdbDividi;
        private System.Windows.Forms.RadioButton rdbMultiplica;
        private System.Windows.Forms.RadioButton rdbSubtrai;
        private System.Windows.Forms.RadioButton rdbSoma;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btnLimpa;
    }
}

