namespace BetZelva
{
    partial class frmRegistroEncuentro
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
            this.components = new System.ComponentModel.Container();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnMontoGanar = new GEN.ControlesBase.txtNumRea(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtnMontoApuesta = new GEN.ControlesBase.txtNumRea(this.components);
            this.lblFechaHoraEncuentro = new System.Windows.Forms.Label();
            this.lblPagaEmpate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPagaVisita = new System.Windows.Forms.Label();
            this.lblPagaLocal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtnAnotacionVisita = new GEN.ControlesBase.txtCBNumerosEnteros(this.components);
            this.txtnAnotacionLocal = new GEN.ControlesBase.txtCBNumerosEnteros(this.components);
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtcNombreVisita = new System.Windows.Forms.TextBox();
            this.txtcNombreLocal = new System.Windows.Forms.TextBox();
            this.txtCodEncuentro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtcDocumento = new GEN.ControlesBase.txtCBNroDocumentos(this.components);
            this.txtcNombres = new System.Windows.Forms.TextBox();
            this.txtcApellidoMat = new System.Windows.Forms.TextBox();
            this.txtcApellidoPat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodRecibo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grbDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Location = new System.Drawing.Point(263, 351);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 14;
            this.btnGrabar.Text = "&Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Enabled = false;
            this.btnNuevo.Location = new System.Drawing.Point(187, 351);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(339, 351);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apellido Paterno:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblFechaHoraEncuentro);
            this.groupBox1.Controls.Add(this.lblPagaEmpate);
            this.groupBox1.Controls.Add(this.lblPagaVisita);
            this.groupBox1.Controls.Add(this.lblPagaLocal);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtcNombreVisita);
            this.groupBox1.Controls.Add(this.txtcNombreLocal);
            this.groupBox1.Controls.Add(this.txtCodEncuentro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnBusca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 205);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Encuentro";
            // 
            // txtnMontoGanar
            // 
            this.txtnMontoGanar.Enabled = false;
            this.txtnMontoGanar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnMontoGanar.FormatoDecimal = false;
            this.txtnMontoGanar.Location = new System.Drawing.Point(293, 58);
            this.txtnMontoGanar.Multiline = true;
            this.txtnMontoGanar.Name = "txtnMontoGanar";
            this.txtnMontoGanar.nDecValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtnMontoGanar.nNumDecimales = 1;
            this.txtnMontoGanar.nvalor = 0D;
            this.txtnMontoGanar.ReadOnly = true;
            this.txtnMontoGanar.Size = new System.Drawing.Size(100, 28);
            this.txtnMontoGanar.TabIndex = 20;
            this.txtnMontoGanar.Text = "0";
            this.txtnMontoGanar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(181, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Empate:";
            // 
            // txtnMontoApuesta
            // 
            this.txtnMontoApuesta.Enabled = false;
            this.txtnMontoApuesta.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnMontoApuesta.FormatoDecimal = false;
            this.txtnMontoApuesta.Location = new System.Drawing.Point(91, 59);
            this.txtnMontoApuesta.Multiline = true;
            this.txtnMontoApuesta.Name = "txtnMontoApuesta";
            this.txtnMontoApuesta.nDecValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtnMontoApuesta.nNumDecimales = 1;
            this.txtnMontoApuesta.nvalor = 0D;
            this.txtnMontoApuesta.Size = new System.Drawing.Size(100, 28);
            this.txtnMontoApuesta.TabIndex = 10;
            this.txtnMontoApuesta.Text = "0";
            this.txtnMontoApuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnMontoApuesta.TextChanged += new System.EventHandler(this.txtnMontoApuesta_TextChanged);
            // 
            // lblFechaHoraEncuentro
            // 
            this.lblFechaHoraEncuentro.AutoSize = true;
            this.lblFechaHoraEncuentro.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraEncuentro.Location = new System.Drawing.Point(255, 24);
            this.lblFechaHoraEncuentro.Name = "lblFechaHoraEncuentro";
            this.lblFechaHoraEncuentro.Size = new System.Drawing.Size(41, 16);
            this.lblFechaHoraEncuentro.TabIndex = 18;
            this.lblFechaHoraEncuentro.Text = "cHora";
            // 
            // lblPagaEmpate
            // 
            this.lblPagaEmpate.AutoSize = true;
            this.lblPagaEmpate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagaEmpate.ForeColor = System.Drawing.Color.Navy;
            this.lblPagaEmpate.Location = new System.Drawing.Point(169, 91);
            this.lblPagaEmpate.Name = "lblPagaEmpate";
            this.lblPagaEmpate.Size = new System.Drawing.Size(126, 16);
            this.lblPagaEmpate.TabIndex = 17;
            this.lblPagaEmpate.Text = "nMultiplicadorEmpate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(197, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Monto por Ganar:";
            // 
            // lblPagaVisita
            // 
            this.lblPagaVisita.AutoSize = true;
            this.lblPagaVisita.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagaVisita.ForeColor = System.Drawing.Color.Navy;
            this.lblPagaVisita.Location = new System.Drawing.Point(271, 91);
            this.lblPagaVisita.Name = "lblPagaVisita";
            this.lblPagaVisita.Size = new System.Drawing.Size(114, 16);
            this.lblPagaVisita.TabIndex = 14;
            this.lblPagaVisita.Text = "nMultiplicadorVisita";
            // 
            // lblPagaLocal
            // 
            this.lblPagaLocal.AutoSize = true;
            this.lblPagaLocal.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagaLocal.ForeColor = System.Drawing.Color.Navy;
            this.lblPagaLocal.Location = new System.Drawing.Point(64, 91);
            this.lblPagaLocal.Name = "lblPagaLocal";
            this.lblPagaLocal.Size = new System.Drawing.Size(114, 16);
            this.lblPagaLocal.TabIndex = 13;
            this.lblPagaLocal.Text = "nMultiplicadorLocal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Monto Apuesta:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtnMontoGanar);
            this.groupBox4.Controls.Add(this.txtnAnotacionVisita);
            this.groupBox4.Controls.Add(this.txtnAnotacionLocal);
            this.groupBox4.Controls.Add(this.txtnMontoApuesta);
            this.groupBox4.Controls.Add(this.lblResultado);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(6, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 97);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // txtnAnotacionVisita
            // 
            this.txtnAnotacionVisita.Enabled = false;
            this.txtnAnotacionVisita.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnAnotacionVisita.Location = new System.Drawing.Point(210, 17);
            this.txtnAnotacionVisita.Multiline = true;
            this.txtnAnotacionVisita.Name = "txtnAnotacionVisita";
            this.txtnAnotacionVisita.Size = new System.Drawing.Size(73, 36);
            this.txtnAnotacionVisita.TabIndex = 8;
            this.txtnAnotacionVisita.Text = "0";
            this.txtnAnotacionVisita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnAnotacionVisita.Click += new System.EventHandler(this.txtnAnotacionVisita_Click);
            this.txtnAnotacionVisita.TextChanged += new System.EventHandler(this.txtnAnotacionVisita_TextChanged);
            // 
            // txtnAnotacionLocal
            // 
            this.txtnAnotacionLocal.Enabled = false;
            this.txtnAnotacionLocal.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnAnotacionLocal.Location = new System.Drawing.Point(13, 17);
            this.txtnAnotacionLocal.Multiline = true;
            this.txtnAnotacionLocal.Name = "txtnAnotacionLocal";
            this.txtnAnotacionLocal.Size = new System.Drawing.Size(73, 36);
            this.txtnAnotacionLocal.TabIndex = 7;
            this.txtnAnotacionLocal.Text = "0";
            this.txtnAnotacionLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnAnotacionLocal.Click += new System.EventHandler(this.txtnAnotacionLocal_Click);
            this.txtnAnotacionLocal.TextChanged += new System.EventHandler(this.txtnAnotacionLocal_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblResultado.Location = new System.Drawing.Point(107, 17);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(94, 21);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "cResultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcNombreVisita
            // 
            this.txtcNombreVisita.Location = new System.Drawing.Point(225, 48);
            this.txtcNombreVisita.Name = "txtcNombreVisita";
            this.txtcNombreVisita.ReadOnly = true;
            this.txtcNombreVisita.Size = new System.Drawing.Size(151, 20);
            this.txtcNombreVisita.TabIndex = 9;
            this.txtcNombreVisita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcNombreLocal
            // 
            this.txtcNombreLocal.Location = new System.Drawing.Point(25, 48);
            this.txtcNombreLocal.Name = "txtcNombreLocal";
            this.txtcNombreLocal.ReadOnly = true;
            this.txtcNombreLocal.Size = new System.Drawing.Size(151, 20);
            this.txtcNombreLocal.TabIndex = 8;
            this.txtcNombreLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodEncuentro
            // 
            this.txtCodEncuentro.Location = new System.Drawing.Point(109, 19);
            this.txtCodEncuentro.Name = "txtCodEncuentro";
            this.txtCodEncuentro.ReadOnly = true;
            this.txtCodEncuentro.Size = new System.Drawing.Size(100, 20);
            this.txtCodEncuentro.TabIndex = 7;
            this.txtCodEncuentro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(252, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "VISITA (V)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(179, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 31);
            this.label8.TabIndex = 5;
            this.label8.Text = "VS";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "LOCAL (L)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(215, 17);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(34, 23);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "...";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Código Encuentro:";
            // 
            // grbDatosCliente
            // 
            this.grbDatosCliente.Controls.Add(this.txtcDocumento);
            this.grbDatosCliente.Controls.Add(this.txtcNombres);
            this.grbDatosCliente.Controls.Add(this.txtcApellidoMat);
            this.grbDatosCliente.Controls.Add(this.txtcApellidoPat);
            this.grbDatosCliente.Controls.Add(this.label4);
            this.grbDatosCliente.Controls.Add(this.label3);
            this.grbDatosCliente.Controls.Add(this.label2);
            this.grbDatosCliente.Controls.Add(this.label1);
            this.grbDatosCliente.Enabled = false;
            this.grbDatosCliente.Location = new System.Drawing.Point(4, 220);
            this.grbDatosCliente.Name = "grbDatosCliente";
            this.grbDatosCliente.Size = new System.Drawing.Size(417, 106);
            this.grbDatosCliente.TabIndex = 5;
            this.grbDatosCliente.TabStop = false;
            this.grbDatosCliente.Text = "Datos del Cliente";
            // 
            // txtcDocumento
            // 
            this.txtcDocumento.Location = new System.Drawing.Point(109, 80);
            this.txtcDocumento.Name = "txtcDocumento";
            this.txtcDocumento.Size = new System.Drawing.Size(162, 20);
            this.txtcDocumento.TabIndex = 13;
            // 
            // txtcNombres
            // 
            this.txtcNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcNombres.Location = new System.Drawing.Point(108, 58);
            this.txtcNombres.Name = "txtcNombres";
            this.txtcNombres.Size = new System.Drawing.Size(208, 20);
            this.txtcNombres.TabIndex = 12;
            // 
            // txtcApellidoMat
            // 
            this.txtcApellidoMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcApellidoMat.Location = new System.Drawing.Point(108, 35);
            this.txtcApellidoMat.Name = "txtcApellidoMat";
            this.txtcApellidoMat.Size = new System.Drawing.Size(282, 20);
            this.txtcApellidoMat.TabIndex = 11;
            // 
            // txtcApellidoPat
            // 
            this.txtcApellidoPat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcApellidoPat.Location = new System.Drawing.Point(108, 13);
            this.txtcApellidoPat.Name = "txtcApellidoPat";
            this.txtcApellidoPat.Size = new System.Drawing.Size(282, 20);
            this.txtcApellidoPat.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido Materno:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(111, 351);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCodRecibo
            // 
            this.txtCodRecibo.Location = new System.Drawing.Point(339, 328);
            this.txtCodRecibo.Name = "txtCodRecibo";
            this.txtCodRecibo.ReadOnly = true;
            this.txtCodRecibo.Size = new System.Drawing.Size(75, 20);
            this.txtCodRecibo.TabIndex = 7;
            this.txtCodRecibo.Text = "0";
            this.txtCodRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Cód. Recibo:";
            // 
            // frmRegistroEncuentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 386);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCodRecibo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbDatosCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Name = "frmRegistroEncuentro";
            this.Text = "Registro Encuentro";
            this.Load += new System.EventHandler(this.frmRegistroEncuentro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbDatosCliente.ResumeLayout(false);
            this.grbDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPagaVisita;
        private System.Windows.Forms.Label lblPagaLocal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtcNombreVisita;
        private System.Windows.Forms.TextBox txtcNombreLocal;
        private System.Windows.Forms.TextBox txtCodEncuentro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbDatosCliente;
        private System.Windows.Forms.TextBox txtcNombres;
        private System.Windows.Forms.TextBox txtcApellidoMat;
        private System.Windows.Forms.TextBox txtcApellidoPat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFechaHoraEncuentro;
        private System.Windows.Forms.Label lblPagaEmpate;
        private GEN.ControlesBase.txtNumRea txtnMontoApuesta;
        private GEN.ControlesBase.txtCBNumerosEnteros txtnAnotacionVisita;
        private GEN.ControlesBase.txtCBNumerosEnteros txtnAnotacionLocal;
        private System.Windows.Forms.Label label7;
        private GEN.ControlesBase.txtNumRea txtnMontoGanar;
        private GEN.ControlesBase.txtCBNroDocumentos txtcDocumento;
        private System.Windows.Forms.TextBox txtCodRecibo;
        private System.Windows.Forms.Label label11;
    }
}