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
    public partial class frmCuadreCierreOpe : Form
    {
        #region VARIABLES
        int idUsuario = 1;// VarGlobal.SysUser.idUsuario;

        #region CORTE FRACCIONARIO
        //================================================
        //--Declarar variables Publicas
        //================================================
        public DataTable tbMonSol;
        public DataTable tbBillSol;
        public DataTable tbBillDol;

        #endregion
        #region CUADRE CAJA
        public DataTable tbIngSol;
        public DataTable tbEgrSol;
        public DataTable tbIngDol;
        public DataTable tbEgrDol;
        #endregion
        #endregion
        #region EVENTOS GENERALES
        private void frmCuadreCierreOpe_Load(object sender, EventArgs e)
        {
            DatosUsuario();

            //===========================================================================================
            //--Validar Inicio de Operaciones
            //===========================================================================================
            string cRpta = ValidarInicioOpeCaj();
            switch (cRpta) // Si Estado es: F--> Falta Iniciar, A--> Caja Abierta, C--> Caja Cerrada  
            {
                case "F":
                    MyMessageBox.Show("El Usuario NO inició operaciones", "Validar Inicio de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl1.Enabled = false;
                    return;
                case "A":
                    //   MyMessageBox.Show("El Usuario ya Inicio sus Operaciones", "Validar Inicio de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // this.Dispose();
                    //   return;
                    break;
                case "C":
                    MyMessageBox.Show("El Usuario ya Cerro sus Operaciones", "Validar Cierre de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Dispose();
                    tabControl1.Enabled = false;
                    return;
                default:
                    MyMessageBox.Show(cRpta, "Error al Validar Estado de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.Dispose();
                    tabControl1.Enabled = false;
                    return;
            }

            //===========================================================================================
            //--Validar Corte Fraccionario
            //===========================================================================================
            if (ValidarCorteFracc(false) == "ERROR")
            {
                //---Llenar Grid
                ListarMonedaSoles(2);
                ListarBilleteSoles(2);
                ListarBilleteDolar(2);

                HabilitarGridCorteDolares(true);
                HabilitarGridCorteSolesBill(true);
                HabilitarGridCorteSolesMonedas(true);
                FormatoGrid();
                DeshabilitaOrdGrid();
                //--Desabilitar botones
                this.dtgMoneda.Enabled = false;
                this.dtgBillete.Enabled = false;
                this.dtgBilletesDolares.Enabled = false;
                this.btnGrabarBilletaje.Enabled = false;
                this.btnEditar.Enabled = true;
            }
            else
            {
                //---Llenar Grid
                ListarMonedaSoles(1);
                ListarBilleteSoles(1);
                ListarBilleteDolar(1);

                HabilitarGridCorteDolares(true);
                HabilitarGridCorteSolesBill(true);
                HabilitarGridCorteSolesMonedas(true);
                FormatoGrid();
                DeshabilitaOrdGrid();
                //--Desabilitar botones
                this.dtgMoneda.Enabled = true;
                this.dtgBillete.Enabled = true;
                this.dtgBilletesDolares.Enabled = true;
                this.btnGrabarBilletaje.Enabled = true;
                this.btnEditar.Enabled = false;
            }

            tabBilletaje.SelectedIndex = 1;
            FormatoGridDolares();
            tabBilletaje.SelectedIndex = 0;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public frmCuadreCierreOpe()
        {
            InitializeComponent();
        }
        #endregion
        #region METODOS GENEREALES
        private void DatosUsuario()
        {
            dtpFechaCuadre.Value = DateTime.Today;
            txtUsuario.Text = "";// VarGlobal.SysUser.cApellidos;
            DataTable DatosCli = new clsInicioCuadreOperaciones().ListaUsuario(idUsuario, "D");
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
            string cEstCie = new clsInicioCuadreOperaciones().ValIniOpeCaja(DateTime.Today, idUsuario).Rows[0][0].ToString();
            return cEstCie;
        }

        #endregion
        #region METODOS CORTE FRACCIONARIO
        private string ValidarCorteFracc(bool lCuadreCaja)
        {
            string cRpta = "OK";
            string msge = "";

            string cCorFra =  new clsInicioCuadreOperaciones().ValidaCorteFracc(DateTime.Today,idUsuario, ref msge);
            if (msge == "OK")
            {
                if (cCorFra != "0" && lCuadreCaja ==false)
                {
                    MyMessageBox.Show("Ya Realizó su Corte Fraccionario", "Validar Corte Fraccionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgMoneda.Enabled = false;
                    dtgBillete.Enabled = false;
                    dtgBilletesDolares.Enabled = false;
                    btnGrabarBilletaje.Enabled = false;
                    btnContinuar.Enabled = true;
                    btnEditar.Enabled = true;

                    cRpta = "ERROR";
                }
                if (cCorFra == "0"&&lCuadreCaja == true)
                {
                    MyMessageBox.Show("Primero debe Realizar su Corte Fraccionario... por Favor..", "Validar Corte Fraccionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cRpta = "ERROR";
                }
            }
            else
            {
                MyMessageBox.Show(msge, "Error al Validar Corte Fraccionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cRpta = "ERROR";
            }
            return cRpta;
        }

        private void ListarMonedaSoles(int nOpc)
        {
            string msge = "";
            if (nOpc == 1)
            {
                tbMonSol = new clsInicioCuadreOperaciones().ListarBillMon(1, 1, ref msge);
                if (msge == "OK")
                {
                    tbMonSol.AcceptChanges();
                    tbMonSol.Columns["nCantidad"].ReadOnly = false;
                    tbMonSol.Columns["nTotal"].ReadOnly = false;
                    this.dtgMoneda.DataSource = tbMonSol;
                }
                else
                {
                    MyMessageBox.Show(msge, "Error al Extraer Datos de Monedas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tbMonSol =new clsInicioCuadreOperaciones().ListarCorteFrac(DateTime.Today, idUsuario,  1, 1, ref msge);
                if (msge == "OK")
                {
                    tbMonSol.AcceptChanges();
                    tbMonSol.Columns["nCantidad"].ReadOnly = false;
                    tbMonSol.Columns["nTotal"].ReadOnly = false;
                    this.dtgMoneda.DataSource = tbMonSol;
                }
                else
                {
                    MyMessageBox.Show(msge, "Error al Extraer Datos de Monedas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void ListarBilleteSoles(int nOpc)
        {
            string msge = "";
            if (nOpc == 1)
            {
                tbBillSol = new clsInicioCuadreOperaciones().ListarBillMon(1, 2, ref msge);
                if (msge == "OK")
                {
                    tbBillSol.AcceptChanges();
                    tbBillSol.Columns["nCantidad"].ReadOnly = false;
                    tbBillSol.Columns["nTotal"].ReadOnly = false;
                    this.dtgBillete.DataSource = tbBillSol;
                }
                else
                {
                    MyMessageBox.Show(msge, "Error al Extraer Datos de Billetes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tbBillSol = new clsInicioCuadreOperaciones().ListarCorteFrac(DateTime.Today, idUsuario,  1, 2, ref msge);
                if (msge == "OK")
                {
                    tbBillSol.AcceptChanges();
                    tbBillSol.Columns["nCantidad"].ReadOnly = false;
                    tbBillSol.Columns["nTotal"].ReadOnly = false;
                    this.dtgBillete.DataSource = tbBillSol;
                }
                else
                {
                    MyMessageBox.Show(msge, "Error al Extraer Datos de Billetes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void ListarBilleteDolar(int nOpc)
        {
            string msge = "";
            if (nOpc == 1)
            {
                tbBillDol = new clsInicioCuadreOperaciones().ListarBillMon(2, 2, ref msge);
                if (msge == "OK")
                {
                    tbBillDol.AcceptChanges();
                    tbBillDol.Columns["nCantidad"].ReadOnly = false;
                    tbBillDol.Columns["nTotal"].ReadOnly = false;
                    this.dtgBilletesDolares.DataSource = tbBillDol;
                }
                else
                {
                    MyMessageBox.Show(msge, "Error al Extraer Billetes en Dólares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                tbBillDol = new clsInicioCuadreOperaciones().ListarCorteFrac(DateTime.Today, idUsuario,  2, 2, ref msge);
                if (msge == "OK")
                {
                    tbBillDol.AcceptChanges();
                    tbBillDol.Columns["nCantidad"].ReadOnly = false;
                    tbBillDol.Columns["nTotal"].ReadOnly = false;
                    this.dtgBilletesDolares.DataSource = tbBillDol;
                    SumaBillDol();
                }
                else
                {
                    MyMessageBox.Show(msge, "Error al Extraer Billetes en Dólares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SumaBillDol()
        {
            double suma = 0.00;
            int nNumPro = this.dtgBilletesDolares.RowCount;
            for (int i = 0; i < nNumPro; i++)
            {
                suma = suma + Convert.ToDouble(this.dtgBilletesDolares.Rows[i].Cells["nTotal"].Value);
            }
            this.txtBilleteDolares.Text = suma.ToString();
            this.txtToralDolares.Text = suma.ToString();
        }
        private void HabilitarGridCorteDolares(Boolean bVal)
        {
            dtgBilletesDolares.ReadOnly = !bVal;
            dtgBilletesDolares.Columns["idMoneda"].ReadOnly = bVal;
            dtgBilletesDolares.Columns["idTipBillMon"].ReadOnly = bVal;
            dtgBilletesDolares.Columns["nValor"].ReadOnly = bVal;
            dtgBilletesDolares.Columns["cDescripcion"].ReadOnly = bVal;
            dtgBilletesDolares.Columns["nCantidad"].ReadOnly = !bVal;
            dtgBilletesDolares.Columns["nTotal"].ReadOnly = bVal;
        }
        private void HabilitarGridCorteSolesBill(Boolean bVal)
        {
            dtgBillete.ReadOnly = !bVal;
            dtgBillete.Columns["idMoneda"].ReadOnly = bVal;
            dtgBillete.Columns["idTipBillMon"].ReadOnly = bVal;
            dtgBillete.Columns["nValor"].ReadOnly = bVal;
            dtgBillete.Columns["cDescripcion"].ReadOnly = bVal;
            dtgBillete.Columns["nCantidad"].ReadOnly = !bVal;
            dtgBillete.Columns["nTotal"].ReadOnly = bVal;
        }
        private void HabilitarGridCorteSolesMonedas(Boolean bVal)
        {
            dtgMoneda.ReadOnly = !bVal;
            dtgMoneda.Columns["idMoneda"].ReadOnly = bVal;
            dtgMoneda.Columns["idTipBillMon"].ReadOnly = bVal;
            dtgMoneda.Columns["nValor"].ReadOnly = bVal;
            dtgMoneda.Columns["cDescripcion"].ReadOnly = bVal;
            dtgMoneda.Columns["nCantidad"].ReadOnly = !bVal;
            dtgMoneda.Columns["nTotal"].ReadOnly = bVal;
        }
        private void FormatoGrid()
        {
            foreach (DataGridViewColumn column in dtgMoneda.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
            this.dtgMoneda.Columns["idMoneda"].Visible = false;
            this.dtgMoneda.Columns["idTipBillMon"].Visible = false;
            this.dtgMoneda.Columns["nValor"].Visible = false;
            this.dtgMoneda.Columns["cDescripcion"].Width = 120;
            this.dtgMoneda.Columns["cDescripcion"].HeaderText = "Denominaciones";
            this.dtgMoneda.Columns["nCantidad"].Width = 60;
            this.dtgMoneda.Columns["nCantidad"].HeaderText = "Cantidad";
            this.dtgMoneda.Columns["nTotal"].Width = 95;
            this.dtgMoneda.Columns["nTotal"].HeaderText = "Total";

            foreach (DataGridViewColumn column in dtgBillete.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            //--Formato Grid Billetes Soles
            this.dtgBillete.Columns["idMoneda"].Visible = false;
            this.dtgBillete.Columns["idTipBillMon"].Visible = false;
            this.dtgBillete.Columns["nValor"].Visible = false;
            this.dtgBillete.Columns["cDescripcion"].Width = 120;
            this.dtgBillete.Columns["cDescripcion"].HeaderText = "Denominaciones";
            this.dtgBillete.Columns["nCantidad"].Width = 60;
            this.dtgBillete.Columns["nCantidad"].HeaderText = "Cantidad";
            this.dtgBillete.Columns["nTotal"].Width = 95;
            this.dtgBillete.Columns["nTotal"].HeaderText = "Total";

            foreach (DataGridViewColumn column in dtgBilletesDolares.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            ////--Formato Grid Billetes Dolares
            this.tabBilletaje.SelectedIndex = 1;
            this.dtgBilletesDolares.Columns["idMoneda"].Visible = false;
            this.dtgBilletesDolares.Columns["idTipBillMon"].Visible = false;
            this.dtgBilletesDolares.Columns["nValor"].Visible = false;
            this.dtgBilletesDolares.Columns["cDescripcion"].Width = 120;
            this.dtgBilletesDolares.Columns["cDescripcion"].HeaderText = "Denominaciones";
            this.dtgBilletesDolares.Columns["nCantidad"].Width = 60;
            this.dtgBilletesDolares.Columns["nCantidad"].HeaderText = "Cantidad";
            this.dtgBilletesDolares.Columns["nTotal"].Width = 150;
            this.dtgBilletesDolares.Columns["nTotal"].HeaderText = "Total";
            this.tabBilletaje.SelectedIndex = 0;
        }
        private void DeshabilitaOrdGrid()
        {
            dtgMoneda.Columns["cDescripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dtgMoneda.Columns["nCantidad"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dtgMoneda.Columns["nTotal"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dtgBillete.Columns["cDescripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dtgBillete.Columns["nCantidad"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dtgBillete.Columns["nTotal"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dtgBilletesDolares.Columns["cDescripcion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dtgBilletesDolares.Columns["nCantidad"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dtgBilletesDolares.Columns["nTotal"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void FormatoGridDolares()
        {
            foreach (DataGridViewColumn column in dtgBilletesDolares.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //--Formato Grid Billetes Dolares
            this.dtgBilletesDolares.Columns["idMoneda"].Visible = false;
            this.dtgBilletesDolares.Columns["idTipBillMon"].Visible = false;
            this.dtgBilletesDolares.Columns["nValor"].Visible = false;
            this.dtgBilletesDolares.Columns["cDescripcion"].Width = 120;
            this.dtgBilletesDolares.Columns["cDescripcion"].HeaderText = "Denominaciones";
            this.dtgBilletesDolares.Columns["nCantidad"].Width = 60;
            this.dtgBilletesDolares.Columns["nCantidad"].HeaderText = "Cantidad";
            this.dtgBilletesDolares.Columns["nTotal"].Width = 150;
            this.dtgBilletesDolares.Columns["nTotal"].HeaderText = "Total";
        }
        private void SumaMonSol()
        {
            double suma = 0.00;
            int nNumPro = this.dtgMoneda.RowCount;
            for (int i = 0; i < nNumPro; i++)
            {
                suma = suma + Convert.ToDouble(this.dtgMoneda.Rows[i].Cells["nTotal"].Value);
            }
            this.txtMonedaSoles.Text = suma.ToString();
            this.txtTotalSoles.Text = Convert.ToString(Math.Round((Math.Round(Convert.ToDouble(this.txtMonedaSoles.Text), 2) + Math.Round(Convert.ToDouble(this.txtBilleteSoles.Text), 2)), 2));
        }
        private void SumaBillSol()
        {
            double suma = 0.00;
            int nNumPro = this.dtgBillete.RowCount;
            for (int i = 0; i < nNumPro; i++)
            {
                suma = suma + Convert.ToDouble(this.dtgBillete.Rows[i].Cells["nTotal"].Value);
            }
            this.txtBilleteSoles.Text = suma.ToString();
            this.txtTotalSoles.Text = Convert.ToString(Math.Round((Convert.ToDouble(this.txtMonedaSoles.Text) + Convert.ToDouble(this.txtBilleteSoles.Text)), 2));
        }
        #endregion
        #region EVENTOS CUADRE OPERACIONES
        private void btnGrabarCuadre_Click(object sender, EventArgs e)
        {
            //===================================================================
            //--Validar Datos del Cuadre
            //===================================================================          
            if (Convert.ToDouble(this.txtSaldoSoles.Text) < 0)
            {
                MyMessageBox.Show("El Saldo Final en SOLES NO Puede ser NEGATIVO: VERIFICAR...", "Validar Cierre de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Convert.ToDouble(this.txtSaldoOpeDolares.Text) < 0)
            {
                MyMessageBox.Show("El Saldo Final en DÓLARES, NO Puede ser NEGATIVO: VERIFICAR...", "Validar Cierre de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Convert.ToDouble(this.txtDiferencia.Text) != 0)
            {
                MyMessageBox.Show("Existe Diferencia en SOLES entre el CORTE FRACCIONARIO y CUADRE CAJA.. VERIFICAR...", "Validar Cierre de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Convert.ToDouble(this.txtDiferenciaDolares.Text) != 0)
            {
                MyMessageBox.Show("Existe Diferencia en DOLARES entre el CORTE FRACCIONARIO y CUADRE CAJA.. VERIFICAR...", "Validar Cierre de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

 
      
            //===================================================================
            //Guardar Datos de Ingreso en Soles XML
            //===================================================================          
            DataSet dsIngSol = new DataSet("dsIngSol");
            dsIngSol.Tables.Add(tbIngSol);
            string xmlIngSol = dsIngSol.GetXml();
            xmlIngSol = clsFormatoXML.EncodingXML(xmlIngSol);
            dsIngSol.Tables.Clear();

            //===================================================================
            //Guardar Datos de Egresos en Soles XML
            //===================================================================          
            DataSet dsEgrSol = new DataSet("dsEgrSol");
            dsEgrSol.Tables.Add(tbEgrSol);
            string xmlEgrSol = dsEgrSol.GetXml();
            xmlEgrSol = clsFormatoXML.EncodingXML(xmlEgrSol);
            dsEgrSol.Tables.Clear();

            //===================================================================
            //Guardar Datos de ingreso en Dólares XML
            //===================================================================          
            DataSet dsIngDol = new DataSet("dsIngDol");
            dsIngDol.Tables.Add(tbIngDol);
            string xmlIngDol = dsIngDol.GetXml();
            xmlIngDol = clsFormatoXML.EncodingXML(xmlIngDol);
            dsIngDol.Tables.Clear();

            //===================================================================
            //Guardar Datos de Egresos en Dolares XML
            //===================================================================          
            DataSet dsEgrDol = new DataSet("dsEgrDol");
            dsEgrDol.Tables.Add(tbEgrDol);
            string xmlEgrDol = dsEgrDol.GetXml();
            xmlEgrDol = clsFormatoXML.EncodingXML(xmlEgrDol);
            dsEgrDol.Tables.Clear();

            //==================================================
            //--Grabar Cuadre Operaciones
            //==================================================
            double nSalIniSol = Convert.ToDouble(this.txtMontoInicioSoles.Text);
            double nSalIniDol = Convert.ToDouble(this.txtInicioDolares.Text);
            double nSalFinSol = Convert.ToDouble(this.txtSaldoSoles.Text);
            double nSalFinDol = Convert.ToDouble(this.txtDiferenciaDolares.Text);

            string cRpta = new clsInicioCuadreOperaciones().RegCierreOperaciones(DateTime.Today, idUsuario,  nSalIniSol, nSalIniDol, nSalFinSol, nSalFinDol, xmlIngSol, xmlEgrSol, xmlIngDol, xmlEgrDol);
            if (cRpta == "OK")
            {
                MyMessageBox.Show("El Cierre de Operaciones se Realizó Correctamente...", "Cierre de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //==================================================
                //--Actualizar Cierre
                //==================================================
                ActualizarCierre();
            }
            else
            {
                MyMessageBox.Show(cRpta, "Cierre de Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.btnGrabarCuadre.Enabled = false;
            btnAtras.Enabled = false;
        }
        #endregion

        #region METODOS CUADRE DE CAJA
        private bool ValInicioCuadreOpercion()
        {
            bool lTrue = true;
            if (ValidarCorteFracc(true) == "ERROR")
            {
                lTrue = false; ;
            }
            if (VerificaCierreOpe() != "OK")
            {
                lTrue = false ;
            }
            return lTrue;
        }
        private bool CargaSaldosCuadre()
        {
            bool lTrue = true;
            if (CuadreOpe() != "OK")
            {
                MyMessageBox.Show(CuadreOpe(), "Error al Extraer Datos de las Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lTrue =false;
            }
            FormatoGridSol();

            if (SalIniOpe() != "OK")
            {
                MyMessageBox.Show(SalIniOpe(), "Error al Extraer Datos de las Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lTrue =false;
            }
            SaldoFinal();
            //--Saldo de Corte Fraccionario
            if (SaldoCorteFraccionario() != "OK")
            {
                MyMessageBox.Show(SaldoCorteFraccionario(), "Error al Extraer Datos de las Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lTrue =false;
            }
            if (lTrue)
            {
                tabCuadre.SelectedIndex = 1;
                FormatoGridDol();
                tabCuadre.SelectedIndex = 0;
                this.btnGrabarCuadre.Enabled = true;
            }
            return lTrue;
        }
        private string CuadreOpe()
        {
            string msge = "";
            //=====================================================================
            //---Ingresos en Soles
            //=====================================================================
            tbIngSol = new clsInicioCuadreOperaciones().CuadreOperaciones(DateTime.Today, idUsuario,1, 1, ref msge);
            if (msge == "OK")
            {
                this.dtgIngresosSoles.DataSource = tbIngSol;
                if (tbIngSol.Rows.Count > 0)
                {
                    this.txtIngresoSoles.Text = tbIngSol.Rows[0]["nTotal"].ToString();
                }
            }
            else
            {
                return msge;
            }

            //=====================================================================
            //---Egresos en Soles
            //=====================================================================
            tbEgrSol = new clsInicioCuadreOperaciones().CuadreOperaciones(DateTime.Today, idUsuario, 1, 2, ref msge);
            if (msge == "OK")
            {
                this.dtgEgresosSoles.DataSource = tbEgrSol;
                if (tbEgrSol.Rows.Count > 0)
                {
                    this.txtSaldoCortSoles.Text = tbEgrSol.Rows[0]["nTotal"].ToString();
                }
            }
            else
            {
                return msge;
            }
            //=====================================================================
            //---Ingresos en Dolares
            //=====================================================================
            tbIngDol = new clsInicioCuadreOperaciones().CuadreOperaciones(DateTime.Today, idUsuario, 2,  1, ref msge);
            if (msge == "OK")
            {
                this.dtgIngresosDolares.DataSource = tbIngDol;
                if (tbIngDol.Rows.Count > 0)
                {
                    this.txtIngresoDolares.Text = tbIngDol.Rows[0]["nTotal"].ToString();
                }
            }
            else
            {
                //return false;
                //MyMessageBox.Show(msge, "Error al Extraer Datos de las Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return msge;
            }

            //=====================================================================
            //---Ingresos en Dolares
            //=====================================================================
            tbEgrDol = new clsInicioCuadreOperaciones().CuadreOperaciones(DateTime.Today, idUsuario, 2, 2, ref msge);
            if (msge == "OK")
            {
                this.dtgEgresosDolares.DataSource = tbEgrDol;
                if (tbEgrDol.Rows.Count > 0)
                {
                    this.txtEgresoDolares.Text = tbEgrDol.Rows[0]["nTotal"].ToString();
                }
            }
            else
            {
                return msge;
            }
            return "OK";
        }
        private string SalIniOpe()
        {
            string msge = "";
            //=====================================================================
            //---Ingresos en Soles
            //=====================================================================
            DataTable tbSalIniOpe = new clsInicioCuadreOperaciones().SaldoinicialOpe(DateTime.Today, idUsuario,  ref msge);
            if (msge == "OK")
            {
                if (tbSalIniOpe.Rows.Count > 0)
                {
                    this.txtMontoInicioSoles.Text = tbSalIniOpe.Rows[0]["nSalIniSol"].ToString();
                    this.txtInicioDolares.Text = tbSalIniOpe.Rows[0]["nSalIniDol"].ToString();
                }
            }
            else
            {
                return msge;
                // MyMessageBox.Show(msge, "Error al Extraer El Saldo Inicial...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "OK";
        }
        private void SaldoFinal()
        {  
            //--SALDO FINA SOLES
            this.txtSaldoSoles.Text = Convert.ToString(Math.Round((Math.Round(Convert.ToDouble(this.txtMontoInicioSoles.Text), 2) + Math.Round(Convert.ToDouble(this.txtIngresoSoles.Text), 2) - Math.Round(Convert.ToDouble(this.txtEgresosSoles.Text), 2)), 2));

            //--SALDO FINA DOLARES
            this.txtSaldoOpeDolares.Text = Convert.ToString(Math.Round((Math.Round(Convert.ToDouble(this.txtInicioDolares.Text), 2) + Math.Round(Convert.ToDouble(this.txtIngresoDolares.Text), 2) - Math.Round(Convert.ToDouble(this.txtEgresoDolares.Text), 2)), 2));
        }
        private void FormatoGridSol()
        {
            foreach (DataGridViewColumn column in dtgIngresosSoles.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //--Formato Grid Ingreso Soles
            this.dtgIngresosSoles.Columns["idConcepto"].Visible = false;
            this.dtgIngresosSoles.Columns["nTotal"].Visible = false;
            //this.dtgIngresosSoles.Columns["cConcepto"].Width = 250;
            this.dtgIngresosSoles.Columns["cConcepto"].HeaderText = "Concepto";
            this.dtgIngresosSoles.Columns["nMontoOperacion"].Width = 120;
            this.dtgIngresosSoles.Columns["nMontoOperacion"].HeaderText = "Total Operación";

            foreach (DataGridViewColumn column in dtgEgresosSoles.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //--Formato Grid Egreso Soles
            this.dtgEgresosSoles.Columns["idConcepto"].Visible = false;
            this.dtgEgresosSoles.Columns["nTotal"].Visible = false;
            //this.dtgEgresosSoles.Columns["cConcepto"].Width = 250;
            this.dtgEgresosSoles.Columns["cConcepto"].HeaderText = "Concepto";
            //this.dtgEgresosSoles.Columns["nMontoOperacion"].Width = 120;
            this.dtgEgresosSoles.Columns["nMontoOperacion"].HeaderText = "Total Operación";
        }
        private void FormatoGridDol()
        {
            foreach (DataGridViewColumn column in dtgIngresosDolares.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            //--Formato Grid Ingreso Dólares
            this.dtgIngresosDolares.Columns["idConcepto"].Visible = false;
            this.dtgIngresosDolares.Columns["nTotal"].Visible = false;
            //this.dtgIngresosDolares.Columns["cConcepto"].Width = 250;
            this.dtgIngresosDolares.Columns["cConcepto"].HeaderText = "Concepto";
            //this.dtgIngresosDolares.Columns["nMontoOperacion"].Width = 120;
            this.dtgIngresosDolares.Columns["nMontoOperacion"].HeaderText = "Total Operación";

            foreach (DataGridViewColumn column in dtgEgresosDolares.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //--Formato Grid Egreso Dólares
            this.dtgEgresosDolares.Columns["idConcepto"].Visible = false;
            this.dtgEgresosDolares.Columns["nTotal"].Visible = false;
            //this.dtgEgresosDolares.Columns["cConcepto"].Width = 250;
            this.dtgEgresosDolares.Columns["cConcepto"].HeaderText = "Concepto";
            //this.dtgEgresosDolares.Columns["nMontoOperacion"].Width = 120;
            this.dtgEgresosDolares.Columns["nMontoOperacion"].HeaderText = "Total Operación";
        }
        private string SaldoCorteFraccionario()
        {
            double nMonSoles = 0.00, nMonDolar = 0.00;

            string cRpta = new clsInicioCuadreOperaciones().RetMontoCorFracc(DateTime.Today, idUsuario,  ref nMonSoles, ref nMonDolar);
            if (cRpta == "OK")
            {
                this.txtSaldoCortSoles.Text = nMonSoles.ToString();
                this.txtSaldoCortDolares.Text = nMonDolar.ToString();
                this.txtDiferencia.Text = Convert.ToString(Math.Round((Math.Round(nMonSoles, 2) - Math.Round(Convert.ToDouble(this.txtSaldoSoles.Text), 2)), 2));
                this.txtDiferenciaDolares.Text = Convert.ToString(Math.Round((Math.Round(nMonDolar, 2) - Math.Round(Convert.ToDouble(this.txtSaldoOpeDolares.Text), 2)), 2));
                //=========================================================================
                //-----Validar Cierre de Operaciones en Soles
                //=========================================================================
                double nDifSol = Math.Round(Convert.ToDouble(this.txtDiferencia.Text), 2);
                if (nDifSol == 0)
                {
                    this.lblSoles.Text = "CIERRE EN SOLES OK...";
                    this.lblSoles.ForeColor = Color.Blue;
                }
                else
                {
                    if (nDifSol > 0)
                    {
                        this.lblSoles.Text = "EXISTE DIFERENCIAS, VERIFICAR!!! (Emitir Recibo de INGRESO por SOBRANTE)";
                        this.lblSoles.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.lblSoles.Text = "EXISTE DIFERENCIAS, VERIFICAR!!! (Emitir Recibo de EGRESO por FALTANTE)";
                        this.lblSoles.ForeColor = Color.Red;
                    }
                }

                //=========================================================================
                //-----Validar Cierre de Operaciones en Dólares
                //=========================================================================
                double nDifDol = Math.Round(Convert.ToDouble(this.txtDiferenciaDolares.Text), 2);
                if (nDifDol == 0)
                {
                    this.lblDolares.Text = "CIERRE EN DÓLARES OK...";
                    this.lblDolares.ForeColor = Color.Blue;
                }
                else
                {
                    if (nDifDol > 0)
                    {
                        this.lblDolares.Text = "EXISTE DIFERENCIAS, VERIFICAR!!! (Emitir Recibo de INGRESO por SOBRANTE)";
                        this.lblDolares.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.lblDolares.Text = "EXISTE DIFERENCIAS, VERIFICAR!!! (Emitir Recibo de EGRESO por FALTANTE)";
                        this.lblDolares.ForeColor = Color.Red;
                    }
                }

            }
            else
            {
                return cRpta;
                //MyMessageBox.Show(cRpta, "Error al Extraer El Saldo Inicial...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "OK";
        }
        private string VerificaCierreOpe()
        {
            string cRpta = "";
            string msg = "";
            DataTable tbvalcierre = new clsInicioCuadreOperaciones().ValidarCierreOpe(DateTime.Today,idUsuario, ref msg);
            if (msg == "OK")
            {
                if (tbvalcierre.Rows.Count > 0)
                {
                    for (int i = 0; i < tbvalcierre.Rows.Count; i++)
                    {
                        cRpta = cRpta + tbvalcierre.Rows[i]["cNombre"].ToString() + " ;";
                    }
                    cRpta = "FALTA QUE CIERREN CAJA: " + cRpta;
                    MyMessageBox.Show(cRpta, "Validar Cierre de Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cRpta = "OK";
                }
            }
            return cRpta;
        }
        private void ActualizarCierre()
        {

            if (CuadreOpe() != "OK")
            {
                MyMessageBox.Show(CuadreOpe(), "Error al Extraer Datos de las Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormatoGridSol();

            if (SalIniOpe() != "OK")
            {
                MyMessageBox.Show(SalIniOpe(), "Error al Extraer Datos de las Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaldoFinal();
            //--Saldo de Corte Fraccionario
            if (SaldoCorteFraccionario() != "OK")
            {
                MyMessageBox.Show(SaldoCorteFraccionario(), "Error al Extraer Datos de las Operaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion

        #region EVENTOS CORTE FRACCIONARIO
        private void btnGrabarBilletaje_Click(object sender, EventArgs e)
        {
            var Msg = MyMessageBox.Show("Esta Seguro de Registrar su Corte Fraccionario?...", "Registrar Corte Fraccionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Msg == DialogResult.No)
            {
                return;
            }
            //===================================================================
            //Guardar Datos de Monedas Mediante XML
            //===================================================================          
            DataSet dsMonSol = new DataSet("dsMonSol");
            dsMonSol.Tables.Add(tbMonSol);
            string xmlMonSol = dsMonSol.GetXml();
            xmlMonSol = clsFormatoXML.EncodingXML(xmlMonSol);
            dsMonSol.Tables.Clear();

            //===================================================================
            //Guardar Datos de Billetes Soles Mediante XML
            //===================================================================          
            DataSet dsBillSol = new DataSet("dsBillSol");
            dsBillSol.Tables.Add(tbBillSol);
            string xmlBillSol = dsBillSol.GetXml();
            xmlBillSol = clsFormatoXML.EncodingXML(xmlBillSol);
            dsBillSol.Tables.Clear();

            //===================================================================
            //Guardar Datos de Billetes Dol Mediante XML
            //===================================================================          
            DataSet dsBillDol = new DataSet("dsBillDol");
            dsBillDol.Tables.Add(tbBillDol);
            string xmlBillDol = dsBillDol.GetXml();
            xmlBillDol = clsFormatoXML.EncodingXML(xmlBillDol);
            dsBillDol.Tables.Clear();

            //==================================================
            //--Grabar Corte Fraccionario
            //==================================================
            string cRpta = new clsInicioCuadreOperaciones().registroCorFrac(idUsuario, DateTime.Today,  xmlMonSol, xmlBillSol, xmlBillDol);
            if (cRpta == "OK")
            {
                MyMessageBox.Show("El Corte Fraccionario se Registro Correctamente...", "Registro de Corte Fraccionario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyMessageBox.Show(cRpta, "Error en Registro de Corte Fraccionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.btnGrabarBilletaje.Enabled = false;
            this.dtgMoneda.Enabled = false;
            this.dtgBillete.Enabled = false;
            this.dtgBilletesDolares.Enabled = false;
            this.btnContinuar.Enabled = true;
            this.btnEditar.Enabled = true;
        }
        private void dtgMoneda_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Int32 fila = Convert.ToInt32(this.dtgMoneda.SelectedCells[0].RowIndex);
            if (string.IsNullOrEmpty(this.dtgMoneda.Rows[fila].Cells["nCantidad"].Value.ToString()))
            {
                this.dtgMoneda.Rows[fila].Cells["nCantidad"].Value = 0;
            }
            tbMonSol.Rows[fila]["nTotal"] = Convert.ToDouble(this.dtgMoneda.Rows[fila].Cells["nCantidad"].Value) * Convert.ToDouble(this.dtgMoneda.Rows[fila].Cells["nValor"].Value);
            SumaMonSol();
        }
        private void dtgBillete_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Int32 fila = Convert.ToInt32(this.dtgBillete.SelectedCells[0].RowIndex);
            if (string.IsNullOrEmpty(this.dtgBillete.Rows[fila].Cells["nCantidad"].Value.ToString()))
            {
                this.dtgBillete.Rows[fila].Cells["nCantidad"].Value = 0;
            }
            tbBillSol.Rows[fila]["nTotal"] = Convert.ToDouble(dtgBillete.Rows[fila].Cells["nCantidad"].Value) * Convert.ToDouble(this.dtgBillete.Rows[fila].Cells["nValor"].Value);
            SumaBillSol();
        }
        private void dtgBilletesDolares_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Int32 fila = Convert.ToInt32(this.dtgBilletesDolares.SelectedCells[0].RowIndex);
            if (string.IsNullOrEmpty(this.dtgBilletesDolares.Rows[fila].Cells["nCantidad"].Value.ToString()))
            {
                this.dtgBilletesDolares.Rows[fila].Cells["nCantidad"].Value = 0;
            }
            tbBillDol.Rows[fila]["nTotal"] = Convert.ToDouble(dtgBilletesDolares.Rows[fila].Cells["nCantidad"].Value) * Convert.ToDouble(this.dtgBilletesDolares.Rows[fila].Cells["nValor"].Value);
            SumaBillDol();
        }
        private void tabBilletaje_Click(object sender, EventArgs e)
        {
            FormatoGridDolares();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {       
            //--Desabilitar botones
            this.dtgMoneda.Enabled = true;
            this.dtgBillete.Enabled = true;
            this.dtgBilletesDolares.Enabled = true;
            this.btnGrabarBilletaje.Enabled = true;
            this.btnEditar.Enabled = false;
            this.btnContinuar.Enabled = false;
        }
        private void dtgMoneda_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txtbox = e.Control as TextBox;
            if (txtbox != null)
            {
                txtbox.KeyPress += new KeyPressEventHandler(txtbox_KeyPress);
            }
        }
        void txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            //{
            //    e.Handled = true;
            //}
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void dtgBillete_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txtbox = e.Control as TextBox;
            if (txtbox != null)
            {
                txtbox.KeyPress += new KeyPressEventHandler(txtbox_KeyPress);
            }
        }
        private void dtgBilletesDolares_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txtbox = e.Control as TextBox;
            if (txtbox != null)
            {
                txtbox.KeyPress += new KeyPressEventHandler(txtbox_KeyPress);
            }
        }


        #endregion

        #region METODOS DE INTERFACE
        #endregion

        #region EVENTOS DE INTERFACE
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (!ValInicioCuadreOpercion()) return;
            if (!CargaSaldosCuadre()) return;
            tabControl1.SelectedTab = tabPage2;
            lblTitulo.Text = "CUADRE Y CIERRE DE OPERACIONES";
            lblTitulo.BackColor = Color.Gray;
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            lblTitulo.Text = "REGISTRO DE BILLETAJE";
            lblTitulo.BackColor = Color.Teal;
        }

        #endregion

   
    }
}
