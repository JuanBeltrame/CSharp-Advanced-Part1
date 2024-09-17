using _12._1._01_Library;

ConsoleColor colorOriginal = Console.ForegroundColor;

Lapiz miLapiz = new Lapiz(10);
Boligrafo miBoligrafo = new (ConsoleColor.Green, 20);

EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
Console.ForegroundColor = eLapiz.color;
Console.WriteLine(eLapiz.texto);
Console.ForegroundColor = colorOriginal;
Console.WriteLine(miLapiz);

EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
Console.ForegroundColor = eBoligrafo.color;
Console.WriteLine(eBoligrafo.texto);
Console.ForegroundColor = colorOriginal;
Console.WriteLine(miBoligrafo);

Console.ReadKey();


