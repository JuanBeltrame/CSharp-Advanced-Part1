using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Example_10._0._01
{
    internal class MiExcepcion : Exception
    {

        public MiExcepcion(string mensaje):this(mensaje,null!)
        {

        }

        public MiExcepcion(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
            
    }
}
