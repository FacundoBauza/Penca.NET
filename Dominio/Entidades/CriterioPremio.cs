using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class CriterioPremio
    {
        public int id { get; set; }
        public int cantGanadores { get; set; }
        public List<int> porcentajes { get; set; } 

        public CriterioPremio()
        {
            porcentajes = new List<int>();
        }
        
        public CriterioPremio(int id, int cantGanadores, List<int> porcentajes)
        {
            this.id = id;
            this.cantGanadores = cantGanadores;
            this.porcentajes = porcentajes;
        }
    }
}
