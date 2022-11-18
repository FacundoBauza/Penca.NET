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
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public List<Subscripcion> subscripcions { get; set; }
        public List<PencaCompartida> pencasCompartidas { get; set; }
        public List<PencaEmpresarial> pencasEmpresariales { get; set; }


        public Usuario()
        {
            subscripcions = new List<Subscripcion>();
            pencasEmpresariales = new List<PencaEmpresarial>();
            pencasCompartidas = new List<PencaCompartida>();
        }

        public Usuario(string id, string nombre, string apellido, string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
        }
    }
}
