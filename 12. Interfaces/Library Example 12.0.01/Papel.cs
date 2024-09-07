using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_12._0._01
{
    public abstract class Papel (string tipo, int cantidadHojas)
    {
        protected string? Tipo => tipo;
        protected int? CantidadHojas => cantidadHojas;
       
       
    }
    
}
