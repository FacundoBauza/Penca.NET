using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.DT;
using DataAccesLayer.Implementacion;
using DataAccesLayer.Interfaces;

namespace DataAccesLayer.Models
{
    [Table(name: "Torneo")]
    public class Torneos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_Torneo { get; set; }
        public string? nombre { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }

        public DTTorneo GetEntity()
        {
            I_Functions F = new Functions();
            DTTorneo aux = new DTTorneo();
            
            aux.id = id_Torneo;
            aux.nombre = nombre;
            aux.fechaInicio = fechaInicio;
            aux.fechaFin = fechaFin;
            aux.eventos = F.obtenerEventosTorneo(id_Torneo);

            return aux;
        }

        public static Torneos GetObjetAdd(Torneo t)
        {
            Torneos aux = new Torneos();

            aux.id_Torneo = t.id;
            aux.nombre = t.nombre;
            aux.fechaInicio = t.fechaInicio;
            aux.fechaFin = t.fechaFin;

            return aux;
        }
    }
}
