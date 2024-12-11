using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._1._01_View
{
    public partial class FrmTestDelegados : Form
    {
        private Action<string> delegadoActualizarNombre;

        public FrmTestDelegados(Action<string> delegadoActualizarNombre)
        {
            InitializeComponent();
            this.delegadoActualizarNombre = delegadoActualizarNombre;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.delegadoActualizarNombre?.Invoke(txtNombre.Text);
        }
    }
}
