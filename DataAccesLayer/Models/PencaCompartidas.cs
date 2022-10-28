using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccesLayer.Models
{
    public class PencaCompartidas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public CriterioPremios criterioPremios { get; set; }
        public List<Premios> premios { get; set; }
        public List<PencaUsuario_Compartidas> pencaUsuarioCompartida { get; set; }
        public Torneos torneo { get; set; }

    }
}
