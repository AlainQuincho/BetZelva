using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsUsuario
    {
        public int idUsuario { get; set; }
        public int idCli { get; set; }
        public DateTime dFechaIngreso { get; set; }
        public Nullable<DateTime> dFechaCese;
        public int idEstado { get; set; }
        public int idCargo { get; set; }
        public string cWinUser { get; set; }
        public bool lChangePass { get; set; }
        public int idAgeCol { get; set; }

    }
}
