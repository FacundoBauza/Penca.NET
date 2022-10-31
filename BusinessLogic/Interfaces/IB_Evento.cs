using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IB_Evento
    {
        //Agregar
        bool agregar_Evento(Evento e);

        //Actualizar
        bool actualizar_Evento(Evento e);

        //Listar
        List<Evento> listar_Eventos();

        //Eliminar
        bool eliminar_Evento(int id_Evento);
    }
}
