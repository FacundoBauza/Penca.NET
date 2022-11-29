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
        bool I_ManejadorTorneo.add_Torneo(Torneo t)
        {
            Torneos aux = Torneos.GetObjetAdd(t);
            _db.Torneos.Add(aux);
            _db.SaveChanges();

            return true;
        }

        //Actuaizar => Etapa: Sin Empezar
        bool I_ManejadorTorneo.update_Torneo(Torneo t)
        {
            //PAra implementar
            return true;
        }

        //Listar => Etapa: Terminado para Testear
        List<DTTorneo> I_ManejadorTorneo.get_Torneos()
        {
            List<DTTorneo> list = _db.Torneos.Select(x => x.GetEntity())
                                            .ToList();
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
