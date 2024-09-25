using System.Data.SqlTypes;
using System.Runtime;
using System.IO;

//----------------------------------------------------------------------------------
// Leer y Escribir Archivos de Texto // StreamWriter y StreamReader // Con Finally
//----------------------------------------------------------------------------------
// StreamReader y StreamWriter es util para archivos mas pesados, o bien para leer o escribir linea por linea
//----------------------------------------------------------------------------------
static void EscribirArchivoTextoConStreamWriterConFinally()
{
    StreamWriter sw = default!;
    try
    {
        string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos");

        if (!Directory.Exists(ruta))
            Directory.CreateDirectory(ruta);


        ruta = Path.Combine(ruta, "HolaMundo.txt");
        sw = new(ruta, true);

        sw.WriteLine("Hola Mundo");
        sw.WriteLine("Hola Mundo 2");
        sw.WriteLine("Hola Mundo 3");

    }
    finally
    {
        sw?.Close();
        sw?.Dispose();
    }
}

static void LeerArchivoTextoConStreamReaderConFinally()
{
    StreamReader sw = default!;
    try
    {
        string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos", "HolaMundo.txt");
        sw = new(ruta);

        while (!sw.EndOfStream)
        {
            string lineaTexto = sw.ReadLine();
            Console.WriteLine(lineaTexto);
        }
    }
    finally
    {
        sw?.Close();
        sw?.Dispose();
    }
}

//----------------------------------------------------------------------------------
// Leer y Escribir Archivos de Texto // StreamWriter y StreamReader // Con Using
//----------------------------------------------------------------------------------
static void EscribirArchivoTextoConStreamWriterConUsing()
{
    string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos");

    if (!Directory.Exists(ruta))
        Directory.CreateDirectory(ruta);


    ruta = Path.Combine(ruta, "HolaMundo.txt");
    using (StreamWriter sw = new(ruta))
    {
        sw.WriteLine("Hola Mundo");
        sw.WriteLine("Hola Mundo 2");
        sw.WriteLine("Hola Mundo 3");
        sw.WriteLine("Aprendemos a trabajar con archivos");
    }
}

static void LeerArchivoTextoConStreamReaderConUsing()
{
    string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos", "HolaMundo.txt");
    using (StreamReader sw = new(ruta))
    {
        string lineaTexto = sw.ReadToEnd();
        Console.WriteLine(lineaTexto);
    }
}


//----------------------------------------------------------------------------------
// Leer y Escribir Archivos de Text // File // La forma mas corta y mas facil
//----------------------------------------------------------------------------------
// File solo es util con archivos livianos, cuando queres escribir o leer todo de golpe 
//----------------------------------------------------------------------------------
static void EscribirArchivoTextoConFile()
{
    string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos", "HolaMundo.txt");
    if (File.Exists(ruta))
    {
        File.Delete(ruta);
    }

    File.WriteAllText(ruta, "Hola Mundo en C#");
    File.AppendAllText(ruta, "\nComision 2D");

    string rutaCopia = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos", "HolaMundoCopia.txt");
    File.Copy(ruta, rutaCopia);

    File.WriteAllText(ruta, "Pise el Hola Mundo");
    string rutaAlt = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos", "HolaMundoRenombrado.txt");
    File.Move(ruta, rutaAlt);
}

static void LeerArchivoTextoConFile()
{
    string rutaCopia = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos", "HolaMundoCopia.txt");

    if (File.Exists(rutaCopia))
    {
        string textoLeido = File.ReadAllText(rutaCopia);
        Console.WriteLine(textoLeido);
    }

    string rutaAlt = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos", "HolaMundo.txt");
    if (File.Exists(rutaAlt))
    {
        string textoLeido = File.ReadAllText(rutaAlt);
        Console.WriteLine(textoLeido);
    }

}



//----- Main Program ------
try
{
    //EscribirArchivoTextoConStreamWriterConFinally();
    //LeerArchivoTextoConStreamReaderConFinally();
    //EscribirArchivoTextoConStreamWriterConUsing();
    //LeerArchivoTextoConStreamReaderConUsing();
    //EscribirArchivoTextoConFile();
    //LeerArchivoTextoConFile();
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
