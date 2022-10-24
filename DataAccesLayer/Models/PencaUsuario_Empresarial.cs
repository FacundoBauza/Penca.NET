using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    public class PencaUsuario_Empresarial
    {
        public virtual PencaEmpresarial pencaEmpresarial { get; set; }
        public virtual Usuario usuario { get; set; }

        [ForeignKey("Usuario")]
        public virtual int id_Usuario { get; set; }
        [ForeignKey("Penca")]
        public virtual int id_Penca { get; set; }
    }
}
