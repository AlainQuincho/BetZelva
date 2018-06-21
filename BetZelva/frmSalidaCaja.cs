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
    public partial class frmSalidaCaja : Form
    {
        AdRetiroCaja _Retiro = new AdRetiroCaja();
        public frmSalidaCaja()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCodRecibo.Text))
            {
                int idCod = Convert.ToInt32(txtCodRecibo.Text);
                var Result = _Retiro.ResultadoBusqueda(idCod);

                HabilitaControles(false);

                txtNombre.Text = Result.cNombres;
                txtApellido.Text = Result.cApellidos;
                txtDNI.Text = Result.cDocumento;
                txtFechaReg.Text = Result.dFechaReg;
                txtFechaCierre.Text = Result.dFechaCierre;

                lblMontoApostado.Text = lblMontoApostado.Text + " " + Result.nMontoApuesta.ToString();
                lblEquipoLocal.Text = Result.EquipoLocal;
                lblEquipoVisita.Text = Result.EquipoVisita;
                lblGolesLocal.Text = Result.nAnotacionesLocal.ToString();
                lblGolesVisita.Text = Result.nAnotacionesVisita.ToString();

                txtMontoRetiro.Text = Result.nMontoAPagar.ToString();

                if(Convert.ToDecimal(Result.nMontoAPagar)==0 || string.IsNullOrEmpty(Result.nMontoAPagar.ToString()))
                {
                    btnGrabar.Enabled = false;
                    btnCancelar.Enabled = true;
                    return;
                }
                if(!Result.cMensaje.Equals("OK"))
                {
                    MessageBox.Show(Result.cMensaje, "Retiro de caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGrabar.Enabled = false;
                    btnCancelar.Enabled = true;
                    return;
                }
            }
        }

        private void txtCodRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void HabilitaControles(bool val)
        {
            grbDatosCliente.Enabled = false;
            grbDatosApuesta.Enabled = false;
            grbBusqueda.Enabled = val;

            txtMontoRetiro.Enabled = false;
        }

        private void LimpiaControles()
        {
            txtCodRecibo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtFechaReg.Clear();
            txtFechaCierre.Clear();

            lblMontoApostado.Text = "Monto Apostado";
            lblEquipoLocal.Text = "Equipo Local";
            lblEquipoVisita.Text = "Equipo Visita";
            lblGolesLocal.Text = "Goles Local";
            lblGolesVisita.Text = "Goles Visita";

            txtMontoRetiro.Text = "0.00";
        }

        private void frmSalidaCaja_Load(object sender, EventArgs e)
        {
            LimpiaControles();
            HabilitaControles(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiaControles();
            HabilitaControles(true);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int idApuesta      = Convert.ToInt32(txtCodRecibo.Text);
            DateTime dFechaReg = VarGlobal.dFechaSys;
            decimal nMontoOperacion = Convert.ToDecimal(txtMontoRetiro.Text);
            int idUsuarioReg = VarGlobal.SysUser.idUsuario;
            int idConcepto = 2;
            int idRecibo = 0;
            int idKardex = 0;

            string Msj = _Retiro.GuardaRetiroCaja(idApuesta, dFechaReg, nMontoOperacion, idUsuarioReg, idConcepto, ref idRecibo, ref idKardex);
            MessageBox.Show(Msj, "Retiro de caja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HabilitaControles(false);
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void grbBusqueda_Enter(object sender, EventArgs e)
        {

        }
    }
}
