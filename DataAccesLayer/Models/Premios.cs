using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Dominio.DT;

namespace DataAccesLayer.Models
{
    [Table(name: "Premios")]
    [PrimaryKey(nameof(Username_Usuario), nameof(id_PencaCompartida))]
    public class Premios
    {
        public float valorPremio { get; set; }
        public bool pago { get; set; }

        [ForeignKey("Users")]
        public string? Username_Usuario { get; set; }

        [ForeignKey("PencaCompartida")]
        public int id_PencaCompartida { get; set; }


        public static Premios GetObjetAdd(DTPremio p)
        {
            Premios aux = new Premios();

            aux.Username_Usuario = p.username;
            aux.id_PencaCompartida = p.idPenca;
            aux.valorPremio = p.valorPremio;
            aux.pago = p.pago;
   

            return aux;
        }

        public DTPremio GetEntity()
        {
            DTPremio aux = new DTPremio();

            aux.username = Username_Usuario;
            aux.idPenca = id_PencaCompartida;
            aux.valorPremio = valorPremio;
            aux.pago = pago;

            return aux;
        }
    }
}
