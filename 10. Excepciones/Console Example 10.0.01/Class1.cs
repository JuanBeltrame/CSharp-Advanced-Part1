using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Example_10._0._01
{
    class Class1
    {
        public static void Metodo1()
        {
            int num1 = 4;
            int num2 = 0;
            int var = num1 / num2; // DivideByZeroException
        }

        public static void Metodo2()
        {
            int[] array = { 1, 2, 3 };
            array[4] = 4; // IndexOutOfRangeException
        }
    }
}
