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
using final_motoDix.Controladores;
using Bunifu.UI.WinForms;

namespace final_motoDix.Vistas
{
    public partial class frmHistory : Form
    {

        public Iconductor infoDriver;
        Persona infoPersona;
        int Rol;
        clsViajeController viaje;

        public frmHistory(Persona infoPersona)
        {
            InitializeComponent();
            this.infoPersona = infoPersona;
            Rol = 1;
            viaje = new clsViajeController();
        }
        public frmHistory(Iconductor infoConductor)
        {
            InitializeComponent();
            this.infoDriver = infoConductor;
            Rol = 2;
            viaje = new clsViajeController();

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

        private void frmHistory_Load(object sender, EventArgs e)
        {

        }

        private void bfbtnConsultarHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                if(Rol == 1)
                {
                    viaje.ejecutarObtenerHistorial(infoPersona.IdDocumentPersona, Rol,bfdtpkDesde.Value,bfdtpkHasta.Value.AddDays(1),bfdgvHistorial);

                }else if(Rol == 2)
                {
                    viaje.ejecutarObtenerHistorial(infoDriver.idDocumentPersonDriver, Rol, bfdtpkDesde.Value, bfdtpkHasta.Value.AddDays(1), bfdgvHistorial);

                }

            }
            catch (Exception err)
            {

                bfSnackbarViajeHistory.Show(this, err.Message, BunifuSnackbar.MessageTypes.Error, 4000,
                        "Error", BunifuSnackbar.Positions.BottomRight);
            }

        }
    }
}
