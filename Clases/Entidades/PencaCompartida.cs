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
        public CriterioPremios criterioPremio { get; set; }

        public PencaCompartida(){
            this.criterioPremio = new CriterioPremios();
        }

        public PencaCompartida(int id, CriterioPremios criterioPremio)
        {
            this.id = id;
            this.criterioPremio = criterioPremio;
        }
    }
}
