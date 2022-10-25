using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccesLayer.Models
{
    public class PencaEmpresarial
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public string link { get; set; }
        public Torneo torneo { get; set; }
        public Usuario usuarioCreador { get; set; }

        public List<Subscripcion> Subscripciones { get; set; }
        public List<PencaUsuario_Empresarial> pencaUsuarioEmpresarial { get; set; }
    }
}
