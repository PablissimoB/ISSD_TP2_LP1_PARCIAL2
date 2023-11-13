using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPelicula
    {
        public static List<Pelicula> Get ()
        {
            try
            {
                return DPelicula.GetAll ();
            }
            catch (Exception) {
                throw;
            }
        }
        public static void Delete(int id)
        {
            try
            {
                DPelicula.Delete(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Update()
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
