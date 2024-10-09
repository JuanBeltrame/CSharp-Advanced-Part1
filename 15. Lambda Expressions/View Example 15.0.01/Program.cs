using System.Security.Cryptography;
using View_Example_15._0._01;

// public delegate void DelegadoSinParmetros();
// public delegate void DelegadoConUnInt(int milisegundos);
// public delegate int DelegadoComparar(int numero1, int numero2);
// public delegate void DelegadoMostrar(int numero1, int numero2);
// public delegate bool DelegadoCriterio(int numero);

public class Program
{
    // static void Saludar() => Console.WriteLine("Hola Mundo");

    // static void SaludarConMilisegundos(int milisegundos) => Console.WriteLine($"Hola Mundo, pasaron {milisegundos} milisegundos");

    // static void SaludarConMilisegundos(int milisegundosMayor, int milisegundosMenor) => Console.WriteLine($"Hola Mundo, pasaron {milisegundosMayor} milisegundos... (mayor a {milisegundosMenor})");

    // static int Comparar(int numeroUno, int numeroDos) => numeroUno - numeroDos;

    // static bool EsPar(int numero) => numero % 2 != 0;

    // static void MostrarOk(int milisegundos) => Console.WriteLine($"{milisegundos} paso el criterio y se espero...");

    // static void MostrarNoOk(int milisegundos) => Console.WriteLine($"{milisegundos} No paso el criterio y No se espero...");

    private static void Main(string[] args)
    {
        // Action delegadoSaludar = Saludar;
        // Action<int> delegadoSaludarConMilisegundos = SaludarConMilisegundos;
        // Func<int, int, int> delegadoComparar = Comparar;
        // Action<int, int> delegadoMostrar = SaludarConMilisegundos;
        // Predicate<int> delegadoCriterio = EsPar;
        // Action<int> delegadoOk = MostrarOk;
        // Action<int> delegadoNoOk = MostrarNoOk;

        List<Persona> personas = [new Persona(1234), new Persona(9874)];
        personas.Sort((p1, p2) => p1.Dni - p2.Dni);

        for (int i = 0; i < 10; i++)
            Temporizador.Esperar(new Random().Next(3000, 5000), n => n % 2 == 0, n => Console.WriteLine($"{n} paso el criterio y se espero..."), m => Console.WriteLine($"{m} No paso el criterio y No se espero..."));

        Temporizador.Esperar(new Random().Next(3000, 5000), () => Console.WriteLine("Hola Mundo"));
        Temporizador.Esperar(new Random().Next(3000, 5000), n => Console.WriteLine($"Hola Mundo, pasaron {n} milisegundos"));
        Temporizador.EsperarElTIempo(new Random().Next(3000, 5000), new Random().Next(3000, 5000), (n1, n2) => n2 - n1, (t1, t2) => Console.WriteLine($"Hola Mundo, pasaron {t1} milisegundos... (mayor a {t2})"));
    }
}