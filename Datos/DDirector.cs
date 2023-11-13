using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDirector
    {
        public static Director GetById(int id)
        {
            Director result = new Director();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("DirectorGetById", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["activo"].ToString() == "1")
                    {
                        result = new Director(Convert.ToInt32(reader["id"]), reader["nombre"].ToString(), reader["apellido"].ToString());
                    }
                }

                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public static List<Director> GetAll()
        {
            var result = new List<Director>(); 
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("DirectoresGet", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Director director = new Director();
                    director.id = Convert.ToInt32(reader["id"]);
                    director.nombre = reader["nombre"].ToString();
                    director.apellido = reader["apellido"].ToString();
                    if(reader["activo"].ToString() == "1")
                    {
                        result.Add(director);
                    }
                }
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public static void Insert(string nombre, string apellido)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("DirectorInsert", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Update(string nombre, string apellido, int activo)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("DirectorUpdate", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@activo", activo);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
