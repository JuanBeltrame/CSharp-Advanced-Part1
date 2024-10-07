using View_Example_14._0._03;

//public delegate void DelegadoSinParmetros();
//public delegate void DelegadoConUnInt(int milisegundos);
//public delegate int DelegadoComparar(int numero1, int numero2);
//public delegate void DelegadoMostrar(int numero1, int numero2);
//public delegate bool DelegadoCriterio(int numero);

public class Program
{
    static void Saludar() => Console.WriteLine("Hola Mundo");

    static void SaludarConMilisegundos(int milisegundos) => Console.WriteLine($"Hola Mundo, pasaron {milisegundos} milisegundos");

    static void SaludarConMilisegundos(int milisegundosMayor, int milisegundosMenor) => Console.WriteLine($"Hola Mundo, pasaron {milisegundosMayor} milisegundos... (mayor a {milisegundosMenor})");

    static int Comparar(int numeroUno, int numeroDos) => numeroUno - numeroDos;

    static bool EsPar(int numero) => numero % 2 != 0;

    static void MostrarOk(int milisegundos) => Console.WriteLine($"{milisegundos} paso el criterio y se espero...");

    static void MostrarNoOk(int milisegundos) => Console.WriteLine($"{milisegundos} No paso el criterio y No se espero...");

    private static void Main(string[] args)
    {
        Action delegadoSaludar = Saludar;
        Action<int> delegadoSaludarConMilisegundos = SaludarConMilisegundos;
        Func<int, int, int> delegadoComparar = Comparar;
        Action<int, int> delegadoMostrar = SaludarConMilisegundos;
        Predicate<int> delegadoCriterio = EsPar;
        Action<int> delegadoOk = MostrarOk;
        Action<int> delegadoNoOk = MostrarNoOk;

        for (int i = 0; i < 10; i++)
        {
            Temporizador.Esperar(new Random().Next(3000, 5000), delegadoCriterio, delegadoOk, delegadoNoOk);
        }


        Temporizador.Esperar(new Random().Next(3000, 5000), () => );
        Temporizador.Esperar(new Random().Next(3000, 5000), delegadoSaludarConMilisegundos);
        Temporizador.EsperarElTIempo(new Random().Next(3000, 5000), new Random().Next(3000, 5000), delegadoComparar, delegadoMostrar);
    }
}
