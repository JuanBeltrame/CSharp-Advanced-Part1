using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View_Example_15._0._01
{
    internal class Persona
    {
        private int dni;

        private string nombre;

        public Persona(int dni)
        {
            this.dni = dni;
        }

        // Solo lectura
        public int Dni => dni;

        // Lectura y escritura
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
