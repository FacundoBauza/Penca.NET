using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Entidades
{
    public class Subscripcion
    {
        public int Id { get; set; }
        public virtual PencaEmpresarial PencaEmpresarial { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int tarjCredito { get; set; }
        public string plan { get; set; }
        public int rut { get; set; }
    }
}
