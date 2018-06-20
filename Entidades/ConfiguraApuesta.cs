using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConfiguraApuesta
    {
        public int      idConfiguraciones     { get; set; }
        public int      idEquipoLocal         { get; set; }
        public string   cEquipoLocal          { get; set; }
        public int      idEquipoVisita        { get; set; }
        public string   cEquipoVisita         { get; set; }
        public decimal  nMultiplicadorLocal   { get; set; }
        public decimal  nMultiplicadorVisita  { get; set; }
        public decimal  nMultiplicadorEmpate  { get; set; }
        public DateTime dFechaEncuentro       { get; set; }
        public string tHoraEncuentro        { get; set; }
        public string   cEstado               { get; set; }
        public bool      lVigente              { get; set; }
        public string   cTorneo               { get; set; }
    }
}
