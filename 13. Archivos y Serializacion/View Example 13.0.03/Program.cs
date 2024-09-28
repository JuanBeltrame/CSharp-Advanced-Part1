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


string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string rutaArchivo = Path.Combine(rutaEscritorio, "personaje.xmlS");

// Personaje personaje = new (100, "CarpinchoAsesino");
// SerializarAXML(rutaArchivo, personaje);
Personaje personaje = DeserializarAXML<Personaje>(rutaArchivo);
Console.WriteLine(personaje.ToString());

