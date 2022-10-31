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
    public class B_Premio: IB_Premio
    {
        private I_ManejadorPremio _dal;
        public B_Premio(I_ManejadorPremio dal)
        {
            _dal = dal;
        } 

        //Otorgar Premio
        bool IB_Premio.agregar_Premio(Premio p)
        {
            return _dal.set_Premio(p);
        }

        //Listar Premios
        List<Premio> IB_Premio.listar_Premios(int id_Usuario)
        {
            return _dal.get_Premios(id_Usuario);
        }

        //Cobrar Premio
        bool IB_Premio.Cobrar_Premio(int id_usuario, int id_Penca)
        {
            return _dal.Cobrar_Premio(id_usuario, id_Penca);
        }
    }
}
