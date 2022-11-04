using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursoDeNet
{
    public partial class practicaDePOOMENU : Form
    {
        public practicaDePOOMENU()
        {
            InitializeComponent();
        }

        private void btnGestionarClientes_Click(object sender, EventArgs e)
        {
            practicaDePOOGESTIONARCLIENTES ventanaGestioanrClientes = new practicaDePOOGESTIONARCLIENTES(); // CREAR UNA VARIABLE QUE TENGA UN FORMULARIO.
            ventanaGestioanrClientes.ShowDialog(); // MOSTRAR LA VENTANA.
        }
    }
}
