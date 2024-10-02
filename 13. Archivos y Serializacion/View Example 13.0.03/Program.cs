using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using View_Example_13._0._03;

static void SerializarAXML<T>(string ruta, T objeto)
{
    using (StreamWriter sw = new(ruta))
    {
        XmlSerializer xmlSerializer = new(typeof(T));
        xmlSerializer.Serialize(sw, objeto);
    }
}


static T DeserializarAXML<T>(string ruta) where T : class
{
    using (StreamReader sr = new(ruta))
    {
        XmlSerializer xmlSerializer = new(typeof(T));
        T objeto = (xmlSerializer.Deserialize(sr) as T)!;
        return objeto;
    }
}

//----------------------------------------------------------------------------------------------
//string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
//string rutaArchivo = Path.Combine(rutaEscritorio, "personaje.xml");

// Personaje personaje = new(100, "CarpinchoAsesino");
// SerializarAXML(rutaArchivo, personaje);

//Personaje personaje = DeserializarAXML<Personaje>(rutaArchivo);
//Console.WriteLine(personaje.ToString());

//----------------------------------------------------------------------------------------------
//string rutaEscritorioParaMago = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
//string rutaArchivoParaMago = Path.Combine(rutaEscritorioParaMago, "personajeMago.xml");

//Personaje personajeMago = new Mago(100, "CarpinchoAsesino", 250);
//SerializarAXML(rutaArchivoParaMago, personajeMago);

//----------------------------------------------------------------------------------------------
string rutaEscritorioParaPersonajes = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string rutaArchivoParaPersonajes = Path.Combine(rutaEscritorioParaPersonajes, "personajes.xml");

//Personaje mago = new Mago(100, "Carpincho Mistico", 250);
//Personaje guerrero = new Guerrero(100, "Carpincho Asesino", 500);
//List<Personaje> personajes = [mago, guerrero];
//SerializarAXML(rutaArchivoParaPersonajes, personajes);

List<Personaje> personajes1 = DeserializarAXML<List<Personaje>>(rutaArchivoParaPersonajes);
foreach (Personaje personaje in personajes1)
{
    Console.WriteLine(personaje);
}
//----------------------------------------------------------------------------------------------