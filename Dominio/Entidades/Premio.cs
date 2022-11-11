using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Premio
    {
        public float valorPremio { get; set; }
        public bool pago { get; set; }
        public PencaCompartida penca { get; set; }
        public Usuario usuario { get; set; }

        public Premio()
        {
            this.usuario = new Usuario();
            this.penca = new PencaCompartida();

        }

        public Premio(Usuario usuario, PencaEmpresarial pencaEmpresarial, float valorPremio, bool pago)
        {
            this.penca = penca;
            this.usuario = usuario;
            this.valorPremio = valorPremio;
            this.pago = false;
        }

    }
}
