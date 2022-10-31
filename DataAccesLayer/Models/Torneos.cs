using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccesLayer.Models
{
    public class Torneos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public List<Eventos> eventos { get; set; }

        public List<PencaCompartidas> pencasCompartidas { get; set; }
        public List<PencaEmpresariales> pencasEmpresariales { get; set; }


        public Torneo GetEntity()
        {
            Torneo aux = new Torneo();
            
            aux.id = id;
            aux.nombre = nombre;
            aux.fechaInicio = fechaInicio;
            aux.fechaFin = fechaFin;
            return aux;
        }

        public void addData(Torneo t)
        {
            this.nombre = t.nombre;
            this.fechaInicio = t.fechaInicio;
            this.fechaFin = t.fechaFin;
        }
    }
}
