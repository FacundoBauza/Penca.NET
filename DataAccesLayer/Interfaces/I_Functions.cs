using DataAccesLayer.Models;
using Dominio.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces
{
    public interface I_Functions
    {
        List<int> obtenerPorcentajesPremio(int id);
        List<int> obtenerEventosTorneo(int id);
        List<DTPencaCompartida> obtenerPencaCompartida_Usuario(string username);
        List<DTPencaEmpresarial> obtenerPencaEmpresarial_Usuario(string username);
        DTTorneo obtenerTorneo_Penca(int id_Penca);
        List<DTSubscripcion> obtenerSubscripciones_Usuario(string username);
        List<string> obtenerUsuarios_PencaCompartida(int id_Penca);
        List<string> obtenerUsuarios_PencaEmpresarial(int id_Penca);
        DTPencaEmpresarial obtenerInfo_PencaEmpresarial(int id_Penca);
        DTPencaCompartida obtenerInfo_PencaCompartida(int id_Penca);
        Users retornarUsuasrio(string username);

        //Chequeos
        bool existePencaCompartida(string nombre);
        bool existePencaEmpresarial(string nombre);
        bool existeTorneo(string nombre);
        bool existeTorneoId(int id);
        bool existeUsuario(string nombre);
        bool existeEvento(DTEvento de);
        bool existePronostico(DTPronostico dp);
        bool existeSubscripcion(DTSubscripcion ds);
        bool existeUsuarioPuntaje(string s, int id_Penca);
        bool perteneceUsuarioPenca(DTUsuarioPenca dp);
    }
}
