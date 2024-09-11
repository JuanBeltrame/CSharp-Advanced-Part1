using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_12._0._01
{
    public class Cuervo : AnimalVolador, IMensaje, IEncriptado
    {
        public Cuervo(string nombre) : base(nombre)
        {

        }

        public string Destino { get { return "King's Landing"; } }

        public string EnviarMensaje()
        {
            return "Llego el Invierno";
        }

        string IEncriptado.EnviarMensaje()
        {
            return "John Snow es el Verdadero Rey";
        }

    }
}
