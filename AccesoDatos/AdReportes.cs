using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Helper;

namespace AccesoDatos
{
    public class AdReportes
    {
        GenEjeSp _EjecSP = new GenEjeSp();
        public DataTable RetiroCaja(int idApuesta, int idKardex)
        {
            DataTable TbRetiro = new DataTable();
            TbRetiro = _EjecSP.EjecSp("RptRetiroCaja", idApuesta, idKardex, 2, 3);
            return TbRetiro;
        }
        public DataTable PagoGanadores(int idApuesta, int idKardex)
        {
            DataTable TbRetiro = new DataTable();
            TbRetiro = _EjecSP.EjecSp("RptRetiroCaja", idApuesta, idKardex, 2, 2);
            return TbRetiro;
        }
        public DataTable CobroApuesta(int idApuesta, int idKardex)
        {
            DataTable TbRetiro = new DataTable();
            TbRetiro = _EjecSP.EjecSp("RptRetiroCaja", idApuesta, idKardex, 1, 1);
            return TbRetiro;
        }
    }
}
