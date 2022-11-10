using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Usuario
    {
        public string id { get; set; }

        public string nombre { get; set; }
        public string apellido { get; set; }
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

        public Usuario(string id, string nickname, string password)
        {
            this.id = id;
            this.nickname = nickname;
            this.password = password;
        }
    }
}
