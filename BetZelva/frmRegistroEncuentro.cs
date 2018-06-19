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

namespace BetZelva
{
    public partial class frmRegistroEncuentro : Form
    {
        #region VARIABLES GLOBALES
        int idConfiguraciones = 0;
        #endregion
        #region MÉTODOS
        public frmRegistroEncuentro()
        {
            InitializeComponent();
        }
        private void HabilitaLimpiaControles(bool lHabilita ,int nOpcion)
        {
            /*
             * lHabilita =0 -->Limpia Controles
             * lHabilita =1 -->Habilita o deshabilita Controles
             */
            if (!lHabilita)
            {
                switch (nOpcion) //Limpia Todo
                {
                    case 1:
                        txtCodEncuentro.Clear();
                        lblFechaHoraEncuentro.Text = "";
                        txtcNombreLocal.Clear();
                        txtcNombreVisita.Clear();
                        lblPagaLocal.Text = "0";
                        lblPagaVisita.Text = "0";
                        lblPagaEmpate.Text = "0";
                        txtnAnotacionLocal.Text = "0";
                        txtnAnotacionVisita.Text = "0";
                        lblResultado.Text = "";
                        txtnMontoApuesta.Text = "0.00";
                        txtnMontoGanar.Text = "0.00";
                        

                        txtcApellidoPat.Clear();
                        txtcApellidoMat.Clear();
                        txtcNombres.Clear();
                        txtcDocumento.Clear();

                        txtCodRecibo.Text = "0";
                        break;
                }
            }
            else
            {
                switch (nOpcion)
                {
                    case 1://deshabilita para grabat
                        btnBusca.Enabled = false;
                        txtnAnotacionLocal.Enabled = true;
                        txtnAnotacionVisita.Enabled = true;
                        txtnMontoApuesta.Enabled = true;
                        grbDatosCliente.Enabled = true;
                        btnCancelar.Enabled = true;
                        btnGrabar.Enabled = true;
                        break;
                    case 2:
                        btnBusca.Enabled = true;
                        txtnAnotacionLocal.Enabled = false;
                        txtnAnotacionVisita.Enabled = false;
                        txtnMontoApuesta.Enabled = false;
                        grbDatosCliente.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnGrabar.Enabled = false;
                        btnNuevo.Enabled = false;
                        break;
                    case 3:
                        btnBusca.Enabled = false;
                        txtnAnotacionLocal.Enabled = false;
                        txtnAnotacionVisita.Enabled = false;
                        txtnMontoApuesta.Enabled = false;
                        grbDatosCliente.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnGrabar.Enabled = false;
                        btnNuevo.Enabled = true;
                        break;
                    case 4:
                        btnBusca.Enabled = true;
                        btnNuevo.Enabled = false;
                        break;
                }
            }
           
        }
        private void Resultado()
        {
            int nAnotacionLocal = 0, nAnotacionVisita = 0;
            decimal nMontoApuesta = 0.00M, nMontoGanar = 0.00M;
            nAnotacionLocal =string.IsNullOrEmpty(txtnAnotacionLocal.Text)?0: Convert.ToInt32(txtnAnotacionLocal.Text);
            nAnotacionVisita = string.IsNullOrEmpty(txtnAnotacionVisita.Text) ? 0 : Convert.ToInt32(txtnAnotacionVisita.Text);
            nMontoApuesta = string.IsNullOrEmpty(txtnMontoApuesta.Text)?0.00M: Convert.ToDecimal(txtnMontoApuesta.Text);
            if (nAnotacionLocal>nAnotacionVisita)
            {
                lblResultado.Text = "GANADOR\nL";
                txtnMontoGanar.Text =(Math.Round(nMontoApuesta * Convert.ToDecimal(lblPagaLocal.Text),1)).ToString();
                return;
            }
            else if (nAnotacionLocal < nAnotacionVisita)
            {
                lblResultado.Text = "GANADOR\nV";
                txtnMontoGanar.Text = (Math.Round(nMontoApuesta * Convert.ToDecimal(lblPagaVisita.Text),1)).ToString();
                return;
            }
            else
            {
                lblResultado.Text = "EMPATE\nE";
                txtnMontoGanar.Text = (Math.Round( nMontoApuesta * Convert.ToDecimal(lblPagaEmpate.Text),1)).ToString();
                return;
            }
        }
        private bool ValidaDatos()
        {
            bool lTrue = true;
            if (string.IsNullOrEmpty(txtCodEncuentro.Text))
            {
                MessageBox.Show("Por favor buscar código de encuentro", "Valida Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lTrue = false;
            }
            else if (string.IsNullOrEmpty(txtnAnotacionLocal.Text))
            {
                MessageBox.Show("La anotación del equipo local no es válida", "Valida Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnAnotacionLocal.Focus();
                lTrue = false;
            }
            else if (string.IsNullOrEmpty(txtnAnotacionVisita.Text))
            {
                MessageBox.Show("La anotación del equipo local no es válida", "Valida Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnAnotacionVisita.Focus();
                lTrue = false;
            }
            else if (string.IsNullOrEmpty(txtnMontoApuesta.Text))
            {
                MessageBox.Show("El monto de apuesta no es válida", "Valida Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnMontoApuesta.Focus();
                lTrue = false;
            }
            else if (Convert.ToDecimal(txtnMontoApuesta.Text)==0)
            {
                MessageBox.Show("El monto de apuesta debe ser mayor a 0", "Valida Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnMontoApuesta.Focus();
                lTrue = false;
            }
            else if (string.IsNullOrEmpty(txtcApellidoPat.Text))
            {
                MessageBox.Show("El apellido paterno del cliente no es válida", "Valida Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcApellidoPat.Focus();
                lTrue = false;
            }
            else if (string.IsNullOrEmpty(txtcApellidoMat.Text))
            {
                MessageBox.Show("El apellido materno del cliente no es válida", "Valida Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcApellidoMat.Focus();
                lTrue = false;
            }
            else if (string.IsNullOrEmpty(txtcNombres.Text))
            {
                MessageBox.Show("El monto de apuesta del cliente no es válida", "Valida Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcNombres.Focus();
                lTrue = false;
            }
            else if (string.IsNullOrEmpty(txtcDocumento.Text))
            {
                MessageBox.Show("El documento del cliente no es válida", "Valida Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcDocumento.Focus();
                lTrue = false;
            }
            return lTrue;
        }
        private void Voucher(DataTable dt)
        {
            string _Contenido = "";
            _Contenido = "**************************************************\n";
            _Contenido = _Contenido + "           Número Operación: " + dt.Rows[0]["idKardex"].ToString() + "\n";
            _Contenido = _Contenido + "           Número Recibo: " + dt.Rows[0]["idRecibo"].ToString() + "\n";
            _Contenido = _Contenido + "           Cód. Apuesta: " + dt.Rows[0]["idApuesta"].ToString() + "\n";
            _Contenido = _Contenido + "--------------------------------------------------\n";
            _Contenido = _Contenido + "Apellidos: " + txtcApellidoPat.Text+" "+txtcApellidoMat.Text + "\n";
            _Contenido = _Contenido + "Nombres: " +txtcNombres.Text+ "\n";
            _Contenido = _Contenido + "DNI: " + txtcDocumento.Text + "\n";
            _Contenido = _Contenido + "Fecha de compra: " +DateTime.Today.ToString() + "\n";
            _Contenido = _Contenido + "---------------score-apuesta---------------\n";
            _Contenido = _Contenido + "      "+txtcNombreLocal.Text +" ("+ txtnAnotacionLocal.Text+")"+"      VS       " +txtcNombreVisita.Text+" ( "+ txtnAnotacionVisita.Text+")"+"\n";
            _Contenido = _Contenido + "Pronóstico: L--> " + lblPagaLocal.Text + "  V--> " + lblPagaVisita.Text + "  E--> " +lblPagaEmpate.Text+"\n";
            _Contenido = _Contenido + "Fecha y Hora de encuentro: " +lblFechaHoraEncuentro.Text+ "\n";
            _Contenido = _Contenido + "Monto Apostado: S/  " + string.Format("{0:0.00}", txtnMontoApuesta.Text) + "\n\n";
            _Contenido = _Contenido + "**NOTA: La única manera de reclamar su gancia\n es presentando el presente voucher y Su DNI**";
            MessageBox.Show(_Contenido, "Voucher");
        }
        #endregion

        #region EVENTOS
        private void btnBusca_Click(object sender, EventArgs e)
        {
            frmBuscaEncuentro frmBusca = new frmBuscaEncuentro();
            frmBusca.ShowDialog();
            idConfiguraciones = frmBusca.idConfiguracion;
            if (idConfiguraciones!=0)
            {
                txtCodEncuentro.Text = frmBusca.idConfiguracion.ToString();
                lblFechaHoraEncuentro.Text = frmBusca.dFechaEncuentro.ToString("dd/MM/yyyy") + "  " + frmBusca.cHraEncuentro;
                txtcNombreLocal.Text = frmBusca.cEquipoLocal.ToUpper().Trim();
                txtcNombreVisita.Text = frmBusca.cEquipoVisita.ToUpper().Trim();
                lblPagaLocal.Text = frmBusca.cPagaLocal;
                lblPagaEmpate.Text = frmBusca.cPagaEmpate;
                lblPagaVisita.Text = frmBusca.cPagaVisita;

                HabilitaLimpiaControles(true, 1);
                txtnAnotacionLocal.Focus();
                txtnAnotacionLocal.SelectAll();
            }
        }
        private void frmRegistroEncuentro_Load(object sender, EventArgs e)
        {
            HabilitaLimpiaControles(false, 1);
            txtcDocumento.tipdoc = "1";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaLimpiaControles(false, 1);
            HabilitaLimpiaControles(true, 2);
        }
        private void txtnAnotacionLocal_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnAnotacionLocal.Text))
            {
                Resultado();
            }


        }
        private void txtnAnotacionVisita_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnAnotacionVisita.Text))
            {
                Resultado();
            }
   
          
        }
        private void txtnMontoApuesta_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnMontoApuesta.Text))
            {
                txtnMontoApuesta.Text = string.Format("{0:0.00}", txtnMontoApuesta.Text);
                Resultado();
            }
        }
        private void txtnAnotacionLocal_Click(object sender, EventArgs e)
        {
            txtnAnotacionLocal.SelectAll();
        }
        private void txtnAnotacionVisita_Click(object sender, EventArgs e)
        {
            txtnAnotacionVisita.SelectAll();
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidaDatos())
            {
                string cNombres = txtcNombres.Text;
                string cApellidos = txtcApellidoPat.Text + " " + txtcApellidoMat.Text;
                string cDocumento = txtcDocumento.Text;
                decimal nMontoApuesta = Convert.ToDecimal(txtnMontoApuesta.Text);
                int nAnotacionesLocal = Convert.ToInt32(txtnAnotacionLocal.Text);
                int nAnotacionesVisita = Convert.ToInt32(txtnAnotacionVisita.Text);
                DateTime dFechaReg = DateTime.Today;
                int idUsuarioReg = 1;
                DataTable dtRes = new clsApuestas().ADRegistraApuesta(idConfiguraciones, cNombres, cApellidos,
                                                                                                     cDocumento, nMontoApuesta, nAnotacionesLocal,
                                                                                                     nAnotacionesVisita, dFechaReg, idUsuarioReg);
                if (dtRes.Rows.Count>0)
                {
                    if (Convert.ToInt32(dtRes.Rows[0][0])==0)
                    {
                        txtCodRecibo.Text = dtRes.Rows[0]["idRecibo"].ToString();
                        Voucher(dtRes);
                        HabilitaLimpiaControles(true, 3);
                    }
                }
              
            }
            
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitaLimpiaControles(false, 1);
            HabilitaLimpiaControles(true, 4);
        }
        #endregion


    }
}
