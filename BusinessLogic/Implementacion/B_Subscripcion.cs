using BusinessLogic.Interfaces;
using DataAccesLayer.Interfaces;
using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementacion
{
    public class B_Subscripcion: IB_Subscripcion
    {
        private I_ManejadorSubscripcion _dal;
        public B_Subscripcion(I_ManejadorSubscripcion dal)
        {
            _dal = dal;
        }

        //Agregar Suscripcion
        bool IB_Subscripcion.agregar_Subscripcion(DTSubscripcion s)
        {
            return _dal.set_Subscripcion(s);
        }

        //Listar Subscripciones
        List<Subscripcion> IB_Subscripcion.listar_Subscripciones(int id_Usuario)
        {
            return _dal.get_Subscripciones(id_Usuario);
        }
    }
}
