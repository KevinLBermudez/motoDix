﻿using System;
using final_motoDix.Vistas;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_motoDix
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
         
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmIdentifier());

        }
    }
}
