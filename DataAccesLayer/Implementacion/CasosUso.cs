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
    public class CasosUso: I_CasosUso
    {
        private readonly SolutionContext _db;
        private I_Functions _fu;
        private I_Casteos _cas;
        public CasosUso(SolutionContext db, I_Functions fu, I_Casteos cas)
        {
            _db = db;
            _fu = fu;
            _cas = cas;
        }

        List<DTPronostico> I_CasosUso.getPronosticos_Usuario(string username, int id_Penca)
        {
            List<DTPronostico> ret = new List<DTPronostico>();

            foreach(Pronostico x in _db.Pronosticos)
            {
                if(x.id_Penca == id_Penca && x.Username_Usuario.Equals(username))
                {
                    ret.Add(_cas.castDTPronostico(x));
                }
            }

            return ret;
        }

        List<DTEvento> I_CasosUso.getEventosTorneo(int id)
        {

            if (id != null)
            {
                if (_db.Torneos.Count() > 0)
                {
                    if (_fu.existeTorneoId(id))
                    {
                        List<DTEvento> ret = new List<DTEvento>();

                        foreach (Eventos e in _db.Eventos)
                        {
                            if (e.id_Torneo == id)
                            {
                                ret.Add(_cas.castDTEvento(e));
                            }
                        }
                        return ret;
                    }
                    else
                        return null;
                }
                else
                    return null;
            }
            else
                return null;
        }
    }
}
