using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DT
{
    public class DTEvento
    {
        public int id { get; set; }
        public string equipo1 { get; set; }
        public string equipo2 { get; set; }
        public DateTime fechaHora { get; set; }
        public string golesEquipo1 { get; set; }
        public string golesEquipo2 { get; set; }
        public string resultado { get; set; }
        public int torneo { get; set; }
    }
}
