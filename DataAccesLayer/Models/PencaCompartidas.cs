using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.DT;

namespace DataAccesLayer.Models
{
    [Table(name: "PencaCompartida")]
    public class PencaCompartidas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_PencaCompartida { get; set; }
        public string? nombre { get; set; }

        [ForeignKey("Torneo")]
        public int id_Torneo { get; set; }

        [ForeignKey("CriterioPremio")]
        public int id_CriterioPremio { get; set; }

        public static PencaCompartidas GetObjetAdd(DTPencaCompartida pc)
        {
            PencaCompartidas aux = new PencaCompartidas();
            aux.id_PencaCompartida = pc.id;
            aux.nombre = pc.nombre;
            aux.id_CriterioPremio = pc.criterioPremio;
            aux.id_Torneo = pc.torneo;

            return aux;
        }

        public static PencaCompartidas GetObjetAdd2(DTPencaCompartida2 pc)
        {
            PencaCompartidas aux = new PencaCompartidas();
            aux.id_PencaCompartida = pc.id;
            aux.nombre = pc.nombre;
            aux.id_Torneo = pc.torneo;

            return aux;
        }
    }
}
