using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Usuario
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public string password { get; set; }
        public List<Subscripcion> subscripcions { get; set; }
        public List<PencaCompartida> pencasCompartidas { get; set; }
        public List<PencaEmpresarial> pencasEmpresariales { get; set; }


        public Usuario()
        {
            subscripcions = new List<Subscripcion>();
            pencasEmpresariales = new List<PencaEmpresarial>();
            pencasCompartidas = new List<PencaCompartida>();
        }

        public Usuario(int id, string nickname, string password)
        {
            this.id = id;
            this.nickname = nickname;
            this.password = password;
        }
    }
}
