using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using Dominio.DT;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementacion
{
    public class ManejadorPremio : I_ManejadorPremio
    {

        private readonly SolutionContext _db;

        public ManejadorPremio(SolutionContext db)
        {
            _db = db;
        }
        //Otorgar Premio => Etapa: Sin Empezar
        bool I_ManejadorPremio.set_Premio(DTPremio p)
        {

            Premios aux = Premios.GetObjetAdd(p);

            try
            {
                _db.Premios.Add(aux);
                _db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    

        //Listar Premios => Etapa: Sin Empezar
        List<DTPremio> I_ManejadorPremio.get_Premios()
        {
            List<DTPremio> list = _db.Premios.Select(x => x.GetEntity())
                                          .ToList();
            return list;

        }

        //Cobrar Premio => Etapa: Sin Empezar
        bool I_ManejadorPremio.Pagar_Premio(string username, int id_Penca)
        {
            Premios aux = null;

            foreach (Premios x in _db.Premios)
            {
                if (x.Username_Usuario == username && x.id_PencaCompartida == id_Penca)
                {
                    aux = x;
                }
            }
            if (aux != null)
            {
                aux.pago = true;


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
            else
            {
                return false;
            }
        }

        //listar porcentajes
        List<int> I_ManejadorPremio.getPorcentajes(int id_Criterio)
        {
            List<PorcentajesPremios> aux = _db.porcentajePremios.Select(x => x.GetEntity())
                                            .ToList();
            List<int> ret = new List<int>();
            List<int> ret1 = new List<int>();

            foreach (PorcentajesPremios p in aux)
            {
                if (p.id_CriterioPremio == id_Criterio)
                {
                    ret.Add(p.porcentaje);
                }
            }

            ret1 = ret.OrderByDescending(i => i).ToList();
            return ret;
        }
    }
}
