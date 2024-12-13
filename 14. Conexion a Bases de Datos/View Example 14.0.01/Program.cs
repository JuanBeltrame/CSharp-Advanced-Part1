using Library_Example_14._0._01;





List<Persona> personas = PersonaAccesoDatos.Leer();

foreach (Persona item in personas)
{
    Console.WriteLine(item.ToString());
}