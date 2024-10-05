using System.Collections.Generic;


List<int> list;

void MostrarNumeros()
{
    string numeros = "";

    foreach (int numero in list)
        numeros += $"{numero} | ";

    Console.WriteLine($"Numeros antes de filtrar: {numeros}");
}

static bool EsPar(int numero) => numero % 2 == 0;

static bool EsNegativo(int numero) => numero < 0;


Console.BackgroundColor = ConsoleColor.Black;

list = new List<int>()
            {
                 3, 45, 6, -9, 70, -134, 247, 17
            };
MostrarNumeros();

list = list.Filtrar(EsPar);
MostrarNumeros();
list = list.Filtrar(EsNegativo);

MostrarNumeros();


