using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using System.Data;
namespace AccesoDatos
{
   public class clsConfiguraciones
    {
        GenEjeSp objEjeSp = new GenEjeSp();
        public DataTable ADConsultaConfiguraciones()
        {
            return objEjeSp.EjecSp("BET_ConsultaConfiguracion_sp");
        }
    }
}
