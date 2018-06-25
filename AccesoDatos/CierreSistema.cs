using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;


namespace AccesoDatos
{
    public class CierreSistema
    {
        GenEjeSp _EjeSp = new GenEjeSp();
        public string AdCierreSistema(ref int idMensaje, int idUsuario)
        {
            string MSJ = "";
            var TbResp = _EjeSp.EjecSp("CierreSistema_SP", idUsuario);
            idMensaje = Convert.ToInt32(TbResp.Rows[0]["nMsje"]);
            MSJ = Convert.ToString(TbResp.Rows[0]["cMsje"]);
            return MSJ;
        }

        public bool ValidaCierre(DateTime dfechaSys)
        {
            var TbResp = _EjeSp.EjecSp("ValidaCierre_SP", dfechaSys);
            bool Resp = Convert.ToBoolean(TbResp.Rows[0]["cMensaje"]);

            return Resp;
        }
    }
}
