﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursoDeNet
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new codigoDelCurso());
            // Application.Run(new calculadoraDelIDMC());
            // Application.Run(new ejerciciosDelCurso());
            Application.Run(new practicaDePOOMENU());
        }
    }
}
