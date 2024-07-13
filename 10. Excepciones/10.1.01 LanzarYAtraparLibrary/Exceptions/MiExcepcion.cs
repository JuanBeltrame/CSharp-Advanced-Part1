using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._01_LanzarYAtraparLibrary.Exceptions
{
    internal class MiExcepcion : Exception
    {
        public MiExcepcion(string? message) : base(message)
        {
        }

        public MiExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
