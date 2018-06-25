using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Entidades;
using AccesoDatos;
using MessageBoxExample;
using Microsoft.Reporting.WinForms;
using Reporteaddor;


namespace BetZelva
{
    public partial class frmRetiroCaja : Form
    {
        private decimal MontoDisponible = 0;
        MetodosReporte _Reportes = new MetodosReporte();
        public frmRetiroCaja()
        {
            InitializeComponent();
        }

        private void frmRetiroCaja_Load(object sender, EventArgs e)
        {
            string cRpta = ValidarInicioOpeCaj();
            bool Rpta = false;
            switch (cRpta) // Si Estado es: F--> Falta Iniciar, A--> Caja Abierta, C--> Caja Cerrada  
            {
                case "F":
                    MyMessageBox.Show("El Usuario NO inició operaciones", "Validar Inicio de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Rpta = true;
                    return;
                case "A":
                    //   MyMessageBox.Show("El Usuario ya Inicio sus Operaciones", "Validar Inicio de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // this.Dispose();
                    //   return;
                    break;
                case "C":
                    MyMessageBox.Show("El Usuario ya Cerro sus Operaciones", "Validar Cierre de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Rpta = true;
                    return;
                default:
                    MyMessageBox.Show(cRpta, "Error al Validar Estado de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Rpta = true;
                    return;
            }
            if(Rpta)
            {
                this.Close();
            }

            MontoDisponible = new AdRetiroCaja().SaldoDisponible(VarGlobal.dFechaSys, VarGlobal.SysUser.idUsuario);
            txtSaldoDisponible.Text = MontoDisponible.ToString();
            txtNombreUsuario.Text = VarGlobal.SysUser.cNombre + " " + VarGlobal.SysUser.cApellidos;
            txtDNI.Text = VarGlobal.SysUser.cDNI;
            txtPerfil.Text = (VarGlobal.SysUser.idPerfil == 1)?"ADMINISTRADOR":"EMPLEADO";
            txtMontoRetiro.Text = "0.00";

            //grbSaldoDisp.Enabled = false;
            txtSaldoDisponible.Enabled = false;
            //grbDetalle.Enabled = false;
            txtNombreUsuario.Enabled = false;
            txtDNI.Enabled = false;
            txtPerfil.Enabled = false;
            
            label2.Enabled = true;
            grbMonto.Enabled = true;

            txtConcepto.Enabled = false;


            //this.Reporte.RefreshReport();
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
                MyMessageBox.Show("Debe ingresar un monto de retiro de caja", "Retiro de caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToDecimal(txtMontoRetiro.Text) <= 0)
            {
                MyMessageBox.Show("El monto del retiro debe ser mayor a cero", "Retiro de caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            decimal nMontoRetiro = Convert.ToDecimal(txtMontoRetiro.Text);
            if (nMontoRetiro > MontoDisponible)
            {
                MyMessageBox.Show("El monto de retiro no puede ser mayor al monto disponible en caja", "Retiro de caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int idApuesta = 0;
            DateTime dFechaReg = VarGlobal.dFechaSys;
            decimal nMontoOperacion = nMontoRetiro;
            int idUsuarioReg = VarGlobal.SysUser.idUsuario;

            // Variables
            int idConcepto      = 3;
            int idTipoOperacion = 2;
            int idRecibo        = 0;
            int idKardex        = 0;

            string Msj = new AdRetiroCaja().GuardaRetiroCaja(idApuesta, dFechaReg, nMontoOperacion, idUsuarioReg, idConcepto, ref idRecibo, ref idKardex);

            MyMessageBox.Show(Msj,"Retiro de caja",MessageBoxButtons.OK, MessageBoxIcon.Information);


            // impresion del boucher 
            DataTable TB = new AdReportes().CobroApuesta(idApuesta, idKardex);
            if (TB.Rows.Count > 0)
            {
                List<ReportDataSource> dtslist = new List<ReportDataSource>();
                List<ReportParameter> paramlist = new List<ReportParameter>();

                dtslist.Clear();
                paramlist.Clear();

                dtslist.Add(new ReportDataSource("dtsImpresion", TB));

                paramlist.Add(new ReportParameter("idApuesta", idApuesta.ToString(), false));
                paramlist.Add(new ReportParameter("idKardex", idKardex.ToString(), false));
                paramlist.Add(new ReportParameter("idTipoOperacion", idTipoOperacion.ToString(), false));
                paramlist.Add(new ReportParameter("idConcepto", idConcepto.ToString(), false));

                string NombreReporte = "RptRetirosCaja.rdlc";
                new FrmReportador(dtslist, NombreReporte, paramlist).ShowDialog();
            }
            MontoDisponible = new AdRetiroCaja().SaldoDisponible(VarGlobal.dFechaSys, VarGlobal.SysUser.idUsuario);
            txtMontoRetiro.Text = "0.00";
            txtSaldoDisponible.Text = MontoDisponible.ToString();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            int idApuesta = 1;
            int idKardex = 1;
            int idTipoOperacion = 1;
            int idConcepto = 1;

            DataTable TB = new AdReportes().CobroApuesta(1,1);
            if(TB.Rows.Count > 0)
            {
                List<ReportDataSource> dtslist = new List<ReportDataSource>();
                List<ReportParameter> paramlist = new List<ReportParameter>();

                dtslist.Clear();
                paramlist.Clear();

                dtslist.Add(new ReportDataSource("dtsImpresion", TB));

                paramlist.Add(new ReportParameter("idApuesta", idApuesta.ToString(), false));
                paramlist.Add(new ReportParameter("idKardex", idKardex.ToString(), false));
                paramlist.Add(new ReportParameter("idTipoOperacion", idTipoOperacion.ToString(), false));
                paramlist.Add(new ReportParameter("idConcepto", idConcepto.ToString(), false));

                string NombreReporte = "RptRetirosCaja.rdlc";
                new FrmReportador(dtslist, NombreReporte, paramlist).ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string ValidarInicioOpeCaj()
        {
            string cEstCie = new clsInicioCuadreOperaciones().ValIniOpeCaja(DateTime.Today, clsVarGlobal.User.idUsuario).Rows[0][0].ToString();
            return cEstCie;
        }
    }
}
