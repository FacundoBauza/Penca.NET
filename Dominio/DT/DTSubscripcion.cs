using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DT
{
    public class DTSubscripcion
    {
        public string nroTar_Credito { get; set; }
        public string rut { get; set; }
        public string Username_Usuario { get; set; }
        public int id_PencaEmpresarial { get; set; }
    }
}
