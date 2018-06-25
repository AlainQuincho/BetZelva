using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using AccesoDatos;
using MessageBoxExample;


namespace BetZelva
{
    public partial class frmCierreApuesta : Form
    {
        private List<ResultadoEquipos> _ListaResultados ;
        AdResultadoEquipos _Resultado = new AdResultadoEquipos();
        public frmCierreApuesta()
        {
            InitializeComponent();
        }

        private void frmCierreApuesta_Load(object sender, EventArgs e)
        {
            ListarEncuentros();
            HabilitaControles(false);
            LimpiaControles();

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;

            foreach (DataGridViewColumn column in dtgEncuentros.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void BuscaEncuentros()
        {
            string CodEncuentro = "";
            string dFechaHoraEncuentro = "";
            string NombreLocal = "";
            string NombreVisita = "";
            string PagoLocal = "";
            string PagoEmpate = "";
            string PagoVisita = "";
            string AnotacionLocal = "";
            string AnotacionVisita = "";
            int idConfiguraciones;

            frmBuscaEncuentro frmBusca = new frmBuscaEncuentro();
            frmBusca.ShowDialog();
            idConfiguraciones = frmBusca.idConfiguracion;
            if (idConfiguraciones != 0)
            {
                CodEncuentro        = frmBusca.idConfiguracion.ToString();
                dFechaHoraEncuentro = frmBusca.dFechaEncuentro.ToString("dd/MM/yyyy") + "  " + frmBusca.cHraEncuentro;
                NombreLocal         = frmBusca.cEquipoLocal.ToUpper().Trim();
                NombreVisita        = frmBusca.cEquipoVisita.ToUpper().Trim();
                PagoLocal           = frmBusca.cPagaLocal;
                PagoEmpate          = frmBusca.cPagaEmpate;
                PagoVisita          = frmBusca.cPagaVisita;

                txtCod.Text = CodEncuentro;
                txtFecha.Text = dFechaHoraEncuentro;
                txtLocal.Text = NombreLocal;
                txtVisita.Text = NombreVisita;
                MultiLocal.Text = "(" + PagoLocal.ToString() + ")";
                MultiVisita.Text = "(" + PagoVisita.ToString() + ")";
                MultiEmpate.Text = "(" + PagoEmpate.ToString() + ")";

                btnGuardar.Enabled  = true;
                btnCancelar.Enabled = true;
                btnEditar.Enabled   = true;

                grbBusqueda.Enabled = true;
                
            }
            else
            {
                return;
            }
            // Asigna valores
            

        }
        private void ListarEncuentros()
        {
            _ListaResultados = _Resultado.ListaResultados();
            dtgEncuentros.DataSource = _ListaResultados.ToList();
            FormatoGrid();
        }

        private void FormatoGrid()
        {
            dtgEncuentros.ReadOnly = true;
            foreach (DataGridViewColumn Column in dtgEncuentros.Columns)
            {
                Column.Visible = false;
                Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dtgEncuentros.Columns["cTorneo"].Visible = true;
            dtgEncuentros.Columns["cEquipoLocal"].Visible = true;
            dtgEncuentros.Columns["cEquipoVisita"].Visible = true;
            dtgEncuentros.Columns["nMultiplicadorLocal"].Visible = true;
            dtgEncuentros.Columns["nMultiplicadorVisita"].Visible = true;
            dtgEncuentros.Columns["nMultiplicadorEmpate"].Visible = true;

            dtgEncuentros.Columns["cTorneo"].HeaderText = "Torneo";
            dtgEncuentros.Columns["cEquipoLocal"].HeaderText = "Local";
            dtgEncuentros.Columns["cEquipoVisita"].HeaderText = "Visita";
            dtgEncuentros.Columns["nMultiplicadorLocal"].HeaderText = "ML";
            dtgEncuentros.Columns["nMultiplicadorVisita"].HeaderText = "MV";
            dtgEncuentros.Columns["nMultiplicadorEmpate"].HeaderText = "ME";

            dtgEncuentros.Columns["cTorneo"].DisplayIndex = 0;
            dtgEncuentros.Columns["cEquipoLocal"].DisplayIndex = 1;
            dtgEncuentros.Columns["cEquipoVisita"].DisplayIndex = 2;
            dtgEncuentros.Columns["nMultiplicadorLocal"].DisplayIndex = 3;
            dtgEncuentros.Columns["nMultiplicadorVisita"].DisplayIndex = 4;
            dtgEncuentros.Columns["nMultiplicadorEmpate"].DisplayIndex = 5;

            dtgEncuentros.Columns["cTorneo"].Width = 150;
            //dtgEncuentros.Columns["cEquipoLocal"].Width = 80;
            //dtgEncuentros.Columns["cEquipoVisita"].Width = 80;
            //dtgEncuentros.Columns["nMultiplicadorLocal"].Width = 0;
            //dtgEncuentros.Columns["nMultiplicadorVisita"].Width = 0;
            //dtgEncuentros.Columns["nMultiplicadorEmpate"].Width = 0;

            dtgEncuentros.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscaEncuentros();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idConfiguraciones = Convert.ToInt32(txtCod.Text);
            int nAnotacionLocal   = Convert.ToInt32(txtGolesLocal.Text);
            int nAnotacionVisita  = Convert.ToInt32(txtGolesVisita.Text) ;
            int idUsuario         = VarGlobal.SysUser.idUsuario;
            DateTime dFechaReg    = VarGlobal.dFechaSys;

            string Rpta = _Resultado.GuardardarResultados(idConfiguraciones, nAnotacionLocal, nAnotacionVisita,
                                                          idUsuario, dFechaReg);

            MyMessageBox.Show(Rpta, "Registro de resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HabilitaControles(false);
            LimpiaControles();

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            ListarEncuentros();
        }

        private void HabilitaControles(bool val)
        {
            //grbBusqueda.Enabled = !val;
            HabilitarControlesBusqueda(!val);
            //grbDetalle.Enabled = false;
            HabilitarControlesDetalle(false);
            //grbGrid.Enabled = !val;
            HabilitarControlesGrid(!val);
            //grbResultado.Enabled = val;
            HabilitarControlesResultado(val);
        }

        private void HabilitarControlesBusqueda(bool val)
        {
            btnBuscar.Enabled = val;
        }
        private void HabilitarControlesDetalle(bool val)
        {
            txtCod.Enabled = val;
            txtFecha.Enabled = val;
            txtLocal.Enabled = val;
            txtVisita.Enabled = val;
        }
        private void HabilitarControlesGrid(bool val)
        {
            dtgEncuentros.Enabled = val;
        }
        private void HabilitarControlesResultado(bool val)
        {
            txtGolesLocal.Enabled = val;
            txtGolesVisita.Enabled = val;
        }



        private void LimpiaControles()
        {
            txtGolesLocal.Text = "0";
            txtGolesVisita.Text = "0";
            MultiLocal.Text = "L";
            MultiVisita.Text = "V";
            MultiEmpate.Text = "E";

            txtCod.Clear();
            txtFecha.Clear();
            txtLocal.Clear();
            txtVisita.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiaControles();
            HabilitaControles(false);
            ListarEncuentros();

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           HabilitaControles(true);

            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void dtgEncuentros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idColumna = e.ColumnIndex;
            int idFila = e.RowIndex;

            if(idFila >= 0)
            {
                HabilitaControles(false);
                txtGolesLocal.Text  = dtgEncuentros.Rows[idFila].Cells["nAnotacionesLocal"].Value.ToString();
                txtGolesVisita.Text = dtgEncuentros.Rows[idFila].Cells["nAnotacionesVisita"].Value.ToString();
                MultiLocal.Text  = "(" + dtgEncuentros.Rows[idFila].Cells["nMultiplicadorLocal"].Value.ToString() + ")";
                MultiVisita.Text = "(" + dtgEncuentros.Rows[idFila].Cells["nMultiplicadorVisita"].Value.ToString() + ")";
                MultiEmpate.Text = "(" + dtgEncuentros.Rows[idFila].Cells["nMultiplicadorEmpate"].Value.ToString() + ")";
                txtCod.Text = dtgEncuentros.Rows[idFila].Cells["idResultado"].Value.ToString();
                txtFecha.Text = dtgEncuentros.Rows[idFila].Cells["dFechaHora"].Value.ToString();
                txtLocal.Text = dtgEncuentros.Rows[idFila].Cells["cEquipoLocal"].Value.ToString();
                txtVisita.Text = dtgEncuentros.Rows[idFila].Cells["cEquipoVisita"].Value.ToString();
            }
            
            btnCancelar.Enabled = true;
            btnEditar.Enabled = true;
            btnGuardar.Enabled = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
