using System.Collections.Generic;

namespace Entidades
{
    public class RondaView
    {
        public int IdRonda { get; set; }
        public string NombreRonda { get; set; }
        public string MultiplicadorLocal { get; set; }
        public string MultiplicadorVisita { get; set; }
        public string MultiplicadorEmpate { get; set; }
        public List<ParticipantesRondaView> Participantes { get; set; }
    }
}
