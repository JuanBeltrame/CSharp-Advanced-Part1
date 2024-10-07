using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View_Example_14._0._03
{
    public class Temporizador
    {
        public static void Esperar(int milisegundos, DelegadoSinParmetros delegadoSinParmetros)
        {
            Thread.Sleep(milisegundos);
            delegadoSinParmetros();
        }

        public static void Esperar(int milisegundos, DelegadoConUnInt delegadoConUnInt)
        {
            Thread.Sleep(milisegundos);
            delegadoConUnInt(milisegundos);
        }

        public static void Esperar(int milisegundos, DelegadoCriterio delegadoCriterio, DelegadoConUnInt delegadoResultadoOk, DelegadoConUnInt delegadoResultadoNoOk)
        {
            if (delegadoCriterio(milisegundos))
            {
                Thread.Sleep(milisegundos);
                delegadoResultadoOk(milisegundos);
            }
            else
            {
                delegadoResultadoNoOk(milisegundos);
            }
        }

        public static void EsperarElTIempo(int milisegundosUno, int milisegundosDos, DelegadoComparar delegadoComparar, DelegadoMostrar delegadoMostrar)
        {
            int milisegundosMayor;
            int milisegundosMenor;

            if (delegadoComparar(milisegundosUno, milisegundosDos) >= 0)
            {
                milisegundosMayor = milisegundosUno;
                milisegundosMenor = milisegundosDos;
            }
            else
            {
                milisegundosMayor = milisegundosDos;
                milisegundosMenor = milisegundosUno;
            }

            Thread.Sleep(milisegundosMayor);
            delegadoMostrar(milisegundosMayor, milisegundosMenor);
        }
    }
}
