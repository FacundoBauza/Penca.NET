using Dominio.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IB_CasosUso
    {
        List<DTEvento> obtenerEventosTorneo(int id);
        List<int> obtenerPorcentajesPremio(int id);
        List<DTPencaCompartida> obtenerPencaCompartida_Usuario(string username);
        List<DTPencaEmpresarial> obtenerPencaEmpresarial_Usuario(string username);
        List<DTEvento> obtenerEventos_Torneo(int id_Torneo);
        DTTorneo obtenerTorneo_Penca(int id_Penca);
        List<DTSubscripcion> obtenerSubscripciones_Usuario(string username);
        List<DTUsuario> obtenerUsuarios_PencaCompartida(int id_Penca);
        List<DTUsuario> obtenerUsuarios_PencaEmpresarial(int id_Penca);
        DTPencaEmpresarial obtenerInfo_PencaEmpresarial(int id_Penca);
        DTPencaCompartida obtenerInfo_PencaCompartida(int id_Penca);
    }
}
