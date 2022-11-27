using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Dominio.DT;
using System.Drawing;
using System.Data.Entity;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.Arm;
using System.Diagnostics.SymbolStore;

namespace DataAccesLayer.Implementacion
{
    public class ManejadorPenca : I_ManejadorPenca
    {
        private readonly SolutionContext _db;
        private I_Functions _fu;
        private I_Casteos _cas;
        private I_CasosUso _cau;
        public ManejadorPenca(SolutionContext db, I_Functions fu, I_Casteos cas, I_CasosUso cau)
        {
            _db = db;
            _fu = fu;
            _cas = cas;
            _cau = cau;
        }

        //Agregar Compartida => Etapa: Terminada
        bool I_ManejadorPenca.set_PencaCompartida(PencaCompartidas pc, CriterioPremio cp)
        {
            CriterioPremios aux = new CriterioPremios()
            {
                cantGanadores = cp.cantGanadores
            };
            _db.criterioPremios.Add(aux);
            _db.SaveChanges();

            int cont1 = 0;
            foreach(CriterioPremios cx in _db.criterioPremios)
            {
                cont1 = cx.id_CriterioPremio;
            }
            pc.id_CriterioPremio = cont1;
            int cont = 1;
            foreach(int x in cp.porcentajes)
            {
                PorcentajesPremios aux3 = new PorcentajesPremios()
                {
                    porcentaje = x,
                    posicion = cont,
                    id_CriterioPremio = cont1
                };
                _db.porcentajePremios.Add(aux3);
                _db.SaveChanges();
                cont++;
            }
  
            try
            {    
                _db.PencasCompartidas.Add(pc);
                _db.SaveChanges();

            }
            catch
            {
                return false;
            }
            return true;
        }

        //Agregar Empresarial => Etapa: Terminada
        bool I_ManejadorPenca.set_PencaEmpresarial(PencaEmpresariales pe)
        {
            try
            {
                _db.PencasEmpresariales.Add(pe);
                _db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Actualizar Compartida => Etapa: Terminada
        bool I_ManejadorPenca.update_PencaCompartida(DTPencaCompartida pc)
        {
            PencaCompartidas aux = null;
            foreach(PencaCompartidas x in _db.PencasCompartidas)
            {
                if(x.id_PencaCompartida == pc.id)
                {
                    aux = x;
                }
            }

            aux.nombre = pc.nombre;
            aux.id_Torneo = pc.torneo;

            try
            {
                _db.Update(aux);
                _db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Actualizar Empresarial => Etapa: Terminada
        bool I_ManejadorPenca.update_PencaEmpresarial(DTPencaEmpresarial pe)
        {
            PencaEmpresariales aux = null;

            foreach (PencaEmpresariales x in _db.PencasEmpresariales)
            {
                if (x.id_PencaEmpresarial == pe.id)
                {
                    aux = x;
                }
            }

            aux.nombre = pe.nombre;
            aux.id_Torneo = pe.torneo;
            aux.link = pe.link;


            try
            {
                _db.Update(aux);
                _db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Listar Compartida => Etapa: Terminada
        List<DTPencaCompartida> I_ManejadorPenca.get_PencaCompartida()
        {
            if (_db.PencasCompartidas.Count() > 0)
            {
                List<DTPencaCompartida> ret = new List<DTPencaCompartida>();

                foreach (PencaCompartidas pc in _db.PencasCompartidas)
                {
                    ret.Add(_cas.castDTPencaCompartida(pc));
                }

                return ret;
            }

            return null;
        }

        //Listar Empresarial => Etapa: Terminada
        List<DTPencaEmpresarial> I_ManejadorPenca.get_PencaEmpresarial()
        {
            if (_db.PencasEmpresariales.Count() > 0)
            {
                List<DTPencaEmpresarial> ret = new List<DTPencaEmpresarial>();

                foreach (PencaEmpresariales pe in _db.PencasEmpresariales)
                {
                    ret.Add(_cas.castDTPencaEmpresarial(pe));
                }

                return ret;
            }

            return null;
        }

        //Eliminar Compartida => Etapa: Sin Empezar
        bool I_ManejadorPenca.delete_PencaCompartida(int id_PencaC)
        {
            return false;
        }

        //Eliminar Empresarial => Etapa: Sin Empezar
        bool I_ManejadorPenca.delete_PencaEmpresarial(int id_PencaE)
        {
            return false;
        }

        //Agregar Pronostico
        bool I_ManejadorPenca.setPronostico(DTPronostico dp)
        {
            Pronostico aux = null;

            if (_fu.existePronostico(dp))
            {
                try
                {
                    foreach(Pronostico x in _db.Pronosticos)
                    {
                        if(x.Username_Usuario.Equals(dp.username) && x.id_Evento == dp.id_Evento)
                        {
                            aux = x;
                        }
                    }

                    aux.golesEquipo1 = dp.golesEquipo1;
                    aux.golesEquipo2 = dp.golesEquipo2;
                    aux.esCompartida = dp.esCompartida;

                    _db.Update(aux);
                    _db.SaveChanges();

                    _cau.updatePuntaje_UsuarioPenca(dp.id_Penca, dp.esCompartida);
                }
                catch
                {
                    return false;
                }
                return true;
            }
            else
            {
                aux = Pronostico.GetObjetAdd(dp);
                try
                {
                    _db.Pronosticos.Add(aux);
                    _db.SaveChanges();

                    _cau.updatePuntaje_UsuarioPenca(dp.id_Penca, dp.esCompartida);
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        //Agregar Usuario a Penca
        bool I_ManejadorPenca.setUsuarioPenca(DTUsuarioPenca dp)
        {
            if(dp.esCompartida == true)
            {
                PencaUsuario_Compartidas aux = new PencaUsuario_Compartidas()
                {
                    id_PencaCompartida = dp.id_Penca,
                    Username_Usuario = dp.username
                };

                try
                {
                    _db.pencaUsuarioCompartida.Add(aux);
                    _db.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
            else
            {
                PencaUsuario_Empresariales aux = new PencaUsuario_Empresariales()
                {
                    id_PencaEmpresarial = dp.id_Penca,
                    Username_Usuario = dp.username
                };

                try
                {
                    _db.pencaUsuarioEmpresarial.Add(aux);
                    _db.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

    }
}
