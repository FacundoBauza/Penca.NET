using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DT
{
    public class DTPremio
    {
        public string username { get; set; }
        public int idPenca{ get; set; }
        public float valorPremio { get; set; }
        public bool pago{ get; set; }
    }
}
