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
    public class B_Premio: IB_Premio
    {
        private I_ManejadorPremio _dal;
        public B_Premio(I_ManejadorPremio dal)
        {
            _dal = dal;
        } 

        //Otorgar Premio
        bool IB_Premio.agregar_Premio(DTPremio p)
        {
            return _dal.set_Premio(p);
        }

        //Listar Premios
        List<DTPremio> IB_Premio.listar_Premios()
        {
            return _dal.get_Premios();
        }

        //Cobrar Premio
        bool IB_Premio.Pagar_Premio(string username, int id_Penca)
        {
            return _dal.Pagar_Premio(username, id_Penca);
        }

        //listar porcentajes
        List<int> IB_Premio.listarPorcentajes(int id_Criterio)
        {
            return _dal.getPorcentajes(id_Criterio);
        }
    }
}
