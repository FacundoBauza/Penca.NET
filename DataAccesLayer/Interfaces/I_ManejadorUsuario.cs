using DataAccesLayer.Models;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces
{
    public interface I_ManejadorUsuario
    {
        //Login
        bool Login(string user, string pass);

        //Agregar
        bool add_Usuario(Users t);

        //Actuaizar
        bool update_Usuario(Usuario t);

        //Listar
        List<Usuario> get_Usuarios();

        //Eliminar
        bool delete_Usuario(int id_Usuario);
    }
}
