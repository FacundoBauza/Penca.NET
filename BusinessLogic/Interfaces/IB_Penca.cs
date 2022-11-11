using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IB_Penca
    {
        //Agregar
        bool agregar_PencaCompartida(PencaCompartida pc);
        bool agregar_PencaEmpresarial(PencaEmpresarial pe);

        //Actualizar
        bool actualizar_PencaCompartida(PencaCompartida pc);
        bool actualizar_PencaEmpresarial(PencaEmpresarial pe);

        //Listar
        List<PencaCompartida> listar_PencaCompartida();
        List<PencaEmpresarial> listar_PencaEmpresarial();

        //Eliminar
        bool eliminar_PencaCompartida(int id_PencaC);
        bool eliminar_PencaEmpresarial(int id_PencaE);

    }
}
