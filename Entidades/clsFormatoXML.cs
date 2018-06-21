using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class clsFormatoXML
    {
        public static string EncodingXML(string xmlDoc)
        {
            string xmlDirec = "<?xml version='1.0' encoding='ISO-8859-1' standalone='no' ?>" + xmlDoc;
            xmlDirec = xmlDirec.Replace("\r\n", "").Replace(Environment.NewLine, "");
            return xmlDirec;
        }
    }
}
