using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class MensajesEnum
    {
        public bool status { get; set; }
        public string mensaje { get; set; }

        public MensajesEnum()
        {

        }

        public void Exepcion_no_Controlada()
        {
            mensaje = "Exepción no controlada";
            status = false;
        }
        public void El_Objeto_enviado_es_Nulo()
        {
            mensaje = "El objeto enviado es nulo";
            status = false;
        }
        public void No_existe_un_Torneo_con_el_Id_ingresado()
        {
            mensaje = "No existe un Torneo con el Id ingresado";
            status = false;
        }
        public void No_existe_un_Evento_con_el_Id_ingresado()
        {
            mensaje = "No existe un Evento con el Id ingresado";
            status = false;
        }
        public void No_existe_una_PencaEmpresarial_con_el_Id_ingresado()
        {
            mensaje = "No existe una Penca Empresarial con el Id ingresado";
            status = false;
        }
        public void No_existe_una_PencaCompartida_con_el_Id_ingresado()
        {
            mensaje = "No existe una Penca Compartida con el Id ingresado";
            status = false;
        }
        public void No_existe_un_Usuario_con_el_UserName_ingresado()
        {
            mensaje = "No existe un Usuario con el Id ingresado";
            status = false;
        }
        public void Ya_existe_una_PencaEmpresarial_con_el_Nombre_ingresado()
        {
            mensaje = "Ya existe una Penca Empresarial con el Id ingresado";
            status = false;
        }
        public void Ya_existe_una_PencaCompartida_con_el_Nombre_ingresado()
        {
            mensaje = "Ya existe una Penca Compartida con el Id ingresado";
            status = false;
        }
        public void Ya_existe_un_Evento_con_el_Nombre_ingresado()
        {
            mensaje = "Ya existe un Evento con el Id ingresado";
            status = false;
        }
        public void Ya_existe_un_Torneo_con_el_Nombre_ingresado()
        {
            mensaje = "Ya existe un Torneo con el Id ingresado";
            status = false;
        }
        public void La_PencaEmpresarial_se_guardo_Correctamente()
        {
            mensaje = "La Penca Empresarial se guardo correctamente";
            status = true;
        }
        public void La_PencaCompartida_se_guardo_Correctamente()
        {
            mensaje = "La Penca Compartida se guardo correctamente";
            status = true;
        }
        public void El_Torneo_se_guardo_Correctamente()
        {
            mensaje = "El Torneo se guardo correctamente";
            status = true;
        }
        public void El_Evento_se_guardo_Correctamente()
        {
            mensaje = "El Evento se guardo correctamente";
            status = true;
        }

        public void Se_Actualizo_Penca()
        {
            mensaje = "Se actualizo correctamente la Penca";
            status = true;
        }

        public void No_se_pudo_actualizar_la_Penca()
        {
            mensaje = "No se pudo actualizar la Penca";
            status = true;
        }

        public void El_Evento_se_actualizo_Correctamente()
        {
            mensaje = " El Evento se actualizo correctamente";
            status = true;
        }
        public void El_Pronostico_se_actualizo_correctamente()
        {
            mensaje = " El Pronostico se actualizo correctamente";
            status = true;
        }
        public void El_Pronostico_se_agrego_correctamente()
        {
            mensaje = " El Pronostico se agrego correctamente";
            status = true;
        }

        public void El_Usuario_Ya_Participa_de_la_Penca()
        {
            mensaje = " El Usuario ya participa de la Penca";
            status = true;
        }

        public void El_Usuario_se_agrego_correctamente_a_la_Penca()
        {
            mensaje = " Se agrego correctamente el Usuario a la Penca";
            status = true;
        }
    }
}
