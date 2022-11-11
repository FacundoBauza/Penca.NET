﻿using DataAccesLayer.Interfaces;
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
            return false;
        }

        //Listar => Etapa: Sin Empezar
        List<Evento> I_ManejadorEvento.get_Eventos()
        {
            return new List<Evento>();
        }

        //Eliminar => Etapa: Sin Empezar
        bool I_ManejadorEvento.delete_Evento(int id_Evento)
        {
            return false;
        }
    }
}
