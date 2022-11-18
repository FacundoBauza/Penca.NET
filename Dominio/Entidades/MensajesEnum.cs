using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public enum MensajesEnum
    {
        Exepcion_no_Controlada,
        El_Objeto_enviado_es_Nulo,
        No_existe_un_Torneo_con_el_Id_ingresado,
        No_existe_un_Evento_con_el_Id_ingresado,
        No_existe_una_PencaEmpresarial_con_el_Id_ingresado,
        No_existe_una_PencaCompartida_con_el_Id_ingresado,
        No_existe_un_Usuario_con_el_UserName_ingresado,
        Ya_existe_una_PencaEmpresarial_con_el_Nombre_ingresado,
        Ya_existe_una_PencaCompartida_con_el_Nombre_ingresado,
        Ya_existe_un_Evento_con_el_Nombre_ingresado,
        Ya_existe_un_Torneo_con_el_Nombre_ingresado,
        La_PencaEmpresarial_se_guardo_Correctamente,
        La_PencaCompartida_se_guardo_Correctamente,
        El_Torneo_se_guardo_Correctamente,
        El_Evento_se_guardo_Correctamente
    }
}
