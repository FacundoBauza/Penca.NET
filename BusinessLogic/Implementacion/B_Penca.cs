using BusinessLogic.Interfaces;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic.Implementacion
{
    public class B_Penca: IB_Penca
    {
        private I_ManejadorPenca _dal;
        private I_Functions _fu;
        private I_Casteos _cas;
        public B_Penca(I_ManejadorPenca dal, I_Functions fu, I_Casteos cas)
        {
            _dal = dal;
            _fu = fu;
            _cas = cas;
        }

        //Agregar
        MensajesEnum IB_Penca.agregar_PencaCompartida(DTPencaCompartida2 pc) 
        {
            MensajesEnum men = new MensajesEnum();
            if(pc != null)
            {
                if (!_fu.existePencaCompartida(pc.nombre))
                {
                    if (_fu.existeTorneoId(pc.torneo))
                    {
                        if (_dal.set_PencaCompartida(PencaCompartidas.GetObjetAdd2(pc), pc.criterioPremio) == true)
                        {
                            men.La_PencaCompartida_se_guardo_Correctamente();
                            return men;
                        }
                        else
                        {
                            men.Exepcion_no_Controlada();
                            return men;
                        }
                    }
                    else
                    {
                        men.No_existe_un_Torneo_con_el_Id_ingresado();
                        return men;
                    }

                }
                else
                {
                    men.Ya_existe_una_PencaCompartida_con_el_Nombre_ingresado();
                    return men;
                }
            }
            
            men.El_Objeto_enviado_es_Nulo();
            return men;
        }

        MensajesEnum IB_Penca.agregar_PencaEmpresarial(DTPencaEmpresarial pe) 
        {
            MensajesEnum men = new MensajesEnum();
            if(pe != null)
            {
                if (!_fu.existePencaEmpresarial(pe.nombre))
                {
                    if (_fu.existeTorneoId(pe.torneo))
                    {
                        if (_fu.existeUsuario(pe.usuario_creador))
                        {
                            if (_dal.set_PencaEmpresarial(PencaEmpresariales.GetObjetAdd(pe)) == true)
                            {
                                men.La_PencaEmpresarial_se_guardo_Correctamente();
                                return men;
                            }
                            else
                            {
                                men.Exepcion_no_Controlada();
                                return men;
                            }
                        }
                        else
                        {
                            men.No_existe_un_Usuario_con_el_UserName_ingresado();
                            return men;
                        }
                    }
                    else
                    {
                        men.No_existe_un_Torneo_con_el_Id_ingresado();
                        return men;
                    }

                }
                else
                {
                    men.Ya_existe_una_PencaEmpresarial_con_el_Nombre_ingresado();
                    return men;
                }
            }

            men.El_Objeto_enviado_es_Nulo();
            return men;
        }

        //Actualizar
        MensajesEnum IB_Penca.actualizar_PencaCompartida(DTPencaCompartida pc) 
        {
            MensajesEnum men = new MensajesEnum();
            if (!_fu.existePencaCompartida(pc.nombre))
            {
                if (_dal.update_PencaCompartida(pc) == true)
                {
                    men.Se_Actualizo_Penca();
                    return men;
                }
                else
                {
                    men.No_se_pudo_actualizar_la_Penca();
                    return men;
                }
            }
            else
            {
                men.Ya_existe_una_PencaCompartida_con_el_Nombre_ingresado();
                return men;
            }
        }

        MensajesEnum IB_Penca.actualizar_PencaEmpresarial(DTPencaEmpresarial pe) 
        {
            MensajesEnum men = new MensajesEnum();
            if (!_fu.existePencaEmpresarial(pe.nombre))
            {
                if (_dal.update_PencaEmpresarial(pe) == true)
                {
                    men.Se_Actualizo_Penca();
                    return men;
                }
                else
                {
                    men.No_se_pudo_actualizar_la_Penca();
                    return men;
                }
            }
            else
            {
                men.Ya_existe_una_PencaEmpresarial_con_el_Nombre_ingresado();
                return men;
            }

        }

        //Listar
        List<DTPencaCompartida> IB_Penca.listar_PencaCompartida()
        {
            return _dal.get_PencaCompartida();
        }

        List<DTPencaEmpresarial> IB_Penca.listar_PencaEmpresarial() 
        {
            return _dal.get_PencaEmpresarial();
        }

        //Eliminar
        bool IB_Penca.eliminar_PencaCompartida(int id_PencaC)
        {
            return _dal.delete_PencaCompartida(id_PencaC);
        }

        bool IB_Penca.eliminar_PencaEmpresarial(int id_PencaE)
        {
            return _dal.delete_PencaEmpresarial(id_PencaE);
        }

        //Agregar Pronostico
        MensajesEnum IB_Penca.agregar_Pronostico(DTPronostico dp)
        {
            MensajesEnum men = new MensajesEnum();
            if (_fu.existePronostico(dp))
            {
                if (_dal.setPronostico(dp, true) == true)
                {
                    men.El_Pronostico_se_actualizo_correctamente();
                    return men;
                }
                else
                {
                    men.Exepcion_no_Controlada();
                    return men;
                }
            }
            else
            {
                if (_dal.setPronostico(dp, false) == true)
                {
                    men.El_Pronostico_se_agrego_correctamente();
                    return men;
                }
                else
                {
                    men.Exepcion_no_Controlada();
                    return men;
                }
            }  
        }

        //Agregar Usuario a Penca
        MensajesEnum IB_Penca.agregar_usuarioPenca(DTUsuarioPenca dp)
        {
            MensajesEnum men = new MensajesEnum();
            if (_fu.perteneceUsuarioPenca(dp))
            {
                men.El_Usuario_Ya_Participa_de_la_Penca();
                return men;
            }
            else
            {
                if (_dal.setUsuarioPenca(dp) == true)
                {
                    men.El_Usuario_se_agrego_correctamente_a_la_Penca();
                    return men;
                }
                else
                {
                    men.Exepcion_no_Controlada();
                    return men;
                }
            }
        }

    }
}
