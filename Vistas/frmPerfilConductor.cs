using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_motoDix.Modelos;
using System.Windows.Forms;

namespace final_motoDix.Vistas
{
    public partial class frmPerfilConductor : Form
    {

        public Driver infoDriver;

        public frmPerfilConductor(Driver infoDriver)
        {
            this.infoDriver = infoDriver;
            InitializeComponent();
        }

        public frmPerfilConductor()
        {
            InitializeComponent();
        }


        private void bfpgLogin_Click(object sender, EventArgs e)
        {

        }

        private void frmPerfilConductor_Load(object sender, EventArgs e)
        {
            bftxtxEmail.Text = infoDriver.P_emailCredentials;
            bftxtConfirmarEmail.Text = infoDriver.P_emailCredentials;
            bftxtPassword.Text = infoDriver.P_credentialpasswordCredentials;
            bftxtConfirmPassword.Text = infoDriver.P_credentialpasswordCredentials;
            bftxtPlacaVehiculo.Text = infoDriver.P_licenseplateVehicle;
            bftxtCilindraje.Text = Convert.ToString(infoDriver.P_cylindercapacityVehicle);
            bftxtModelo.Text = Convert.ToString(infoDriver.P_modelVehicle);
            bftxtMarca.Text = infoDriver.P_brandVehicle;
            bfdtpExpedicionSoat.Value = infoDriver.P_expeditiondatesoatVehicle;
            bfdtpFechaInicioSoat.Value = infoDriver.P_initialvaliditysoatVehicle;
            bfdtpFechaFinalSoat.Value = infoDriver.P_finalvaliditysoatVehicle;
            bfdtpExpedicionTecnomecanica.Value = infoDriver.P_expeditiondatetechnomechanicsVehicle;
            bftxtExpiracionTecnomecanica.Value = infoDriver.P_expirationdatetechnomechanicsVehicle;
        }
    }
}
