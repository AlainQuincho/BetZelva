using System;
using System.Text;
using System.Windows.Forms;
using Entidades;
using AccesoDatos;
using System.Collections;
using System.DirectoryServices;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;


namespace BetZelva
{
    public partial class frmAcceso : Form
    {
        private Usuario _Usuario = new Usuario();
        private bool lAutenticado = false;

        public frmAcceso()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;

            if (Validar())
                return;

            try
            {
                Ingresar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Acceso incorrecto, vuelva a intentarlo", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Acceso incorrecto, vuelva a intentarlo", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void FrmAcceso_Load(object sender, EventArgs e)
        {
            txtContraseña.Clear();
            txtUsuario.Clear();

        }

        private bool Validar()
        {
            if(string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar el usuario", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContraseña.Clear();
                return true;
            }
            if(string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña","Acceso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtContraseña.Clear();
                return true;
            }
            return false;
        }

        private void Ingresar()
        {
            _Usuario.CodigoAD = txtUsuario.Text.Trim();
            _Usuario.clave = txtContraseña.Text.Trim();

            if (!lAutenticado)
            {
                clsAutenticacion objAut = new clsAutenticacion();
                if (objAut.Autenticar(_Usuario.CodigoAD, _Usuario.clave))
                {
                    lAutenticado = true;

                    if (clsVarGlobal.User.lChangePass)
                    {
                        MessageBox.Show("Cambie su contraseña por favor", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadChangePass();
                    }
                }
                else
                {
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtUsuario.Focus();
                    return;
                }
            }

            if (lAutenticado)
            {
                MessageBox.Show("Bienvenido!!!", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                new AdVarGlobal().AdCargaVariables(); // carga variables globales

                //TODO: Abre contenedor (inicializa panel principal)
                //frmContenedor frmPrincipal = new frmContenedor(this);
                //frmPrincipal.Show();
            }
            
        }
        private void LoadChangePass()
        {
            //TODO: Aqui aparece el cambio de las contraseñas
            this.ClientSize = new System.Drawing.Size(311, 418);
            this.Refresh();
            //grbLogeo.Enabled = false;
            //grbChangPass.Enabled = true;
            //txtContNue.Enabled = false;
            //txtContNueCon.Enabled = false;
            //btnAceptar2.Enabled = false;
            //txtContAct.Text = "";
            //txtContNue.Text = "";
            //txtContNueCon.Text = "";
            //txtContAct.Focus();
        }
    }
    #region Clases

    public class clsAutenticacion
    {
        ArrayList arlConexion = new ArrayList();

        private clsCNUsuarioSistema Usuario = new clsCNUsuarioSistema();

        public bool Autenticar(string cUsu, string cPass)
        {
            bool res = false;
            clsPassword.cUsuDB = cUsu;
            clsPassword.cPassUsuDB = cPass;


            //lee XML
            arlConexion = clsGENConexion.leeXML();
            clsVarGlobal.cConexString = (string)arlConexion[0];
            clsVarGlobal.nTipoAute = 2;
            clsVarGlobal.cRutPathApp = Path.GetDirectoryName(Application.ExecutablePath);
            
            if (clsVarGlobal.nTipoAute == 2)
            {
                if (Usuario.ValiUsuSQL(cUsu, cPass))
                {
                    if (new clsCNUsuario().ValidarUsuario(cUsu))
                    {
                        //new clsCNVarGen().LisVar(clsVarGlobal.nIdAgencia);
                        res = true;
                    }
                    else
                    {
                        MessageBox.Show("Usuario incorrecto", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return res;
        }


    }
    public class clsCNUsuarioSistema
    {
        private string claveUs;
        private string CodigoAcDi;
        public static string codPer;
        public static string nomPer;
        public string cCodigoApl = "SGR";
        public string cDesCodApl = "";
        public static string cCodigoPer;
        public static string cOficin;
        public static string cCodOfi;
        public static string cCodDesArea;

        public string clave
        {
            get { return claveUs; }
            set { claveUs = value; }
        }
        public string CodigoAD
        {
            get { return CodigoAcDi; }
            set { CodigoAcDi = value; }
        }
        public string CodPerson
        {
            get { return codPer; }
            set { codPer = value; }
        }
        public string CodOficin
        {
            get { return cCodOfi; }
            set { cCodOfi = value; }
        }
        public string NomPerson
        {
            get { return nomPer; }
            set { nomPer = value; }
        }
        public string CodPerfil
        {
            get { return cCodigoPer; }
            set { cCodigoPer = value; }
        }
        public string DesOficin
        {
            get { return cOficin; }
            set { cOficin = value; }
        }
        public string CodDesArea
        {
            get { return cCodDesArea; }
            set { cCodDesArea = value; }

        }
        public int ValiUsuDA()
        {
            string user;
            string _Glob = "SVRDOMINIO";//nombre del equipo del dominio
            string _path = "LDAP://" + _Glob;
            string domainAndUsername = CodigoAD;
            AuthenticationTypes atAuthentType = new AuthenticationTypes();
            atAuthentType = AuthenticationTypes.Secure;
            DirectoryEntry deDirEntry = new DirectoryEntry();
            deDirEntry = new DirectoryEntry(_path, domainAndUsername, claveUs, atAuthentType);
            try
            {
                user = deDirEntry.Name;
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public bool ValiUsuSQL(string UsuSql, string PassUsuSql)
        {
            try
            {
                using (SqlConnection Conexion = new SqlConnection())
                {
                    Conexion.ConnectionString = clsGENConexion.leeXML()[0].ToString();
                    Conexion.Open();
                    Conexion.Close();
                    Conexion.Dispose();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    public class clsCNSeguridad
    {
        public bool VerEstActApl()
        {
            bool enEjecucion;
            enEjecucion = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).GetUpperBound(0) > 0;
            return enEjecucion;
        }
        public bool VerUsuEqui(string cCodUsuWin)
        {
            if (cCodUsuWin.Trim().ToUpper() == System.Environment.UserName.ToString().ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GeneratePasswordHash(string thisPassword)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] tmpSource;
            byte[] tmpHash;

            tmpSource = ASCIIEncoding.ASCII.GetBytes(thisPassword); // Turn password into byte array
            tmpHash = md5.ComputeHash(tmpSource);

            StringBuilder sOutPut = new StringBuilder(tmpHash.Length);
            for (int i = 0; i < tmpHash.Length; i++)
            {
                sOutPut.Append(tmpHash[i].ToString("X2"));  // X2 formats to hexadecimal
            }
            return sOutPut.ToString();
        }
        public Boolean VerifyHashPassword(string thisPassword, string thisHash)
        {
            Boolean IsValid = false;
            string tmpHash = GeneratePasswordHash(thisPassword); // Call the routine on user input
            if (tmpHash == thisHash) IsValid = true;  // Compare to previously generated hash
            return IsValid;
        }
    }
    public class clsCNUsuario
    {
        public bool ValidarUsuario(string x_User)
        {
            bool lEstado = false;
            clsUsuario lUser = new clsUsuario();
            try
            {
                lUser = new clsADUsuario().ValidarLogin(x_User);
                if (lUser.cWinUser != null)
                {
                    lEstado = true;
                    clsVarGlobal.User = lUser;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return lEstado;

        }

        public clsUsuario SeleccionarDatUsu(string x_User)
        {
            return new clsADUsuario().ValidarLogin(x_User);
        }

        public bool ChangePassword(string cUsu, string cPassOld, string cPassNew, string cPassNewCon)
        {
            bool res = false;

            if (cPassNewCon == cPassNew)
            {
                if (res = new clsADUsuario().ChangePassword(cUsu, cPassOld, cPassNew))
                {
                    MessageBox.Show("Cambio de contraseña realizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al cambiar de contraseña", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas nuevas no coinciden.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return res;
        }
    }

    #endregion
}
