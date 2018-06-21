namespace BetZelva
{
    partial class frmSalidaCaja
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
            this.txtCodRecibo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.grbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtFechaCierre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaReg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbDatosApuesta = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEquipoVisita = new System.Windows.Forms.Label();
            this.lblEquipoLocal = new System.Windows.Forms.Label();
            this.lblGolesLocal = new System.Windows.Forms.Label();
            this.lblGolesVisita = new System.Windows.Forms.Label();
            this.lblMontoApostado = new System.Windows.Forms.Label();
            this.txtMontoRetiro = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbBusqueda.SuspendLayout();
            this.grbDatosCliente.SuspendLayout();
            this.grbDatosApuesta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodRecibo
            // 
            this.txtCodRecibo.Location = new System.Drawing.Point(90, 21);
            this.txtCodRecibo.Name = "txtCodRecibo";
            this.txtCodRecibo.Size = new System.Drawing.Size(112, 20);
            this.txtCodRecibo.TabIndex = 0;
            this.txtCodRecibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodRecibo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod. Recibo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(220, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.btnBuscar);
            this.grbBusqueda.Controls.Add(this.txtCodRecibo);
            this.grbBusqueda.Controls.Add(this.label1);
            this.grbBusqueda.Location = new System.Drawing.Point(21, 22);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(313, 57);
            this.grbBusqueda.TabIndex = 3;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Enter += new System.EventHandler(this.grbBusqueda_Enter);
            // 
            // grbDatosCliente
            // 
            this.grbDatosCliente.Controls.Add(this.txtFechaCierre);
            this.grbDatosCliente.Controls.Add(this.label7);
            this.grbDatosCliente.Controls.Add(this.txtFechaReg);
            this.grbDatosCliente.Controls.Add(this.label5);
            this.grbDatosCliente.Controls.Add(this.txtDNI);
            this.grbDatosCliente.Controls.Add(this.txtApellido);
            this.grbDatosCliente.Controls.Add(this.txtNombre);
            this.grbDatosCliente.Controls.Add(this.label4);
            this.grbDatosCliente.Controls.Add(this.label3);
            this.grbDatosCliente.Controls.Add(this.label2);
            this.grbDatosCliente.Location = new System.Drawing.Point(21, 86);
            this.grbDatosCliente.Name = "grbDatosCliente";
            this.grbDatosCliente.Size = new System.Drawing.Size(313, 158);
            this.grbDatosCliente.TabIndex = 4;
            this.grbDatosCliente.TabStop = false;
            this.grbDatosCliente.Text = "Detalle";
            // 
            // txtFechaCierre
            // 
            this.txtFechaCierre.Location = new System.Drawing.Point(90, 128);
            this.txtFechaCierre.Name = "txtFechaCierre";
            this.txtFechaCierre.Size = new System.Drawing.Size(112, 20);
            this.txtFechaCierre.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha cierre:";
            // 
            // txtFechaReg
            // 
            this.txtFechaReg.Location = new System.Drawing.Point(90, 102);
            this.txtFechaReg.Name = "txtFechaReg";
            this.txtFechaReg.Size = new System.Drawing.Size(112, 20);
            this.txtFechaReg.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha reg:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(90, 73);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(112, 20);
            this.txtDNI.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(90, 47);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(205, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Monto ganado:";
            // 
            // grbDatosApuesta
            // 
            this.grbDatosApuesta.Controls.Add(this.label11);
            this.grbDatosApuesta.Controls.Add(this.lblEquipoVisita);
            this.grbDatosApuesta.Controls.Add(this.lblEquipoLocal);
            this.grbDatosApuesta.Controls.Add(this.lblGolesLocal);
            this.grbDatosApuesta.Controls.Add(this.lblGolesVisita);
            this.grbDatosApuesta.Controls.Add(this.lblMontoApostado);
            this.grbDatosApuesta.Location = new System.Drawing.Point(21, 250);
            this.grbDatosApuesta.Name = "grbDatosApuesta";
            this.grbDatosApuesta.Size = new System.Drawing.Size(313, 120);
            this.grbDatosApuesta.TabIndex = 5;
            this.grbDatosApuesta.TabStop = false;
            this.grbDatosApuesta.Text = "Detalle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(130, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "-";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquipoVisita
            // 
            this.lblEquipoVisita.AutoSize = true;
            this.lblEquipoVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoVisita.Location = new System.Drawing.Point(159, 52);
            this.lblEquipoVisita.Name = "lblEquipoVisita";
            this.lblEquipoVisita.Size = new System.Drawing.Size(100, 16);
            this.lblEquipoVisita.TabIndex = 4;
            this.lblEquipoVisita.Text = "Equipo Visita";
            this.lblEquipoVisita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquipoLocal
            // 
            this.lblEquipoLocal.AutoSize = true;
            this.lblEquipoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoLocal.Location = new System.Drawing.Point(21, 52);
            this.lblEquipoLocal.Name = "lblEquipoLocal";
            this.lblEquipoLocal.Size = new System.Drawing.Size(99, 16);
            this.lblEquipoLocal.TabIndex = 3;
            this.lblEquipoLocal.Text = "Equipo Local";
            this.lblEquipoLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGolesLocal
            // 
            this.lblGolesLocal.AutoSize = true;
            this.lblGolesLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolesLocal.Location = new System.Drawing.Point(21, 84);
            this.lblGolesLocal.Name = "lblGolesLocal";
            this.lblGolesLocal.Size = new System.Drawing.Size(91, 16);
            this.lblGolesLocal.TabIndex = 2;
            this.lblGolesLocal.Text = "Goles Local";
            this.lblGolesLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGolesVisita
            // 
            this.lblGolesVisita.AutoSize = true;
            this.lblGolesVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolesVisita.Location = new System.Drawing.Point(159, 84);
            this.lblGolesVisita.Name = "lblGolesVisita";
            this.lblGolesVisita.Size = new System.Drawing.Size(90, 16);
            this.lblGolesVisita.TabIndex = 1;
            this.lblGolesVisita.Text = "Goles visita";
            this.lblGolesVisita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMontoApostado
            // 
            this.lblMontoApostado.AutoSize = true;
            this.lblMontoApostado.Location = new System.Drawing.Point(21, 25);
            this.lblMontoApostado.Name = "lblMontoApostado";
            this.lblMontoApostado.Size = new System.Drawing.Size(87, 13);
            this.lblMontoApostado.TabIndex = 0;
            this.lblMontoApostado.Text = "Monto apostado:";
            // 
            // txtMontoRetiro
            // 
            this.txtMontoRetiro.Location = new System.Drawing.Point(234, 376);
            this.txtMontoRetiro.Name = "txtMontoRetiro";
            this.txtMontoRetiro.Size = new System.Drawing.Size(100, 20);
            this.txtMontoRetiro.TabIndex = 6;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(259, 415);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "Retirar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(178, 414);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSalidaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 453);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtMontoRetiro);
            this.Controls.Add(this.grbDatosApuesta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grbDatosCliente);
            this.Controls.Add(this.grbBusqueda);
            this.Name = "frmSalidaCaja";
            this.Text = "Salidas de Caja";
            this.Load += new System.EventHandler(this.frmSalidaCaja_Load);
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            this.grbDatosCliente.ResumeLayout(false);
            this.grbDatosCliente.PerformLayout();
            this.grbDatosApuesta.ResumeLayout(false);
            this.grbDatosApuesta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodRecibo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.GroupBox grbDatosCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbDatosApuesta;
        private System.Windows.Forms.Label lblGolesLocal;
        private System.Windows.Forms.Label lblGolesVisita;
        private System.Windows.Forms.Label lblMontoApostado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEquipoVisita;
        private System.Windows.Forms.Label lblEquipoLocal;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMontoRetiro;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtFechaCierre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFechaReg;
        private System.Windows.Forms.Label label5;
    }
}