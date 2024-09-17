using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._01_Library
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor color;
        private float tinta;

        public Boligrafo(ConsoleColor color, float tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
            set
            {
                color = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                tinta = value;
            }
        }


        public EscrituraWrapper Escribir(string texto)
        {
            if (tinta >= texto.Length * 0.3)
            {
                tinta -= texto.Length * 0.3f;
                return new EscrituraWrapper(((IAcciones)this).Color, texto);
            }
            return null;
        }

        public bool Recargar(int unidades)
        {
            if (unidades > 0)
            {
                tinta += unidades;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Boligrafo color: {color} cantidad de tinta {tinta}";
        }
    }
}
