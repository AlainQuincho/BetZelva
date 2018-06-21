using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace BetZelva
{
    public partial class frmDisplayGanadores : Form
    {
        private readonly AdDisplay _adDisplay;
        private int _rondaG, _rondaGMaxima;
        private int _filaG, _filaGMax;
        private List<RondaView> _listaRondasGanadas;

        private void frmDisplayGanadores_Load(object sender, EventArgs e)
        {
            dtgRondaGanadores.AutoGenerateColumns = false;
            IniciarGanadores();
        }
        public frmDisplayGanadores()
        {
            InitializeComponent();
            _adDisplay = new AdDisplay();

            _rondaG = 0;
            _rondaGMaxima = 0;
            _filaG = 0;
            _filaGMax = 0;
        }
        private void IniciarGanadores()
        {
            if (_rondaG != 0 && _rondaG == _rondaGMaxima)
            {
                _rondaG = 0;
                _rondaGMaxima = 0;
            }

            _listaRondasGanadas = _adDisplay.AdListarRondasPasadas();

            var lastOrDefault = _listaRondasGanadas.LastOrDefault();
            if (lastOrDefault != null)
                _rondaGMaxima = lastOrDefault.IdRonda;

            if (_listaRondasGanadas.Count > 0)
            {
                if (_rondaG == 0)
                {
                    //mostrar la pimera ronda
                    var rondaG = _listaRondasGanadas.FirstOrDefault();
                    lblRondaGanadores.Text = rondaG.NombreRonda;

                    _rondaG = rondaG.IdRonda;

                    _listaRondasGanadas = _adDisplay.AdListarRondasPasadas();

                    _filaG = 0;
                    _filaGMax = rondaG.Participantes.Count;

                    dtgRondaGanadores.DataSource = rondaG.Participantes;

                    IniciarRecorridoGanadores();
                }
                else
                {
                    var rondaG = _listaRondasGanadas.FirstOrDefault(x => x.IdRonda > _rondaG);
                    lblRondaGanadores.Text = rondaG.NombreRonda;
                    _rondaG = rondaG.IdRonda;

                    _filaG = 0;
                    _filaGMax = rondaG.Participantes.Count;

                    dtgRondaGanadores.DataSource = rondaG.Participantes;

                    IniciarRecorridoGanadores();
                }
            }
            else
            {
                timerG.Enabled = true;
                timerG.Interval = 2000;
            }
        }
        private void IniciarRecorridoGanadores()
        {
            if (_filaG == _filaGMax)
            {
                _filaG = 0;
                IniciarGanadores();
                return;
            }

            dtgRondaGanadores.ClearSelection();

            dtgRondaGanadores.Rows[_filaG].Selected = true;
            _filaG = _filaG + 1;

            timerGParticipantes.Enabled = true;
            timerGParticipantes.Interval = 2000;
        }
        private void timerG_Tick(object sender, EventArgs e)
        {
            timerG.Enabled = false;
            IniciarGanadores();
        }
        private void timerGParticipantes_Tick(object sender, EventArgs e)
        {
            timerGParticipantes.Enabled = false;

            IniciarRecorridoGanadores();
        }
    }
}
