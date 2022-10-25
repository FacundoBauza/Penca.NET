using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Subscripcion
    {
        public int id { get; set; }
        public string nroTar_Credito { get; set; }
        public string rut { get; set; }
        public Usuario usuario { get; set; }
        public PencaEmpresarial penca { get; set; }

        public Subscripcion()
        {
            this.penca = new PencaEmpresarial();
            this.usuario = new Usuario();
        }

        public Subscripcion(string nroTar_Credito, string rut, Usuario usuario, PencaEmpresarial penca)
        {
            this.nroTar_Credito = nroTar_Credito;
            this.rut = rut;
            this.usuario = usuario;
            this.penca = penca;
        }
    }
}
