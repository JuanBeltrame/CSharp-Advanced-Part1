static void EscribirArchivoTextoConStreamWriterConFinally()
{
    string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string rutaArchivo = Path.Combine(rutaEscritorio, "ArchivoTexto.txt");
    using (StreamWriter sw = new StreamWriter(rutaArchivo))
    {
        sw.WriteLine("Hola Mundo");
        sw.WriteLine("Hola Mundo 2");
        sw.WriteLine("Hola Mundo 3");
    }
}

static void LeerArchivoTextoConStreamReaderConFinally()
{
    string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string rutaArchivo = Path.Combine(rutaEscritorio, "ArchivoTexto.txt");
    using (StreamReader sr = new StreamReader(rutaArchivo))
    {
        string linea;
        while ((linea = sr.ReadLine()) != null)
        {
            Console.WriteLine(linea);
        }
    }
}

static void EscribirArchivoTextoConStreamWriterConUsing()
{
    string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string rutaArchivo = Path.Combine(rutaEscritorio, "ArchivoTexto.txt");
    using (StreamWriter sw = new StreamWriter(rutaArchivo))
    {
        sw.WriteLine("Hola Mundo");
        sw.WriteLine("Hola Mundo 2");
        sw.WriteLine("Hola Mundo 3");
    }
}

static void LeerArchivoTextoConStreamReaderConUsing()
{
    string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string rutaArchivo = Path.Combine(rutaEscritorio, "ArchivoTexto.txt");
    using (StreamReader sr = new StreamReader(rutaArchivo))
    {
        string linea;
        while ((linea = sr.ReadLine()) != null)
        {
            Console.WriteLine(linea);
            Console.WriteLine(linea);
        }
    }
}

static void EscribirArchivoTextoConFile()
{
    string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string rutaArchivo = Path.Combine(rutaEscritorio, "ArchivoTexto.txt");
    using (StreamWriter sw = new StreamWriter(rutaArchivo))
    {
        sw.WriteLine("Hola Mundo");
        sw.WriteLine("Hola Mundo 2");
        sw.WriteLine("Hola Mundo 3");
    }
}

static void LeerArchivoTextoConFile()
{
    string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string rutaArchivo = Path.Combine(rutaEscritorio, "ArchivoTexto.txt");
    using (StreamReader sr = new StreamReader(rutaArchivo))
    {
        string linea;
        while ((linea = sr.ReadLine()) != null)
        {
            Console.WriteLine(linea);
        }
    }
}


//----- Main Program ------
EscribirArchivoTextoConStreamWriterConFinally();
//LeerArchivoTextoConStreamReaderConFinally();
//EscribirArchivoTextoConStreamWriterConUsing();
//LeerArchivoTextoConStreamReaderConUsing();
//EscribirArchivoTextoConFile();
//LeerArchivoTextoConFile();
