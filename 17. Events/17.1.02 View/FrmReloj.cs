namespace _16._1._02_View
{
    public partial class FrmReloj : Form
    {
        private Temporizador temporizador;

        public FrmReloj()
        {
            InitializeComponent();
            temporizador = new(1000);
            temporizador.TiempoCumplido += AsignarHora;
        }

        private void btnIniciar_Click(object sender, EventArgs e) => temporizador.IniciarTemporizador();

        private void btnDetener_Click(object sender, EventArgs e) => temporizador.DetenerTemporizador();
        
        public void AsignarHora()
        {
            // Invoke required sera true si estamos en un hilo de ejecucion
            // distinto al hilo donde se instancio el control o formulario.
            // false si estamos en el mismo hilo
            if (lblHora.InvokeRequired) // 1. da true // 3. da false
            {
                // Guardo en un delegado el metodo que quiero llamar
                // desde el hilo donde se instancio el control / formulario
                Action asignarHora = AsignarHora;

                // Invoke para ejecutar ese metodo
                // (el que esta referenciado dentro del delegado)
                // desde el hilo donde se creo el control o formulario
                lblHora.Invoke(asignarHora); 
                // 2. llamada recursiva desde el hilo que creo el control 
            }
            else
            {
                // 4. Cambio el texto del lblHora
                lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }
    }
}
