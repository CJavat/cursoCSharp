using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoDeNet
{
    internal class Cliente
    {
        /*private string nombre; // DECLARACION EN PRIVADO PARA QUE NO PUEDAN ACCEDER A ESTA VARIABLE DESDE OTRA PARTE DEL CODIGO.
        private string apellido;
        private string telefono;
        private string tarjetaDeCredito;*/

        // CREACION DE GETTERS Y SETTERS.
        /*public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }*/
        // LA FORMA MAS SIMPLIFICADA DE CREAR LOS GETTERS Y SETTER:
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string TarjetaDeCredito { get; set; }

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; } // YA NO ES NECESARIO CREAR LAS VARIABLES PORQUE CON LOS GETTER Y SETTER SE CREAN.
        }

        // CREAR UN METODO PARA QUE SE VEAN BIEN TODOS LOS DATOS EN LA LISTA QUE SE AGREGARON CON LAS CLASES
        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}