using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class PencaCompartida
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public CriterioPremio criterioPremio { get; set; }
        public Torneo torneo { get; set; }
        public List<Usuario> participantes { get; set; }


        public PencaCompartida()
        {
            this.criterioPremio = new CriterioPremio();
            this.torneo = new Torneo();
            this.participantes = new List<Usuario>();
        }

        public PencaCompartida(int id, CriterioPremio criterioPremio, Torneo torneo, List<Usuario> participantes)
        {
            this.id = id;
            this.criterioPremio = criterioPremio;
            this.torneo = torneo;
            this.participantes = participantes;
        }
    }
}
