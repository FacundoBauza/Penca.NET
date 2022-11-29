using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    [Table(name: "PencaEmpresarial_Users")]
    [PrimaryKey(nameof(Username_Usuario), nameof(id_PencaEmpresarial))]
    public class PencaUsuario_Empresariales
    {
        [ForeignKey("Users")]
        public string Username_Usuario { get; set; }

        [ForeignKey("PencaEmpresarial")]
        public int id_PencaEmpresarial { get; set; }

    }
}
