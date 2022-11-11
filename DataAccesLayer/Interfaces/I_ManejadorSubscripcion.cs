using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces
{
    public interface I_ManejadorSubscripcion
    {
        //Agregar Suscripcion
        bool set_Subscripcion(Subscripcion s);

        //Listar Subscripciones
        List<Subscripcion> get_Subscripciones(int id_Usuario);
    }
}
