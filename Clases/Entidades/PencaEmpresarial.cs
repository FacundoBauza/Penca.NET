using Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class PencaEmpresarial
    {
        public int id { get; set; }
        public string link { get; set; }

        public Usuario usuarioCreador;

        public PencaEmpresarial(){
            usuarioCreador = new Usuario();
        }

        public PencaEmpresarial(int id, string link, Usuario usuarioCreador)
        {
            this.id = id;
            this.link = link;
            this.usuarioCreador = usuarioCreador;
        }
    }
}
