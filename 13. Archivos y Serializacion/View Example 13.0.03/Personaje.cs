using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace View_Example_13._0._03
{
    [XmlInclude(typeof(Mago))]
    [XmlInclude(typeof(Guerrero))]
    public class Personaje
    {
        private int puntosdeVida;
        private string nombre;

        public int PuntosdeVida { get => puntosdeVida; set => puntosdeVida = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Personaje()
        {
        }

        public Personaje(int puntosdeVida, string nombre)
        {
            this.puntosdeVida = puntosdeVida;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, Puntos de vida: {puntosdeVida}";
        }
    }
}
