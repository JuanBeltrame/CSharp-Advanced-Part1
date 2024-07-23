using _10._1._01_LanzarYAtraparLibrary;
using _10._1._01_LanzarYAtraparLibrary.Exceptions;

OtraClase otraClase = new();

try
{

otraClase.MiMetodoDeInstancia();
}
catch(MiExcepcion ex)
{
    Console.WriteLine(ex.Message);
    Exception inner = ex.InnerException!;
    Console.WriteLine(inner.Message);
    Exception inner2 = inner.InnerException!;
    Console.WriteLine(inner2.Message);   
}