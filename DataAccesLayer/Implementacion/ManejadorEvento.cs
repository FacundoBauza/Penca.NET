using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
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

        //Agregar
        bool I_ManejadorEvento.set_Evento(Evento e)
        {
            return false;
        }

        //Actualizar
        bool I_ManejadorEvento.update_Evento(Evento e)
        {
            return false;
        }

        //Listar
        List<Evento> I_ManejadorEvento.get_Eventos()
        {
            return new List<Evento>();
        }

        //Eliminar
        bool I_ManejadorEvento.delete_Evento(int id_Evento)
        {
            return false;
        }
    }
}
