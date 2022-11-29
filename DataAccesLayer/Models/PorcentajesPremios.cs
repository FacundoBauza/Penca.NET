using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    [Table(name: "PorcentajePremio")]
    public class PorcentajesPremios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_Porcentaje { get; set; } 
        public int posicion { get; set; }
        public int porcentaje { get; set; }

        [ForeignKey("CriterioPremio")]
        public int id_CriterioPremio { get; set; }

        public PorcentajesPremios GetEntity()
        {
            PorcentajesPremios p = new PorcentajesPremios();

            p.posicion = posicion;
            p.porcentaje = porcentaje;

            return p;
        }
    }
}
