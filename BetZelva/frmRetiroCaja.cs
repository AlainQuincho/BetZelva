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
    public partial class frmRetiroCaja : Form
    {
        private decimal MontoDisponible = 0;
        public frmRetiroCaja()
        {
            InitializeComponent();
        }

        private void frmRetiroCaja_Load(object sender, EventArgs e)
        {
            MontoDisponible = new AdRetiroCaja().SaldoDisponible(VarGlobal.dFechaSys, VarGlobal.SysUser.idUsuario);
            txtSaldoDisponible.Text = MontoDisponible.ToString();
            txtNombreUsuario.Text = VarGlobal.SysUser.cNombre + " " + VarGlobal.SysUser.cApellidos;
            txtDNI.Text = VarGlobal.SysUser.cDNI;
            txtPerfil.Text = (VarGlobal.SysUser.idPerfil == 1)?"ADMINISTRADOR":"EMPLEADO";
            txtMontoRetiro.Text = "0.00";

            grbSaldoDisp.Enabled = false;
            grbDetalle.Enabled = false;
            grbMonto.Enabled = true;

            txtConcepto.Enabled = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMontoRetiro.Text = "0.00";
            MontoDisponible = new AdRetiroCaja().SaldoDisponible(VarGlobal.dFechaSys, VarGlobal.SysUser.idUsuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMontoRetiro.Text))
            {
                MessageBox.Show("Debe ingresar un monto de retiro de caja", "Retiro de caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if( Convert.ToDecimal(txtMontoRetiro.Text) <= 0 )
            {
                MessageBox.Show("El monto del retiro debe ser mayor a cero", "Retiro de caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            decimal nMontoRetiro = Convert.ToDecimal(txtMontoRetiro.Text);
            if (nMontoRetiro > MontoDisponible)
            {
                MessageBox.Show("El monto de retiro no puede ser mayor al monto disponible en caja", "Retiro de caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int idApuesta = 0;
            DateTime dFechaReg = VarGlobal.dFechaSys;
            decimal nMontoOperacion = nMontoRetiro;
            int idUsuarioReg = VarGlobal.SysUser.idUsuario;
            int idConcepto = 3;

            int idRecibo = 0;
            int idKardex = 0;

            string Msj = new AdRetiroCaja().GuardaRetiroCaja(idApuesta, dFechaReg, nMontoOperacion, idUsuarioReg, idConcepto, ref idRecibo, ref idKardex);

            MessageBox.Show(Msj,"Retiro de caja",MessageBoxButtons.OK, MessageBoxIcon.Information);

            MontoDisponible = new AdRetiroCaja().SaldoDisponible(VarGlobal.dFechaSys, VarGlobal.SysUser.idUsuario);
            txtMontoRetiro.Text = "0.00";

        }
    }
}
