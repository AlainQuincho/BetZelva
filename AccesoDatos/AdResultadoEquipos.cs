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
    public class AdResultadoEquipos
    {
        GenEjeSp _EjecSP = new GenEjeSp();
        public  List<ResultadoEquipos>  ListaResultados()
        {
            var Tb = _EjecSP.EjecSp("ListaResultadosEquipos_SP");
            List<ResultadoEquipos> ListaResultado = new List<ResultadoEquipos>();
            foreach(DataRow Row in Tb.Rows)
            {
                ListaResultado.Add(new ResultadoEquipos
                {
                    idResultado = Convert.ToInt32(Row["idResultado"]),
                    idConfiguraciones = Convert.ToInt32(Row["idConfiguraciones"]),
                    nAnotacionesLocal = Convert.ToInt32(Row["nAnotacionesLocal"]),
                    nAnotacionesVisita = Convert.ToInt32(Row["nAnotacionesVisita"]),
                    lVigente = Convert.ToBoolean(Row["lVigente"]),
                    idEquipoLocal = Convert.ToInt32(Row["idEquipoLocal"]),
                    cEquipoLocal = Convert.ToString(Row["cEquipoLocal"]),
                    idEquipoVisita = Convert.ToInt32(Row["idEquipoVisita"]),
                    cEquipoVisita = Convert.ToString(Row["cEquipoVisita"]),
                    nMultiplicadorLocal = Convert.ToInt32(Row["nMultiplicadorLocal"]),
                    nMultiplicadorVisita = Convert.ToInt32(Row["nMultiplicadorVisita"]),
                    nMultiplicadorEmpate = Convert.ToInt32(Row["nMultiplicadorEmpate"]),
                    cTorneo = Convert.ToString(Row["cTorneo"]),
                    dFechaHora = Convert.ToString(Row["dFechaHora"])
                });
            }
            return ListaResultado;
        }

        public string GuardardarResultados(int idConfiguraciones,int nAnotacionLocal, int nAnotacionVisita, 
            int idUsuario, DateTime dFechaReg)
        {
            var Tb = _EjecSP.EjecSp("RegistraResultadoEquipos_SP", idConfiguraciones, nAnotacionLocal, nAnotacionVisita, idUsuario, dFechaReg);
            string Rpta = Tb.Rows[0][0].ToString();
            return Rpta;     
        }

    }
}
