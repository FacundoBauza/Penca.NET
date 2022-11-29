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
    public class Casteos: I_Casteos
    {
        public DTPronostico castDTPronostico(Pronostico x)
        {
            DTPronostico dTPronostico = new DTPronostico()
            {
                id_Evento = x.id_Evento,
                golesEquipo1 = x.golesEquipo1,
                golesEquipo2 = x.golesEquipo2,
                username = x.Username_Usuario,
                id_Penca = x.id_Penca,
                esCompartida = x.esCompartida
            };

            return dTPronostico;
        }

        public DTUsuario castDTUsuario(Users x)
        {
            DTUsuario dTUsuario = new DTUsuario()
            {
                Id = x.Id,
                Username = x.UserName,
                Nombre = x.nombre,
                Apellido = x.apellido,
                Email = x.Email
            };

            return dTUsuario;
        }

        DTEvento I_Casteos.castDTEvento(Eventos x)
        {
            DTEvento dTEvento = new DTEvento()
            {
                id = x.id_Evento,
                equipo1 = x.equipo1,
                equipo2 = x.equipo2,
                fechaHora = x.fechaHora,
                golesEquipo1 = x.golesEquipo1,
                golesEquipo2 = x.golesEquipo2,
                resultado = x.resultado,
                torneo = x.id_Torneo
            };

            return dTEvento;
        }

        DTPencaCompartida I_Casteos.castDTPencaCompartida(PencaCompartidas x)
        {
            DTPencaCompartida dTPenca = new DTPencaCompartida()
            {
                id = x.id_PencaCompartida,
                nombre = x.nombre,
                criterioPremio = x.id_CriterioPremio,
                torneo = x.id_Torneo,
                esCompartida = true
            };

            return dTPenca;
        }

        DTPencaEmpresarial I_Casteos.castDTPencaEmpresarial(PencaEmpresariales x)
        {
            DTPencaEmpresarial dTPenca = new DTPencaEmpresarial()
            {
                id = x.id_PencaEmpresarial,
                link = x.link,
                nombre = x.nombre,
                usuario_creador = x.Username_UsuarioCreador,
                torneo = x.id_Torneo,
                esCompartida = false
            };

            return dTPenca;
        }

    }
}
