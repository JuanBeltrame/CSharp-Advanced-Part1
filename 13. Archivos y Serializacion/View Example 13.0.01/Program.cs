static void VerificarSistemaOperativo()
{
    Console.WriteLine($"Es Windows? {OperatingSystem.IsWindows()}");
    Console.WriteLine($"Es Linux? {OperatingSystem.IsLinux()}");
    Console.WriteLine($"Es MacOS? {OperatingSystem.IsMacOS()}");
    Console.WriteLine($"Es Andriod? {OperatingSystem.IsAndroid()}");
}

static void ObtenerInformacionSistemaOperativo()
{
    Console.WriteLine($"Sistema Operativo: {Environment.OSVersion}");
    Console.WriteLine($"Plataforma: {Environment.OSVersion.Platform}");
    Console.WriteLine($"Version: {Environment.OSVersion.Version}");
    Console.WriteLine($"Cantidad Procesadores Logicos: {Environment.ProcessorCount}");
    Console.WriteLine($"Tiene Arquitectura 64bits?: {Environment.Is64BitProcess}");
    Console.WriteLine($"Usuario OS: {Environment.UserName}");

}

static void ObtenerInformacionMediosDeAlmacenamiento()
{
    Console.WriteLine($"Unidades de Disco: {DriveInfo.GetDrives().Length}");
    foreach (DriveInfo drive in DriveInfo.GetDrives())
    {
        Console.WriteLine($"Nombre: {drive.Name}");
        Console.WriteLine($"Tipo: {drive.DriveType}");
        Console.WriteLine($"Formato: {drive.DriveFormat}");
        Console.WriteLine($"Espacio Total: {drive.TotalSize}");
        Console.WriteLine($"Espacio Disponible: {drive.AvailableFreeSpace}");
        Console.WriteLine($"Etiqueta: {drive.VolumeLabel}");
        Console.WriteLine($"-----------{Environment.NewLine}");
    }
}

static void TrabajarConDirectorio()
{
    string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    Console.WriteLine($"Ruta escritorio: {rutaEscritorio}");

    string rutaNuevoDirectorio = Path.Combine(rutaEscritorio, "Prueba");
    Console.WriteLine($"Ruta nuevo directorio: {rutaNuevoDirectorio}");

    VerificarSiExisteDirectorio(rutaNuevoDirectorio);

    Console.WriteLine("Creo un directorio....");
    Directory.CreateDirectory(rutaNuevoDirectorio);

    VerificarSiExisteDirectorio(rutaNuevoDirectorio);

    Console.WriteLine("Creo un directorio....");
    string rutaRenombrada = Path.Combine(rutaEscritorio, "PruebaRenombrar");
    Console.WriteLine($"Ruta renombrada: {rutaRenombrada}");

    VerificarSiExisteDirectorio(rutaRenombrada);

    Console.WriteLine("Muevo/Renombro....");
    Directory.Move(rutaNuevoDirectorio, rutaRenombrada);

    VerificarSiExisteDirectorio(rutaRenombrada);
    VerificarSiExisteDirectorio(rutaNuevoDirectorio);

}

static void VerificarSiExisteDirectorio(string ruta)
{
    bool existeDirectorio = Directory.Exists(ruta);
    Console.WriteLine($"Existe Directorio? {existeDirectorio}");
}

static void TrabajarConRutasRelativasYAbsolutas()
{
    string rutaAbsoluta = Path.GetFullPath(".");
    Console.WriteLine($"Ruta Absoluta: {rutaAbsoluta}");

    string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string rutraRelativa = Path.GetRelativePath(rutaEscritorio, ".");
    Console.WriteLine($"Ruta Relativa escritorio a App: {rutaAbsoluta}");

    string rutaRelativa2 = Path.GetRelativePath(".", rutaEscritorio);
    Console.WriteLine($"Ruta Relativa App a escritorio: {rutaRelativa2}");


    string rutaMisDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    string rutaRelativa3 = Path.GetRelativePath(rutaEscritorio, rutaMisDocumentos);
    Console.WriteLine($"Ruta Relativa escritorio a mis Documentos: {rutaRelativa3}");
}

static void TrabajarConNombresDeRutas()
{
    string rutaAbsoluta = Path.GetFullPath(".");
    Console.WriteLine($"Ruta Absoluta: {rutaAbsoluta}");

    string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string rutraRelativa = Path.GetRelativePath(rutaEscritorio, ".");
    Console.WriteLine($"Ruta Relativa escritorio a App: {rutaAbsoluta}");

    string rutaRelativa2 = Path.GetRelativePath(".", rutaEscritorio);
    Console.WriteLine($"Ruta Relativa App a escritorio: {rutaRelativa2}");


    string rutaMisDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    string rutaRelativa3 = Path.GetRelativePath(rutaEscritorio, rutaMisDocumentos);
    Console.WriteLine($"Ruta Relativa escritorio a mis Documentos: {rutaRelativa3}");

}

//----- Main Program ------
//VerificarSistemaOperativo();
//ObtenerInformacionSistemaOperativo();
//ObtenerInformacionMediosDeAlmacenamiento();
//------------------------------------------------
//TrabajarConDirectorio();
TrabajarConRutasRelativasYAbsolutas();
TrabajarConNombresDeRutas();


