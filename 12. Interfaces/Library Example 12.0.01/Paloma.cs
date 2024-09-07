using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_12._0._01
{
    public class Paloma : AnimalVolador, IMensaje
    {
        public string destino;

        public Paloma(string nombre, string destino) : base(nombre)
        {
            this.destino = destino;
        }

        public string EnviarMensaje()
        {
            return "Nos rendimos";
        }
    }
}
