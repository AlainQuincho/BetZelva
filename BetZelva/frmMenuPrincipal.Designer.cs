namespace BetZelva
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnFrmInicioOperaciones = new System.Windows.Forms.Button();
            this.btnFrmRegistraEncuentro = new System.Windows.Forms.Button();
            this.btnOpcionVisualizar = new System.Windows.Forms.Button();
            this.btnFrmUsuarios = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(250, 38);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1050, 612);
            this.pnlContenedor.TabIndex = 5;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTop.Controls.Add(this.btnMinimizar);
            this.pnlTop.Controls.Add(this.btnMaximizar);
            this.pnlTop.Controls.Add(this.btnRestaurar);
            this.pnlTop.Controls.Add(this.btnSalir);
            this.pnlTop.Controls.Add(this.btnMenu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(250, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1050, 38);
            this.pnlTop.TabIndex = 4;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.pnlMenuVertical.Controls.Add(this.btnFrmInicioOperaciones);
            this.pnlMenuVertical.Controls.Add(this.btnFrmRegistraEncuentro);
            this.pnlMenuVertical.Controls.Add(this.btnOpcionVisualizar);
            this.pnlMenuVertical.Controls.Add(this.btnFrmUsuarios);
            this.pnlMenuVertical.Controls.Add(this.button8);
            this.pnlMenuVertical.Controls.Add(this.ptbLogo);
            this.pnlMenuVertical.Controls.Add(this.button2);
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(250, 650);
            this.pnlMenuVertical.TabIndex = 3;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = global::BetZelva.Properties.Resources.btnMinimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(930, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = global::BetZelva.Properties.Resources.btnMaximizar;
            this.btnMaximizar.Location = new System.Drawing.Point(971, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = global::BetZelva.Properties.Resources.btnRestaurar;
            this.btnRestaurar.Location = new System.Drawing.Point(971, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Image = global::BetZelva.Properties.Resources.btnSalir;
            this.btnSalir.Location = new System.Drawing.Point(1012, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 25);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 1;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::BetZelva.Properties.Resources.IconoHamburguesa;
            this.btnMenu.InitialImage = global::BetZelva.Properties.Resources.IconoHamburguesa;
            this.btnMenu.Location = new System.Drawing.Point(3, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 30);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnFrmInicioOperaciones
            // 
            this.btnFrmInicioOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnFrmInicioOperaciones.FlatAppearance.BorderSize = 0;
            this.btnFrmInicioOperaciones.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFrmInicioOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmInicioOperaciones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmInicioOperaciones.ForeColor = System.Drawing.Color.White;
            this.btnFrmInicioOperaciones.Image = global::BetZelva.Properties.Resources._24_Iniciar;
            this.btnFrmInicioOperaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmInicioOperaciones.Location = new System.Drawing.Point(12, 356);
            this.btnFrmInicioOperaciones.Name = "btnFrmInicioOperaciones";
            this.btnFrmInicioOperaciones.Size = new System.Drawing.Size(229, 32);
            this.btnFrmInicioOperaciones.TabIndex = 20;
            this.btnFrmInicioOperaciones.Text = "Iniciar operaciones";
            this.btnFrmInicioOperaciones.UseVisualStyleBackColor = false;
            this.btnFrmInicioOperaciones.Click += new System.EventHandler(this.btnFrmInicioOperaciones_Click);
            // 
            // btnFrmRegistraEncuentro
            // 
            this.btnFrmRegistraEncuentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnFrmRegistraEncuentro.FlatAppearance.BorderSize = 0;
            this.btnFrmRegistraEncuentro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFrmRegistraEncuentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmRegistraEncuentro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmRegistraEncuentro.ForeColor = System.Drawing.Color.White;
            this.btnFrmRegistraEncuentro.Image = global::BetZelva.Properties.Resources._24_Registra;
            this.btnFrmRegistraEncuentro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmRegistraEncuentro.Location = new System.Drawing.Point(12, 394);
            this.btnFrmRegistraEncuentro.Name = "btnFrmRegistraEncuentro";
            this.btnFrmRegistraEncuentro.Size = new System.Drawing.Size(229, 32);
            this.btnFrmRegistraEncuentro.TabIndex = 19;
            this.btnFrmRegistraEncuentro.Text = "Registrar encuentro";
            this.btnFrmRegistraEncuentro.UseVisualStyleBackColor = false;
            this.btnFrmRegistraEncuentro.Click += new System.EventHandler(this.btnFrmRegistraEncuentro_Click);
            // 
            // btnOpcionVisualizar
            // 
            this.btnOpcionVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOpcionVisualizar.FlatAppearance.BorderSize = 0;
            this.btnOpcionVisualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOpcionVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcionVisualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnOpcionVisualizar.Image = global::BetZelva.Properties.Resources._24_Tv;
            this.btnOpcionVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpcionVisualizar.Location = new System.Drawing.Point(12, 606);
            this.btnOpcionVisualizar.Name = "btnOpcionVisualizar";
            this.btnOpcionVisualizar.Size = new System.Drawing.Size(229, 32);
            this.btnOpcionVisualizar.TabIndex = 18;
            this.btnOpcionVisualizar.Text = "Visualizar control";
            this.btnOpcionVisualizar.UseVisualStyleBackColor = false;
            this.btnOpcionVisualizar.Click += new System.EventHandler(this.btnOpcionVisualizar_Click);
            // 
            // btnFrmUsuarios
            // 
            this.btnFrmUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnFrmUsuarios.FlatAppearance.BorderSize = 0;
            this.btnFrmUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFrmUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnFrmUsuarios.Image = global::BetZelva.Properties.Resources._24_Usuario;
            this.btnFrmUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmUsuarios.Location = new System.Drawing.Point(12, 432);
            this.btnFrmUsuarios.Name = "btnFrmUsuarios";
            this.btnFrmUsuarios.Size = new System.Drawing.Size(229, 32);
            this.btnFrmUsuarios.TabIndex = 14;
            this.btnFrmUsuarios.Text = "Mantenimiento usuarios";
            this.btnFrmUsuarios.UseVisualStyleBackColor = false;
            this.btnFrmUsuarios.Click += new System.EventHandler(this.btnFrmUsuarios_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 269);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(250, 32);
            this.button8.TabIndex = 13;
            this.button8.Text = "Operaciones";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::BetZelva.Properties.Resources.MiniLogo;
            this.ptbLogo.Location = new System.Drawing.Point(0, 4);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(250, 92);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Operaciones";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContenedor";
            this.pnlTop.ResumeLayout(false);
            this.pnlMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.Button btnOpcionVisualizar;
        private System.Windows.Forms.Button btnFrmUsuarios;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFrmRegistraEncuentro;
        private System.Windows.Forms.Button btnFrmInicioOperaciones;
    }
}