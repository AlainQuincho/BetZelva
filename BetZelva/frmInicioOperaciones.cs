using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace BetZelva
{
    public partial class frmInicioOperaciones : Form
    {
        #region Variables Globales

        string mRespValExis = "";
        private int pidTipResCaj = 0;
        private int pnCantidad = 0;
        private int pidUsuario = 0;
        string cResp;
        string cUsuario = "";

        #endregion
        public frmInicioOperaciones()
        {
            InitializeComponent();
        }

        private void frmInicioOperaciones_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = true;
            VarGlobal.SysUser  = new Usuario();
            VarGlobal.SysUser.idUsuario = 1;
            pidUsuario = VarGlobal.SysUser.idUsuario;
            cUsuario = VarGlobal.SysUser.cNombre;
            DatosUsuario();
            if (pidUsuario==0)
            {
                MessageBox.Show("No existe usuario", "Validar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                return;
            }

                DataTable tbSaldos = new clsInicioCuadreOperaciones().SaldoIniOpe( DateTime.Today, 1);
                if (tbSaldos.Rows.Count > 0)
                {
                    txtInicioSoles.Text = tbSaldos.Rows[0]["nMontoCieSol"].ToString();
                    txtInicioDolares.Text = tbSaldos.Rows[1]["nMontoCieDol"].ToString();
                }
                else
                {
                txtInicioSoles.Text = "0.00";
                txtInicioDolares.Text = "0.00";
                }
            //===========================================================
            //--Validar Inicio de Operaciones
            //===========================================================
            string cRpta = ValidarInicioOpeCaj();
            switch (cRpta) // Si Estado es: F--> Falta Iniciar, A--> Caja Abierta, C--> Caja Cerrada  
            {
                case "F":
                    break;
                case "A":
                    MessageBox.Show("El Usuario ya Inicio sus Operaciones", "Validar Inicio de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    return;
                case "C":
                    MessageBox.Show("El Usuario ya Cerro sus Operaciones", "Validar Cierre de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    return;
                default:
                    MessageBox.Show(cRpta, "Error al Validar Estado de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Dispose();
                    return;
            }
        }
        private void DatosUsuario()
        {
            dtpFechaInicio.Value = DateTime.Today;
            txtUsuario.Text = cUsuario;
          
            DataTable DatosCli = new clsInicioCuadreOperaciones().ListaUsuario(pidUsuario, "D");
            if (DatosCli.Rows.Count > 0)
            {
                txtUsuario.Text = DatosCli.Rows[0]["cNombre"].ToString();
            }
            else
            {
                txtUsuario.Text = "";
            }
        }
        private string ValidarInicioOpeCaj()
        {
            string cEstCie = new clsInicioCuadreOperaciones().ValIniOpeCaja(DateTime.Today, pidUsuario).Rows[0][0].ToString();
            return cEstCie;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var Msg = MessageBox.Show("Esta seguro de Realizar el Inicio de Operaciones?...", "Inicio de Operaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Msg == DialogResult.Yes)
            {
                string Rpta;
                double nMonSol = Convert.ToDouble(txtInicioSoles.Text);
                double nMonDol = Convert.ToDouble(txtInicioDolares.Text);
                Rpta = new clsInicioCuadreOperaciones().GuardaIniOpe(DateTime.Today, pidUsuario, nMonSol, nMonDol);
                if (Rpta == "OK")
                {
                    MessageBox.Show("El Inicio de Operaciones se Realizó Correctamente...", "Inicio de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGrabar.Enabled = false;
                }
                else
                {
                    MessageBox.Show(Rpta, "Inicio de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
