using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IB_Usuario
    {
        //Agregar
        bool agregar_Usuario(Usuario t);

        //Actualizar
        bool actualizar_Usuario(Usuario t);

        //Listar
        List<Usuario> listar_Usuarios();

        //Eliminar
        bool eliminar_Usuario(int id_Usuario);
    }
}
