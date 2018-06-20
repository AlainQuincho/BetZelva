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
using Entidades;

namespace BetZelva
{
    public partial class frmControlDisplay : Form
    {
        private readonly AdDisplay _adDisplay;
        private int _ronda;
        private int _fila, _filaMax;
        private List<RondaView> _listaRondas;
        public frmControlDisplay()
        {
            InitializeComponent();

            _adDisplay = new AdDisplay();
            _ronda = 0;
            _fila = 0;
        }

        private void frmControlDisplay_Load(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void Iniciar()
        {
            _listaRondas = _adDisplay.AdListarRondas();

            if (_listaRondas.Count > 0)
            {
                if (_ronda == 0)
                {
                    //mostrar la pimera ronda
                    var ronda = _listaRondas.FirstOrDefault();
                    lblRondaApuesta.Text = ronda.NombreRonda;

                    _ronda = ronda.IdRonda;

                    _listaRondas = _adDisplay.AdListarRondas();

                    dtgParticipantesRonda.DataSource = ronda.Participantes;
                }
                else
                {
                    var ronda = _listaRondas.FirstOrDefault(x => x.IdRonda > _ronda);
                    lblRondaApuesta.Text = ronda.NombreRonda;
                    _ronda = ronda.IdRonda;

                    dtgParticipantesRonda.DataSource = ronda.Participantes;
                }
            }
            else
            {
                timer.Enabled = true;
                timer.Interval = 1000;

            }
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void timerParticipantes_Tick(object sender, EventArgs e)
        {
            SeleccionarPartipiante();
        }

        private void dtgParticipantesRonda_SelectionChanged(object sender, EventArgs e)
        {
            SeleccionarPartipiante();
        }

        public void SeleccionarPartipiante()
        {
            if (dtgParticipantesRonda.RowCount > 0)
            {
                _filaMax = dtgParticipantesRonda.RowCount;

                if (_fila == 0)
                {
                    dtgParticipantesRonda.SelectionChanged -= dtgParticipantesRonda_SelectionChanged;
                    dtgParticipantesRonda.Rows[_fila].Selected = true;
                    //dtgParticipantesRonda.SelectionChanged += dtgParticipantesRonda_SelectionChanged;
                    _fila = _fila + 1;

                    timerParticipantes.Enabled = true;
                    timerParticipantes.Interval = 10000;
                }
                else if (_fila == _filaMax + 1)
                {
                    Iniciar();
                }
                else
                {
                    timerParticipantes.Enabled = true;
                    timerParticipantes.Interval = 10000;
                }
            }
            else
            {
                Iniciar();
            }
        }
    }
}
