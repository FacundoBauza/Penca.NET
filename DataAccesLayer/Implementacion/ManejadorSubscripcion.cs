using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementacion
{
    public class ManejadorSubscripcion: I_ManejadorSubscripcion
    {
        private readonly SolutionContext _db;
        private I_Functions _fu;
        private I_Casteos _cas;
        public ManejadorSubscripcion(SolutionContext db, I_Functions fu, I_Casteos cas)
        {
            _db = db;
            _fu = fu;
            _cas = cas;
        }
        //Agregar Suscripcion => Etapa: Sin Empezar
        bool I_ManejadorSubscripcion.set_Subscripcion(DTSubscripcion s)
        {
            Subscripciones aux = Subscripciones.GetObjetAdd(s);

            if (s.Username_Usuario != null && s.id_PencaEmpresarial != null)
            {
                aux.Username_Usuario = s.Username_Usuario;
                aux.id_PencaEmpresarial = s.id_PencaEmpresarial;
            }
            _db.Subscripciones.Add(aux);
            _db.SaveChanges();

            return true;
        }

        //Listar Subscripciones => Etapa: Sin Empezar
        List<Subscripcion> I_ManejadorSubscripcion.get_Subscripciones(int id_Usuario)
        {
            return new List<Subscripcion>();
        }
    }
}
