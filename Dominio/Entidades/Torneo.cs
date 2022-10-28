using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Torneo
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public List<Evento> eventos { get; set; }

        public Torneo()
        {
            this.eventos = new List<Evento>();
        }

        public Torneo(int id, string nombre, DateTime fechaInicio, DateTime fechaFin, List<Evento> eventos)
        {
            this.id = id;
            this.nombre = nombre;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.eventos = eventos;
        }
    }
}
