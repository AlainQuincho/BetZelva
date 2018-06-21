using System.Collections.Generic;
using System.Data;
using System.Linq;
using Entidades;
using Helper;

namespace AccesoDatos
{
    public class AdDisplay
    {
        readonly GenEjeSp _ejeSp = new GenEjeSp();

        public List<RondaView> AdListarRondas()
        {
            var listaRondas = new List<RondaView>();

            var dt = _ejeSp.EjecSp("BET_ListaRondaApuestas_SP");

            foreach (DataRow row in dt.Rows)
            {
                listaRondas.Add(new RondaView
                {
                    IdRonda = row.Field<int>("IdRonda"),
                    NombreRonda = row.Field<string>("NombreRonda"),
                    MultiplicadorLocal = row.Field<string>("MultiplicadorLocal"),
                    MultiplicadorVisita = row.Field<string>("MultiplicadorVisita"),
                    MultiplicadorEmpate = row.Field<string>("MultiplicadorEmpate"),
                    Participantes = AdListaParticipantes(row.Field<int>("IdRonda"))
                });
            }

            return listaRondas.ToList();
        }

        public List<RondaView> AdListarRondasPasadas()
        {
            var listaRondas = new List<RondaView>();

            var dt = _ejeSp.EjecSp("BET_ListaRondasPasadas_SP");

            foreach (DataRow row in dt.Rows)
            {
                listaRondas.Add(new RondaView
                {
                    IdRonda = row.Field<int>("IdRonda"),
                    NombreRonda = row.Field<string>("NombreRonda"),
                    Participantes = AdListaParticipantes(row.Field<int>("IdRonda"))
                });
            }

            return listaRondas.ToList();
        }

        public List<ParticipantesRondaView> AdListaParticipantes(int idRonda)
        {
            var listaParticipantes = new List<ParticipantesRondaView>();

            var dt = _ejeSp.EjecSp("BET_ListarParticipantesByRonda_SP", idRonda);

            foreach (DataRow row in dt.Rows)
            {
                listaParticipantes.Add(new ParticipantesRondaView
                {
                    Fila = row.Field<int>("Fila"),
                    Nombres = row.Field<string>("Nombres"),
                    MontoApuesta = row.Field<decimal>("MontoApuesta"),
                    ScortLocal = row.Field<int>("ScortLocal"),
                    ScortVisita = row.Field<int>("ScortVisita"),
                });
            }

            return listaParticipantes.ToList();
        }
    }
}
