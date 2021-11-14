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
using final_motoDix.Estructuras;
using Bunifu.UI.WinForms;

namespace final_motoDix.Vistas
{
    public partial class frmSolicitudViajes : Form
    {
        clsViajeController viajes;
        public Iconductor infoDriver;
        string travelId = "null";

        public frmSolicitudViajes(Iconductor infoDriver)
        {
            this.infoDriver = infoDriver;
            InitializeComponent();
            
        }

        private void bfbtnAceptar_Click(object sender, EventArgs e)
        {
            viajes = new clsViajeController(travelId,infoDriver.licenseplate, infoDriver.idDocumentPersonDriver);
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

        private void frmSolicitudViajes_Load(object sender, EventArgs e)
        {
            viajes = new clsViajeController();
            viajes.ejecutarObtenerViajesSolicitados(bfdgvSolicitudes);
        }

        private void contadorSolicitud_Tick(object sender, EventArgs e)
        {
             viajes.ejecutarObtenerViajesSolicitados(bfdgvSolicitudes);
            
        }

        private void bfdgvSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaViaje = bfdgvSolicitudes.CurrentRow.Index;
            bftxtPuntoInicio.Text = bfdgvSolicitudes.Rows[filaViaje].Cells[4].Value.ToString();
            bftxtPuntoLlegada.Text = bfdgvSolicitudes.Rows[filaViaje].Cells[5].Value.ToString();
            bftxtCliente.Text = bfdgvSolicitudes.Rows[filaViaje].Cells[2].Value.ToString() +" " + bfdgvSolicitudes.Rows[filaViaje].Cells[3].Value.ToString();
            travelId = bfdgvSolicitudes.Rows[filaViaje].Cells[0].Value.ToString();
        }

    }
       
}
