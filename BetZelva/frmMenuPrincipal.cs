using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ControlesBase;
using Entidades;

namespace BetZelva
{
    public partial class frmMenuPrincipal : Form
    {
        #region Contructor
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Resources/BetZelva.Ico");
            MonstrarLogo();
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
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
            lblUsuario.Text = string.Concat(@"Bienvenido usuario: ", clsVarGlobal.User.cWinUser);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Menú
        private void btnOpcionVisualizar_Click(object sender, EventArgs e)
        {
            var frm = new frmControlDisplay();
            frm.ShowDialog();
        }
        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MonstrarLogo();
        }
        private void btnFrmUsuarios_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmMantenimientoUsuario());
        }
        private void btnFrmRegistraEncuentro_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmRegistroEncuentro());
        }
        private void btnFrmInicioOperaciones_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmInicioOperaciones());
        }
        private void btnFrmBilletaje_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmCuadreCierreOpe());
        }
        private void btnFrmRetiroCaja_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmRetiroCaja());
        }
        private void btnFrmRondasApuestas_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmRondasApuesta());
        }
        private void btnFrmSalidaCaja_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmSalidaCaja());
        }
        private void btnFrmCierreApuesta_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmCierreApuesta());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new frmCierreSistema());
        }
        #endregion

        #region Métodos
        private void OpenFormInPanel(Form frmHijo)
        {
            frmHijo.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);

            if (btnFrmCierreSistema.Controls.Count > 0)
            {
                btnFrmCierreSistema.Controls.RemoveAt(0);
            }
            var frm = frmHijo as Form;
            if (frm != null)
            {
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                this.btnFrmCierreSistema.Controls.Add(frm);
                btnFrmCierreSistema.Tag = frm;
                frm.Show();
            }
        }
        private void MonstrarLogo()
        {
            OpenFormInPanel(new frmLogo());
        }
        #endregion

        
    }
}
