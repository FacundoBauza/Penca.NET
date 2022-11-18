using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.DT;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace DataAccesLayer.Models
{
    [Table(name: "Subscripcion")]
    [PrimaryKey(nameof(Username_Usuario), nameof(id_PencaEmpresarial))]
    public class Subscripciones
    {
        public string? nroTar_Credito { get; set; }
        public string rut { get; set; }

        [ForeignKey("Users")]
        public string? Username_Usuario { get; set; }

        [ForeignKey("PencaEmpresarial")]
        public int id_PencaEmpresarial { get; set; }

        public Subscripciones GetEntity()
        {
            Subscripciones aux = new Subscripciones();
            aux.nroTar_Credito = nroTar_Credito;
            aux.rut = rut;
            aux.Username_Usuario = Username_Usuario;
            aux.id_PencaEmpresarial =id_PencaEmpresarial;

            return aux;
        }

        public static Subscripciones GetObjetAdd(DTSubscripcion x)
        {
            Subscripciones aux = new Subscripciones();

            aux.nroTar_Credito = x.nroTar_Credito;
            aux.rut = x.rut;
            aux.Username_Usuario = x.Username_Usuario;
            aux.id_PencaEmpresarial = x.id_PencaEmpresarial;

            return aux;
        }
    }
}
