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

        //Agregar Compartida => Etapa: Sin Empezar
        bool I_ManejadorPenca.set_PencaCompartida(PencaCompartida pc)
        {
            return false;
        }

        //Agregar Empresarial => Etapa: Sin Empezar
        bool I_ManejadorPenca.set_PencaEmpresarial(PencaEmpresarial pe)
        {
            return false;
        }

        //Actualizar Compartida => Etapa: Sin Empezar
        bool I_ManejadorPenca.update_PencaCompartida(PencaCompartida pc)
        {
            return false;
        }

        //Actualizar Empresarial => Etapa: Sin Empezar
        bool I_ManejadorPenca.update_PencaEmpresarial(PencaEmpresarial pe)
        {
            return false;
        }

        //Listar Compartida => Etapa: Sin Empezar
        List<PencaCompartida> I_ManejadorPenca.get_PencaCompartida()
        {
            return new List<PencaCompartida>();
        }

        //Listar Empresarial => Etapa: Sin Empezar
        List<PencaEmpresarial> I_ManejadorPenca.get_PencaEmpresarial()
        {
            return new List<PencaEmpresarial>();
        }

        //Eliminar Compartida => Etapa: Sin Empezar
        bool I_ManejadorPenca.delete_PencaCompartida(int id_PencaC)
        {
            return false;
        }

        //Eliminar Empresarial => Etapa: Sin Empezar
        bool I_ManejadorPenca.delete_PencaEmpresarial(int id_PencaE)
        {
            return false;
        }
    }
}
