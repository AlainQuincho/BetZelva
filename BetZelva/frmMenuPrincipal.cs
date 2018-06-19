using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ControlesBase;

namespace BetZelva
{
    public partial class frmMenuPrincipal :Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 250)
            {
                pnlMenuVertical.Width = 70;
            }
            else
            {
                pnlMenuVertical.Width = 250;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnOpcionVisualizar_Click(object sender, EventArgs e)
        {
            var frm = new frmControlDisplay();
            frm.ShowDialog();
        }

        private void OpenFormInPanel(object frmHijo)
        {
            if (pnlContenedor.Controls.Count > 0)
            {
                pnlContenedor.Controls.RemoveAt(0);
            }
            var frm = frmHijo as Form;
            if (frm != null)
            {
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                this.pnlContenedor.Controls.Add(frm);
                pnlContenedor.Tag = frm;
                frm.Show();
            }
        }

        private void btnFrmUsuarios_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmMantenimientoUsuario());
        }

        private void btnInicioOperaciones_Click(object sender, EventArgs e)
        {
            frmInicioOperaciones frmInicioOpe = new frmInicioOperaciones();
            frmInicioOpe.Show();
        }
    }
}
