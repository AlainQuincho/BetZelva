using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetZelva
{
    public partial class frmAcceso : Form
    {
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

            // Valida Inicio de session



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

    }
}
