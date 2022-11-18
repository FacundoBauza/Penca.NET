using BusinessLogic.Interfaces;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementacion
{
    public class B_Evento: IB_Evento
    {
        private I_ManejadorEvento _dal;
        private I_Casteos _cas;
        public B_Evento(I_ManejadorEvento dal, I_Casteos cas)
        {
            _dal = dal;
            _cas = cas;
        }

        //Agregar
        bool IB_Evento.agregar_Evento(DTEvento e)
        {
            return _dal.set_Evento(e);
        }

        //Actualizar
        bool IB_Evento.actualizar_Evento(Evento e)
        {
            return _dal.update_Evento(e);
        }

        //Listar
        List<DTEvento> IB_Evento.listar_Eventos()
        {
            List<DTEvento> eventos = new List<DTEvento>();
            foreach(Eventos x in _dal.get_Eventos())
            {
                eventos.Add(_cas.castDTEvento(x));
            }

            return eventos;
        }

        //Eliminar
        bool IB_Evento.eliminar_Evento(int id_Evento)
        {
            return _dal.delete_Evento(id_Evento);
        }
    }
}
