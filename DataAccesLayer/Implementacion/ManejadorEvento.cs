using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
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
            if(e.nombre_torneo != "")
            {
                foreach(Torneos t in _db.Torneos)
                {
                    if (t.nombre.Equals(e.nombre_torneo))
                    {
                        aux.torneo = t;
                    }
                }
            }
          
            _db.Eventos.Add(aux);
            _db.SaveChanges();

            return true;
        }

        //Actualizar => Etapa: Sin Empezar
        bool I_ManejadorEvento.update_Evento(Evento e)
        {
            var evento = _db.Eventos.SingleOrDefault(evt => evt.id == e.id);
            if (evento != null)
            {
                if (e.equipo1 != null) evento.equipo1 = e.equipo1;
                if (e.equipo2 != null) evento.equipo2 = e.equipo2;
                if (e.resultado != null) evento.resultado = e.resultado;
                if (e.golesEquipo1 != null) evento.golesEquipo1 = e.golesEquipo1;
                if (e.golesEquipo2 != null) evento.golesEquipo2 = e.golesEquipo2;
                _db.SaveChanges();

                return true;
            }
            return false;
        }

        //Listar => Etapa: Sin Empezar
        List<Evento> I_ManejadorEvento.get_Eventos()
        {
            List<Evento> list = _db.Eventos
                .Include(x => x.torneo)
                .Select(x => x.GetEntity())
                .ToList();
            return list;
        }

        //Eliminar => Etapa: Sin Empezar
        bool I_ManejadorEvento.delete_Evento(int id_Evento)
        {
            return false;
        }
    }
}
