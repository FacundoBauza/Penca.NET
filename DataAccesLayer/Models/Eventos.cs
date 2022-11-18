using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    [Table(name: "Evento")]
    public class Eventos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_Evento { get; set; }
        public string? equipo1 { get; set; }
		public string? equipo2 { get; set; }
        public DateTime fechaHora{ get; set; }
		public string? golesEquipo1 { get; set; }
		public string? golesEquipo2 { get; set; }
		public string? resultado { get; set; }
        
        [ForeignKey("Torneo")]
        public int id_Torneo { get; set; }

        public DTEvento GetEntity()
        {
            DTEvento aux = new DTEvento();

            aux.id = id_Evento;
            aux.equipo1 = equipo1;
            aux.equipo2 = equipo2;
            aux.fechaHora = fechaHora;
            aux.golesEquipo1 = golesEquipo1;
            aux.golesEquipo2 = golesEquipo2;
            aux.resultado = resultado;
            aux.torneo = id_Torneo;

            return aux;
        }

        public static Eventos GetObjetAdd(DTEvento x)
        {
            Eventos aux = new Eventos();

            aux.id_Evento = x.id;
            aux.equipo1 = x.equipo1;
            aux.equipo2 = x.equipo2;
            aux.fechaHora = x.fechaHora;
            aux.golesEquipo1 = x.golesEquipo1;
            aux.golesEquipo2 = x.golesEquipo2;
            aux.resultado = x.resultado;
            aux.id_Torneo = x.torneo;

            return aux;
        }

        public Eventos GetObjetAdd2()
        {
            Eventos aux = new Eventos();

            aux.id_Evento = id_Evento;
            aux.equipo1 = equipo1;
            aux.equipo2 = equipo2;
            aux.fechaHora = fechaHora;
            aux.golesEquipo1 = golesEquipo1;
            aux.golesEquipo2 = golesEquipo2;
            aux.resultado = resultado;
            aux.id_Torneo = id_Torneo;

            return aux;
        }
    }
}
