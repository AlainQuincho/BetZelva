using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Helper;
using Entidades;

namespace AccesoDatos
{
    public class AdPerfil
    {
        GenEjeSp _EjecSP = new GenEjeSp();
        public List<Perfil> ListaPerfil()
        {
            List<Perfil> Perfil = new List<Perfil>(); 
            var TB = _EjecSP.EjecSp("ListaPerfil_SP");

            foreach(DataRow Row in TB.Rows)
            {
                Perfil.Add(new Perfil {
                    idPerfil = Convert.ToInt32(Row["idPerfil"]),
                    cPerfil = Convert.ToString(Row["cPerfil"]),
                    lVigente = Convert.ToBoolean(Row["lVigente"])
                });
            }

            return Perfil;
        } 
    }
}
