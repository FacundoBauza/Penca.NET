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

        //Agregar
        bool I_ManejadorPenca.set_PencaCompartida(PencaCompartida pc)
        {
            return false;
        }

        bool I_ManejadorPenca.set_PencaEmpresarial(PencaEmpresarial pe)
        {
            return false;
        }

        //Actualizar
        bool I_ManejadorPenca.update_PencaCompartida(PencaCompartida pc)
        {
            return false;
        }

        bool I_ManejadorPenca.update_PencaEmpresarial(PencaEmpresarial pe)
        {
            return false;
        }

        //Listar
        List<PencaCompartida> I_ManejadorPenca.get_PencaCompartida()
        {
            return new List<PencaCompartida>();
        }

        List<PencaEmpresarial> I_ManejadorPenca.get_PencaEmpresarial()
        {
            return new List<PencaEmpresarial>();
        }

        //Eliminar
        bool I_ManejadorPenca.delete_PencaCompartida(int id_PencaC)
        {
            return false;
        }

        bool I_ManejadorPenca.delete_PencaEmpresarial(int id_PencaE)
        {
            return false;
        }
    }
}
