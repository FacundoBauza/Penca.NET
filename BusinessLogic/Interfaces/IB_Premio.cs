using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IB_Premio
    {
        //Otorgar Premio
        bool agregar_Premio(Premio p);

        //Listar Premios
        List<Premio> listar_Premios(int id_Usuario);

        //Cobrar Premio
        bool Cobrar_Premio(int id_usuario, int id_Penca);
    }
}
