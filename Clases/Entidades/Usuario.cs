using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Entidades
{
    public class Usuario
    {
        public string Id { get; set; }
        public string nickname { get; set; }
        public string password { get; set; }
        public Subscripcion subscripcion { get; set; }


    }
}
