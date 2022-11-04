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
    public partial class practicaDePOOGESTIONARCLIENTES : Form
    {
        public practicaDePOOGESTIONARCLIENTES()
        {
            InitializeComponent();
        }

        private void practicaDePOOGESTIONARCLIENTES_Load(object sender, EventArgs e)
        {
            //lstClientes.Items.Add();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // CREAR UN OBJETO CLASE Y AGREGARLE LOS DATOS.
            Cliente cliente = new Cliente();
            cliente.Nombre = txbNombre.Text;
            cliente.Apellido = txbApellido.Text;
            cliente.Telefono = txbTelefono.Text;
            cliente.TarjetaDeCredito = txbTarjetaDeCredito.Text;

            lstClientes.Items.Add(cliente);
            txbNombre.Text = "";
            txbApellido.Text = "";
            txbTelefono.Text = "";
            txbTarjetaDeCredito.Text = ""; 
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indiceCliente = lstClientes.SelectedIndex;
            lstClientes.Items.RemoveAt(indiceCliente);
        }
    }
}
