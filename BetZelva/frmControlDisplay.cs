using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace BetZelva
{
    public partial class frmControlDisplay : Form
    {
        private readonly AdDisplay _adDisplay;
        private int _ronda, _rondaMaxima;
        private int _fila, _filaMax;
        private List<RondaView> _listaRondas;
        public frmControlDisplay()
        {
            InitializeComponent();

            _adDisplay = new AdDisplay();
            _ronda = 0;
            _rondaMaxima = 0;
            _fila = 0;
            _filaMax = 0;
        }

        private void frmControlDisplay_Load(object sender, EventArgs e)
        {
            Form frm = new frmDisplayGanadores();

            OpenFormInPanel(frm);

            Iniciar();
        }

        private void Iniciar()
        {
            if (_ronda != 0 && _ronda == _rondaMaxima)
            {
                _ronda = 0;
                _rondaMaxima = 0;
            }

            _listaRondas = _adDisplay.AdListarRondas();

            var lastOrDefault = _listaRondas.LastOrDefault();
            if (lastOrDefault != null) _rondaMaxima = lastOrDefault.IdRonda;

            if (_listaRondas.Count > 0)
            {
                if (_ronda == 0)
                {
                    var ronda = _listaRondas.FirstOrDefault();
                    lblRondaApuesta.Text = ronda.NombreRonda;

                    _ronda = ronda.IdRonda;

                    _listaRondas = _adDisplay.AdListarRondas();

                    _fila = 0;
                    _filaMax = ronda.Participantes.Count;

                    dtgParticipantesRonda.DataSource = ronda.Participantes;

                    IniciarRecorrido();
                }
                else
                {
                    var ronda = _listaRondas.FirstOrDefault(x => x.IdRonda > _ronda);
                    lblRondaApuesta.Text = ronda.NombreRonda;
                    _ronda = ronda.IdRonda;

                    _fila = 0;
                    _filaMax = ronda.Participantes.Count;

                    dtgParticipantesRonda.DataSource = ronda.Participantes;

                    IniciarRecorrido();
                }
            }
            else
            {
                timer.Enabled = true;
                timer.Interval = 2000;
            }
        }

        private void OpenFormInPanel(object frmHijo)
        {
            if (pnlGanadores.Controls.Count > 0)
            {
                pnlGanadores.Controls.RemoveAt(0);
            }
            var frm = frmHijo as Form;
            if (frm != null)
            {
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                this.pnlGanadores.Controls.Add(frm);
                pnlGanadores.Tag = frm;
                frm.Show();
            }
        }

        private void IniciarRecorrido()
        {
            if (_fila == _filaMax)
            {
                _fila = 0;
                Iniciar();
                return;
            }

            dtgParticipantesRonda.ClearSelection();

            dtgParticipantesRonda.Rows[_fila].Selected = true;
            _fila = _fila + 1;

            timerParticipantes.Enabled = true;
            timerParticipantes.Interval = 2000;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            Iniciar();
        }

        private void timerParticipantes_Tick(object sender, EventArgs e)
        {
            timerParticipantes.Enabled = false;

            IniciarRecorrido();
        }
    }
}
