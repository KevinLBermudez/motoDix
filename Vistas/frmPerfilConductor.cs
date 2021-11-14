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
using final_motoDix.Estructuras;

namespace final_motoDix.Vistas
{
    public partial class frmPerfilConductor : Form
    {

        public Iconductor infoDriver;

        public frmPerfilConductor(Iconductor infoDriver)
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
            bftxtxEmail.Text = infoDriver.email;
            bftxtConfirmarEmail.Text = infoDriver.email;
            //bftxtPassword.Text = infoDriver.;
            //bftxtConfirmPassword.Text = infoDriver.P_credentialpasswordCredentials;
            bftxtPlacaVehiculo.Text = infoDriver.licenseplate;
            bftxtCilindraje.Text = Convert.ToString(infoDriver.cylindercapacity);
            bftxtModelo.Text = Convert.ToString(infoDriver.model);
            bftxtMarca.Text = infoDriver.brand;
            bfdtpExpedicionSoat.Value = infoDriver.expeditiondatesoat;
            bfdtpFechaInicioSoat.Value = infoDriver.initialvaliditysoat;
            bfdtpFechaFinalSoat.Value = infoDriver.finalvaliditysoat;
            bfdtpExpedicionTecnomecanica.Value = infoDriver.expeditiondatetechnomechanics;
            bftxtExpiracionTecnomecanica.Value = infoDriver.expirationdatetechnomechanics;
        }
    }
}
