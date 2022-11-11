using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccesLayer.Models
{
    public class PencaCompartidas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public CriterioPremios criterioPremios { get; set; }
        public List<Premios> premios { get; set; }
        public List<PencaUsuario_Compartidas> pencaUsuarioCompartida { get; set; }
        public Torneos torneo { get; set; }

        public PencaCompartida GetEntity()
        {
            SolutionContext sol = new SolutionContext();
            PencaCompartida aux = new PencaCompartida();
            List<Usuario> us = new List<Usuario>();

            aux.id = id;
            aux.nombre = nombre;
            aux.criterioPremio = criterioPremios.GetEntity();
            aux.torneo = torneo.GetEntity();

            if (sol.pencaUsuarioCompartida.Count() > 0)
            {
                foreach (PencaUsuario_Compartidas u in sol.pencaUsuarioCompartida)
                {
                    if (u.id_Penca == id)
                    {
                        us.Add(u.usuario.GetEntity());
                    }
                }
            }
            aux.participantes = us;
            return aux;
        }

        public static PencaCompartidas GetObjetAdd(PencaCompartida pc)
        {
            PencaCompartidas aux = new PencaCompartidas();
            aux.id = pc.id;
            aux.nombre = pc.nombre;

            return aux;
        }

        /*public static PencaCompartidas GetObjetAdd2(PencaCompartida pc)
        {
            Torneos aux = new Torneos();

            aux.id = t.id;
            aux.nombre = t.nombre;
            aux.fechaInicio = t.fechaInicio;
            aux.fechaFin = t.fechaFin;

            //aux.eventos = Eventos.GetObjetAdd();
            //aux.pencasCompartidas = PencaCompartidas.GetObjetAdd(x.torneo);
            //aux.pencasEmpresariales = PencaEmpresariales.GetObjetAdd(x.torneo);

            return aux;
        }*/

    }
}
