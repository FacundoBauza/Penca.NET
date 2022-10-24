using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Entidades
{
    public class Premio
    {
        public int id { get; set; }
        public PencaCompartida penca { get; set; }
        public Usuario usuario { get; set; }
        public float valorPremio { get; set; }
        public bool pago { get; set; }
       
        public Premio(){
            this.usuario = new Usuario();
            this.penca = new PencaCompartida();

        }

        public Premio(Usuario usuario, PencaEmpresarial pencaEmpresarial, float valorPremio, bool pago){
            this.penca = penca;
            this.usuario = usuario;
            this.valorPremio = valorPremio;
            this.pago = true;
        }

    }

}
