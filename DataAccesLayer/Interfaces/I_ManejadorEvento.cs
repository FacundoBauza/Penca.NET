using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces
{
    public interface I_ManejadorEvento
    {
        //Agregar
        bool set_Evento(DTEvento e);

        //Actualizar
        bool update_Evento(Evento e);

        //Listar
        List<Eventos> get_Eventos();

        //Eliminar
        bool delete_Evento(int id_Evento);
    }
}
