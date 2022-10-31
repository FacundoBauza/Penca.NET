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
    public class B_Evento: IB_Evento
    {
        private I_ManejadorEvento _dal;
        public B_Evento(I_ManejadorEvento dal)
        {
            _dal = dal;
        }

        //Agregar
        bool IB_Evento.agregar_Evento(Evento e)
        {
            return _dal.set_Evento(e);
        }

        //Actualizar
        bool IB_Evento.actualizar_Evento(Evento e)
        {
            return _dal.update_Evento(e);
        }

        //Listar
        List<Evento> IB_Evento.listar_Eventos()
        {
            return _dal.get_Eventos();
        }

        //Eliminar
        bool IB_Evento.eliminar_Evento(int id_Evento)
        {
            return _dal.delete_Evento(id_Evento);
        }
    }
}
