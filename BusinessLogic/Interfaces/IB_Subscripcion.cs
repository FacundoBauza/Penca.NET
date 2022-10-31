using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IB_Subscripcion
    {
        //Agregar Suscripcion
        bool agregar_Subscripcion(Subscripcion s);

        //Listar Subscripciones
        List<Subscripcion> listar_Subscripciones(int id_Usuario);
    }
}
