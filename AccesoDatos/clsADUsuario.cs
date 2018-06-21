using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using EntityLayer;
using Helper;
using System.Data;
using Entidades;


namespace AccesoDatos
{
    public class clsADUsuario
    {
        public clsUsuario ValidarLogin(string x_User)
        {
            GenEjeSp objEjeSp = new GenEjeSp();
            clsUsuario lUser = new clsUsuario();
            try
            {
                var query = objEjeSp.EjecSp("GEN_ValUsu_sp", x_User, clsVarGlobal.nIdAgencia);

                foreach (DataRow dr in query.Rows)
                {
                    try
                    {
                        lUser.idUsuario = (int)dr["idUsuario"];
                        lUser.cWinUser = (string)dr["cWinUser"];
                        //lUser.idCli = (int)dr["idCli"];
                        lUser.dFechaIngreso = (DateTime)dr["dFechaIngreso"];
                        //lUser.idEstado = (int)dr["idEstado"];
                        lUser.idCargo = (int)dr["idCargo"];
                        //lUser.dFechaCese = dr["dFechaCese"].ToString() == "" ? null : (Nullable<DateTime>)dr["dFechaCese"];
                        lUser.lChangePass = (bool)dr["lChangePass"];
                        //lUser.idAgeCol = (int)dr["idAgencia"];
                        //lUser.dFechaCese = dr["dFechaCese"] == null ? DateTime.Today : (DateTime)dr["dFechaCese"];
                        //lUser.dFechaCese = (Nullable<DateTime>)dr["dFechaCese"];// (Nullable<DateTime>)dr["dFechaCese"]==null ? null:System.DateTime.Now.Date;
                        //lUser.cCodPerfil = item.cCodPerfil;

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lUser;
        }

        public bool ChangePassword(string cUsu, string cPassOld, string cPassNew)
        {
            bool res = false;
            GenEjeSp objEjeSp = new GenEjeSp();
            try
            {
                objEjeSp.EjecSp("GEN_ChangePassword_sp", cUsu, cPassOld, cPassNew);
                res = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }


    }
}
