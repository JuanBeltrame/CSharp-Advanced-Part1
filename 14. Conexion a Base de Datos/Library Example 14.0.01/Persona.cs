namespace Library_Example_14._0._01
{
    public class Persona
    {
        string? nombre;
        string? apellido; 

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public override string ToString() => $"Nombre: {nombre}, Apellido: {apellido}";
        
    }
}
