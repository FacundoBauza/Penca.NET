using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccesLayer.Models
{
    [Table(name: "Premios")]
    [PrimaryKey(nameof(Username_Usuario), nameof(id_PencaCompartida))]
    public class Premios
    {
        public float valorPremio { get; set; }
        public bool pago { get; set; }

        [ForeignKey("Users")]
        public string? Username_Usuario { get; set; }

        [ForeignKey("PencaCompartida")]
        public int id_PencaCompartida { get; set; }
    }
}
