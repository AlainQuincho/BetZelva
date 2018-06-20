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
    }
}
