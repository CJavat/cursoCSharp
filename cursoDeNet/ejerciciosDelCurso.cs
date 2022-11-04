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
            // TERMINADO.

            // EJERCICIO #5 - MOSTRAR LOS 100 PRIMEROS NUMEROS PRIMOS.
            numerosPrimos();
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

        private void numerosPrimos()
        {
            int numeroPrimo = Int32.Parse(txbNumeroPrimo.Text);
            bool esNumeroPrimo = true;

            for (int i=2; i<numeroPrimo; i++)
            {
                if(numeroPrimo%i == 0)
                {
                    esNumeroPrimo = false;
                }
            }

            if (esNumeroPrimo)
            {
                MessageBox.Show("El numero es primo", "Resultado numero primo");
            }
            else
            {
                MessageBox.Show("El numero NO es primo", "Resultado numero primo");
            }
        }

        private void ejerciciosDelCurso_Load(object sender, EventArgs e)
        {
            // AÑADIR ITEMS AL COMBOBOX.
            cbbProductos.Items.Add("Pantalon");
            cbbProductos.Items.Add("Camisa");
            cbbProductos.Items.Add("Zapatos");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string productoSelecionado = cbbProductos.SelectedItem.ToString(); // OBTENER EL ARTICULO SELECCIONADO EN EL COMBOBOX.
            lstCarritoDeCompras.Items.Add(productoSelecionado); // AGREGA EL ARTICULO EN LA LISTA.s
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            double precioFinal = 0;
            int totalProductosCargados = lstCarritoDeCompras.Items.Count; // CUENTA CUANTOS ITEMS HAY EN LA LISTA DE CARRITOS.

            for (int i=0; i < totalProductosCargados; i++)
            { // RECORRE LA LISTA PARA IR SUMANDO EL PRECIO DE LOS ITEMS.
                string productoElegido = lstCarritoDeCompras.Items[i].ToString(); // LE PASA EL VALOR DEL ITEM.
                // COMPROBACION DE LO QUE SE HA AGREGADO A LA LISTA PARA HACER LA SUMA CORRESPONDIENTE.
                if(productoElegido == "Pantalon")
                {
                    precioFinal += 20;
                }
                else if(productoElegido == "Camisa")
                {
                    precioFinal += 35;
                }
                else if(productoElegido == "Zapatos")
                {
                    precioFinal += 24;
                }
            }

            // VERIFICA QUE HAYA INTRODUCIDO EL CODIGO DE DESCUENTO PARA HACER VALIDO EL DESCUENTO.
            if(txbCodigoDeDescuento.Text == "NAVIDAD")
            {
                precioFinal *= 0.90; // DESCUENTO DE 10%.
            }
            
            MessageBox.Show("El precio final es: " + precioFinal, "Precio Final"); // MOSTRAR EL PRECIO FINAL (TENIENDO O NO TENIENDO EL DESCUENTO).
        }
    }
}
