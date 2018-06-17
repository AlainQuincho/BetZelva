using System.Data.SqlClient;

namespace Facturador.GEN.Helper
{
    public class GenParams
    {
        public int Posicion { get; set; }
        public string Tipodatos { get; set; }
        public SqlParameter Parametro { get; set; }
    }
}
