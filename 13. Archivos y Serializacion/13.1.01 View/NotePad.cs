using System.Drawing.Text;
using System.Text;

namespace _13._1._01_View_NotePad_
{
    public partial class Notepad : Form
    {
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        string archivo;

        public Notepad()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            statusStrip1.Text = "0 Caracteres";
        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MostrarMensajeError(Exception ex)
        {
            StringBuilder sb = new();
            sb.AppendLine($"Error {ex.Message}");
            sb.AppendLine(ex.StackTrace);

            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{richTextBox1.Text.Length} Caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    archivo = openFileDialog.FileName;
                    using (StreamReader sr = new StreamReader(archivo))
                    {
                        richTextBox1.Text = sr.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensajeError(ex);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(archivo))
            {

                GuardarArchivoFileDialog();
            }
            else
            {
                GuardarArchivo(archivo);
            }
        }

        private void GuardarArchivo(string ruta)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.Write(richTextBox1.Text);
                }

            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarArchivoFileDialog();
        }

        private void GuardarArchivoFileDialog()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivo = saveFileDialog.FileName;
                GuardarArchivo(archivo);
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{richTextBox1.Text.Length} Caracteres";
        }
    }
}
