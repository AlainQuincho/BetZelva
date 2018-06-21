using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ResultadoApuesta
    {
        public string   cMensaje            { get; set; }
		public int      idMensaje           { get; set; }
        public int      idApuesta           { get; set; }
        public string   cNombres            { get; set; }
        public string   cApellidos          { get; set; }
        public string   cDocumento          { get; set; }
        public decimal  nMontoApuesta       { get; set; }
        public int      nAnotacionesLocal   { get; set; }
        public int      nAnotacionesVisita  { get; set; }
        public decimal  nMontoAPagar        { get; set; }
        public bool     lGana               { get; set; }
        public string   EquipoLocal         { get; set; }
        public string   EquipoVisita        { get; set; }
        public string dFechaReg             { get; set; }
        public string dFechaCierre          { get; set; }
    }                 
}
