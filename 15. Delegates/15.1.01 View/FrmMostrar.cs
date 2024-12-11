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
    public partial class FrmMostrar : Form
    {
        public FrmMostrar() => InitializeComponent();
        
        public void ActualizarNombre(string nombre) => lblNombre.Text = nombre;   
        
    }
}
