using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1._01_Library
{
    public abstract class Equipo(string nombre, DateTime fechaCreacion)
    {
        private string nombre = nombre;
        private DateTime fechaCreacion = fechaCreacion;

        public string Nombre { get => nombre; set => nombre = value; }

        public static bool operator ==(Equipo equipo1, Equipo equipo2) => equipo1.nombre == equipo2.nombre && equipo1.fechaCreacion == equipo2.fechaCreacion;

        public static bool operator !=(Equipo equipo1, Equipo equipo2) => !(equipo1 == equipo2);

        public string Ficha() => $"Nombre: {nombre} - Fundado el: {fechaCreacion.ToString("dd/MM/yyyy")}";

        

    }
}
