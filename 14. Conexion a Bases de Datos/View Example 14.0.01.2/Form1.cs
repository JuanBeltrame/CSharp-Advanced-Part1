using Library_Example_14._0._01;

namespace View_Example_14._0._01._2
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
       
        private void Form1_Load(object sender, EventArgs e) => dtgvPersonas.DataSource = PersonaAccesoDatos.Leer();
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) => Refrescar();
      
        private void Refrescar()
        {
            dtgvPersonas.DataSource = PersonaAccesoDatos.Leer();
            dtgvPersonas.Update();
            dtgvPersonas.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgvPersonas.SelectedRows.Count > 0)
            {
                Persona persona = (Persona)dtgvPersonas.CurrentRow.DataBoundItem;
                PersonaAccesoDatos.Eliminar(persona.Id);
                Refrescar();
            }
        }
    }
}
