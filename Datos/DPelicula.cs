using Modelos;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class DPelicula
    {
        public static Pelicula GetById(int id)
        {
            Pelicula result = new Pelicula();
            try
            {
                
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public static List<Pelicula> GetAll()
        {
            List<Pelicula> result = new List<Pelicula>();
            try
            {
              
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public static void Delete(int id)
        {
            try
            {
                
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Update ()
        {
            try
            {
               
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Insert()
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}