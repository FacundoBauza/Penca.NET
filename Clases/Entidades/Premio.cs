using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Entidades
{
    public class Premio
    {
        public int id { get; set; }
        public int id_User { get; set; }
        public string id_Penca { get; set; }
        public bool pago { get; set; }
    }
}
