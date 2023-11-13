using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDirector
    {
        public static List<Director> Get()
        {
            try
            {
                return DDirector.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Insert(string nombre, string apellido)
        {
            try
            {
                DDirector.Insert(nombre, apellido);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}