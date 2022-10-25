using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccesLayer.Models
{
    public class PencaCompartida
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public CriterioPremios criterioPremios { get; set; }
        public List<Premio> Premios { get; set; }
        public List<PencaUsuario_Compartida> pencaUsuarioCompartida { get; set; }
        public Torneo torneo { get; set; }  
    }
}
