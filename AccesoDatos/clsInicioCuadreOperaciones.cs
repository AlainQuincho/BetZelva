using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using System.Data;
namespace AccesoDatos
{
    public class clsInicioCuadreOperaciones
    {
        GenEjeSp objEjeSp = new GenEjeSp();
        public DataTable ListaUsuario(int nidUsurio, string cTipBus)
        {
            return objEjeSp.EjecSp("BET_DatosCliente_sp", nidUsurio, cTipBus);
        }
        public DataTable SaldoIniOpe(DateTime dFecSis, int nidUsuario)
        {
            return objEjeSp.EjecSp("BET_SaldoInicial_sp", dFecSis, nidUsuario);
        }
        public DataTable ValIniOpeCaja(DateTime dFecSis, int nidUsuario)
        {
            return objEjeSp.EjecSp("BET_ValidaIniOpe_sp", dFecSis, nidUsuario);
        }

        public string GuardaIniOpe(DateTime dFecSis, int nidUsuario, double nMonSoles, double nmonDolares)
        {
            string cRpta;
            try
            {
                objEjeSp.EjecSp("BET_InicioOperaciones_sp", dFecSis, nidUsuario, nMonSoles, nmonDolares);
                cRpta = "OK";
            }
            catch (Exception e)
            {
                cRpta = e.Message;
            }
            return cRpta;
        }
    }
}
