using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccesLayer.Models
{
    public class Premios
    {
        public float valorPremio { get; set; }
        public bool pago { get; set; }
        public virtual PencaCompartidas pencaCompartida { get; set; }
        public virtual Usuarios usuario { get; set; }
        public virtual CriterioPremios criterioPremios { get; set; }


        [ForeignKey("CriterioPremios")]
        public virtual int id_CriterioPremio { get; set; }

        [ForeignKey("Usuario")]
        public virtual int id_Usuario { get; set; }

        [ForeignKey("Penca")]
        public virtual int id_Penca { get; set; }
    }
}
