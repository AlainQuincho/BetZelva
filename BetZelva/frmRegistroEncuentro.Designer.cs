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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFechaHoraEncuentro = new System.Windows.Forms.Label();
            this.lblPagaEmpate = new System.Windows.Forms.Label();
            this.lblPagaVisita = new System.Windows.Forms.Label();
            this.lblPagaLocal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtnMontoGanar = new GEN.ControlesBase.txtNumRea(this.components);
            this.txtnAnotacionVisita = new GEN.ControlesBase.txtCBNumerosEnteros(this.components);
            this.txtnAnotacionLocal = new GEN.ControlesBase.txtCBNumerosEnteros(this.components);
            this.txtnMontoApuesta = new GEN.ControlesBase.txtNumRea(this.components);
            this.lblResultado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcNombreVisita = new System.Windows.Forms.TextBox();
            this.txtcNombreLocal = new System.Windows.Forms.TextBox();
            this.txtCodEncuentro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtcDocumento = new GEN.ControlesBase.txtCBNroDocumentos(this.components);
            this.txtcNombres = new System.Windows.Forms.TextBox();
            this.txtcApellidoMat = new System.Windows.Forms.TextBox();
            this.txtcApellidoPat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodRecibo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grbDatosCliente.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apellido Paterno:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBusca);
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
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 357);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Encuentro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(205, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Empate:";
            // 
            // lblFechaHoraEncuentro
            // 
            this.lblFechaHoraEncuentro.AutoSize = true;
            this.lblFechaHoraEncuentro.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHoraEncuentro.Location = new System.Drawing.Point(393, 45);
            this.lblFechaHoraEncuentro.Name = "lblFechaHoraEncuentro";
            this.lblFechaHoraEncuentro.Size = new System.Drawing.Size(55, 21);
            this.lblFechaHoraEncuentro.TabIndex = 18;
            this.lblFechaHoraEncuentro.Text = "cHora";
            // 
            // lblPagaEmpate
            // 
            this.lblPagaEmpate.AutoSize = true;
            this.lblPagaEmpate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagaEmpate.ForeColor = System.Drawing.Color.Navy;
            this.lblPagaEmpate.Location = new System.Drawing.Point(174, 148);
            this.lblPagaEmpate.Name = "lblPagaEmpate";
            this.lblPagaEmpate.Size = new System.Drawing.Size(182, 21);
            this.lblPagaEmpate.TabIndex = 17;
            this.lblPagaEmpate.Text = "nMultiplicadorEmpate";
            // 
            // lblPagaVisita
            // 
            this.lblPagaVisita.AutoSize = true;
            this.lblPagaVisita.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagaVisita.ForeColor = System.Drawing.Color.Navy;
            this.lblPagaVisita.Location = new System.Drawing.Point(320, 148);
            this.lblPagaVisita.Name = "lblPagaVisita";
            this.lblPagaVisita.Size = new System.Drawing.Size(167, 21);
            this.lblPagaVisita.TabIndex = 14;
            this.lblPagaVisita.Text = "nMultiplicadorVisita";
            // 
            // lblPagaLocal
            // 
            this.lblPagaLocal.AutoSize = true;
            this.lblPagaLocal.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagaLocal.ForeColor = System.Drawing.Color.Navy;
            this.lblPagaLocal.Location = new System.Drawing.Point(39, 148);
            this.lblPagaLocal.Name = "lblPagaLocal";
            this.lblPagaLocal.Size = new System.Drawing.Size(164, 21);
            this.lblPagaLocal.TabIndex = 13;
            this.lblPagaLocal.Text = "nMultiplicadorLocal";
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
            this.groupBox4.Location = new System.Drawing.Point(0, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 115);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // txtnMontoGanar
            // 
            this.txtnMontoGanar.Enabled = false;
            this.txtnMontoGanar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnMontoGanar.FormatoDecimal = false;
            this.txtnMontoGanar.Location = new System.Drawing.Point(363, 81);
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
            // txtnAnotacionVisita
            // 
            this.txtnAnotacionVisita.Enabled = false;
            this.txtnAnotacionVisita.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnAnotacionVisita.Location = new System.Drawing.Point(347, 17);
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
            this.txtnAnotacionLocal.Location = new System.Drawing.Point(42, 17);
            this.txtnAnotacionLocal.Multiline = true;
            this.txtnAnotacionLocal.Name = "txtnAnotacionLocal";
            this.txtnAnotacionLocal.Size = new System.Drawing.Size(73, 36);
            this.txtnAnotacionLocal.TabIndex = 7;
            this.txtnAnotacionLocal.Text = "0";
            this.txtnAnotacionLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnAnotacionLocal.Click += new System.EventHandler(this.txtnAnotacionLocal_Click);
            this.txtnAnotacionLocal.TextChanged += new System.EventHandler(this.txtnAnotacionLocal_TextChanged);
            // 
            // txtnMontoApuesta
            // 
            this.txtnMontoApuesta.Enabled = false;
            this.txtnMontoApuesta.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnMontoApuesta.FormatoDecimal = false;
            this.txtnMontoApuesta.Location = new System.Drawing.Point(120, 81);
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
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblResultado.Location = new System.Drawing.Point(173, 19);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(94, 21);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "cResultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Monto Apuesta:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(232, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Monto por Ganar:";
            // 
            // txtcNombreVisita
            // 
            this.txtcNombreVisita.Location = new System.Drawing.Point(283, 84);
            this.txtcNombreVisita.Name = "txtcNombreVisita";
            this.txtcNombreVisita.ReadOnly = true;
            this.txtcNombreVisita.Size = new System.Drawing.Size(151, 23);
            this.txtcNombreVisita.TabIndex = 9;
            this.txtcNombreVisita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcNombreLocal
            // 
            this.txtcNombreLocal.Location = new System.Drawing.Point(29, 84);
            this.txtcNombreLocal.Name = "txtcNombreLocal";
            this.txtcNombreLocal.ReadOnly = true;
            this.txtcNombreLocal.Size = new System.Drawing.Size(151, 23);
            this.txtcNombreLocal.TabIndex = 8;
            this.txtcNombreLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodEncuentro
            // 
            this.txtCodEncuentro.Location = new System.Drawing.Point(151, 41);
            this.txtCodEncuentro.Name = "txtCodEncuentro";
            this.txtCodEncuentro.ReadOnly = true;
            this.txtCodEncuentro.Size = new System.Drawing.Size(100, 23);
            this.txtCodEncuentro.TabIndex = 7;
            this.txtCodEncuentro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 110);
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
            this.label8.Location = new System.Drawing.Point(208, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 31);
            this.label8.TabIndex = 5;
            this.label8.Text = "VS";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "LOCAL (L)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
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
            this.grbDatosCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDatosCliente.Enabled = false;
            this.grbDatosCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosCliente.Location = new System.Drawing.Point(497, 3);
            this.grbDatosCliente.Name = "grbDatosCliente";
            this.grbDatosCliente.Size = new System.Drawing.Size(488, 357);
            this.grbDatosCliente.TabIndex = 5;
            this.grbDatosCliente.TabStop = false;
            this.grbDatosCliente.Text = "Datos del Cliente";
            // 
            // txtcDocumento
            // 
            this.txtcDocumento.Location = new System.Drawing.Point(165, 125);
            this.txtcDocumento.Name = "txtcDocumento";
            this.txtcDocumento.Size = new System.Drawing.Size(162, 23);
            this.txtcDocumento.TabIndex = 13;
            // 
            // txtcNombres
            // 
            this.txtcNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcNombres.Location = new System.Drawing.Point(165, 96);
            this.txtcNombres.Name = "txtcNombres";
            this.txtcNombres.Size = new System.Drawing.Size(282, 23);
            this.txtcNombres.TabIndex = 12;
            // 
            // txtcApellidoMat
            // 
            this.txtcApellidoMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcApellidoMat.Location = new System.Drawing.Point(165, 67);
            this.txtcApellidoMat.Name = "txtcApellidoMat";
            this.txtcApellidoMat.Size = new System.Drawing.Size(282, 23);
            this.txtcApellidoMat.TabIndex = 11;
            // 
            // txtcApellidoPat
            // 
            this.txtcApellidoPat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcApellidoPat.Location = new System.Drawing.Point(165, 38);
            this.txtcApellidoPat.Name = "txtcApellidoPat";
            this.txtcApellidoPat.Size = new System.Drawing.Size(282, 23);
            this.txtcApellidoPat.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido Materno:";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 500);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(28, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(994, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 397);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(988, 44);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSalir);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Controls.Add(this.btnGrabar);
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(101, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 38);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.grbDatosCliente, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(988, 363);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Image = global::BetZelva.Properties.Resources._24_Volver;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(667, 2);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 32);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "VOLVER";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Image = global::BetZelva.Properties.Resources._24_Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(533, 2);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 32);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGrabar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGrabar.Image = global::BetZelva.Properties.Resources._24_Grabar;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(398, 2);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(131, 32);
            this.btnGrabar.TabIndex = 16;
            this.btnGrabar.Text = "GUARDAR";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Image = global::BetZelva.Properties.Resources._24_Nuevo;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(278, 2);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 32);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBusca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBusca.Image = global::BetZelva.Properties.Resources._16_Buscar;
            this.btnBusca.Location = new System.Drawing.Point(279, 40);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(2);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(46, 24);
            this.btnBusca.TabIndex = 20;
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // frmRegistroEncuentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1050, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCodRecibo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroEncuentro";
            this.Text = "Registro Encuentro";
            this.Load += new System.EventHandler(this.frmRegistroEncuentro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbDatosCliente.ResumeLayout(false);
            this.grbDatosCliente.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbDatosCliente;
        private System.Windows.Forms.TextBox txtcNombres;
        private System.Windows.Forms.TextBox txtcApellidoMat;
        private System.Windows.Forms.TextBox txtcApellidoPat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnBusca;
    }
}