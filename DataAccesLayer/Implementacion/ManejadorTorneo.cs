using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
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

        //Agregar
        bool I_ManejadorTorneo.add_Torneo(Torneo t)
        {
            Torneos t1 = new Torneos();
            t1.addData(t);
            _db.Add(t1);

            return true;
        }

        //Actuaizar
        bool I_ManejadorTorneo.update_Torneo(Torneo t)
        {
            //PAra implementar
            return true;
        }

        //Listar
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

        //Eliminar
        bool I_ManejadorTorneo.delete_Torneo(int id_Torneo)
        {
            //PAra implementar
            return true;
        }
    }
}
