using Dominio.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces
{
    public interface I_CasosUso
    {
        List<DTEvento> getEventosTorneo(int id);
        List<DTPronostico> getPronosticos_Usuario(string username, int id_Penca);
    }
}
