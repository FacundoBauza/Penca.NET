using Dominio.DT;
using Dominio.Entidades;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    public class Users: IdentityUser
    {
        [MaxLength(128), MinLength(3), Required]
        public string? nombre { get; set; }
        [MaxLength(128), MinLength(3), Required]
        public string? apellido { get; set; }

        public Users GetEntity()
        {
            Users aux = new Users();

            aux.Id = Id;
            aux.nombre = nombre;
            aux.apellido = apellido;
            aux.Email = Email;
            aux.UserName = UserName;

            return aux;
        }

        public DTUsuario GetEntity2()
        {
            DTUsuario aux = new DTUsuario();

            aux.Id = Id;
            aux.Nombre = nombre;
            aux.Apellido = apellido;
            aux.Email = Email;
            aux.Username = UserName;

            return aux;
        }
    }
}