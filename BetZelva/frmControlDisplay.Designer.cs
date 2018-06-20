namespace BetZelva
{
    partial class frmControlDisplay
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgRondaApuesta = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRondaApuesta = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgParticipantesRonda = new System.Windows.Forms.DataGridView();
            this.FilaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScortLocalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScortVisitaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgRondaGanadores = new System.Windows.Forms.DataGridView();
            this.FilaGanadorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresGanadorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRondaGanadores = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerParticipantes = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRondaApuesta)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantesRonda)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRondaGanadores)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.1371F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.8629F));
            this.tableLayoutPanel1.Controls.Add(this.dtgRondaApuesta, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.76936F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.23064F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1251, 626);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtgRondaApuesta
            // 
            this.dtgRondaApuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRondaApuesta.Image = global::BetZelva.Properties.Resources.Logo;
            this.dtgRondaApuesta.Location = new System.Drawing.Point(842, 3);
            this.dtgRondaApuesta.Name = "dtgRondaApuesta";
            this.dtgRondaApuesta.Size = new System.Drawing.Size(406, 117);
            this.dtgRondaApuesta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dtgRondaApuesta.TabIndex = 1;
            this.dtgRondaApuesta.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblRondaApuesta, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(833, 117);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(827, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "RONDA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRondaApuesta
            // 
            this.lblRondaApuesta.AutoSize = true;
            this.lblRondaApuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRondaApuesta.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRondaApuesta.ForeColor = System.Drawing.Color.Lime;
            this.lblRondaApuesta.Location = new System.Drawing.Point(3, 58);
            this.lblRondaApuesta.Name = "lblRondaApuesta";
            this.lblRondaApuesta.Size = new System.Drawing.Size(827, 59);
            this.lblRondaApuesta.TabIndex = 1;
            this.lblRondaApuesta.Text = "--- . ---";
            this.lblRondaApuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.253012F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.74699F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.Controls.Add(this.dtgParticipantesRonda, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 126);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.47165F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.52834F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(833, 497);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // dtgParticipantesRonda
            // 
            this.dtgParticipantesRonda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgParticipantesRonda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgParticipantesRonda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParticipantesRonda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilaColumn,
            this.NombresColumn,
            this.MontoColumn,
            this.ScortLocalColumn,
            this.ScortVisitaColumn});
            this.dtgParticipantesRonda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgParticipantesRonda.GridColor = System.Drawing.SystemColors.Control;
            this.dtgParticipantesRonda.Location = new System.Drawing.Point(29, 62);
            this.dtgParticipantesRonda.Name = "dtgParticipantesRonda";
            this.dtgParticipantesRonda.Size = new System.Drawing.Size(782, 411);
            this.dtgParticipantesRonda.TabIndex = 0;
            this.dtgParticipantesRonda.SelectionChanged += new System.EventHandler(this.dtgParticipantesRonda_SelectionChanged);
            // 
            // FilaColumn
            // 
            this.FilaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilaColumn.DataPropertyName = "Fila";
            this.FilaColumn.FillWeight = 10F;
            this.FilaColumn.HeaderText = "N°";
            this.FilaColumn.Name = "FilaColumn";
            this.FilaColumn.ReadOnly = true;
            // 
            // NombresColumn
            // 
            this.NombresColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombresColumn.DataPropertyName = "Nombres";
            this.NombresColumn.FillWeight = 40F;
            this.NombresColumn.HeaderText = "Nombres y apellidos";
            this.NombresColumn.Name = "NombresColumn";
            this.NombresColumn.ReadOnly = true;
            // 
            // MontoColumn
            // 
            this.MontoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MontoColumn.DataPropertyName = "MontoApuesta";
            this.MontoColumn.FillWeight = 20F;
            this.MontoColumn.HeaderText = "Monto apuesta";
            this.MontoColumn.Name = "MontoColumn";
            this.MontoColumn.ReadOnly = true;
            // 
            // ScortLocalColumn
            // 
            this.ScortLocalColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScortLocalColumn.DataPropertyName = "ScortLocal";
            this.ScortLocalColumn.FillWeight = 15F;
            this.ScortLocalColumn.HeaderText = "Scort local";
            this.ScortLocalColumn.Name = "ScortLocalColumn";
            this.ScortLocalColumn.ReadOnly = true;
            // 
            // ScortVisitaColumn
            // 
            this.ScortVisitaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScortVisitaColumn.DataPropertyName = "ScortVisita";
            this.ScortVisitaColumn.FillWeight = 15F;
            this.ScortVisitaColumn.HeaderText = "Scort visita";
            this.ScortVisitaColumn.Name = "ScortVisitaColumn";
            this.ScortVisitaColumn.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(29, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(782, 59);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lista de participantes de la ronda:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.104651F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.89535F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.dtgRondaGanadores, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(842, 126);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.36406F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.63595F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(406, 497);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 437);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(356, 57);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dtgRondaGanadores
            // 
            this.dtgRondaGanadores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgRondaGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRondaGanadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilaGanadorColumn,
            this.NombresGanadorColumn});
            this.dtgRondaGanadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRondaGanadores.Location = new System.Drawing.Point(26, 61);
            this.dtgRondaGanadores.Name = "dtgRondaGanadores";
            this.dtgRondaGanadores.Size = new System.Drawing.Size(356, 370);
            this.dtgRondaGanadores.TabIndex = 1;
            // 
            // FilaGanadorColumn
            // 
            this.FilaGanadorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FilaGanadorColumn.DataPropertyName = "Fila";
            this.FilaGanadorColumn.FillWeight = 10F;
            this.FilaGanadorColumn.HeaderText = "N°";
            this.FilaGanadorColumn.Name = "FilaGanadorColumn";
            this.FilaGanadorColumn.ReadOnly = true;
            // 
            // NombresGanadorColumn
            // 
            this.NombresGanadorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombresGanadorColumn.DataPropertyName = "Nombres";
            this.NombresGanadorColumn.FillWeight = 90F;
            this.NombresGanadorColumn.HeaderText = "Nombres y apellidos";
            this.NombresGanadorColumn.Name = "NombresGanadorColumn";
            this.NombresGanadorColumn.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblRondaGanadores, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(26, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(356, 49);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ganadores ronda:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRondaGanadores
            // 
            this.lblRondaGanadores.AutoSize = true;
            this.lblRondaGanadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRondaGanadores.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRondaGanadores.ForeColor = System.Drawing.Color.Yellow;
            this.lblRondaGanadores.Location = new System.Drawing.Point(3, 24);
            this.lblRondaGanadores.Name = "lblRondaGanadores";
            this.lblRondaGanadores.Size = new System.Drawing.Size(350, 25);
            this.lblRondaGanadores.TabIndex = 1;
            this.lblRondaGanadores.Text = "--- . ---";
            this.lblRondaGanadores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerParticipantes
            // 
            this.timerParticipantes.Tick += new System.EventHandler(this.timerParticipantes_Tick);
            // 
            // frmControlDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1251, 626);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmControlDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmControlDisplay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmControlDisplay_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRondaApuesta)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantesRonda)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRondaGanadores)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox dtgRondaApuesta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRondaApuesta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dtgParticipantesRonda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgRondaGanadores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRondaGanadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScortLocalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScortVisitaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilaGanadorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresGanadorColumn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerParticipantes;
    }
}