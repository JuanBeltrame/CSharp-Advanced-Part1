using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_12._0._01
{
    public class Email (string origen, string destino) : IMensaje
    {
        private string Origen => origen;
        private string Destino => destino;

        public string EnviarMensaje()
        {
            return "Ya terminaste? ):";
        }
    }
}
