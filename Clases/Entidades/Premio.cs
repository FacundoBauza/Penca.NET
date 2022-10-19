using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Entidades
{
    public class Premio
    {
        public int Id { get; set; }
        public virtual PencaCompartida PencaCompartida { get; set; }
        public virtual Usuario Usuario { get; set; }
        public float monto { get; set; }
        public bool estaPago { get; set; }
    }
}
