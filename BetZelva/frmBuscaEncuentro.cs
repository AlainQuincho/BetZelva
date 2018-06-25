using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace BetZelva
{
    public partial class frmBuscaEncuentro : Form
    {
        #region VARIABLES GLOBALES
        public int idConfiguracion = 0;
        public string cEquipoLocal = "";
        public string cEquipoVisita = "";
        public string cPagaLocal = "";
        public string cPagaVisita = "";
        public string cPagaEmpate = "";
        public DateTime dFechaEncuentro;
        public string cHraEncuentro="";
        #endregion
        #region MÉTODOS
        public frmBuscaEncuentro()
        {
            InitializeComponent();
        }
        private void AsignaVariable()
        {
            if (dtgEncuentros.RowCount > 0)
            {
                idConfiguracion = Convert.ToInt32(dtgEncuentros.Rows[dtgEncuentros.SelectedCells[0].RowIndex].Cells["idConfiguraciones"].Value);
                cEquipoLocal = Convert.ToString(dtgEncuentros.Rows[dtgEncuentros.SelectedCells[0].RowIndex].Cells["cEquipoLocal"].Value); ;
                cEquipoVisita = Convert.ToString(dtgEncuentros.Rows[dtgEncuentros.SelectedCells[0].RowIndex].Cells["cEquipoVisita"].Value); ;
                cPagaLocal = Convert.ToString(dtgEncuentros.Rows[dtgEncuentros.SelectedCells[0].RowIndex].Cells["nMultiplicadorLocal"].Value); ;
                cPagaVisita = Convert.ToString(dtgEncuentros.Rows[dtgEncuentros.SelectedCells[0].RowIndex].Cells["nMultiplicadorVisita"].Value); ;
                cPagaEmpate = Convert.ToString(dtgEncuentros.Rows[dtgEncuentros.SelectedCells[0].RowIndex].Cells["nMultiplicadorEmpate"].Value); ;
                dFechaEncuentro = Convert.ToDateTime(dtgEncuentros.Rows[dtgEncuentros.SelectedCells[0].RowIndex].Cells["dFechaEncuentro"].Value); ;
                cHraEncuentro = Convert.ToString(dtgEncuentros.Rows[dtgEncuentros.SelectedCells[0].RowIndex].Cells["tHoraEncuentro"].Value);
            }
        }
        private void CargarEncuentro()
        {
            DataTable dtConfig = new clsConfiguraciones().ADConsultaConfiguraciones();
            dtgEncuentros.DataSource = dtConfig;
            FormatoGrid();
        }
        private void FormatoGrid()
        {
            foreach (DataGridViewColumn Col in dtgEncuentros.Columns)
            {
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;
                Col.ReadOnly = true;
                Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dtgEncuentros.EnableHeadersVisualStyles = false;
            dtgEncuentros.Columns["idConfiguraciones"].HeaderText = "Cod.";
            dtgEncuentros.Columns["idEquipoLocal"].Visible = false;
            dtgEncuentros.Columns["cEquipoLocal"].HeaderText = "Local";
            dtgEncuentros.Columns["idEquipoVisita"].Visible = false;
            dtgEncuentros.Columns["cEquipoVisita"].HeaderText = "Visitante";
            dtgEncuentros.Columns["nMultiplicadorLocal"].HeaderText = "L";
            dtgEncuentros.Columns["nMultiplicadorVisita"].HeaderText = "V";
            dtgEncuentros.Columns["nMultiplicadorEmpate"].HeaderText = "E";
            dtgEncuentros.Columns["dFechaEncuentro"].HeaderText = "Fecha";
            dtgEncuentros.Columns["tHoraEncuentro"].HeaderText = "Hora";
        }
        #endregion

        #region EVENTOS
        private void btnSalir_Click(object sender, EventArgs e)
        {
            idConfiguracion = 0;
            Dispose();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AsignaVariable();
            Dispose();
        }
        private void frmBuscaEncuentro_Load(object sender, EventArgs e)
        {
            CargarEncuentro();
            if (dtgEncuentros.RowCount==0)
            {
                btnAceptar.Enabled = false;
            }
        }

        #endregion

        #region Arrastre
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
