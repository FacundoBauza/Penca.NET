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
    public class Subscripcion
    {
        /*[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }*/
        public string nroTar_Credito { get; set; }
        public string rut { get; set; }
        public virtual Usuario usuario { get; set; }
        public virtual PencaEmpresarial pencaEmpresarial { get; set; }

        [ForeignKey("Usuario")]
        public virtual int id_Usuario { get; set; }
        [ForeignKey("Penca")]
        public virtual int id_Penca { get; set; }
    }
}
