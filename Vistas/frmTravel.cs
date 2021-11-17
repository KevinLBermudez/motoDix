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
using System.Threading;

namespace final_motoDix.Vistas
{
    public partial class frmTravel : Form
    {
        clsMapa mapa;
        double baseKilometro = 2500;
        double valorViaje = 4000;
        double descuento = 0;
        clsViajeController viaje;
        Persona infoPersona;
        EstViaje viajeEstructura;
        string travelId = null;
        bool banderaAceptacionViaje = false;
        Stopwatch timeMeasure = new Stopwatch();
        bool viajeActivo = false;
        PointLatLng Inicio;
        PointLatLng Destino;

        public frmTravel(Persona infoPersona)
        {
            this.infoPersona = infoPersona;

            InitializeComponent();

        }

        private void frmTravel_Load(object sender, EventArgs e)
        {
            mapa = new clsMapa(gMapControl);

            mapa.cargarConfiguracionesMapa();

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
                
                mapa.seleccionarPunto(punto);

                cargarLabels();
            }
        }

        private void gMapControl_Load(object sender, EventArgs e)
        {
            this.AutoScroll = false;

        }

        private void btnUbicacionAcyual_Click(object sender, EventArgs e)
        {
    
            mapa.activarPosicionActual(gMapControl);

            cargarLabels();
          
        }

        private void bfbtnSolicitarViaje_Click(object sender, EventArgs e)
        {
            try
            {
                if(Int32.Parse(mapa.infoViajeRuta[0].Dato) > 30000)
                {
                    bfSnackbarTravel.Show(this, "No se puede solicitar un viaje con una ruta de mas de 30 kilometros", BunifuSnackbar.MessageTypes.Error, 6000,
                   "Denegado", BunifuSnackbar.Positions.BottomRight);
                    limpiarFormulario();
                }
                else
                {
                    if (!viajeActivo)
                    {
                        string state = "Solicitado";
                        mapa.validarRuta();

                        viaje = new clsViajeController(infoPersona.IdDocumentPersona, mapa.infoViajeRuta[2].Dato, mapa.infoViajeRuta[3].Dato,
                            valorViaje, descuento, state,mapa.puntoInicio.Lat.ToString(),mapa.puntoInicio.Lng.ToString(),mapa.puntoFinal.Lat.ToString(),
                            mapa.puntoFinal.Lng.ToString());


                        travelId = viaje.ejecutarSolicitarViaje();
                        viaje = new clsViajeController(travelId);
                        timeMeasure.Start();
                        viajeActivo = true;
                        bfSnackbarTravel.Show(this, "Su viaje se ha solicitado correctamente", BunifuSnackbar.MessageTypes.Success, 4000,
                        "Solicitado", BunifuSnackbar.Positions.BottomRight);
                    }
                    else
                    {
                        bfSnackbarTravel.Show(this, "No se puede solicitar un viaje mientras tiene uno en curso", BunifuSnackbar.MessageTypes.Information, 4000,
                        "Solicitud rechazada", BunifuSnackbar.Positions.BottomRight);
                    }
                }
              
            }
            catch (Exception err)
            {
                bfSnackbarTravel.Show(this, err.Message, BunifuSnackbar.MessageTypes.Error, 4000,
                    "Error interno", BunifuSnackbar.Positions.BottomRight);
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

                        if(viajeEstructura.State == "Aceptado")
                        {
                            bfpgbEstadoViaje.Value = 50;

                        }

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
                viaje.ejecutarCompletarViaje(travelId, timeElapsed, rating);
                banderaAceptacionViaje = false;
                bfpgbEstadoViaje.Value = 100;
                lblEstadoViaje.Text = "completado";
                bfSnackbarTravel.Show(this, "Su viaje a finalizado con exito, Feliz dia", BunifuSnackbar.MessageTypes.Success, 4000,
                "Completado", BunifuSnackbar.Positions.BottomRight);
                limpiarFormulario();
            }
            else
            {
                   bfSnackbarTravel.Show(this, "Debes tener un viaje activo para pagar y terminar", BunifuSnackbar.MessageTypes.Information, 4000,
                 "Solicitud rechazada", BunifuSnackbar.Positions.BottomRight);
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
            bfpgbEstadoViaje.Value = 20;
            lblEstadoViaje.Text = "Solicitado";
            travelId = null;
            viajeActivo = false;
            mapa = new clsMapa(gMapControl);
            mapa.limpiarPuntos(gMapControl);
            mapa.cargarConfiguracionesMapa();

        }

        private void pbBuscarPuntoInicial_Click(object sender, EventArgs e)
        {
           Inicio= mapa.buscarPunto(bftxtInicio.Text);
        }

        private void pbBuscarPuntoLlegada_Click(object sender, EventArgs e)
        {
            Destino= mapa.buscarPunto(bftxtPuntoLlegada.Text);

        }

        private void lblConfirmarInicio_Click(object sender, EventArgs e)
        {
            mapa.seleccionarPunto(Inicio,"Punto Inicial");
            cargarLabels();
        }

        private void lblConfirmarDestino_Click(object sender, EventArgs e)
        {
            mapa.seleccionarPunto(Destino, "Punto de destino");
            cargarLabels();
        }
        
        public void cargarLabels()
        {
            if (mapa.validarRuta())
            {
                lblDistanciaViajeValor.Text = mapa.infoViajeRuta[0].Dato + " metros";
                lblTiempoValor.Text = mapa.infoViajeRuta[1].Dato;
                bftxtInicio.Text = mapa.infoViajeRuta[2].Dato;
                bftxtPuntoLlegada.Text = mapa.infoViajeRuta[3].Dato;

                double distancia = double.Parse(mapa.infoViajeRuta[0].Dato);

                valorViaje = valorViaje + (distancia / 1000 * baseKilometro);
                lblFacturaValor.Text = valorViaje.ToString();
            }
        }
    }
}
