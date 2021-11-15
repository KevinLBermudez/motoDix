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

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            bfpgRegisterVehicle.PageIndex = 0;
        }

        private void bfbtnAtras2_Click(object sender, EventArgs e)
        {
            bfpgRegisterVehicle.PageIndex = 1;
        }

        private void bfbtnAtras1_Click(object sender, EventArgs e)
        {
            bfpgRegisterVehicle.PageIndex = 0;
        }

        private void bfbtnAtras2_Click_1(object sender, EventArgs e)
        {
            bfpgRegisterVehicle.PageIndex = 1;
        }

        private void bfbtnAtras3_Click(object sender, EventArgs e)
        {
            bfpgRegisterVehicle.PageIndex = 2;
        }
    }
}
