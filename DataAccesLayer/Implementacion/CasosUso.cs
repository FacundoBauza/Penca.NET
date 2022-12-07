using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
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

        List<DTPronostico> I_CasosUso.getPronosticos_Usuario(string username, int id_Penca, bool esCompartida)
        {
            List<DTPronostico> ret = new List<DTPronostico>();

            foreach(Pronostico x in _db.Pronosticos)
            {
                if(x.id_Penca == id_Penca && x.Username_Usuario.Equals(username) && x.esCompartida == esCompartida)
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

        List<DTPuntosUsuarioFront> I_CasosUso.getPuntaje_UsuarioPenca(int id_Penca, bool esCompartida)
        {
            List<string> u = null;
            List<DTPuntosUsuarioFront> auxV = new List<DTPuntosUsuarioFront>();

            int cont = 0;
            int id_Torneo = 0;
            bool ex = false;

            if (esCompartida == true)
            {
                u = _fu.obtenerUsuarios_PencaCompartida(id_Penca);
 
                foreach(string s in u)
                {
                    foreach (UsuarioPuntajes up in _db.usuarioPuntajes)
                    {
                        if (s.Equals(up.username) && id_Penca == up.id_Penca && up.esCompartida == esCompartida)
                        {
                            DTPuntosUsuarioFront dt = new DTPuntosUsuarioFront()
                            {
                                userna = up.username,
                                puntos = up.puntaje
                            };
                            auxV.Add(dt);
                            ex = true;
                        }
                    }
                    if(ex == false)
                    {
                        DTPuntosUsuarioFront dt = new DTPuntosUsuarioFront()
                        {
                            userna = s,
                            puntos = 0
                        };
                        auxV.Add(dt);
                    }
                }
            }
            else
            {
                u = _fu.obtenerUsuarios_PencaEmpresarial(id_Penca);

                foreach (string s in u)
                {
                    foreach (UsuarioPuntajes up in _db.usuarioPuntajes)
                    {
                        if (s.Equals(up.username) && id_Penca == up.id_Penca && up.esCompartida == esCompartida)
                        {
                            DTPuntosUsuarioFront dt = new DTPuntosUsuarioFront()
                            {
                                userna = up.username,
                                puntos = up.puntaje
                            };
                            auxV.Add(dt);
                            ex = true;
                        }
                    }
                    if (ex == false)
                    {
                        DTPuntosUsuarioFront dt = new DTPuntosUsuarioFront()
                        {
                            userna = s,
                            puntos = 0
                        };
                        auxV.Add(dt);
                    }
                }
            }

            

            return auxV;
        }
        void I_CasosUso.updatePuntaje_UsuarioPenca(int id_Penca, bool esCompartida)
        {
            List<Pronostico> aux = new List<Pronostico>();
            List<Eventos> auxX = new List<Eventos>();
            List<string> u = null;
            List<DTPuntosUsuarioFront> auxV = new List<DTPuntosUsuarioFront>();

            int cont = 0;
            int id_Torneo = 0;

            if (esCompartida == true)
            {
                u = _fu.obtenerUsuarios_PencaCompartida(id_Penca);
            }
            else
            {
                u = _fu.obtenerUsuarios_PencaEmpresarial(id_Penca);
            }

            foreach (string s in u)
            {
                foreach (Pronostico p in _db.Pronosticos)
                {
                    if (p.Username_Usuario.Equals(s) && p.id_Penca == id_Penca && p.esCompartida == esCompartida)
                    {
                        aux.Add(p);
                    }
                }
            }
            Console.WriteLine(aux.Count());

            if (esCompartida == true)
            {
                foreach (PencaCompartidas p in _db.PencasCompartidas)
                {
                    if (p.id_PencaCompartida == id_Penca)
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

            foreach (Eventos e in _db.Eventos)
            {
                if (e.id_Torneo == id_Torneo)
                {
                    auxX.Add(e);
                }
            }

            foreach(string s1 in u) 
            {
                foreach (Pronostico p1 in aux)
                {
                    if (p1.Username_Usuario.Equals(s1))
                    {
                        foreach (Eventos e1 in auxX)
                        {
                            if (e1.golesEquipo1 != "" && e1.golesEquipo1 != null && e1.golesEquipo2 != "" && e1.golesEquipo2 != null)
                            {
                                if (e1.id_Evento == p1.id_Evento)
                                {

                                    if ((e1.golesEquipo1 == e1.golesEquipo2) && (p1.golesEquipo1 == p1.golesEquipo2))
                                    {
                                        cont = cont + 3;
                                    }
                                    else if (Int32.Parse(e1.golesEquipo1) > Int32.Parse(e1.golesEquipo2) && p1.golesEquipo1 > p1.golesEquipo2)
                                    {
                                        cont = cont + 3;
                                    }
                                    else if (Int32.Parse(e1.golesEquipo1) < Int32.Parse(e1.golesEquipo2) && p1.golesEquipo1 < p1.golesEquipo2)
                                    {
                                        cont = cont + 3;
                                    }


                                    if (p1.golesEquipo1.ToString().Equals(e1.golesEquipo1))
                                    {
                                        cont = cont + 1;
                                    }

                                    if (p1.golesEquipo2.ToString().Equals(e1.golesEquipo2))
                                    {
                                        cont = cont + 1;
                                    }

                                }
                            }
                        }
                    }
                }

                UsuarioPuntajes auxd = null;

                if (_fu.existeUsuarioPuntaje(s1, id_Penca, esCompartida) == true)
                {
                    foreach (UsuarioPuntajes x in _db.usuarioPuntajes)
                    {
                        if (x.username.Equals(s1) && x.id_Penca == id_Penca)
                        {
                            auxd = x;
                        }
                    }

                    auxd.puntaje = cont;

                    _db.Update(auxd);
                    _db.SaveChanges();
                }
                else
                {
                    UsuarioPuntajes auxd2 = UsuarioPuntajes.GetObjetAdd(s1, id_Penca, cont, esCompartida);
                    _db.usuarioPuntajes.Add(auxd2);
                    _db.SaveChanges();
                }
                cont= 0;
            }
        }

        List<DTUsuario> I_CasosUso.getUsuariosPenca(int id_Penca, bool esCompartida)
        {
            List<string> u = null;
            DTUsuario x = null;
            List<DTUsuario> aux = new List<DTUsuario>();

            if(esCompartida == true)
            {
                u = _fu.obtenerUsuarios_PencaCompartida(id_Penca);
            }
            else
            {
                u = _fu.obtenerUsuarios_PencaEmpresarial(id_Penca);
            }

            foreach(string s in u)
            {
                foreach(Users us in _db.Users)
                {
                    if (us.UserName.Equals(s))
                    {
                        x = new DTUsuario()
                        {
                            Id = us.Id,
                            Nombre = us.nombre,
                            Apellido = us.apellido,
                            Email = us.Email,
                            Username = us.UserName,
                        };
                        aux.Add(x);
                    }
                }
            }

            return aux;
        }

        List<DTUsuario> I_CasosUso.getUsuarios()
        {
            return _db.Users.Select(x => x.GetEntity2()).ToList();
        }

        List<DTSubscripcion> I_CasosUso.getSubscripcionesUsuario(string username)
        {
            List<DTSubscripcion> ret = new List<DTSubscripcion>();

            foreach(Subscripciones s in _db.Subscripciones)
            {
                if (s.Username_Usuario.Equals(username))
                {
                    ret.Add(_cas.castDTSubscripciones(s));
                }
            }

            return ret;
        }
        bool I_CasosUso.updateUsuario(string username, string pass)
        {
            Users aux = null;

            foreach (Users u in _db.Users)
            {
                if (u.UserName.Equals(username))
                {
                    aux = u;
                }
            }

            try
            {
                aux.PasswordHash = pass;
                aux.nombre = "Loco";
                _db.Update(aux);
                _db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
           
        }

        Users I_CasosUso.getUsuario(string username)
        {
            foreach(Users u in _db.Users)
            {
                if (u.UserName.Equals(username))
                {
                    return u;
                }
            }

            return null;
        }
    }
}
