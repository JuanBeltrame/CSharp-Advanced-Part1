using System.Numerics;
using System.Text;

namespace _11._1._01_Library
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        public string nombre;

        private Torneo() => equipos = new();

        public Torneo(string nombre) : this() => this.nombre = nombre;

        public string JugarPartido
        {
            get
            {
                Random rd = new();
                T equipo1;
                T equipo2;

                do
                {
                    equipo1 = equipos[rd.Next(0, equipos.Count)];
                    equipo2 = equipos[rd.Next(0, equipos.Count)];
                } while (equipo1 == equipo2);

                return CalcularPartido(equipo1, equipo2);
            }
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T item in torneo.equipos)
            {
                if (item == equipo)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo) => !(torneo == equipo);


        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if ((torneo is not null && equipo is not null) && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre del torneo: {nombre}");
            foreach (T item in equipos)
                sb.AppendLine(item.Ficha());


            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random rd = new();
            return $"{equipo1.Nombre}{rd.Next(0,10)} - {equipo2.Nombre}{rd.Next(0,10)}";
        }

    }
}
