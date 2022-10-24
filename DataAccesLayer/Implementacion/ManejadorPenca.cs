using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using System.Data.SqlClient;
using DataAccesLayer.Interfaces;

namespace DataAccesLayer.Implementacion
{
    public class ManejadorPenca : I_ManejadorPenca
    {
        public bool addPenca()
        {
            /*Conexion x = new Conexion();

            string conect = x.conect();

            using (SqlConnection connection = new SqlConnection(conect))
            {
                string query = "INSERT INTO Usuario(Nombre) VALUES (@Nombre)";
                SqlCommand com = new SqlCommand(query, connection);

                com.Parameters.AddWithValue("@Nombre", "Facundo2X");

                connection.Open();
                int result = com.ExecuteNonQuery();
            }*/

            return true;
        }
    }
}
