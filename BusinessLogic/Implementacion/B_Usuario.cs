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
    public class B_Usuario: IB_Usuario
    {
        private I_ManejadorUsuario _dal;
        public B_Usuario(I_ManejadorUsuario dal)
        {
            _dal = dal;
        }

        //Agregar
        bool IB_Usuario.agregar_Usuario(Usuario t)
        {
            return _dal.add_Usuario(t);
        }

        //Actualizar
        bool IB_Usuario.actualizar_Usuario(Usuario t)
        {
            return _dal.update_Usuario(t);
        }

        //Listar
        List<Usuario> IB_Usuario.listar_Usuarios()
        {
            return _dal.get_Usuarios();
        }

        //Eliminar
        bool IB_Usuario.eliminar_Usuario(int id_Usuario)
        {
            return _dal.delete_Usuario(id_Usuario);
        }
    }
}
