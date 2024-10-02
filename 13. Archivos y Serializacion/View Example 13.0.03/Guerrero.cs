using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace View_Example_13._0._03
{
    public class Guerrero : Personaje
    {
        private int puntosDeFuerza;

        public int PuntosDeFuerza
        {
            get { return puntosDeFuerza; }
            set { puntosDeFuerza = value; }
        }

        public Guerrero()
        {

        }

        public Guerrero(int puntosDeVida, string nombre, int puntosDeFueza) : base(puntosDeVida, nombre)
        {
            this.puntosDeFuerza = puntosDeFueza;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - {puntosDeFuerza} puntos de fuerza";
        }

    }
}
