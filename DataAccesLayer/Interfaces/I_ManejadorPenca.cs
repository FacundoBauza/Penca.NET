using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces
{
    public interface I_ManejadorPenca
    {
        //Agregar
        bool set_PencaCompartida(PencaCompartida pc);
        bool set_PencaEmpresarial(PencaEmpresarial pe);

        //Actualizar
        bool update_PencaCompartida(PencaCompartida pc);
        bool update_PencaEmpresarial(PencaEmpresarial pe);

        //Listar
        List<PencaCompartida> get_PencaCompartida();
        List<PencaEmpresarial> get_PencaEmpresarial();

        //Eliminar
        bool delete_PencaCompartida(int id_PencaC);
        bool delete_PencaEmpresarial(int id_PencaL);
    }
}
