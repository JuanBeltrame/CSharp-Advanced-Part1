namespace _14._1._01_View
{
    public partial class FrmPrincipal : Form
    {
        private FrmTestDelegados frmTestDelegados;
        private FrmMostrar frmMostrar;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmMostrar = new();
            frmMostrar.MdiParent = this;

            frmTestDelegados = new(frmMostrar.ActualizarNombre);
            frmTestDelegados.MdiParent = this;


            mostrarToolStripMenuItem.Enabled = false;

        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar.Show();
        }
    }
}
