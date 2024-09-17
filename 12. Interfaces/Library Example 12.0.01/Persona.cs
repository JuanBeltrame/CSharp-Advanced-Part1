using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_12._0._01
{
    public abstract class Persona
    {
        protected string? nombre;
        protected string? apellido;
        protected string? dni;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        protected const string mensaje = "Estoy corriendo.";

        public string Correr()
        {
            return mensaje;
        }
    }
}
