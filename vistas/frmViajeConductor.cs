using Bunifu.UI.WinForms;
using final_motoDix.Controladores;
using final_motoDix.Estructuras;
using final_motoDix.helpers;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static final_motoDix.Estructuras.EViaje;

namespace final_motoDix.Vistas
{
    public partial class frmViajeConductor : Form
    {
        clsViajeController viajes;
        public Iconductor infoDriver;
        string travelId = null;
        clsMapa mapa;
        string inicio = null;
        string final = null;
        EstViaje viaje;
        bool viendoDetalles = false;
        PointLatLng inicioPoint;
        PointLatLng finalPoint;
        double inicioPointLat;
        double inicioPointLng;
        double finalPointLat;
        double finalPointLng;


        public frmViajeConductor(Iconductor infoDriver)
        {
            this.infoDriver = infoDriver;
            InitializeComponent();
            mapa = new clsMapa(gMapControl);
            mapa.cargarConfiguracionesMapa();

        }

        public frmViajeConductor()
        {
            InitializeComponent();
        }

        private void bftpSolicitudes_Click(object sender, EventArgs e)
        {

        }

        private void bfdgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void frmViajeConductor_Load(object sender, EventArgs e)
        {
            if (infoDriver.driverstade == "Activo")
            {
                viajes = new clsViajeController();
                viajes.ejecutarObtenerViajesSolicitados(bfdgvSolicitudes);

            }
            else if(infoDriver.driverstade == "Rechazado")
            {
                bfSnackbarSolicitud.Show(this, "Lamentablemente su solicitud fue rechazada, esperamos que en un futuro trabaje con nosotros", BunifuSnackbar.MessageTypes.Error, 10000,
                         "Peticion rechazada", BunifuSnackbar.Positions.BottomRight);
            }
            else
            {
                bfSnackbarSolicitud.Show(this, "Usted aun no se encuentra activo como conductor, espere hasta que aprueben su solicitud", BunifuSnackbar.MessageTypes.Error, 5000,
                 "Acceso denegado", BunifuSnackbar.Positions.BottomRight);
            }
        }

        private void contadorSolicitud_Tick(object sender, EventArgs e)
        {
            if (infoDriver.driverstade == "Activo")
            {
                if (!viendoDetalles)
                {
                    viajes.ejecutarObtenerViajesSolicitados(bfdgvSolicitudes);

                }
            }
           
        }

        private void bfbtnVerDetalles_Click(object sender, EventArgs e)
        {

            if(travelId != null)
            {
                viendoDetalles = true;
                bfpgTramitesViaje.PageIndex = 1;
                viaje = viajes.ejecutarMonitorearViajeConductor(travelId);
                bftptxtPuntoInicio2.Text = inicio;
                bftptxtDestino2.Text = final;
                lblDescuentoValor.Text = viaje.Discount.ToString();
                lblFacturaValor.Text = viaje.ValueTravel.ToString();
                lblNombreCliente.Text = viaje.FirstNameCustomer + " " +  viaje.SurnameCustomer;
                bfImagenCliente.ImageLocation = viaje.ProfilePictureCustomer;

            }
            else
            {
                bfSnackbarSolicitud.Show(this, "Debe seleccionar un viaje para ver los detalles de este", BunifuSnackbar.MessageTypes.Information, 5000,
                   "Rechazo", BunifuSnackbar.Positions.BottomRight);
            }

        }

        private void bfbtnAceptar_Click(object sender, EventArgs e)
        {
            if(travelId != null)
            {
                try
                {
                    viajes = new clsViajeController(travelId, infoDriver.licenseplate, infoDriver.idDocumentPersonDriver);

                }
                catch (Exception err)
                {
                    bfSnackbarSolicitud.Show(this, err.Message, BunifuSnackbar.MessageTypes.Error, 4000,
                    "Error", BunifuSnackbar.Positions.BottomRight);
                }
                try
                {
                    if (viajes.ejecutaraceptarViaje())
                    {
                        bfbtnAceptar.Enabled = false;
                        bfSnackbarSolicitud.Show(this, "Usted acaba de aceptar un viaje", BunifuSnackbar.MessageTypes.Information, 4000,
                        "Viaje iniciado", BunifuSnackbar.Positions.BottomRight);

                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                bfSnackbarSolicitud.Show(this, "Debe seleccionar un vaije para aceptarlo", BunifuSnackbar.MessageTypes.Information, 4000,
                        "Viaje rechazado", BunifuSnackbar.Positions.BottomRight);
            }
          
        }


        private void bftgResumenViaje_Enter(object sender, EventArgs e)
        {
            try
            {
                inicioPoint = new PointLatLng(inicioPointLat,inicioPointLng);
                finalPoint = new PointLatLng(finalPointLat,finalPointLng);

                mapa.calcularRutaTexto(inicioPoint, finalPoint);

            }
            catch (Exception err)
            {
                bfbtnAceptar.Enabled = false;
                bfSnackbarSolicitud.Show(this, err.Message, BunifuSnackbar.MessageTypes.Error, 4000,
                "Error", BunifuSnackbar.Positions.BottomRight);
            }

        }

        private void bfdgvSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaViaje = bfdgvSolicitudes.CurrentRow.Index;
            inicio = bfdgvSolicitudes.Rows[filaViaje].Cells[4].Value.ToString();
            final = bfdgvSolicitudes.Rows[filaViaje].Cells[5].Value.ToString();
            bftxtPuntoInicio.Text = inicio;
            bftxtPuntoLlegada.Text = final;
            bftxtCliente.Text = bfdgvSolicitudes.Rows[filaViaje].Cells[2].Value.ToString() + " " + bfdgvSolicitudes.Rows[filaViaje].Cells[3].Value.ToString();
            travelId = bfdgvSolicitudes.Rows[filaViaje].Cells[0].Value.ToString();

            inicioPointLat = double.Parse(bfdgvSolicitudes.Rows[filaViaje].Cells[7].Value.ToString());
            inicioPointLng = double.Parse(bfdgvSolicitudes.Rows[filaViaje].Cells[8].Value.ToString());
            finalPointLat = double.Parse(bfdgvSolicitudes.Rows[filaViaje].Cells[9].Value.ToString());
            finalPointLng = double.Parse(bfdgvSolicitudes.Rows[filaViaje].Cells[10].Value.ToString());

            inicioPoint = new PointLatLng();
        }

        private void timerVerEstado_Tick(object sender, EventArgs e)
        {

            try
            {
                if(travelId != null)
                {
                    lblEstadoViaje.Text = viajes.ejecutarVerEstado();

                }
            }
            catch (Exception err)
            {
                bfSnackbarSolicitud.Show(this,err.Message, BunifuSnackbar.MessageTypes.Error, 4000,
                   "Error", BunifuSnackbar.Positions.BottomRight);
            }

        }
    }
}
