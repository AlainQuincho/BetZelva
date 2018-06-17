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
    }
}
