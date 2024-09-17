using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_12._0._01
{
    public class Courier : Persona, IMensaje
    {
        public Courier()
        {
        }
        public Courier(string nombre, string apellido, string dni) : base (nombre, apellido, dni)
        {
            
        }

        public string EnviarMensaje()
        {
            return "La ficha se encuentra en el Locker 38";
        }
    }
}
