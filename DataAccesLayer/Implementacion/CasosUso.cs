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

        int I_CasosUso.getPuntaje_UsuarioPenca(string username, int id_Penca, bool esCompartida)
        {
            List<DTPronostico> aux = new List<DTPronostico>();
            List<Eventos> auxX = new List<Eventos>();
            int cont = 0;
            int id_Torneo = 0;

            foreach (Pronostico x in _db.Pronosticos)
            {
                if (x.id_Penca == id_Penca && x.Username_Usuario.Equals(username))
                {
                    aux.Add(_cas.castDTPronostico(x));
                }
            }

            if (esCompartida == true)
            {
                foreach (PencaCompartidas p in _db.PencasCompartidas)
                {
                    if(p.id_PencaCompartida == id_Penca)
                    {
                        id_Torneo = p.id_Torneo;
                    }
                }
            }
            else
            {
                foreach (PencaEmpresariales p in _db.PencasEmpresariales)
                {
                    if (p.id_PencaEmpresarial == id_Penca)
                    {
                        id_Torneo = p.id_Torneo;
                    }
                }
            }

            foreach(Eventos e in _db.Eventos)
            {
                if(e.id_Torneo == id_Torneo)
                {
                    auxX.Add(e);
                }
            }

            foreach (DTPronostico p1 in aux)
            {
                foreach(Eventos e1 in auxX)
                {
                    if(p1.id_Evento == e1.id_Evento)
                    {
                        //Esto evalua que la fecha actual es menor a la del evento para saber
                        //si el evento ya paso.
                        if (DateTime.Compare(DateTime.Today, e1.fechaHora) > 0)
                        {
                            if (e1.resultado.Equals("EMPATE") && p1.golesEquipo1 == p1.golesEquipo2)
                            {
                                cont = cont + 1;
                            }
                            else if (e1.resultado.Equals("EQUIPO1") && p1.golesEquipo1 > p1.golesEquipo2)
                            {
                                cont = cont + 3;
                            }
                            else if (e1.resultado.Equals("EQUIPO2") && p1.golesEquipo1 < p1.golesEquipo2)
                            {
                                cont = cont + 3;
                            }


                            if(p1.golesEquipo1.ToString().Equals(e1.golesEquipo1) && p1.golesEquipo2.ToString().Equals(e1.golesEquipo2))
                            {
                                cont= cont + 2;
                            }
                        }
                    }
                }
            }

            return cont;
        }
    }
}
