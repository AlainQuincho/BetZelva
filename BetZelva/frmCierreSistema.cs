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
    public partial class frmCierreSistema : Form
    {
        public frmCierreSistema()
        {
            InitializeComponent();
        }

        private void frmCierreSistema_Load(object sender, EventArgs e)
        {
            lblFecha.Text = VarGlobal.dFechaSys.ToString("dd/MM/yyyy");
            lblMensaje.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idPerfil = VarGlobal.SysUser.idPerfil;

            if(idPerfil != 1)
            {
                btnCierreSistema.Enabled = false;
            }
            else
            {
                bool Val = new CierreSistema().ValidaCierre(VarGlobal.dFechaSys);
                if(Val)
                {
                    MyMessageBox.Show("Ya se cerro sistema, por favor cerrar el sistema", "Cierre del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblMensaje.Text = "Ya se cerro sistema, por favor cerrar el sistema";
                    btnCierreSistema.Enabled = false;
                }
                else
                {
                    btnCierreSistema.Enabled = true;
                }
            }

            int idMensaje = 0;
            string MSJ = new CierreSistema().AdCierreSistema(ref idMensaje, VarGlobal.SysUser.idUsuario);

            MyMessageBox.Show(MSJ, "Cierre del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMensaje.Text = MSJ;
            btnCierreSistema.Enabled = false;
        }

        private void btnCierreSistema_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
