using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class CriterioPremios
    {
        public int id { get; set; }
        public int cantGanadores { get; set; }
        public Array[] porcentajePremio { get; set; }

        public CriterioPremios()
        {
            this.porcentajePremio = new Array[this.cantGanadores];
        }

        public CriterioPremios(int cantGanadores, Array[] porcentajePremio)
        {
            this.cantGanadores = cantGanadores;
            this.porcentajePremio = porcentajePremio;
        }
    }
}
