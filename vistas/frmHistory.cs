using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final_motoDix.Modelos;
using final_motoDix.Estructuras;

namespace final_motoDix.Vistas
{
    public partial class frmHistory : Form
    {
        public Iconductor infoDriver;
        Persona infoPersona;
        int Rol;

        public frmHistory(Persona infoPersona)
        {
            InitializeComponent();
            this.infoPersona = infoPersona;
            Rol = 1;
        }
        public frmHistory(Iconductor infoConductor)
        {
            InitializeComponent();
            this.infoDriver = infoConductor;
            Rol = 2;
        }

        private void ptbMinizarHViajes_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void ptbMaximizarHViajes_Click(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void ptbCerrarHViajes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
