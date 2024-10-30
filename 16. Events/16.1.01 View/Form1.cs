using _16._1._01_Library;
using System.Windows.Forms;

namespace _16._1._01_View
{
    public partial class Form1 : Form
    {
        Persona persona;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NotificarCambio(string msg) => MessageBox.Show(msg);
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (persona is null)
            {
                persona = new();
                persona.EventoString += msg => MessageBox.Show(msg);
                button1.Text = "Actualizar";
            }

            if (textBox1.Text != persona.Nombre)
                persona.Nombre = textBox1.Text;

            if (textBox2.Text != persona.Apellido)
                persona.Apellido = textBox2.Text;

            label3.Text = persona.Mostrar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
