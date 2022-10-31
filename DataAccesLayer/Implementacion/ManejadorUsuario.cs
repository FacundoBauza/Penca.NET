using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementacion
{
    public class ManejadorUsuario: I_ManejadorUsuario
    {
        private readonly SolutionContext _db;
        public ManejadorUsuario(SolutionContext db)
        {
            _db = db;
        }

        //Login => Estado: Sin Empezar
        bool I_ManejadorUsuario.Login(string user, string pass)
        {
            return true;
        }

        //Agregar => Etapa: Sin Empezar
        bool I_ManejadorUsuario.add_Usuario(Usuario t)
        {
            return true;
        }

        //Actuaizar => Etapa: Sin Empezar
        bool I_ManejadorUsuario.update_Usuario(Usuario t)
        {
            return true;
        }

        //Listar => Etapa: Sin Empezar
        List<Usuario> I_ManejadorUsuario.get_Usuarios()
        {
            return new List<Usuario>();
        }

        //Eliminar => Etapa: Sin Empezar
        bool I_ManejadorUsuario.delete_Usuario(int id_Usuario)
        {
            return true;
        }
    }
}
