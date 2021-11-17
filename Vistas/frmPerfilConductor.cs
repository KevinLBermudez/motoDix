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
            bftxtPrimerNombre.Text = infoDriver.firstname;
            bftxtSegundoNombre.Text = infoDriver.secondname;
            bftxtPrimerApellido.Text = infoDriver.secondsurname;
            bftxtSegundoApellido.Text = infoDriver.secondsurname;
            dateTimePicker1.Value = infoDriver.dateofbirth;
            bunifuPictureBox1.ImageLocation = infoDriver.profilePicture;
            bftxtPlacaVehiculo.Text = infoDriver.licenseplate;
            bftxtCilindraje.Text = Convert.ToString(infoDriver.cylindercapacity);
            bftxtModelo.Text = Convert.ToString(infoDriver.model);
            bftxtMarca.Text = infoDriver.brand;
            bfdtpExpedicionSoat.Value = infoDriver.expeditiondatesoat;
            bfdtpFechaInicioSoat.Value = infoDriver.initialvaliditysoat;
            bfdtpFechaFinalSoat.Value = infoDriver.finalvaliditysoat;
            bfdtpExpedicionTecnomecanica.Value = infoDriver.expeditiondatetechnomechanics;
            bftxtExpiracionTecnomecanica.Value = infoDriver.expirationdatetechnomechanics;
            bftxtPrimerApellidoPropietario.Text = infoDriver.ownersurname;
            bftxtPrimerNombrePropietario.Text = infoDriver.ownerfirstname;
            bftxtSegundoNombrePropietario.Text = infoDriver.ownersecondname;
            bftxtSegundoApellidoPropietario.Text = infoDriver.ownersecondsurname;
            bftxtTransitoExpendedor.Text = infoDriver.licensetransitexpender;
            bftxtFechaExpedicion.Text = Convert.ToString(infoDriver.licenseexpeditiondate);
            bftxtRestricciones.Text = infoDriver.licenserestrictions;
            bfCategoria.Text = infoDriver.licensecategory;
            bfFechaVigencia.Value = infoDriver.licensevalidity;
        }

        private void bfbtnVerMas_Click(object sender, EventArgs e)
        {
            bfpgRegisterVehicle.PageIndex = 1;
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            bfpgRegisterVehicle.PageIndex = 2;

        }

        private void bfbtnLicenceNext_Click(object sender, EventArgs e)
        {
            bfpgRegisterVehicle.PageIndex = 3;

        }

        private void bfbtnAtras_Click(object sender, EventArgs e)
        {
            bfpgRegisterVehicle.PageIndex = 0;

        }

        private void bfbtnAtras2_Click(object sender, EventArgs e)
        {
            bfpgRegisterVehicle.PageIndex = 1;

        }

        private void bfbtnAtras3_Click(object sender, EventArgs e)
        {
            bfpgRegisterVehicle.PageIndex = 2;

        }
    }
}
