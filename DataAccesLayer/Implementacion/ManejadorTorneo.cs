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

        List<Torneo> I_ManejadorTorneo.ListTorneos()
        {
            return _db.Torneos.Select(x => x.GetEntity(_db)).ToList();
        }
    }
}
