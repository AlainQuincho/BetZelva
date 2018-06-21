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
            var TB_Usuario = _EjecSP.EjecSp("DatosUsuario_SP", clsVarGlobal.User.cWinUser);

            foreach(DataRow Row in tb.Rows)
            {
                switch(Row["Variable"].ToString())
                {
                    case "dFechaSys":
                        VarGlobal.dFechaSys = Convert.ToDateTime(Row["Valor"]);
                        break;
                    case "nDisplayGanadores":
                        VarGlobal.nDisplayGanadores = Convert.ToInt32(Row["Valor"]);
                        break;
                    case "nDiasReclamo":
                        VarGlobal.nDiasReclamo = Convert.ToInt32(Row["Valor"]);
                        break;
                    default:
                        break;
                }

            }
            VarGlobal.SysUser = new Usuario();
            foreach (DataRow Row in TB_Usuario.Rows)
            {
                VarGlobal.SysUser.idUsuario = Convert.ToInt32(Row["idUsuario"]);
                VarGlobal.SysUser.cNombre = Convert.ToString(Row["cNombre"]);
                VarGlobal.SysUser.cApellidos = Convert.ToString(Row["cApellidos"]);
                VarGlobal.SysUser.cDireccion = Convert.ToString(Row["cDireccion"]);
                VarGlobal.SysUser.cCorreoElect = Convert.ToString(Row["cCorreoElect"]);
                VarGlobal.SysUser.cDNI = Convert.ToString(Row["cDNI"]);
                VarGlobal.SysUser.cCelular = Convert.ToString(Row["cCelular"]);
                VarGlobal.SysUser.lVigente = Convert.ToBoolean(Row["lVigente"]);
                VarGlobal.SysUser.idPerfil = Convert.ToInt32(Row["idPerfil"]);
                VarGlobal.SysUser.cUsuario = Convert.ToString(Row["cUsuario"]);
            }
        }

    }
}
