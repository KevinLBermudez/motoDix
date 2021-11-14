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
using Bunifu.UI.WinForms;
using final_motoDix.Estructuras;
using System.Diagnostics;
using static final_motoDix.Estructuras.EViaje;

namespace final_motoDix.Vistas
{
    public partial class frmTravel : Form
    {
        clsMapa mapa;
        double baseKilometro = 2500;
        double valorViaje = 4000;
        clsViajeController viaje;
        Persona infoPersona;
        EstViaje viajeEstructura;
        string travelId = null;
        bool banderaAceptacionViaje = false;
        Stopwatch timeMeasure = new Stopwatch();
        bool viajeActivo = false;

        public frmTravel(Persona infoPersona)
        {
            this.infoPersona = infoPersona;

            InitializeComponent();

        }

        private void frmTravel_Load(object sender, EventArgs e)
        {
            mapa = new clsMapa();

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
            this.AutoScroll = false;

        }

        private void btnUbicacionAcyual_Click(object sender, EventArgs e)
        {
            mapa.activarPosicionActual(gMapControl);
        }

        private void bfbtnSolicitarViaje_Click(object sender, EventArgs e)
        {
            try
            {
                if (!viajeActivo)
                {
                    string state = "Solicitado";
                    mapa.validarRuta();
                    lblDistanciaViajeValor.Text = mapa.infoViajeRuta[0].Dato + " metros";
                    lblTiempoValor.Text = mapa.infoViajeRuta[1].Dato;
                    bftxtInicio.Text = mapa.infoViajeRuta[2].Dato;
                    bftxtPuntoLlegada.Text = mapa.infoViajeRuta[3].Dato;
                    viaje = new clsViajeController(infoPersona.IdDocumentPersona, mapa.infoViajeRuta[2].Dato, mapa.infoViajeRuta[3].Dato, state);
                    travelId = viaje.ejecutarSolicitarViaje();
                    viaje = new clsViajeController(travelId);
                    timeMeasure.Start();
                    viajeActivo = true;
                }
                else
                {
                    MessageBox.Show("No se puede solicitar un viaje mientras tiene uno en curso");
                }
              
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void gMapControl_Click(object sender, EventArgs e)
        {
            this.AutoScroll = false;

        }

        private void frmTravel_Click(object sender, EventArgs e)
        {
            this.AutoScroll = true;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!banderaAceptacionViaje)
            {
                if (travelId != null)
                {
                    viajeEstructura = viaje.ejecutarMonitoreoViaje();

                    if (viajeEstructura.TravelId != null)
                    {
                        ptbProfilePictureDriver.ImageLocation = viajeEstructura.ProfilePictureDriver;
                        lblNombreConductor.Text = viajeEstructura.FirstNameDriver + " " + viajeEstructura.SecondNameDriver + " "
                        + viajeEstructura.SurnameDriver + " " + viajeEstructura.SecondSurname;

                        lblMarca.Text = viajeEstructura.Brand;
                        lblColor.Text = viajeEstructura.Color;
                        lblPlaca.Text = viajeEstructura.LicencePLate;

                        banderaAceptacionViaje = true;

                        double distancia =double.Parse(mapa.infoViajeRuta[0].Dato);

                        valorViaje = valorViaje + (distancia / 1000 * baseKilometro);
                        lblFacturaValor.Text = valorViaje.ToString();

                    }

                }
            }
          
        }

        private void bfbtnPagar_Click(object sender, EventArgs e)
        {
            if (banderaAceptacionViaje)
            {
                timeMeasure.Stop();
                TimeSpan time = timeMeasure.Elapsed;
                string timeElapsed = string.Format("{0:00}:{1:00}:{2:00}:{3:00}",time.Hours,time.Minutes,time.Seconds,time.Milliseconds/10);

                int rating = ratingDriver.Value;
            
                viaje.ejecutarCompletarViaje(travelId, valorViaje, timeElapsed, rating);
                banderaAceptacionViaje = false;
                limpiarFormulario();
            }
            else
            {
                MessageBox.Show("Debes tener un viaje activo antes de Finalizarlo");
            }

        }


        public void limpiarFormulario()
        {
            bftxtPuntoInicio.Clear();
            bftxtPuntoLlegada.Clear();
            bftxtInicio.Clear();
            ptbProfilePictureDriver.ImageLocation = "https://res.cloudinary.com/dhameorhz/image/upload/v1636677166/defaulHombre_xssu9f.jpg";
            lblNombreConductor.Text = "Nombre conductor";
            lblMarca.Text = "Marca";
            lblColor.Text = "Color";
            lblPlaca.Text = "Placa";
            lblTiempoValor.Text = ":";
            lblDistanciaViajeValor.Text = ":";
            lblFacturaValor.Text = ":";
            lblDescuntoValor.Text = ":";
            lblTotalViajeValor.Text = ":";
            mapa = new clsMapa();
            mapa.limpiarPuntos(gMapControl);
            mapa.cargarConfiguracionesMapa(gMapControl);

        }

    }
}
