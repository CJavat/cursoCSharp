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
    public partial class calculadoraDelIDMC : Form
    {
        public calculadoraDelIDMC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorPeso = Double.Parse(txbPeso.Text); // PESO EN KG.
            double valorAltura = Double.Parse(txbAltura.Text); // ALTURA EN M.
            double IMC = (valorPeso / (valorAltura * valorAltura));

            lblAltura.Text = IMC.ToString();
            MessageBox.Show("El IMC ES: " + IMC);
        }
    }
}
