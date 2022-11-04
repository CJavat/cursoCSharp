using System;
using System.Collections;
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
    public partial class codigoDelCurso : Form
    {
        public codigoDelCurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int numero = 10;
            string prueba = "Hola Nuevo Mundo";
            bool pruebaBooleano = true;

            // label1.Text = prueba;
            if(numero > 10)
            {
                lblResultado.Text = "El usuario es mayor de edad.";
            }
            else
            {
                lblResultado.Text = "El usuario es menor de edad.";
            }*/

            /*string textoEdad = txtEdad.Text; // PASARLE LA EDAD DEL USUARIO A LA VARIABLE.
            int edad = Int32.Parse(textoEdad); // CONVERTIR LA VARIABLE EN ENTERO.

            if (edad >= 18)
            {
                lblResultado.Text = "El usuario es mayor de edad.";
            }
            else
            {
                lblResultado.Text = "El usuario es menor de edad.";
            }*/

            // DECLARACIÓN DE ARRAYS Y BUCLES.
            /*List<int> lista = new List<int>(); // Declaración de un array.
            lista.Add(2); // AGREGAR UN DATO A LA LISTA.
            lista.Add(20);
            lista.Add(15);
            lista.Add(100);

            int[] lista2 = new int[] { 1, 2, 3, 4, 5 }; // ESTA ES OTRA FORMA PERO YA NO SE PUEDEN MODIFICAR LOS DATOS DADOS AL PRINCIPIO.

            for(int i=0; i < lista.Count; i++) // DECLARACIÓN DE FOR.
            {
                int numero = lista[i]; // FORMA DE ITERAR UN ARREGLO.
                MessageBox.Show(numero.ToString(), "BUCLE FOR"); // MOSTRAR EL RESULTADO DEL ARREGLO MEDIANTE UN MENSAJE.
            }

            int iteracion = 0;
            while(iteracion < 2) // DECLARACIÓN DE WHILE.
            {
                int numero = lista[iteracion];
                MessageBox.Show(numero.ToString(), "BUCLE WHILE");
                iteracion++;
            }

            int iteracion2 = 0;
            do
            {
                int numero = lista[iteracion2];
                MessageBox.Show(numero.ToString(), "BUCLE DO-WHILE");

                iteracion2++;

            }while(iteracion2 < 2);*/

            // INTRODUCCIÓN A LA FUNCIÓN.
            /*List<int> lista = traerListado();
            mostrarListado(lista);*/

            // POO.
            // EN LAS CLASES A LAS VARIABLES SE LES LLAMA PROPIEDADES Y A LAS FUNCIONES METODOS.
            /*
                CONCEPTOS DE LA POO:
                * HERENCIA --------> DARLE LAS PROPIEDADES DE LA CLASE PADRE A LA CLASE HIJA.
                * ABSTRACCIÓN -----> OBTENER LAS CARACTERISTICAS DE LA CLASE PADRE.
                * POLIMORFISMO ----> PODER MODIFICAR LOS MÉTODOS CREADOS EN LA CLASE PADRE.
                * ENCAPSULAMIENTO -> PONER LAS VARIABLES COMO PUBLICO O PRIVADAS PARA QUE SE LIMITE EL ACCESO A ÉSTAS.
            */
            /*
                TIPOS DE ENCAPSULAMIENTO:
                - PUBLICO:   DESDE OTRO LUGAR DEL CÓDIGO SE VA A PODER ACCEDER.
                - PROTEGIDO: 
                - PRIVADO:   SOLO SE VA A PODER UTILIZAR DENTRO DE LA MISMA CLASE.
            */
        }
        // CREACION DE UNA FUNCIÓN.
        private List<int> traerListado()
        {
            List<int> lista = new List<int>(); // Declaración de un array.
            lista.Add(2); // AGREGAR UN DATO A LA LISTA.
            lista.Add(20);
            lista.Add(15);
            lista.Add(100);

            return lista;
        }
        private void mostrarListado(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++) // DECLARACIÓN DE FOR.
            {
                int numero = lista[i]; // FORMA DE ITERAR UN ARREGLO.
                MessageBox.Show(numero.ToString(), "BUCLE FOR"); // MOSTRAR EL RESULTADO DEL ARREGLO MEDIANTE UN MENSAJE.
            }
        }
    }
}