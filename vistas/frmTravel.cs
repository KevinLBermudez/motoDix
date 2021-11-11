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
using final_motoDix.Modelos;
using final_motoDix.helpers;
using GMap.NET.MapProviders;
using GMap.NET;

namespace final_motoDix.Vistas
{
    public partial class frmTravel : Form
    {
        clsMapa mapa = new clsMapa();
        clsViajeController viaje;
        public Persona infoPersona;

        public frmTravel()
        {
            InitializeComponent();

        }
        public void cargarInfoPersona(Persona infoPersona)
        {
            this.infoPersona = infoPersona;
        }

        private void frmTravel_Load(object sender, EventArgs e)
        {
            mapa.cargarConfiguracionesMapa(gMapControl);

        }

        private void ptbMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbMaximizar_Click(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gMapControl_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var point = gMapControl.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;
                PointLatLng punto = new PointLatLng(lat, lng);
                
                mapa.seleccionarPunto(punto,gMapControl);

            }
        }

        private void gMapControl_Load(object sender, EventArgs e)
        {

        }

        private void btnUbicacionAcyual_Click(object sender, EventArgs e)
        {
            mapa.activarPosicionActual(gMapControl);
        }

        private void bfbtnSolicitarViaje_Click(object sender, EventArgs e)
        {
            try
            {
                string state = "Solicitado";
                mapa.validarRuta();

                viaje = new clsViajeController(infoPersona.IdDocumentPersona,mapa.infoViajeRuta[0].Dato,mapa.infoViajeRuta[1].Dato, state);


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
    }
}
