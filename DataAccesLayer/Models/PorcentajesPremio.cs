using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    public class PorcentajesPremio
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; } 
        public int posicion { get; set; }
        public int porcentaje { get; set; }

        [ForeignKey("CriterioPremios")]
        public virtual int id_CriterioPremio { get; set; }
        public virtual CriterioPremios criterio { get; set; }
    }
}
