
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
    public class AdMantenimientoUsuario
    {
        GenEjeSp _EjecSP = new GenEjeSp();
        public string RegistroUsuario(string cNombre , string Apellidos , string Direccion , 
                string CorreoElectronico , string DNI , string cCelular, ref int idMensaje, int idUsuarioReg,
                int idPerfil, string User)
        {
            var TB = _EjecSP.EjecSp("InsertaUsuarios_SP", cNombre, Apellidos, Direccion, CorreoElectronico, 
                                                          DNI, cCelular, idUsuarioReg, idPerfil, User);

            #region Comentado
            //foreach(DataRow Row in TB.Rows)
            //{
            //    _Usuario.Add(new Usuario
            //    {
            //        cNombre = Row[""]
            //        cApellidos
            //        cDireccion
            //        cCorreoElect
            //        cDNI
            //        cCelular
            //        lVigente
            //    });
            //}
            #endregion

            string Msj = TB.Rows[0]["cMensaje"].ToString();
            idMensaje = Convert.ToInt32(TB.Rows[0]["idMensaje"]);

            return Msj;
        }

        public List<Usuario> ListaUsuario()
        {
            List<Usuario> _Usuario = new List<Usuario>();
            var TB = _EjecSP.EjecSp("ListaUsuarios_SP");

            #region Comentado
            foreach (DataRow Row in TB.Rows)
            {
                _Usuario.Add(new Usuario
                {
                    idUsuario    = Convert.ToInt32(Row["idUsuario"]),
                    cNombre      = Row["cNombre"].ToString(),
                    cApellidos   = Row["cApellidos"].ToString(),
                    cDireccion   = Row["cDireccion"].ToString(),
                    cCorreoElect = Row["cCorreoElect"].ToString(),
                    cDNI         = Row["cDNI"].ToString(),
                    cCelular     = Row["cCelular"].ToString(),
                    idPerfil     = Convert.ToInt32(Row["idPerfil"]),
                    lVigente     = Convert.ToBoolean(Row["lVigente"]),
                });
            }
            #endregion

            return _Usuario;
        }

        public string ActualizarUsuario(string cNombre, string Apellidos, string Direccion,
                string CorreoElectronico, string DNI, string cCelular, ref int idMensaje, bool lVigente, 
                int idUsuario ,int idUsuarioMod, int idPerfil, string User)
        {
            var TB = _EjecSP.EjecSp("ActualizaUsuario_SP", cNombre, Apellidos, Direccion, CorreoElectronico, DNI, 
                                                           cCelular,lVigente, idUsuario ,idUsuarioMod, idPerfil, User);


            string Msj = TB.Rows[0]["cMensaje"].ToString();
            idMensaje = Convert.ToInt32(TB.Rows[0]["idMensaje"]);

            return Msj;
        }
    }
}
