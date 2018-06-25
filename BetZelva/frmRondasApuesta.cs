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
    public partial class frmRondasApuesta : Form
    {
        AdMantenimientoRonda _Ronda = new AdMantenimientoRonda();
        List<ConfiguraApuesta> _ListaConfiguracion = new List<ConfiguraApuesta>();
        string _Accion = "";
        public frmRondasApuesta()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void frmRondasApuesta_Load(object sender, EventArgs e)
        {
            CargaEquipos();
            cboLocal.SelectedIndex = -1;
            cboVisita.SelectedIndex = -1;
        }
        private void CargaEquipos()
        {
            cboLocal.DataSource = _Ronda.ListaEquipos();
            cboLocal.DisplayMember = "NombreEquipo";
            cboLocal.ValueMember = "CodEquipo";

            cboLocal.AutoCompleteCustomSource = LoadAutoComplete();
            cboLocal.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboLocal.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cboVisita.DataSource = _Ronda.ListaEquipos();
            cboVisita.DisplayMember = "NombreEquipo";
            cboVisita.ValueMember = "CodEquipo";

            cboVisita.AutoCompleteCustomSource = LoadAutoComplete();
            cboVisita.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboVisita.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void cboVisita_SelectedIndexChanged(object sender, EventArgs e)
        {
            //new AdVarGlobal().AdCargaVariables();
            //int idUsuario =  VarGlobal.SysUser.idUsuario;  
        }
        public AutoCompleteStringCollection LoadAutoComplete()
        {
            var dt = _Ronda.ListaEquipos();

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (var row in dt)
            {
                stringCol.Add(row.NombreEquipo);
            }

            return stringCol;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(cboLocal.SelectedText))
            {
                MyMessageBox.Show("Debe seleccionar un equipo local", "Ronde apuestas", MessageBoxButtons.OK);
                return;
            }
            if(string.IsNullOrEmpty(cboVisita.SelectedText))
            {
                MyMessageBox.Show("Debe seleccionar un equipo visita", "Ronde apuestas", MessageBoxButtons.OK);
                return;
            }

            #region Agregar
            if (!_Accion.Equals("N"))
            {
                _ListaConfiguracion.Clear();
            }
            _ListaConfiguracion.Add(new ConfiguraApuesta
            {
                idConfiguraciones    = 0,
                idEquipoLocal        = (int)cboLocal.SelectedValue,
                cEquipoLocal         = cboLocal.SelectedText,
                idEquipoVisita       = (int)cboVisita.SelectedValue,
                cEquipoVisita        = cboVisita.SelectedText,
                nMultiplicadorLocal  = Convert.ToDecimal(txtMultiLocal.Text),
                nMultiplicadorVisita = Convert.ToDecimal(txtMultiVisita.Text),
                nMultiplicadorEmpate = Convert.ToDecimal(txtMultiEmpate.Text),
                dFechaEncuentro      = Convert.ToDateTime(dtpFechaEncuentro.Value),
                tHoraEncuentro       = txtHora.Text + ":" + txtMinuto.Text,
                cEstado              = "Vigente",
                lVigente             = true,
                cTorneo              = txtTorneo.Text
            });

            dtgDetalle.DataSource = _ListaConfiguracion.ToList();
            FormatoGrid();
            #endregion

            LimpiaControles();
            HabilitaControles(true);
            chcActivo.Enabled = true;
            dtgDetalle.Enabled = true;
            chcActivo.Checked = false;

        }
        private void FormatoGrid()
        {
            foreach(DataGridViewColumn Column in dtgDetalle.Columns)
            {
                Column.Visible = false;
            }

            dtgDetalle.Columns["idConfiguraciones"].Visible = true;
            dtgDetalle.Columns["cTorneo"].Visible = true;
            dtgDetalle.Columns["cEquipoLocal"].Visible = true;
            dtgDetalle.Columns["cEquipoVisita"].Visible = true;
            dtgDetalle.Columns["nMultiplicadorLocal"].Visible = true;
            dtgDetalle.Columns["nMultiplicadorVisita"].Visible = true;
            dtgDetalle.Columns["nMultiplicadorEmpate"].Visible = true;
            dtgDetalle.Columns["dFechaEncuentro"].Visible = true;
            dtgDetalle.Columns["tHoraEncuentro"].Visible = true;
            dtgDetalle.Columns["lVigente"].Visible = true;

            dtgDetalle.Columns["idConfiguraciones"].HeaderText = "Cod";
            dtgDetalle.Columns["cTorneo"].HeaderText = "Torneo";
            dtgDetalle.Columns["cEquipoLocal"].HeaderText = "Local";
            dtgDetalle.Columns["cEquipoVisita"].HeaderText = "Visita";
            dtgDetalle.Columns["nMultiplicadorLocal"].HeaderText = "Mul. Local";
            dtgDetalle.Columns["nMultiplicadorVisita"].HeaderText = "Mul. Visita";
            dtgDetalle.Columns["nMultiplicadorEmpate"].HeaderText = "Mul. Empate";
            dtgDetalle.Columns["dFechaEncuentro"].HeaderText = "Fecha";
            dtgDetalle.Columns["tHoraEncuentro"].HeaderText = "Hora";
            dtgDetalle.Columns["lVigente"].HeaderText = "Estado";

            //dtgDetalle.Columns["idConfiguraciones"].Width = 0;
            //dtgDetalle.Columns["cTorneo"].Width = 0;
            //dtgDetalle.Columns["cEquipoLocal"].Width = 0;
            //dtgDetalle.Columns["cEquipoVisita"].Width = 0;
            //dtgDetalle.Columns["nMultiplicadorLocal"].Width = 0;
            //dtgDetalle.Columns["nMultiplicadorVisita"].Width = 0;
            //dtgDetalle.Columns["nMultiplicadorEmpate"].Width = 0;
            //dtgDetalle.Columns["dFechaEncuentro"].Width = 0;
            //dtgDetalle.Columns["tHoraEncuentro"].Width = 0;
            //dtgDetalle.Columns["cEstado"].Width = 0;


            dtgDetalle.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int index = dtgDetalle.CurrentRow.Index;
            //int idRonda
            // TODO: CONTINUA DE DESDE AQUI
        }
        private void LimpiaControles()
        {
            cboLocal.SelectedIndex = -1;
            cboVisita.SelectedIndex = -1;
            dtpFechaEncuentro.Value = DateTime.Now.Date;
            txtHora.Clear();
            txtMinuto.Clear();
            txtMultiLocal.Clear();
            txtMultiVisita.Clear();
            txtMultiEmpate.Clear();
            txtTorneo.Clear();
        } 

        private void HabilitaControles(bool Val)
        {
            cboLocal.Enabled            = Val;
            cboVisita.Enabled           = Val;
            dtpFechaEncuentro.Enabled   = Val;
            txtHora.Enabled             = Val;
            txtMinuto.Enabled           = Val;
            txtMultiLocal.Enabled       = Val;
            txtMultiVisita.Enabled      = Val;
            txtMultiEmpate.Enabled      = Val;
            txtTorneo.Enabled           = Val;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _Accion = "N";
            LimpiaControles();
            HabilitaControles(true);
            dtgDetalle.Enabled = false;
            chcActivo.Enabled  = false;
            chcActivo.Checked  = false;
        }

        private void chcActivo_CheckedChanged(object sender, EventArgs e)
        {
            _Accion = "";
            bool lEstado = chcActivo.Checked;
            if (chcActivo.Checked)
            {
                _ListaConfiguracion = _ListaConfiguracion.Where(x => x.lVigente == lEstado).ToList();
            }else
            {
                _ListaConfiguracion = _Ronda.ListaConfiguraciones();
            }
           
            dtgDetalle.DataSource = _ListaConfiguracion;
            FormatoGrid();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _Accion = "";
            LimpiaControles();
            HabilitaControles(false);
            dtgDetalle.Enabled = true;
            chcActivo.Enabled = true;
            chcActivo.Checked = false;
        }

        private void CargarConfiguracion()
        {
            _ListaConfiguracion = _Ronda.ListaConfiguraciones();
            dtgDetalle.DataSource = _ListaConfiguracion;
            FormatoGrid();

        }

        private void button1_Click(object sender, EventArgs e) // editar
        {
            _Accion = "A";
            HabilitaControles(true);
            dtgDetalle.Enabled = false;
            chcActivo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //logica de guardado
            if (ValidaGuardar())
                return;
            DataTable TablaApuesta = ConvertToDataTable<ConfiguraApuesta>(_ListaConfiguracion);

            DataSet ds = new DataSet("dsConfiguracionApuesta");
            ds.Tables.Add(TablaApuesta);
            string XML = ds.GetXml();

            int idUsuario = VarGlobal.SysUser.idUsuario;
            DateTime dFechaSys = VarGlobal.dFechaSys;
            string Rtpa = "";
            if (_Accion.Equals("N"))
            {
                Rtpa = _Ronda.GuardaNuevaConfiguracion(XML, idUsuario, dFechaSys);
            }
            else 
            if (_Accion.Equals("A"))
            {
                Rtpa = _Ronda.ActualizaConfiguracion(XML, idUsuario, dFechaSys);
            }

            MyMessageBox.Show(Rtpa, "Guarda configuracion de apuestas", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            _Accion = "";
            HabilitaControles(false);
            LimpiaControles();
            dtgDetalle.Enabled = true;
            chcActivo.Enabled = true;
            chcActivo.Checked = false;
            CargarConfiguracion();

        }

        private bool ValidaGuardar()
        {
            string MSJ = "";
            if(_ListaConfiguracion.Count <= 0)
            {
                MSJ = "No existen datos para guardar";
                return true;
            }

            if (!MSJ.Equals(""))
            {
                MyMessageBox.Show(MSJ, "Guardar configuración de apuestas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;

        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
