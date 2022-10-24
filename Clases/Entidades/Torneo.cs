using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Entidades
{
    public class Torneo
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public List<Evento> eventos { get; set; }
        public List<PencaCompartida> penasCompartidas { get; set; }
        public List<PencaEmpresarial> pencaEmpresarials { get; set; }

        public Torneo(){
            this.eventos = new List<Evento>();
            this.penasCompartidas = new List<PencaCompartida>();
            this.pencaEmpresarials = new List<PencaEmpresarial>();
        }

        public Torneo(int id, string nombre, DateTime fechaInicio, DateTime fechaFin, List<Evento> eventos, List<PencaCompartida> pencasCompartidas, List<PencaEmpresarial> pencasEmpresariales)
        {
            Id = id;
            this.nombre = nombre;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.eventos = eventos;
            this.penasCompartidas = pencasCompartidas;
            this.pencaEmpresarials = pencasEmpresariales;
        }
    }
}
