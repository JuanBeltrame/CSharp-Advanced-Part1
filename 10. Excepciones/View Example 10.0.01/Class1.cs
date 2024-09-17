using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_Example_10._0._01
{
    class Class1
    {
        public static void Metodo1()
        {
            try
            {
                int num1 = 4;
                int num2 = 0;
                int var = num1 / num2; // DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void Metodo2()
        {
            try
            {
                int[] array = { 1, 2, 3 };
                array[4] = 4; // IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void Metodo3()
        {
            try
            {
                int num1 = 4;
                int num2 = 0;
                int var = num1 / num2;
            }
            catch (IndexOutOfRangeException) // Como no necesito la instancia de la clase (ex), no la uso.
            {
                throw;
            }
            catch (Exception) // Como no necesito la instancia de la clase (ex), no la uso.
            {
                throw;
            }
        }

        public static void Metodo4()
        {
            try
            {
                int num1 = 4;
                int num2 = 0;
                int var = num1 / num2;
            }
            catch (DivideByZeroException ex) 
            {
                throw new IndexOutOfRangeException("Ocurrio un error", ex);
            }
            catch (Exception) 
            {
                throw;
            }
        }

        public static void Metodo5()
        {
            try
            {
                int num1 = 4;
                int num2 = 0;
                int var = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                throw new MiExcepcion("Catapumbas", ex);
            }
            catch (Exception) 
            {
                throw;
            }
        }

        public static void Metodo6()
        {
            try
            {
                int num1 = 4;
                int num2 = 0;
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                int var = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                throw new MiExcepcion("Catapumbas", ex);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
