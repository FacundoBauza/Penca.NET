using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DT
{
    public class DTPronostico
    {
        public int golesEquipo1 { get; set; }
        public int golesEquipo2 { get; set; }
        public string username { get; set; }
        public int id_Evento { get; set; }
    }
}
