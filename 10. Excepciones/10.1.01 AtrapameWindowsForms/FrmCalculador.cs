using _10._1._01_AtrapameLibrary;

namespace _10._1._01_AtrapameWindowsForms

{
    public partial class FrmCalculador : Form
    {
        public FrmCalculador()
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
                if (textLitros.Text == string.Empty || textKilometros.Text == string.Empty)
                {
                    throw new ParametrosVaciosException("Alguno de los campos esta vacio");
                }

                this.rtbCalculador.Text = $"Km / hs: {Calculador.Calcular(int.Parse(textKilometros.Text), int.Parse(textLitros.Text))}";
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textLitros_TextChanged(object sender, EventArgs e)
        {

        }

        private void textKilometros_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbCalculador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
