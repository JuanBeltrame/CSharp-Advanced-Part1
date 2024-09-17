using Library_Example_12._0._01;

Paloma paloma = new("Azir", "Shurima");
Courier courier = new("Vault", "Dueller", "32713684");
Carta carta = new("A4", 1, "Lobo");
Email mail = new("jefe@gmail.com", "Programador@gmail.com");
Cuervo cuervo = new("BloodRaven");


IMensaje mensaje = paloma;
Console.WriteLine(mensaje.EnviarMensaje());


List<IMensaje> mensajes = [paloma, courier, carta, mail, cuervo];
Console.WriteLine("------------------------");
Console.WriteLine("Implementacion implicita");
Console.WriteLine("------------------------");
foreach (IMensaje item in mensajes)
{
    Console.WriteLine(item.EnviarMensaje());

}

// Interfaz Explicita
Console.WriteLine("------------------------");
Console.WriteLine("Implementacion explicita");
Console.WriteLine("------------------------");
string mensajeSecreto = ((IEncriptado)cuervo).EnviarMensaje();
Console.WriteLine(mensajeSecreto);