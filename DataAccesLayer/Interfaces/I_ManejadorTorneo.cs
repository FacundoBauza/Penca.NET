﻿using DataAccesLayer.Implementacion;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Interfaces
{
    public interface I_ManejadorTorneo
    {
        List<Torneo> ListTorneos();
    }
}