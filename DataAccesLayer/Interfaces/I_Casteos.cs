using DataAccesLayer.Models;
using Dominio.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces
{
    public interface I_Casteos
    {
        DTEvento castDTEvento(Eventos x);
        DTPencaCompartida castDTPencaCompartida(PencaCompartidas x);
        DTPencaEmpresarial castDTPencaEmpresarial(PencaEmpresariales x);
    }
}
