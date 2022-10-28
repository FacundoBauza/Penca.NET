using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccesLayer.Models
{
    public class Usuarios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public string nickname { get; set; }
        public string password { get; set; }    
        public List<Subscripciones> Subscripciones { get; set; }
        public List<Premios> Premios { get; set; }
        public List<PencaUsuario_Compartidas> pencaUsuarioCompartida { get; set; }
        public List<PencaUsuario_Empresariales> pencaUsuarioEmpresarial { get; set; }
    }
}
