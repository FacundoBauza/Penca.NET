using DataAccesLayer.Interfaces;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementacion
{
    public class ManejadorSubscripcion: I_ManejadorSubscripcion
    {

        //Agregar Suscripcion => Etapa: Sin Empezar
        bool I_ManejadorSubscripcion.set_Subscripcion(Subscripcion s)
        {
            return true;
        }

        //Listar Subscripciones => Etapa: Sin Empezar
        List<Subscripcion> I_ManejadorSubscripcion.get_Subscripciones(int id_Usuario)
        {
            return new List<Subscripcion>();
        }
    }
}
