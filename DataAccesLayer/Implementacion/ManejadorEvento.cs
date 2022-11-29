using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

        //Agregar => Etapa: Terminado
        bool I_ManejadorEvento.set_Evento(DTEvento e)
        {
            Eventos aux = Eventos.GetObjetAdd(e);

            try
            {
                _db.Eventos.Add(aux);
                _db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Actualizar => Etapa: Sin Empezar
        bool I_ManejadorEvento.update_Evento(DTEvento e)
        {
            Eventos aux = null;

            foreach (Eventos x in _db.Eventos)
            {
                if (x.id_Evento == e.id)
                {
                    aux = x;
                }
            }

            aux.equipo1 = e.equipo1;
            aux.equipo2 = e.equipo2;
            aux.golesEquipo1 = e.golesEquipo1;
            aux.golesEquipo2 = e.golesEquipo2;
            aux.resultado = e.resultado;
            //aux.fechaHora = e.fechaHora;
            aux.id_Torneo = e.torneo;

            try
            {
                _db.Update(aux);
                _db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
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
