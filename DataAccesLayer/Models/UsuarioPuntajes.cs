using Dominio.DT;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    [Table(name: "Usuarios_Puntaje")]
    [PrimaryKey(nameof(username), nameof(id_Penca), nameof(esCompartida))]
    public class UsuarioPuntajes
    {
        public string? username { get; set; }

        public int id_Penca { get; set; }
        public int puntaje { get; set; }
        public bool esCompartida { get; set; }

        public static UsuarioPuntajes GetObjetAdd(string username, int id_Penca, int cont, bool esCompartida)
        {
            UsuarioPuntajes usuarioPuntajes = new UsuarioPuntajes()
            {
                username = username,
                id_Penca = id_Penca,
                puntaje = cont,
                esCompartida = esCompartida
            };

            return usuarioPuntajes;
        }
    }
}
