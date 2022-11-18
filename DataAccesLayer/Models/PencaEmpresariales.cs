using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dominio.DT;
using Dominio.Entidades;

namespace DataAccesLayer.Models
{
    [Table(name:"PencaEmpresarial")]
    public class PencaEmpresariales
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_PencaEmpresarial { get; set; }
        public string link { get; set; }
        public string nombre { get; set; }


        [ForeignKey("Torneo")]
        public int id_Torneo { get; set; }

        [ForeignKey("Users")]
        public string? Username_UsuarioCreador { get; set; }

        public PencaEmpresariales GetEntity()
        {
            PencaEmpresariales aux = new PencaEmpresariales();

            aux.id_PencaEmpresarial = id_PencaEmpresarial;
            aux.nombre = nombre;
            aux.link = link;
            aux.id_Torneo = id_Torneo;
            aux.Username_UsuarioCreador = Username_UsuarioCreador;
            return aux;
        }

        public DTPencaEmpresarial GetEntity2()
        {
            DTPencaEmpresarial aux = new DTPencaEmpresarial();

            aux.id = id_PencaEmpresarial;
            aux.nombre = nombre;
            aux.link = link;
            aux.torneo = id_Torneo;
            aux.usuario_creador = Username_UsuarioCreador;
            return aux;
        }

        public static PencaEmpresariales GetObjetAdd(DTPencaEmpresarial pe)
        {
            PencaEmpresariales aux = new PencaEmpresariales();
            aux.id_PencaEmpresarial = pe.id;
            aux.nombre = pe.nombre;
            aux.link = pe.link;
            aux.id_Torneo = pe.torneo;
            aux.Username_UsuarioCreador = pe.usuario_creador;

            return aux;
        }
    }
}
