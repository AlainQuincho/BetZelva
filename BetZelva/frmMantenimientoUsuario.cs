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
    public partial class frmMantenimientoUsuario : Form
    {
        AdMantenimientoUsuario _Accion = new AdMantenimientoUsuario();
        string Tipo = "";
        public frmMantenimientoUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void frmMantenimientoUsuario_Load(object sender, EventArgs e)
        {
            CargaUsuarios();
            CargarComboPerfil();

            // estas variables globales cargarlos en el login del sistema
            VarGlobal.SysUser = new Usuario();
            VarGlobal.SysUser.idUsuario = 0;
            HabilitarControles(false);
            Tipo = "";

            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void CargarComboPerfil()
        {
            var Perfiles = new AdPerfil().ListaPerfil().ToList();
            cboPerfil.DataSource = Perfiles;
            cboPerfil.DisplayMember = "cPerfil";
            cboPerfil.ValueMember = "idPerfil";
        }

        private void CargaUsuarios()
        {
            List<Usuario> Usuarios = new List<Usuario>();

            Usuarios = _Accion.ListaUsuario();
            dtgUsuarios.DataSource = Usuarios;
            FormatoTabla();

        }

        private void FormatoTabla()
        {
            foreach(DataGridViewColumn Column in dtgUsuarios.Columns)
            {
                Column.Visible = false;
            }

            dtgUsuarios.Columns["cNombre"].Visible   = true;
            dtgUsuarios.Columns["cApellidos"].Visible = true;
            dtgUsuarios.Columns["cDNI"].Visible      = true;

            dtgUsuarios.Columns["cNombre"].HeaderText   = "Nombre";
            dtgUsuarios.Columns["cApellidos"].HeaderText = "Apellido";
            dtgUsuarios.Columns["cDNI"].HeaderText      = "DNI";

            dtgUsuarios.Columns["cNombre"].Width = 130;
            dtgUsuarios.Columns["cApellidos"].Width = 130;
            //dtgUsuarios.Columns["cDNI"].Width = 30;

            dtgUsuarios.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Logica de guardo 
            if (ValidaControles())
                return;

            string Nombres = txtNombres.Text;
            string Apellidos = txtApellidos.Text;
            string Direccion = txtDireccion.Text;
            string CorreoElectronico = txtCorreoElect.Text;
            string Celular = txtCelular.Text;
            bool Vigente = chcVigente.Checked;
            string DNI = txtDNI.Text;
            int idMensaje = 0;
            int idUsuarioSis = VarGlobal.SysUser.idUsuario;
            int idPerfil = (int)(cboPerfil.SelectedValue);
            string Rpta = "";
            string User = txtUsuario.Text;

            if (Tipo.Equals("A"))
            {
                int index = dtgUsuarios.CurrentRow.Index;
                int idUsuario = Convert.ToInt32(dtgUsuarios.Rows[index].Cells["idUsuario"].Value);
                Rpta = _Accion.ActualizarUsuario(Nombres, Apellidos, Direccion, CorreoElectronico, DNI, Celular, ref idMensaje,Vigente, idUsuario, idUsuarioSis, idPerfil, User);
            }
            if(Tipo.Equals("N"))
            {
                Rpta = _Accion.RegistroUsuario(Nombres,Apellidos,Direccion,CorreoElectronico,DNI,Celular,ref idMensaje, idUsuarioSis, idPerfil, User);
            }
            if (idMensaje != 0)
                MessageBox.Show(Rpta, "Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show(Rpta, "Registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Tipo = "";
            CargaUsuarios();
            HabilitarControles(false);
            dtgUsuarios.Enabled = true;

            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;

        }

        private bool ValidaControles()
        {
            string Msj = "";
            if(string.IsNullOrEmpty(txtNombres.Text))
            {
                Msj = "Debe ingresar el nombre del usuario";
                return true;

            }
            else if(string.IsNullOrEmpty(txtApellidos.Text))
            {
                Msj = "Debe ingresar los apellidos";
                return true;
            }
            else if(string.IsNullOrEmpty(txtDireccion.Text))
            {
                Msj = "Debe ingresar la dirección";
                return true;
            }
            else if(string.IsNullOrEmpty(txtDNI.Text))
            {
                Msj = "Debe ingresar el DNI";
                return true;
            }
            else if(txtDNI.Text.Length != 8)
            {
                Msj = "EL DNI ingresado no es válido";
                return true;
            }
            else if(string.IsNullOrEmpty(txtCelular.Text))
            {
                Msj = "Debe ingresar el número de celular";
                return true;
            }
            else if(cboPerfil.SelectedIndex < 0)
            {
                Msj = "Debe seleccionar un perfil";
                return true;
            }

            if(!string.IsNullOrEmpty(Msj))
            {
                MessageBox.Show(Msj, "Mantenimiento de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Fila = e.RowIndex;
            int Columna = e.ColumnIndex;

            if(Columna >= 0)
            {
                txtNombres.Text = dtgUsuarios.Rows[Fila].Cells["cNombre"].Value.ToString();
                txtApellidos.Text = dtgUsuarios.Rows[Fila].Cells["cApellidos"].Value.ToString();
                txtDireccion.Text = dtgUsuarios.Rows[Fila].Cells["cDireccion"].Value.ToString();
                txtCorreoElect.Text = dtgUsuarios.Rows[Fila].Cells["cCorreoElect"].Value.ToString(); 
                txtDNI.Text = dtgUsuarios.Rows[Fila].Cells["cDNI"].Value.ToString();
                txtCelular.Text = dtgUsuarios.Rows[Fila].Cells["cCelular"].Value.ToString();
                chcVigente.Checked = Convert.ToBoolean(dtgUsuarios.Rows[Fila].Cells["lVigente"].Value);
                cboPerfil.SelectedValue = Convert.ToInt32(dtgUsuarios.Rows[Fila].Cells["idPerfil"].Value);
            }

            btnEditar.Enabled = true;
            btnNuevo.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tipo = "N";
            LimpiarControles();
            HabilitarControles(true);
            chcVigente.Enabled = false;
            chcVigente.Checked = true;
            dtgUsuarios.Enabled = false;

            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void LimpiarControles()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtCorreoElect.Clear();
            txtDNI.Clear();
            txtCelular.Clear();
            cboPerfil.SelectedIndex = -1;
            chcVigente.Checked = false;
            txtUsuario.Clear();
        }

        private void HabilitarControles(bool val)
        {
            txtNombres.Enabled = val;
            txtApellidos.Enabled = val;
            txtDireccion.Enabled = val;
            txtCorreoElect.Enabled = val;
            txtDNI.Enabled = val;
            txtCelular.Enabled = val;
            chcVigente.Enabled = val;
            cboPerfil.Enabled = val;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tipo = "A";
            HabilitarControles(true);
            dtgUsuarios.Enabled = false;

            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tipo = "";
            LimpiarControles();
            HabilitarControles(false);
            dtgUsuarios.Enabled = true;
            CargaUsuarios();

            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void dtgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txtNombres.Text = txtNombres.Text.ToUpper();
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void EscribeUsuario()
        {
            string Usuario = "";
            // El usuario esta conformado por nombre + 4 ultimos digitos del DNI
            Usuario = txtNombres.Text + txtDNI.Text.Substring(6,2);
            txtUsuario.Text = Usuario;
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            EscribeUsuario();
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            EscribeUsuario();
        }
    }
}
