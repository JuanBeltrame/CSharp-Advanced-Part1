using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_12._0._01
{
    public interface IPrueba<T> where T : Persona, new()
    {
        T MostrarPersona<U>(U nomnbre) where U : AnimalVolador;
    }
}
