using _10._1._01_LanzarYAtraparLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._01_LanzarYAtraparLibrary
{
    internal class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase mi = new(10);
            }
            catch (DivideByZeroException ex)
            {

                throw new UnaExcepcion("Excepcion capturadara en ctor con parametros y re lanzada", ex);
            }

        }

        public MiClase(int id)
        {
            try
            {
                MiMetodoStatico();
            }
            catch (DivideByZeroException)
            {
                throw;
            }
            
        }

        public static void MiMetodoStatico() => throw new DivideByZeroException("Excepcion lanzada en mi metodo estatico MiClase");

    }
}
