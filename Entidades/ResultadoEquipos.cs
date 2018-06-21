using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ResultadoEquipos
    {
        public int     idResultado          { get; set; }
        public int     idConfiguraciones    { get; set; }
        public int     nAnotacionesLocal    { get; set; }
        public int     nAnotacionesVisita   { get; set; }
        public bool    lVigente             { get; set; }
        public int     idEquipoLocal        { get; set; }
        public string  cEquipoLocal         { get; set; }
        public int     idEquipoVisita       { get; set; }
        public string  cEquipoVisita        { get; set; }
        public int     nMultiplicadorLocal  { get; set; }
        public int     nMultiplicadorVisita { get; set; }
        public int     nMultiplicadorEmpate { get; set; }
        public string  cTorneo              { get; set; }
        public string dFechaHora            { get; set; }
    }
}
