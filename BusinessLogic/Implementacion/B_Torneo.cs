using BusinessLogic.Interfaces;
using DataAccesLayer.Implementacion;
using DataAccesLayer.Interfaces;
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

        List<Torneo> IB_Torneo.getTorneos()
        {
            return _dal.ListTorneos();
        }
    }
}
