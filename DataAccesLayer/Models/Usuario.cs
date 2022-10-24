﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccesLayer.Models
{
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public string nickname { get; set; }
        public string password { get; set; }    
        public List<Subscripcion> Subscripciones { get; set; }
        public List<Premio> Premios { get; set; }
        public List<PencaUsuario_Compartida> pencaUsuarioCompartida { get; set; }
        public List<PencaUsuario_Empresarial> pencaUsuarioEmpresarial { get; set; }
    }
}
