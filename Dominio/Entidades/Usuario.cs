using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Usuario
    {
        public string Id { get; set; }
        public string nickname { get; set; }
        public string password { get; set; }
        public List<Subscripcion> subscripcions { get; set; }

        public Usuario()
        {
            subscripcions = new List<Subscripcion>();
        }

        public Usuario(string nickname, string password)
        {
            this.nickname = nickname;
            this.password = password;
        }
    }
}
