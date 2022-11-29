using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DT
{
    public class DTPencaEmpresarial
    {
        public int id { get; set; }
        public string link { get; set; }
        public string nombre { get; set; }
        public string usuario_creador { get; set; }
        public int torneo { get; set; }
        public bool esCompartida { get; set; }
    }
}
