using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Dominio.Entidades;

namespace DataAccesLayer.Implementacion
{
    public class ManejadorPenca : I_ManejadorPenca
    {
        private readonly SolutionContext _db;

        public ManejadorPenca(SolutionContext db)
        {
            _db = db;
        }

        public List<PencaCompartida> ListPencaCompartida()
        {
            /*return _db.Torneos
            .Include(x => x.pencasCompartidas)
            .Include(x => x.pencasEmpresariales)
            .Where(x => x.nombre == "Copa Libertadores" && x.nombre == "Copa Sudamericana")
            .Select(x => x.GetEntity()).ToList();*/
            return null;
        }

        public List<PencaEmpresarial> ListPencaEmpresarial()
        {
            /*return _db.Torneos
            .Include(x => x.pencasCompartidas)
            .Include(x => x.pencasEmpresariales)
            .Where(x => x.nombre == "Copa Libertadores" && x.nombre == "Copa Sudamericana")
            .Select(x => x.GetEntity()).ToList();*/
            return null;
        }
    }
}
