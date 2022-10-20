using Dominio.Entidades;
using System.Data.SqlClient;

Conexion x = new Conexion();

string conect = x.conect();

using (SqlConnection connection = new SqlConnection(conect))
{
    string query = "INSERT INTO Usuario(Nombre) VALUES (@Nombre)";
    SqlCommand com = new SqlCommand(query, connection);

    com.Parameters.AddWithValue("@Nombre", "FacundoX");

    connection.Open();
    int result = com.ExecuteNonQuery();
}
