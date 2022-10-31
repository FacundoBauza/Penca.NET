using BusinessLogic.Interfaces;
using DataAccesLayer.Interfaces;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementacion
{
    public class B_Penca: IB_Penca
    {
        private I_ManejadorPenca _dal;
        public B_Penca(I_ManejadorPenca dal)
        {
            _dal = dal;
        }

        //Agregar
        bool IB_Penca.agregar_PencaCompartida(PencaCompartida pc) 
        {
            return _dal.set_PencaCompartida(pc);
        }

        bool IB_Penca.agregar_PencaEmpresarial(PencaEmpresarial pe) 
        {
            return _dal.set_PencaEmpresarial(pe);
        }

        //Actualizar
        bool IB_Penca.actualizar_PencaCompartida(PencaCompartida pc) 
        {
            return _dal.update_PencaCompartida(pc);
        }

        bool IB_Penca.actualizar_PencaEmpresarial(PencaEmpresarial pe) 
        {
            return _dal.update_PencaEmpresarial(pe);
        }

        //Listar
        List<PencaCompartida> IB_Penca.listar_PencaCompartida()
        {
            return _dal.get_PencaCompartida();
        }

        List<PencaEmpresarial> IB_Penca.listar_PencaEmpresarial() 
        {
            return _dal.get_PencaEmpresarial();
        }

        //Eliminar
        bool IB_Penca.eliminar_PencaCompartida(int id_PencaC)
        {
            return _dal.delete_PencaCompartida(id_PencaC);
        }

        bool IB_Penca.eliminar_PencaEmpresarial(int id_PencaE)
        {
            return _dal.delete_PencaEmpresarial(id_PencaE);
        }

    }
}
