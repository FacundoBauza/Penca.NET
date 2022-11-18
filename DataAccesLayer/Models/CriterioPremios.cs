using DataAccesLayer.Implementacion;
using DataAccesLayer.Interfaces;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    [Table(name: "CriterioPremio")]
    public class CriterioPremios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_CriterioPremio { get; set; }
        public int cantGanadores { get; set; }

        public CriterioPremio GetEntity()
        {
            I_Functions F = new Functions();
            CriterioPremio aux = new CriterioPremio();

            aux.id = id_CriterioPremio;
            aux.cantGanadores = cantGanadores;
            aux.porcentajes = F.obtenerPorcentajesPremio(id_CriterioPremio);

            return aux;
        }
    }
}
