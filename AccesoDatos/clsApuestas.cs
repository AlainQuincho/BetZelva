using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using System.Data;

namespace AccesoDatos
{
    public class clsApuestas
    {
        GenEjeSp objEjeSP = new GenEjeSp();
        public DataTable ADRegistraApuesta(int idConfiguraciones, string cNombres, string cApellidos,
                                                                          string cDocumento, decimal nMontoApuesta, int nAnotacionesLocal, 
                                                                          int nAnotacionesVisita, DateTime dFechaReg,  int idUsuarioReg)
        {
            return objEjeSP.EjecSp("BET_RegistraApuesta_sp", idConfiguraciones, cNombres, cApellidos,
                                                                                                     cDocumento, nMontoApuesta, nAnotacionesLocal,
                                                                                                     nAnotacionesVisita, dFechaReg, idUsuarioReg);
        }

    }
}
