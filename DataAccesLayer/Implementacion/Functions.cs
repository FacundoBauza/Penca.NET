using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Dominio.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementacion
{
    public class Functions: I_Functions
    {
        private readonly SolutionContext _db;
        public Functions(SolutionContext db)
        {
            _db = db;
        }

        public Functions()
        {
        }

        List<int> I_Functions.obtenerPorcentajesPremio(int id)
        {
            if (id != null)
            {
                List<int> aux = new List<int>();
                foreach(PorcentajesPremios p in _db.porcentajePremios)
                {
                    if (p.id_CriterioPremio == id)
                    {
                        aux.Add(p.porcentaje);
                    }
                }

                if (aux != null)
                    return aux;
                else
                    return null;
            }
            else
                return null;
            
        }

        List<int> I_Functions.obtenerEventosTorneo(int id)
        {
            throw new NotImplementedException();
        }

        List<DTPencaCompartida> I_Functions.obtenerPencaCompartida_Usuario(string username)
        {
            throw new NotImplementedException();
        }

        List<DTPencaEmpresarial> I_Functions.obtenerPencaEmpresarial_Usuario(string username)
        {
            throw new NotImplementedException();
        }

        List<DTEvento> I_Functions.obtenerEventos_Torneo(int id_Torneo)
        {
            throw new NotImplementedException();
        }

        DTTorneo I_Functions.obtenerTorneo_Penca(int id_Penca)
        {
            throw new NotImplementedException();
        }

        List<DTSubscripcion> I_Functions.obtenerSubscripciones_Usuario(string username)
        {
            throw new NotImplementedException();
        }

        List<DTUsuario> I_Functions.obtenerUsuarios_PencaCompartida(int id_Penca)
        {
            throw new NotImplementedException();
        }

        List<DTUsuario> I_Functions.obtenerUsuarios_PencaEmpresarial(int id_Penca)
        {
            throw new NotImplementedException();
        }

        DTPencaEmpresarial I_Functions.obtenerInfo_PencaEmpresarial(int id_Penca)
        {
            throw new NotImplementedException();
        }

        DTPencaCompartida I_Functions.obtenerInfo_PencaCompartida(int id_Penca)
        {
            throw new NotImplementedException();
        }




        //Chequeos
        bool I_Functions.existePencaCompartida(string nombre)
        {
            if (_db.PencasCompartidas.Count() > 0)
            {
                foreach (PencaCompartidas p in _db.PencasCompartidas) {
                    if(p.nombre.Equals(nombre))
                        return true;
                }
                return false;
            }
            else
                return false;
        }

        bool I_Functions.existePencaEmpresarial(string nombre)
        {
            if (_db.PencasEmpresariales.Count() > 0)
            {
                foreach (PencaEmpresariales p in _db.PencasEmpresariales)
                {
                    if (p.nombre.Equals(nombre))
                        return true;
                }
                return false;
            }
            else
                return false;
        }

        bool I_Functions.existeTorneo(string nombre)
        {
            if (_db.Torneos.Count() > 0)
            {
                foreach (Torneos t in _db.Torneos)
                {
                    if (t.nombre.Equals(nombre))
                        return true;
                }
                return false;
            }
            else
                return false;
        }

        bool I_Functions.existeTorneoId(int id)
        {
            if (_db.Torneos.Count() > 0)
            {
                foreach (Torneos t in _db.Torneos)
                {
                    if (t.id_Torneo == id)
                        return true;
                }
                return false;
            }
            else
                return false;
        }

        bool I_Functions.existeUsuario(string nombre)
        {
            if (_db.Users.Count() > 0)
            {
                foreach (Users t in _db.Users)
                {
                    if (t.UserName.Equals(nombre))
                        return true;
                }
                return false;
            }
            else
                return false;
        }

        bool I_Functions.existeEvento(DTEvento de)
        {
            if (_db.Eventos.Count() > 0)
            {
                foreach (Eventos e in _db.Eventos)
                {
                    if (e.equipo1.Equals(de.equipo1) && e.equipo1.Equals(de.equipo2) 
                                  && DateTime.Compare(de.fechaHora, e.fechaHora) == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }

        bool I_Functions.existePronostico(DTPronostico dp)
        {
            if (_db.Pronosticos.Count() > 0)
            {
                foreach (Pronostico e in _db.Pronosticos)
                {
                    if (e.Username_Usuario.Equals(dp.username) && e.id_Evento == dp.id_Evento)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }
    }
}
