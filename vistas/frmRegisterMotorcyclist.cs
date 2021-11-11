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
using final_motoDix.helpers;

namespace final_motoDix.Vistas
{
    public partial class frmRegisterMotorcyclist : Form
    {

        public frmRegisterMotorcyclist()
        {
            InitializeComponent();
        }

        private void frmRegisterMotorcyclist_Load(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmRegisterMotorcyclist_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            bfchkLoginDetails.Checked = true;

            bfpgRegisterVehicle.PageIndex = 1;
            
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

            bfpgRegisterVehicle.PageIndex = 2;

        }

        private void bfbtnLicenceNext_Click(object sender, EventArgs e)
        {
            bfchkVehicleInfo.Checked = true;
            bfpgRegisterVehicle.PageIndex = 3;

        }

        private void bfbtnInfoFinish_Click(object sender, EventArgs e)
        {
            bfchkLicence.Checked = true;
            //string idDocumentPerson, string email, string credentialPassword, int idRol,                                                              string licenseplate, string color, int model, int cylindercapacity, string brand, DateTime expeditiondatetechnomechanics, DateTime expirationdatetechnomechanics, DateTime expeditiondatesoat, DateTime initialvaliditysoat, DateTime finalvaliditysoat, string statee, string iddocumentowner, string firstname, string secondname,                                                                                string surname,    string secondsurname, string transitexpender, DateTime expeditiondate, string restrictions, string category, string service, DateTime validity, string stade, DateTime assignmentdate, string assignmentstate
            clsDriverController controladorConductor = new clsDriverController(bftxtDocumentoIdentidad.Text, bftxtxEmail.Text, bftxtPassword.Text, 2, bftxtPlacaVehiculo.Text, bftxtColor.Text, Convert.ToInt32(bftxtModelo.Text), Convert.ToInt32(bftxtCilindraje.Text), bftxtMarca.Text, bfdtpExpedicionTecnomecanica.Value, bftxtExpiracionTecnomecanica.Value, bfdtpExpedicionSoat.Value, bfdtpFechaInicioSoat.Value, bfdtpFechaFinalSoat.Value, "Valido", bftxtDocumentoPropietario.Text, bftxtPrimerNombrePropietario.Text, bftxtSegundoNombrePropietario.Text, bftxtPrimerApellidoPropietario.Text, bftxtSegundoApellidoPropietario.Text, bftxtTransitoExpendedor.Text, bfdtpExpedicion.Value, bftxtRestricciones.Text, bfCategoria.Text,"Privado", bfdtpVigencia.Value,"Valido",DateTime.Now, "Null");

            controladorConductor.ejecutarCrearDriver();

        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bfpgVehicle_Click(object sender, EventArgs e)
        {

        }
    }
}
