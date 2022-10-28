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
        public Torneo torneo { get; set; }
        List<Usuario> participantes { get; set; }

        public PencaEmpresarial()
        {
            this.usuarioCreador = new Usuario();
            this.torneo = new Torneo();
            this.participantes = new List<Usuario>();
        }

        public PencaEmpresarial(int id, string link, Usuario usuarioCreador, Torneo torneo, List<Usuario> participantes)
        {
            this.id = id;
            this.link = link;
            this.usuarioCreador = usuarioCreador;
            this.torneo = torneo;
            this.participantes = participantes;
        }
    }
}
