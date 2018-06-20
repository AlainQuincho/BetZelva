using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using System.Data;
using Entidades;

namespace AccesoDatos
{
    public class AdVarGlobal
    {
        GenEjeSp _EjecSP = new GenEjeSp();
        public void AdCargaVariables()
        {
            var tb = _EjecSP.EjecSp("BET_ListaVariables_SP");

            foreach(DataRow Row in tb.Rows)
            {
                switch(Row["Variable"].ToString())
                {
                    case "dFechaSys":
                        VarGlobal.dFechaSys = Convert.ToDateTime(Row["Valor"]);
                        break;
                }

            }

            VarGlobal.SysUser = new Usuario();
            VarGlobal.SysUser.idUsuario = 0;
            VarGlobal.SysUser.cNombre = "El kevin";
            VarGlobal.SysUser.cApellidos = "de la Cruz";
        }

    }
}
