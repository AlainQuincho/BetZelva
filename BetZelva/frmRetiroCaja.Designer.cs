namespace BetZelva
{
    partial class frmRetiroCaja
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoRetiro = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grbDetalle = new System.Windows.Forms.GroupBox();
            this.grbSaldoDisp = new System.Windows.Forms.GroupBox();
            this.txtSaldoDisponible = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbMonto = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.grbDetalle.SuspendLayout();
            this.grbSaldoDisp.SuspendLayout();
            this.grbMonto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto a retirar";
            // 
            // txtMontoRetiro
            // 
            this.txtMontoRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoRetiro.Location = new System.Drawing.Point(120, 45);
            this.txtMontoRetiro.Name = "txtMontoRetiro";
            this.txtMontoRetiro.Size = new System.Drawing.Size(110, 21);
            this.txtMontoRetiro.TabIndex = 1;
            this.txtMontoRetiro.Text = "0.00";
            this.txtMontoRetiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(120, 23);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(262, 20);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(120, 48);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(110, 20);
            this.txtDNI.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Perfil:";
            // 
            // txtPerfil
            // 
            this.txtPerfil.Location = new System.Drawing.Point(120, 74);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(110, 20);
            this.txtPerfil.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Retirar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grbDetalle
            // 
            this.grbDetalle.Controls.Add(this.label2);
            this.grbDetalle.Controls.Add(this.txtPerfil);
            this.grbDetalle.Controls.Add(this.txtNombreUsuario);
            this.grbDetalle.Controls.Add(this.label4);
            this.grbDetalle.Controls.Add(this.label3);
            this.grbDetalle.Controls.Add(this.txtDNI);
            this.grbDetalle.Location = new System.Drawing.Point(16, 69);
            this.grbDetalle.Name = "grbDetalle";
            this.grbDetalle.Size = new System.Drawing.Size(394, 102);
            this.grbDetalle.TabIndex = 10;
            this.grbDetalle.TabStop = false;
            // 
            // grbSaldoDisp
            // 
            this.grbSaldoDisp.Controls.Add(this.label6);
            this.grbSaldoDisp.Controls.Add(this.label5);
            this.grbSaldoDisp.Controls.Add(this.txtSaldoDisponible);
            this.grbSaldoDisp.Location = new System.Drawing.Point(16, 12);
            this.grbSaldoDisp.Name = "grbSaldoDisp";
            this.grbSaldoDisp.Size = new System.Drawing.Size(394, 51);
            this.grbSaldoDisp.TabIndex = 11;
            this.grbSaldoDisp.TabStop = false;
            // 
            // txtSaldoDisponible
            // 
            this.txtSaldoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoDisponible.Location = new System.Drawing.Point(120, 19);
            this.txtSaldoDisponible.Name = "txtSaldoDisponible";
            this.txtSaldoDisponible.Size = new System.Drawing.Size(110, 22);
            this.txtSaldoDisponible.TabIndex = 0;
            this.txtSaldoDisponible.Text = "0.00";
            this.txtSaldoDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Saldo disponible:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Soles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Soles";
            // 
            // grbMonto
            // 
            this.grbMonto.Controls.Add(this.label8);
            this.grbMonto.Controls.Add(this.txtConcepto);
            this.grbMonto.Controls.Add(this.label1);
            this.grbMonto.Controls.Add(this.label7);
            this.grbMonto.Controls.Add(this.txtMontoRetiro);
            this.grbMonto.Location = new System.Drawing.Point(16, 177);
            this.grbMonto.Name = "grbMonto";
            this.grbMonto.Size = new System.Drawing.Size(394, 77);
            this.grbMonto.TabIndex = 12;
            this.grbMonto.TabStop = false;
            this.grbMonto.Text = "groupBox3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Concepto";
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.SystemColors.Window;
            this.txtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(120, 19);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(110, 20);
            this.txtConcepto.TabIndex = 5;
            this.txtConcepto.Text = "RETIRO DE CAJA";
            // 
            // frmRetiroCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 298);
            this.Controls.Add(this.grbMonto);
            this.Controls.Add(this.grbSaldoDisp);
            this.Controls.Add(this.grbDetalle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmRetiroCaja";
            this.Text = "Retiro de caja";
            this.Load += new System.EventHandler(this.frmRetiroCaja_Load);
            this.grbDetalle.ResumeLayout(false);
            this.grbDetalle.PerformLayout();
            this.grbSaldoDisp.ResumeLayout(false);
            this.grbSaldoDisp.PerformLayout();
            this.grbMonto.ResumeLayout(false);
            this.grbMonto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoRetiro;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grbDetalle;
        private System.Windows.Forms.GroupBox grbSaldoDisp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaldoDisponible;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbMonto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConcepto;
    }
}