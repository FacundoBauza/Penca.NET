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
        public List<PencaCompartidas> pencasCompartidas { get; set; }
        public List<PencaEmpresariales> pencasEmpresariales { get; set; }


        public Torneo GetEntity(SolutionContext s)
        {
            Torneo aux = new Torneo();
            
            aux.id = id;
            aux.nombre = nombre;
            aux.fechaInicio = fechaInicio;
            aux.fechaFin = fechaFin;
            if(s.Eventos.ToList().Count>0) 
                aux.eventos = s.Eventos.Where(x => x.id_Torneo==id).Select(x => x.GetEntity()).ToList();
               
            return aux;
        }
    }
}
