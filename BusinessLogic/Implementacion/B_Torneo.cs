using BusinessLogic.Interfaces;
using DataAccesLayer.Implementacion;
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
    public class B_Torneo : IB_Torneo
    {
        private I_ManejadorTorneo _dal;
        public B_Torneo(I_ManejadorTorneo dal)
        {
            _dal = dal;
        }

        //Agregar
        bool IB_Torneo.agregar_Torneo(DTTorneo t)
        {
            return _dal.add_Torneo(t);
        }

        //Actualizar
        bool IB_Torneo.actualizar_Torneo(Torneo t)
        {
            return _dal.update_Torneo(t);
        }

        //Listar
        List<Torneo> IB_Torneo.listar_Torneos()
        {
            return _dal.get_Torneos();
        }

        //Eliminar
        bool IB_Torneo.eliminar_Torneo(int id_Torneo)
        {
            return _dal.delete_Torneo(id_Torneo);
        }
    }
}
