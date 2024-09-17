using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._01_Library
{
    public class EscrituraWrapper
    {
        public ConsoleColor color;
        public string texto;

        public EscrituraWrapper(ConsoleColor color, string texto)
        {
            this.color = color;
            this.texto = texto;
        }
    }
}
