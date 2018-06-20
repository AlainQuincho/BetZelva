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
    public class AdMantenimientoRonda
    {
        GenEjeSp _EjecSP = new GenEjeSp();
        public List<Equipo> ListaEquipos()
        {
            var Tb = _EjecSP.EjecSp("ListaEquipos_SP");
            List<Equipo> Equipos = new List<Equipo>();
            foreach(DataRow Row in Tb.Rows)
            {
                Equipos.Add(new Equipo
                {
                    CodEquipo = Convert.ToInt32(Row["CodEquipo"]),
                    NombreEquipo = Convert.ToString(Row["NombreEquipo"])
                });
            }
            return Equipos;
        } 

        // GUARDA CONFIGURACION 
        public string GuardaNuevaConfiguracion(string xml, int idUsuario, DateTime dFechaSys)
        {
            var tb = _EjecSP.EjecSp("GuardaConfiguracion_SP", xml,idUsuario,dFechaSys);
            string Rpta = tb.Rows[0][0].ToString();
            return Rpta;
        }

        // EDITA CONFIGURACION 
        public string ActualizaConfiguracion(string xml, int idUsuario, DateTime dFechaSys)
        {
            var tb = _EjecSP.EjecSp("ActualizaConfiguracion_SP", xml, idUsuario, dFechaSys);
            string Rpta = tb.Rows[0][0].ToString();
            return Rpta;
        }

        // LISTA CONFIGURACIONES 
        public List<ConfiguraApuesta> ListaConfiguraciones ()
        {
            var Tb = _EjecSP.EjecSp("ListaConfiguraciones_SP");
            List<ConfiguraApuesta> Configuracion = new List<ConfiguraApuesta>();
            foreach (DataRow Row in Tb.Rows)
            {
                Configuracion.Add(new ConfiguraApuesta
                {
                    idConfiguraciones       = Convert.ToInt32(Row["idConfiguraciones"]),
                    idEquipoLocal           = Convert.ToInt32(Row["idEquipoLocal"]),
                    cEquipoLocal            = Convert.ToString(Row["cEquipoLocal"]),
                    idEquipoVisita          = Convert.ToInt32(Row["idEquipoVisita"]),
                    cEquipoVisita           = Convert.ToString(Row["cEquipoVisita"]),
                    nMultiplicadorLocal     = Convert.ToDecimal(Row["nMultiplicadorLocal"]),
                    nMultiplicadorVisita    = Convert.ToDecimal(Row["nMultiplicadorVisita"]),
                    nMultiplicadorEmpate    = Convert.ToDecimal(Row["nMultiplicadorEmpate"]),
                    dFechaEncuentro         = Convert.ToDateTime(Row["dFechaEncuentro"]),
                    tHoraEncuentro          = Convert.ToString(Row["tHoraEncuentro"]),
                    cEstado                 = Convert.ToString(Row["cEstado"]),
                    lVigente                = Convert.ToBoolean(Row["lVigente"]),
                    cTorneo                 = Convert.ToString(Row["cTorneo"]),
                });
            }
            return Configuracion;
        } 
    }
}
