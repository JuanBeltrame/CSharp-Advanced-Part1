using _10._1._01_AtrapameLibrary;

namespace _10._1._01_AtrapameWindowsForms

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textLitros.Text == string.Empty || this.textKilometros.Text == string.Empty)
                {
                    throw new ParametrosVaciosException("Alguno de los campos esta vacio");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
