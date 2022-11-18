using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    [Table(name: "PencaCompartida_Users")]
    [PrimaryKey(nameof(Username_Usuario), nameof(id_PencaCompartida))]
    public class PencaUsuario_Compartidas
    {
        [ForeignKey("Users")]
        public string? Username_Usuario { get; set; }

        [ForeignKey("PencaCompartida")]
        public int id_PencaCompartida { get; set; }

    }
}
