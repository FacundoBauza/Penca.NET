using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Evento
    {
		public int id { get; set; }
        public string equipo1 { get; set; }
		public string equipo2 { get; set; }
        public DateTime fechaHora{ get; set; }
		public string golesEquipo1 { get; set; }
		public string golesEquipo2 { get; set; }
		public string resultado { get; set; }

    }
}
