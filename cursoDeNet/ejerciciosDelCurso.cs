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
    public partial class ejerciciosDelCurso : Form
    {
        public ejerciciosDelCurso()
        {
            InitializeComponent();
        }

        private void btnEnviarDatos_Click(object sender, EventArgs e)
        {
            // EJERCICIO #1 - MOSTRAR CUAL DE LOS 3 DATOS ES MAYOR.
            /*int resultado = mayorDeLosTres();
            MessageBox.Show("El mayor de los 3 números es: " + resultado, "Resultado");*/

            // EJERCICIO #2 - CALCULAR PROMEDIO.
            //calcularPromedio();

            // EJERCICIO #3 - NÚMERO PAR.
            //numeroPar();

            // EJERCICIO #4 - FACTURAZIÓN DE PRODUCTOS.

        }

        private int mayorDeLosTres()
        {
            int numero1 = Int32.Parse(txb_num1.Text);
            int numero2 = Int32.Parse(txb_num2.Text);
            int numero3 = Int32.Parse(txb_num3.Text);

            if(numero1 > numero2 && numero1 > numero3)
            {
                return numero1;
            }
            else if(numero2 > numero1 && numero2 > numero3)
            {
                return numero2;
            }
            else if(numero3 > numero1 && numero3 > numero2)
            {
                return numero3;
            }

            return 0;
        }

        private void calcularPromedio()
        {
            double calificacion1 = Double.Parse(txbCalificacion1.Text);
            double calificacion2 = Double.Parse(txbCalificacion2.Text);
            double calificacion3 = Double.Parse(txbCalificacion3.Text);
            
            double promedioTotal = (calificacion1 + calificacion2 + calificacion3) / 3;

            MessageBox.Show("Tu promedio total es de: " + promedioTotal, "Promedio Calculado");
        }

        private void numeroPar()
        {
            int numero = Int32.Parse(txbNumeroParOImpar.Text);

            if(numero%2 == 0)
            {
                MessageBox.Show("El número que ingresaste es PAR", "Par o Impar");
            }
            else
            {
                MessageBox.Show("El número que ingresaste es IMPAR", "Par o Impar");
            }
        }

        private void facturazionDeProductos()
        {

        }
    }
}
