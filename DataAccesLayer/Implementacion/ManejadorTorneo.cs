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
    public class ManejadorTorneo: I_ManejadorTorneo
    {
        private readonly SolutionContext _db;
        public ManejadorTorneo(SolutionContext db)
        {
            _db = db;
        }

        //Agregar => Etapa: Terminado para Testear
        bool I_ManejadorTorneo.add_Torneo(DTTorneo t)
        {
            Torneos aux = Torneos.GetObjetAdd(t);
            _db.Torneos.Add(aux);
            _db.SaveChanges();

            return true;
        }

        //Actuaizar => Etapa: Sin Empezar
        bool I_ManejadorTorneo.update_Torneo(Torneo t)
        {
            var torneo = _db.Torneos.SingleOrDefault(tor => tor.id == t.id);
            if (torneo != null)
            {
                if (t.nombre != null) torneo.nombre = t.nombre;
                torneo.fechaInicio = t.fechaInicio;
                torneo.fechaFin = t.fechaFin;
                _db.SaveChanges();

                return true;
            }
            return false;
        }

        //Listar => Etapa: Terminado para Testear
        List<Torneo> I_ManejadorTorneo.get_Torneos()
        {
            List<Torneo> list = _db.Torneos.Include(x => x.eventos)
                                           .Select(x => x.GetEntity())
                                           .ToList();
            List<Evento> list2 = _db.Eventos.Select(x => x.GetEntity())
                                            .ToList();
            foreach(Torneo t in list)
            {
                foreach(Evento e in list2)
                {
                    if(e.torneo.id == t.id)
                    {
                        t.eventos.Add(e);
                    }
                }
            }

            return list;
        }

        //Eliminar => Etapa: Sin Empezar
        bool I_ManejadorTorneo.delete_Torneo(int id_Torneo)
        {
            //PAra implementar
            return true;
        }
    }
}
