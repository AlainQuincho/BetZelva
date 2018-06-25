using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MessageBoxExample
{
    public partial class MyMessageBox : Form
    {

        static MyMessageBox newMessageBox;
        //static string Button_id;
        public static DialogResult Respuesta;

        public MyMessageBox()
        {
            InitializeComponent();
        }

        public static DialogResult Show(string txtMessage)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.lblTitulo.Text = "";
            newMessageBox.btnOk.Visible = true;
            newMessageBox.btnCancel.Visible = false;
            newMessageBox.btnYes.Visible = false;
            newMessageBox.btnNo.Visible = false;
            newMessageBox.ptbIcono.Image = BetZelva.Properties.Resources.ShowMensaje;
            newMessageBox.ShowDialog();

            return Respuesta;
        }

        public static DialogResult Show(string txtMessage, string txtTitle)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.lblTitulo.Text = txtTitle;
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.btnOk.Visible = true;
            newMessageBox.btnCancel.Visible = false;
            newMessageBox.btnYes.Visible = false;
            newMessageBox.btnNo.Visible = false;
            newMessageBox.ptbIcono.Image = BetZelva.Properties.Resources.ShowMensaje;
            newMessageBox.ShowDialog();

            return Respuesta;
        }

        public static DialogResult Show(string txtMessage, string txtTitle, MessageBoxButtons button)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.lblTitulo.Text = txtTitle;
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.ptbIcono.Image = BetZelva.Properties.Resources.ShowMensaje;
            if (button == MessageBoxButtons.OK)
            {
                newMessageBox.btnOk.Visible = true;
                newMessageBox.btnCancel.Visible = false;
                newMessageBox.btnYes.Visible = false;
                newMessageBox.btnNo.Visible = false;
            }
            else if (button == MessageBoxButtons.OKCancel)
            {
                newMessageBox.btnOk.Visible = true;
                newMessageBox.btnCancel.Visible = true;
                newMessageBox.btnYes.Visible = false;
                newMessageBox.btnNo.Visible = false;
            }
            else if (button == MessageBoxButtons.YesNo)
            {
                newMessageBox.btnOk.Visible = false;
                newMessageBox.btnCancel.Visible = false;
                newMessageBox.btnYes.Visible = true;
                newMessageBox.btnNo.Visible = true;
            }

            newMessageBox.ShowDialog();
            return Respuesta;
        }
        public static DialogResult Show(string txtMessage, string txtTitle, MessageBoxButtons button, MessageBoxIcon icono)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.lblTitulo.Text = txtTitle;
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.ptbIcono.Image = BetZelva.Properties.Resources.ShowMensaje;
            if (button == MessageBoxButtons.OK)
            {
                newMessageBox.btnOk.Visible = true;
                newMessageBox.btnCancel.Visible = false;
                newMessageBox.btnYes.Visible = false;
                newMessageBox.btnNo.Visible = false;
            }
            else if (button == MessageBoxButtons.OKCancel)
            {
                newMessageBox.btnOk.Visible = true;
                newMessageBox.btnCancel.Visible = true;
                newMessageBox.btnYes.Visible = false;
                newMessageBox.btnNo.Visible = false;
            }
            else if (button == MessageBoxButtons.YesNo)
            {
                newMessageBox.btnOk.Visible = false;
                newMessageBox.btnCancel.Visible = false;
                newMessageBox.btnYes.Visible = true;
                newMessageBox.btnNo.Visible = true;
            }

            if (icono == MessageBoxIcon.Information)
                newMessageBox.ptbIcono.Image = BetZelva.Properties.Resources.ShowInformacion;
            if (icono == MessageBoxIcon.Error)
                newMessageBox.ptbIcono.Image = BetZelva.Properties.Resources.ShowError;
            if (icono == MessageBoxIcon.Question)
                newMessageBox.ptbIcono.Image = BetZelva.Properties.Resources.ShowPregunta;
            if (icono == MessageBoxIcon.Warning)
                newMessageBox.ptbIcono.Image = BetZelva.Properties.Resources.ShowAdvertencia;

            newMessageBox.ShowDialog();
            return Respuesta;
        }

        private void MyMessageBox_Load(object sender, EventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Respuesta = DialogResult.OK;
            newMessageBox.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Respuesta = DialogResult.Cancel;
            newMessageBox.Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Respuesta = DialogResult.No;
            newMessageBox.Dispose();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Respuesta = DialogResult.Yes;
            newMessageBox.Dispose();
        }

        #region Arrastre
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}