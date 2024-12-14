namespace Library_Example_14._0._01
{
    public class Persona
    {
        string? nombre;
        string? apellido;
        int id;

        public Persona(string nombre, string apellido, int id) : this(nombre, apellido) => this.id = id;
       
        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int Id { get => id; set => id = value; }

        public override string ToString() => $"Nombre: {Nombre}, Apellido: {Apellido}";
        
    }
}
