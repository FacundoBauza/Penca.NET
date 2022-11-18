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
        private I_Functions _fu;
        public B_Evento(I_ManejadorEvento dal, I_Casteos cas, I_Functions fu)
        {
            _dal = dal;
            _cas = cas;
            _fu = fu;
        }

        //Agregar
        MensajesEnum IB_Evento.agregar_Evento(DTEvento e)
        {
            MensajesEnum men = new MensajesEnum();  
            if(e != null)
            {
                if(!_fu.existeEvento(e))
                {
                    if (_fu.existeTorneoId(e.torneo))
                    {
                        if (_dal.set_Evento(e) == true)
                        {
                            men.El_Evento_se_guardo_Correctamente();
                            return men;
                        }
                        else
                        {
                            men.Exepcion_no_Controlada();
                            return men;
                        }
                    }
                    else
                    {
                        men.No_existe_un_Torneo_con_el_Id_ingresado();
                        return men;
                    }
                }
                else
                {
                    men.Ya_existe_un_Evento_con_el_Nombre_ingresado();
                    return men;
                }
            }
            else
            {
                men.El_Objeto_enviado_es_Nulo();
                return men;
            }
       
        }

        //Actualizar
        MensajesEnum IB_Evento.actualizar_Evento(DTEvento e)
        {
            MensajesEnum men = new MensajesEnum();
            if (e != null)
            {
                if (_fu.existeTorneoId(e.torneo))
                {
                    if (_dal.update_Evento(e) == true)
                    {
                        men.El_Evento_se_actualizo_Correctamente();
                        return men;
                    }
                    else
                    {
                        men.Exepcion_no_Controlada();
                        return men;
                    }
                }
                else
                {
                    men.No_existe_un_Torneo_con_el_Id_ingresado();
                    return men;
                }
            }
            else
            {
                men.El_Objeto_enviado_es_Nulo();
                return men;
            }

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
