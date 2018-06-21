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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlGanadores = new System.Windows.Forms.TableLayoutPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerParticipantes = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRondaApuesta)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantesRonda)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.pnlGanadores, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.76936F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.23064F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1250, 593);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtgRondaApuesta
            // 
            this.dtgRondaApuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRondaApuesta.Image = global::BetZelva.Properties.Resources.Logo;
            this.dtgRondaApuesta.Location = new System.Drawing.Point(842, 3);
            this.dtgRondaApuesta.Name = "dtgRondaApuesta";
            this.dtgRondaApuesta.Size = new System.Drawing.Size(405, 111);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(833, 111);
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
            this.label1.Size = new System.Drawing.Size(827, 55);
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
            this.lblRondaApuesta.Location = new System.Drawing.Point(3, 55);
            this.lblRondaApuesta.Name = "lblRondaApuesta";
            this.lblRondaApuesta.Size = new System.Drawing.Size(827, 56);
            this.lblRondaApuesta.TabIndex = 1;
            this.lblRondaApuesta.Text = "--- . ---";
            this.lblRondaApuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.253012F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.74699F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.Controls.Add(this.dtgParticipantesRonda, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 120);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.47165F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.52834F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(833, 470);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // dtgParticipantesRonda
            // 
            this.dtgParticipantesRonda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgParticipantesRonda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgParticipantesRonda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgParticipantesRonda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParticipantesRonda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilaColumn,
            this.NombresColumn,
            this.MontoColumn,
            this.ScortLocalColumn,
            this.ScortVisitaColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgParticipantesRonda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgParticipantesRonda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgParticipantesRonda.GridColor = System.Drawing.SystemColors.Control;
            this.dtgParticipantesRonda.Location = new System.Drawing.Point(29, 59);
            this.dtgParticipantesRonda.Name = "dtgParticipantesRonda";
            this.dtgParticipantesRonda.RowHeadersVisible = false;
            this.dtgParticipantesRonda.Size = new System.Drawing.Size(778, 387);
            this.dtgParticipantesRonda.TabIndex = 0;
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
            this.NombresColumn.HeaderText = "NOMBRES Y APELLIDOS";
            this.NombresColumn.Name = "NombresColumn";
            this.NombresColumn.ReadOnly = true;
            // 
            // MontoColumn
            // 
            this.MontoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MontoColumn.DataPropertyName = "MontoApuesta";
            this.MontoColumn.FillWeight = 20F;
            this.MontoColumn.HeaderText = "MONTO APUESTA";
            this.MontoColumn.Name = "MontoColumn";
            this.MontoColumn.ReadOnly = true;
            // 
            // ScortLocalColumn
            // 
            this.ScortLocalColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScortLocalColumn.DataPropertyName = "ScortLocal";
            this.ScortLocalColumn.FillWeight = 15F;
            this.ScortLocalColumn.HeaderText = "SCORT LOCAL";
            this.ScortLocalColumn.Name = "ScortLocalColumn";
            this.ScortLocalColumn.ReadOnly = true;
            // 
            // ScortVisitaColumn
            // 
            this.ScortVisitaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScortVisitaColumn.DataPropertyName = "ScortVisita";
            this.ScortVisitaColumn.FillWeight = 15F;
            this.ScortVisitaColumn.HeaderText = "SCORT VISITA";
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
            this.label3.Size = new System.Drawing.Size(778, 56);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lista de participantes de la ronda:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlGanadores
            // 
            this.pnlGanadores.ColumnCount = 1;
            this.pnlGanadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlGanadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGanadores.Location = new System.Drawing.Point(842, 120);
            this.pnlGanadores.Name = "pnlGanadores";
            this.pnlGanadores.RowCount = 1;
            this.pnlGanadores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlGanadores.Size = new System.Drawing.Size(405, 470);
            this.pnlGanadores.TabIndex = 4;
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
            this.ClientSize = new System.Drawing.Size(1250, 593);
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
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerParticipantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScortLocalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScortVisitaColumn;
        private System.Windows.Forms.TableLayoutPanel pnlGanadores;
    }
}