using System.Data.SqlClient;

namespace Helper
{
    public class GenParametros
    {
        public int Posicion { get; set; }
        public string Tipodatos { get; set; }
        public SqlParameter Parametro { get; set; }
    }
}
