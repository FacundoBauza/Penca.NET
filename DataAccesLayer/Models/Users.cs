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
    public class Users : IdentityUser
    {
        [MaxLength(128), MinLength(3), Required]
        public string? nombre { get; set; }
        [MaxLength(128), MinLength(3), Required]
        public string? apellido { get; set; }
        public List<Subscripciones> Subscripciones { get; set; }
        public List<Premios> Premios { get; set; }
        public List<PencaUsuario_Compartidas> pencaUsuarioCompartida { get; set; }
        public List<PencaUsuario_Empresariales> pencaUsuarioEmpresarial { get; set; }

        public Usuario GetEntity()
        {
            Usuario aux = new Usuario();

            aux.id = Id;
            aux.nombre = nombre;
            aux.apellido = apellido;

            return aux;
        }

        public Usuario GetEntity2()
        {
            Usuario aux = new Usuario();

            aux.id = Id;
            aux.nombre = nombre;
            aux.apellido = apellido;

            //Hay que implementar que agregue las colecciones
            return aux;
        }
    }
}