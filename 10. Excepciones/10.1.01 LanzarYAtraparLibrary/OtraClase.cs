using _10._1._01_LanzarYAtraparLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._01_LanzarYAtraparLibrary
{
    
    public class OtraClase
    {
        public void MiMetodoDeInstancia()
        {
            try
            {
                MiClase miClase = new();
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("Excepcion capturada en OtraClase en MiMetodoDeInstancia", ex);
            }
        }
    }
}
