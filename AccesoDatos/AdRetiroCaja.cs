using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Entidades;
using System.Data;

namespace AccesoDatos
{
    public class AdRetiroCaja
    {
        GenEjeSp _EjecSP = new GenEjeSp();
        public ResultadoApuesta ResultadoBusqueda(int idApuesta)
        {
            ResultadoApuesta Resultado = new ResultadoApuesta();

            var Tb = _EjecSP.EjecSp("BuscaGanador_SP", idApuesta);

            foreach (DataRow Row in Tb.Rows)
            {
                Resultado.cMensaje = Row["cMensaje"].ToString();
                Resultado.idMensaje = Convert.ToInt32(Row["idMensaje"]);
                Resultado.idApuesta = Convert.ToInt32(Row["idApuesta"]);
                Resultado.cNombres = Row["cNombres"].ToString();
                Resultado.cApellidos = Row["cApellidos"].ToString();
                Resultado.cDocumento = Row["cDocumento"].ToString();
                Resultado.nMontoApuesta = Convert.ToDecimal(Row["nMontoApuesta"]);
                Resultado.nAnotacionesLocal = Convert.ToInt32(Row["nAnotacionesLocal"]);
                Resultado.nAnotacionesVisita = Convert.ToInt32(Row["nAnotacionesVisita"]);
                Resultado.nMontoAPagar = Convert.ToDecimal(Row["nMontoAPagar"]);
                Resultado.lGana = Convert.ToBoolean(Row["lGana"]);
                Resultado.EquipoLocal = Convert.ToString(Row["EquipoLocal"]);
                Resultado.EquipoVisita = Convert.ToString(Row["EquipoVisita"]);
                Resultado.dFechaReg = Convert.ToString(Row["dFechaReg"]);
                Resultado.dFechaCierre = Convert.ToString(Row["dFechaCierre"]);
            }

            return Resultado;
        }

        public string GuardaRetiroCaja(int idApuesta, DateTime dFechaReg, decimal nMontoOperacion, 
            int idUsuarioReg, int idConcepto, ref int idRecibo, ref int idKardex)
        {
            string Msj = "";
            var TB = _EjecSP.EjecSp("RegistraEgreso_sp", idApuesta, dFechaReg, nMontoOperacion, idUsuarioReg, idConcepto);
            if (Convert.ToInt32(TB.Rows[0]["idMensaje"])  == 0) // Correcto
            {
                idRecibo = Convert.ToInt32(TB.Rows[0]["idRecibo"]);
                idKardex = Convert.ToInt32(TB.Rows[0]["idKardex"]);
            }
            else // Error 
            {
                idRecibo = 0;
                idKardex = 0;
            }

            Msj = TB.Rows[0][0].ToString();
            return Msj;
        }

        public decimal SaldoDisponible(DateTime dFecOpe, int idUsuario)
        {
            var Tb = _EjecSP.EjecSp("SaldoCaja_SP", dFecOpe, idUsuario);
            decimal SaldoDisponible = 0;
            if (Tb.Rows.Count == 0)
            {
                SaldoDisponible = Convert.ToDecimal(0);
            }
            else
            {
                SaldoDisponible = Convert.ToDecimal(Tb.Rows[0][0]);
            }
            return SaldoDisponible;
        }
    }
}
