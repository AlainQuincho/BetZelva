
namespace Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string cNombre { get; set; }
        public string cApellidos { get; set; }
        public string cDireccion { get; set; }
        public string cCorreoElect { get; set; }
        public string cDNI { get; set; }
        public string cCelular { get; set; }
        public bool lVigente { get; set; }
        public int idPerfil { get; set; }
    }
}
