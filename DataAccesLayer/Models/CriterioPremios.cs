using DataAccesLayer.Interfaces;
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
    public class CriterioPremios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public int cantGanadores { get; set; }

        public CriterioPremio GetEntity()
        {
            SolutionContext sol = new SolutionContext();
            CriterioPremio aux = new CriterioPremio();
            List<int> i = new List<int>();
            List<PorcentajesPremios> pp1 = new List<PorcentajesPremios>();

            aux.id = id;
            aux.cantGanadores = cantGanadores;

            pp1 = sol.porcentajePremios.OrderBy(PorcentajesPremios => PorcentajesPremios.posicion).ToList();
           
            foreach(PorcentajesPremios pp in pp1)
            {
                i.Add(pp.porcentaje);
            }
            aux.porcentajes = i;

            return aux;
        }

        public static Torneos GetObjetAdd(Torneo t)
        {
            Torneos aux = new Torneos();

            aux.id = t.id;
            aux.nombre = t.nombre;
            aux.fechaInicio = t.fechaInicio;
            aux.fechaFin = t.fechaFin;

            return aux;
        }
    }
}
