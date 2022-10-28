using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccesLayer.Models
{
    public class PencaEmpresariales
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public string link { get; set; }
        public Torneos torneo { get; set; }
        public Usuarios usuarioCreador { get; set; }

        public List<Subscripciones> Subscripciones { get; set; }
        public List<PencaUsuario_Empresariales> pencaUsuarioEmpresarial { get; set; }
    }
}
