namespace _16._1._01_Library
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        private string nombre;
        private string apellido;

        public event DelegadoString EventoString;

        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
                EventoString?.Invoke($"Nombre: {nombre}");
            }
        }

        public string Apellido
        {
            get => apellido;
            set
            {
                apellido = value;
                EventoString?.Invoke($"Apellido: {apellido}");
            }
        }

        public string Mostrar() => $"{nombre} {apellido}";

    }
}
