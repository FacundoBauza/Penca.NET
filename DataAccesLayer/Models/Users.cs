using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    public class Users : IdentityUser
    {
        [MaxLength(128), MinLength(3), Required]
        public string? Nombre { get; set; }
        [MaxLength(128), MinLength(3), Required]
        public string? Apellido { get; set; }
        public List<Subscripciones> Subscripciones { get; set; }
        public List<Premios> Premios { get; set; }
        public List<PencaUsuario_Compartidas> pencaUsuarioCompartida { get; set; }
        public List<PencaUsuario_Empresariales> pencaUsuarioEmpresarial { get; set; }

    }
}