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
    public class ManejadorEvento: I_ManejadorEvento
    {
        private readonly SolutionContext _db;
        public ManejadorEvento(SolutionContext db)
        {
            _db = db;
        }

        //Agregar => Etapa: Terminada para Testear
        bool I_ManejadorEvento.set_Evento(DTEvento e)
        {
            Eventos aux = Eventos.GetObjetAdd(e);
          
            _db.Eventos.Add(aux);
            _db.SaveChanges();

            return true;
        }

        //Actualizar => Etapa: Sin Empezar
        bool I_ManejadorEvento.update_Evento(Evento e)
        {
            return false;
        }

        //Listar => Etapa: Sin Empezar
        List<Eventos> I_ManejadorEvento.get_Eventos()
        {
            return _db.Eventos.Select(x => x.GetObjetAdd2()).ToList();
        }

        //Eliminar => Etapa: Sin Empezar
        bool I_ManejadorEvento.delete_Evento(int id_Evento)
        {
            return false;
        }
    }
}
