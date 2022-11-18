using Dominio.DT;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    [Table(name: "Pronostico")]
    [PrimaryKey(nameof(Username_Usuario), nameof(id_Evento))]
    public class Pronostico
    {
        public int golesEquipo1 { get; set; }
        public int golesEquipo2 { get; set; }

        [ForeignKey("Users")]
        public string? Username_Usuario { get; set; }

        [ForeignKey("Evento")]
        public int id_Evento { get; set; }

        public static Pronostico GetObjetAdd(DTPronostico dp)
        {
            Pronostico pro = new Pronostico();

            pro.golesEquipo1 = dp.golesEquipo1;
            pro.golesEquipo2 = dp.golesEquipo2;
            pro.Username_Usuario = dp.username;
            pro.id_Evento = dp.id_Evento;

            return pro;
        }
    }
}
