using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Example_12._0._01
{
    public abstract class Persona (string nombre, string apellido, string dni)
    {
        protected string? Nombre => nombre;
        protected string? Apellido => apellido;
        protected string? DNI => dni;

        protected const string mensaje = "Estoy corriendo.";

        public string Correr()
        {
            return mensaje;
        }
    }
}
