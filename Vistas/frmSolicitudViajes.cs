using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final_motoDix.Controladores;
namespace final_motoDix.Vistas
{
    public partial class frmSolicitudViajes : Form
    {
        clsViajeController viajes;

        public frmSolicitudViajes()
        {
            InitializeComponent();
        }

        private void bfbtnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void frmSolicitudViajes_Load(object sender, EventArgs e)
        {
            viajes = new clsViajeController();
            viajes.ejecutarObtenerViajesSolicitados(bfdgvSolicitudes);
        }

        private void contadorSolicitud_Tick(object sender, EventArgs e)
        {
             viajes.ejecutarObtenerViajesSolicitados(bfdgvSolicitudes);
            
        }
    }
       
}
