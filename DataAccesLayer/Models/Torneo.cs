﻿using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccesLayer.Models
{
    public class Torneo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string nombre { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public List<PencaCompartida> pencasCompartidas { get; set; }
        public List<PencaEmpresarial> pencasEmpresariales { get; set; }


        public Dominio.Entidades.Torneo GetEntity()
        {
            return new Dominio.Entidades.Torneo()
            {
                Id = Id,
                nombre = nombre,
                fechaInicio = fechaInicio,
                fechaFin = fechaFin,
                //penasCompartidas = pencasCompartidas.Select(x => x.)
            };
        }
    }
}