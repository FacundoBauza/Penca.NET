using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Evento
    {
        public int id { get; set; }
        public string equipo1 { get; set; }
        public string equipo2 { get; set; }
        public DateTime fechaHora { get; set; }
        public string golesEquipo1 { get; set; }
        public string golesEquipo2 { get; set; }
        public string resultado { get; set; }
        public Torneo torneo { get; set; }
        
        public Evento(){}

        public Evento(int id, string equipo1, string equipo2, DateTime fechaHora, string golesEquipo1, string golesEquipo2, string resultado, Torneo torneo)
        {
            this.id = id;
            this.equipo1 = equipo1;
            this.equipo2 = equipo2;
            this.fechaHora = fechaHora;
            this.golesEquipo1 = golesEquipo1;
            this.golesEquipo2 = golesEquipo2;
            this.resultado = resultado;
            this.torneo = torneo;
        }
    }
}
