using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_12._0._01
{
    public class ClasePrueba : IPrueba<Courier>
    {
        public Courier MostrarPersona<U>(U nomnbre) where U : AnimalVolador
        {
            return new Courier();
        }
    }
}
