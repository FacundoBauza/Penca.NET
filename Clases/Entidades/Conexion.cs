using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Dominio.Entidades
{
   
    public class Conexion
    {
        static string _ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["_ConnectionString"].ConnectionString;


        public string conect()
        {
            return _ConnectionString;
        }
    }

}
