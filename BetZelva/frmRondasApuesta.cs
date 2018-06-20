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

namespace BetZelva
{
    public partial class frmRondasApuesta : Form
    {
        AdMantenimientoRonda _Ronda = new AdMantenimientoRonda();
        List<ConfiguraApuesta> _ListaConfiguracion = new List<ConfiguraApuesta>();
        string Accion = "";
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
            #region Agregar
            if (!Accion.Equals("Agregar"))
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
            dtgDetalle.Columns["cEstado"].Visible = true;

            dtgDetalle.Columns["idConfiguraciones"].HeaderText = "Cod";
            dtgDetalle.Columns["cTorneo"].HeaderText = "Torneo";
            dtgDetalle.Columns["cEquipoLocal"].HeaderText = "Local";
            dtgDetalle.Columns["cEquipoVisita"].HeaderText = "Visita";
            dtgDetalle.Columns["nMultiplicadorLocal"].HeaderText = "Mul. Local";
            dtgDetalle.Columns["nMultiplicadorVisita"].HeaderText = "Mul. Visita";
            dtgDetalle.Columns["nMultiplicadorEmpate"].HeaderText = "Mul. Empate";
            dtgDetalle.Columns["dFechaEncuentro"].HeaderText = "Fecha";
            dtgDetalle.Columns["tHoraEncuentro"].HeaderText = "Hora";
            dtgDetalle.Columns["cEstado"].HeaderText = "Estado";

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
            LimpiaControles();
            HabilitaControles(true);
            dtgDetalle.Enabled = false;
            chcActivo.Enabled  = false;
            chcActivo.Checked  = false;
        }

        private void chcActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
