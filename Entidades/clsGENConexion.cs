using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Entidades
{
    public class clsGENConexion
    {
        public static ArrayList leeXML()
        {
            ArrayList arlConexion = new ArrayList();

            XmlDocument xDoc = new XmlDocument();

            xDoc.Load(@"conexion.xml");

            XmlNodeList conexion = xDoc.GetElementsByTagName("conexion");

            XmlNodeList listaDatos = ((XmlElement)conexion[0]).GetElementsByTagName("datos");

            string cadenaConexion = "";

            foreach (XmlElement nodo in listaDatos)
            {

                XmlNodeList cserver = nodo.GetElementsByTagName("server");

                XmlNodeList cdatabase = nodo.GetElementsByTagName("database");

                XmlNodeList cautenticacion = nodo.GetElementsByTagName("autenticacion");

                if (Convert.ToInt32(cautenticacion[0].InnerText) == 2)
                {
                    cadenaConexion = string.Format("Data Source={0}; Initial Catalog={1}; User={2}; Password={3}; Connection Timeout=60", cserver[0].InnerText, cdatabase[0].InnerText, clsPassword.cUsuDB, clsPassword.cPassUsuDB);
                }

                arlConexion.Add(cadenaConexion);
                arlConexion.Add(clsPassword.cRole);
                arlConexion.Add(clsPassword.cPassRole);
                arlConexion.Add(cautenticacion[0].InnerText);
            }

            return arlConexion;
        }
    }
}
