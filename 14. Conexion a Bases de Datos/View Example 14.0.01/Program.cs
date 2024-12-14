using Library_Example_14._0._01;

//--------------------- LEER -------------------------------------
//List<Persona> personas = PersonaAccesoDatos.Leer();
//
//foreach (Persona item in personas)
//    Console.WriteLine(item.ToString());

//------------------------ GUARDAR ----------------------------------
//Persona persona = new("Juan", "Beltrame");
//PersonaAccesoDatos.Guardar(persona);
//List<Persona> personas = PersonaAccesoDatos.Leer();

//foreach (Persona item in personas)
//    Console.WriteLine(item.ToString());


//------------------------ MODIFICAR ----------------------------------
Persona persona = new("Esteban", "Prieto", 8);
PersonaAccesoDatos.Modificar(persona);
List<Persona> personas = PersonaAccesoDatos.Leer();

foreach (Persona item in personas)
    Console.WriteLine(item.ToString());


//------------------------ ELIMINAR ----------------------------------
//PersonaAccesoDatos.Eliminar(3);
//List<Persona> personas = PersonaAccesoDatos.Leer();
//
//foreach (Persona item in personas)
//    Console.WriteLine(item.ToString());
