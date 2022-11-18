using BusinessLogic.Interfaces;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
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
            if(pc != null)
            {
                if (!_fu.existePencaCompartida(pc.nombre))
                {
                    if (_fu.existeTorneoId(pc.torneo))
                    {
                        if (_dal.set_PencaCompartida(PencaCompartidas.GetObjetAdd2(pc), pc.criterioPremio) == true)
                        {
                            //return false;
                            return MensajesEnum.La_PencaCompartida_se_guardo_Correctamente;
                        }
                        else
                        {
                            return MensajesEnum.Exepcion_no_Controlada;
                        }
                    }
                    else
                        return MensajesEnum.No_existe_un_Torneo_con_el_Id_ingresado;


                }
                else
                {
                    //return false;
                    return MensajesEnum.Ya_existe_una_PencaCompartida_con_el_Nombre_ingresado;
                }
            }
            
            //return false;
            return MensajesEnum.El_Objeto_enviado_es_Nulo;
        }

        MensajesEnum IB_Penca.agregar_PencaEmpresarial(DTPencaEmpresarial pe) 
        {
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
                                //return false;
                                return MensajesEnum.La_PencaEmpresarial_se_guardo_Correctamente;
                            }
                            else
                            {
                                return MensajesEnum.Exepcion_no_Controlada;
                            }
                        }
                        else
                        {
                            return MensajesEnum.No_existe_un_Usuario_con_el_UserName_ingresado;
                        }
                    }
                    else
                        return MensajesEnum.No_existe_un_Torneo_con_el_Id_ingresado;

                }
                else
                {
                    //return false;
                    return MensajesEnum.Ya_existe_una_PencaEmpresarial_con_el_Nombre_ingresado;
                }
            }

            //return false;
            return MensajesEnum.El_Objeto_enviado_es_Nulo;
        }

        //Actualizar
        bool IB_Penca.actualizar_PencaCompartida(DTPencaCompartida pc) 
        {
            return _dal.update_PencaCompartida(pc);
        }

        bool IB_Penca.actualizar_PencaEmpresarial(DTPencaEmpresarial pe) 
        {
            return _dal.update_PencaEmpresarial(pe);
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

    }
}
