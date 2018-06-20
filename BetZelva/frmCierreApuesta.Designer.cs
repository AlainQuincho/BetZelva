namespace BetZelva
{
    partial class frmCierreApuesta
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
            this.dtgEncuentros = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbDetalle = new System.Windows.Forms.GroupBox();
            this.txtVisita = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbGrid = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGolesVisita = new System.Windows.Forms.TextBox();
            this.txtGolesLocal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbResultado = new System.Windows.Forms.GroupBox();
            this.MultiVisita = new System.Windows.Forms.Label();
            this.MultiLocal = new System.Windows.Forms.Label();
            this.MultiEmpate = new System.Windows.Forms.Label();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncuentros)).BeginInit();
            this.grbDetalle.SuspendLayout();
            this.grbGrid.SuspendLayout();
            this.grbResultado.SuspendLayout();
            this.grbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgEncuentros
            // 
            this.dtgEncuentros.AllowUserToAddRows = false;
            this.dtgEncuentros.AllowUserToDeleteRows = false;
            this.dtgEncuentros.AllowUserToResizeColumns = false;
            this.dtgEncuentros.AllowUserToResizeRows = false;
            this.dtgEncuentros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgEncuentros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEncuentros.Location = new System.Drawing.Point(16, 19);
            this.dtgEncuentros.MultiSelect = false;
            this.dtgEncuentros.Name = "dtgEncuentros";
            this.dtgEncuentros.RowHeadersVisible = false;
            this.dtgEncuentros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEncuentros.Size = new System.Drawing.Size(399, 273);
            this.dtgEncuentros.TabIndex = 6;
            this.dtgEncuentros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEncuentros_CellClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(614, 292);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 27);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grbDetalle
            // 
            this.grbDetalle.Controls.Add(this.txtVisita);
            this.grbDetalle.Controls.Add(this.txtLocal);
            this.grbDetalle.Controls.Add(this.txtFecha);
            this.grbDetalle.Controls.Add(this.txtCod);
            this.grbDetalle.Controls.Add(this.label8);
            this.grbDetalle.Controls.Add(this.label7);
            this.grbDetalle.Controls.Add(this.label6);
            this.grbDetalle.Controls.Add(this.label5);
            this.grbDetalle.Location = new System.Drawing.Point(439, 170);
            this.grbDetalle.Name = "grbDetalle";
            this.grbDetalle.Size = new System.Drawing.Size(248, 117);
            this.grbDetalle.TabIndex = 8;
            this.grbDetalle.TabStop = false;
            this.grbDetalle.Text = "DETALLES";
            // 
            // txtVisita
            // 
            this.txtVisita.Location = new System.Drawing.Point(81, 80);
            this.txtVisita.Name = "txtVisita";
            this.txtVisita.Size = new System.Drawing.Size(157, 20);
            this.txtVisita.TabIndex = 12;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(81, 59);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(157, 20);
            this.txtLocal.TabIndex = 11;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(81, 38);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(157, 20);
            this.txtFecha.TabIndex = 10;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(81, 17);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(59, 20);
            this.txtCod.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Visita:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Local:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cod:";
            // 
            // grbGrid
            // 
            this.grbGrid.Controls.Add(this.dtgEncuentros);
            this.grbGrid.Location = new System.Drawing.Point(12, 27);
            this.grbGrid.Name = "grbGrid";
            this.grbGrid.Size = new System.Drawing.Size(421, 298);
            this.grbGrid.TabIndex = 9;
            this.grbGrid.TabStop = false;
            this.grbGrid.Text = "ANTIGUOS RESULTADOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "BUSCAR ENCUENTRO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(170, 9);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 20);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "VISITA";
            // 
            // txtGolesVisita
            // 
            this.txtGolesVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGolesVisita.Location = new System.Drawing.Point(141, 44);
            this.txtGolesVisita.Margin = new System.Windows.Forms.Padding(2);
            this.txtGolesVisita.Multiline = true;
            this.txtGolesVisita.Name = "txtGolesVisita";
            this.txtGolesVisita.Size = new System.Drawing.Size(60, 34);
            this.txtGolesVisita.TabIndex = 3;
            this.txtGolesVisita.Text = "0";
            this.txtGolesVisita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGolesLocal
            // 
            this.txtGolesLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGolesLocal.Location = new System.Drawing.Point(30, 44);
            this.txtGolesLocal.Margin = new System.Windows.Forms.Padding(2);
            this.txtGolesLocal.Multiline = true;
            this.txtGolesLocal.Name = "txtGolesLocal";
            this.txtGolesLocal.Size = new System.Drawing.Size(60, 34);
            this.txtGolesLocal.TabIndex = 1;
            this.txtGolesLocal.Text = "0";
            this.txtGolesLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOCAL";
            // 
            // grbResultado
            // 
            this.grbResultado.Controls.Add(this.MultiVisita);
            this.grbResultado.Controls.Add(this.MultiLocal);
            this.grbResultado.Controls.Add(this.MultiEmpate);
            this.grbResultado.Controls.Add(this.label1);
            this.grbResultado.Controls.Add(this.label3);
            this.grbResultado.Controls.Add(this.txtGolesLocal);
            this.grbResultado.Controls.Add(this.txtGolesVisita);
            this.grbResultado.Controls.Add(this.label2);
            this.grbResultado.Location = new System.Drawing.Point(438, 64);
            this.grbResultado.Margin = new System.Windows.Forms.Padding(2);
            this.grbResultado.Name = "grbResultado";
            this.grbResultado.Padding = new System.Windows.Forms.Padding(2);
            this.grbResultado.Size = new System.Drawing.Size(249, 101);
            this.grbResultado.TabIndex = 5;
            this.grbResultado.TabStop = false;
            this.grbResultado.Text = "RESULTADOS ENCUENTRO";
            // 
            // MultiVisita
            // 
            this.MultiVisita.AutoSize = true;
            this.MultiVisita.Location = new System.Drawing.Point(182, 20);
            this.MultiVisita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MultiVisita.Name = "MultiVisita";
            this.MultiVisita.Size = new System.Drawing.Size(14, 13);
            this.MultiVisita.TabIndex = 7;
            this.MultiVisita.Text = "V";
            // 
            // MultiLocal
            // 
            this.MultiLocal.AutoSize = true;
            this.MultiLocal.Location = new System.Drawing.Point(75, 20);
            this.MultiLocal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MultiLocal.Name = "MultiLocal";
            this.MultiLocal.Size = new System.Drawing.Size(13, 13);
            this.MultiLocal.TabIndex = 6;
            this.MultiLocal.Text = "L";
            // 
            // MultiEmpate
            // 
            this.MultiEmpate.AutoSize = true;
            this.MultiEmpate.Location = new System.Drawing.Point(94, 47);
            this.MultiEmpate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MultiEmpate.Name = "MultiEmpate";
            this.MultiEmpate.Size = new System.Drawing.Size(14, 13);
            this.MultiEmpate.TabIndex = 5;
            this.MultiEmpate.Text = "E";
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.label4);
            this.grbBusqueda.Controls.Add(this.btnBuscar);
            this.grbBusqueda.Location = new System.Drawing.Point(438, 27);
            this.grbBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Padding = new System.Windows.Forms.Padding(2);
            this.grbBusqueda.Size = new System.Drawing.Size(249, 33);
            this.grbBusqueda.TabIndex = 6;
            this.grbBusqueda.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(537, 292);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 27);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(460, 292);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 27);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmCierreApuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 352);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbBusqueda);
            this.Controls.Add(this.grbGrid);
            this.Controls.Add(this.grbDetalle);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbResultado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCierreApuesta";
            this.Text = "Cierre de apuesta";
            this.Load += new System.EventHandler(this.frmCierreApuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncuentros)).EndInit();
            this.grbDetalle.ResumeLayout(false);
            this.grbDetalle.PerformLayout();
            this.grbGrid.ResumeLayout(false);
            this.grbResultado.ResumeLayout(false);
            this.grbResultado.PerformLayout();
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgEncuentros;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grbDetalle;
        private System.Windows.Forms.GroupBox grbGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGolesVisita;
        private System.Windows.Forms.TextBox txtGolesLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbResultado;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.TextBox txtVisita;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MultiVisita;
        private System.Windows.Forms.Label MultiLocal;
        private System.Windows.Forms.Label MultiEmpate;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
    }
}