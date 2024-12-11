using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._1._02_View
{
    public class Temporizador
    {
        public delegate void DelegadoTemporizador();
        public event DelegadoTemporizador TiempoCumplido;
        private readonly int intervalo;
        private Task hilo;
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;

        public Temporizador(int intervalo) => this.intervalo = intervalo;
        
        public int Intervalo => intervalo;
        public bool EstaActivo => hilo != null && hilo.Status == TaskStatus.Running;

        public void IniciarTemporizador()
        {
            if (!EstaActivo)
            {
                cancellationTokenSource = new();
                cancellationToken = cancellationTokenSource.Token;
                hilo = new Task(CorrerTiempo);
                hilo.Start();
            }
        }

        public void DetenerTemporizador()
        {
            if(EstaActivo)
            {
                cancellationTokenSource.Cancel();
            }
        }

        private void CorrerTiempo()
        {
            while (TiempoCumplido is not null && !cancellationToken.IsCancellationRequested)
            {
                TiempoCumplido?.Invoke();
                Thread.Sleep(intervalo);
            }
        }
    }
}
