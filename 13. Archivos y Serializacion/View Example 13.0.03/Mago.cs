using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View_Example_13._0._03
{
    public class Mago : Personaje
    {
        private int puntosDeMana;

        public int PuntosDeMana
        {
            get { return puntosDeMana; }
            set { puntosDeMana = value; }
        }

        public Mago()
        {
            
        }

        public Mago(int puntosDeVida, string nombre, int puntosDeMana) : base(puntosDeVida, nombre)
        {
            this.puntosDeMana = puntosDeMana;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {puntosDeMana} puntos de mana";
        }

    }
}
