using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Entidades
{
    public class Subscripcion
    {
        public int id { get; set; }
        public string nroTar_Credito { get; set; }
        public string rut { get; set; }
        public int id_User { get; set; }
        public int id_Penca { get; set; }
    }
}
