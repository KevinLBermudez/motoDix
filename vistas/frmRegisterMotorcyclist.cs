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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bfbtnLicenceNext_Click(object sender, EventArgs e)
        {
            


            
            if (bftxtPrimerNombrePropietario.Text != string.Empty && bftxtPrimerApellidoPropietario.Text != string.Empty 
                   && bftxtDocumentoPropietario.Text != string.Empty)
            {
                validacionPropietario.SetError(panelPropietario, "");
                bfchkVehicleInfo.Checked = true;
                bfpgRegisterVehicle.PageIndex = 3;
            }
            else
            {
                if (bftxtPrimerNombrePropietario.Text == string.Empty)
                {
                    validacionPropietario.SetError(panelPropietario, "Es necesario introducir el nombre");
                }
                else if (bftxtPrimerApellidoPropietario.Text == string.Empty)
                {
                    validacionPropietario.SetError(panelPropietario, "Es necesario introducir un apellido");
                }
                else if (bftxtDocumentoPropietario.Text == string.Empty)
                {
                    validacionPropietario.SetError(panelPropietario, "Es necesario introducir el documento");
                }
            }
        }

        private void bfbtnInfoFinish_Click(object sender, EventArgs e)
        {
            if (bftxtTransitoExpendedor.Text != string.Empty
                   && bfCategoria.Text != string.Empty)
            {
                validacionLicencia.SetError(panelLicencia, "");
                bfchkLicence.Checked = true;
                clsDriverController controladorConductor = new clsDriverController(bftxtDocumentoIdentidad.Text, bftxtxEmail.Text, bftxtPassword.Text, 2, bftxtPlacaVehiculo.Text, bftxtColor.Text, Convert.ToInt32(bftxtModelo.Text), Convert.ToInt32(bftxtCilindraje.Text), bftxtMarca.Text, bfdtpExpedicionTecnomecanica.Value, bftxtExpiracionTecnomecanica.Value, bfdtpExpedicionSoat.Value, bfdtpFechaInicioSoat.Value, bfdtpFechaFinalSoat.Value, "Solicitado", bftxtDocumentoPropietario.Text, bftxtPrimerNombrePropietario.Text, bftxtSegundoNombrePropietario.Text, bftxtPrimerApellidoPropietario.Text, bftxtSegundoApellidoPropietario.Text, bftxtTransitoExpendedor.Text, bfdtpExpedicion.Value, bftxtRestricciones.Text, bfCategoria.Text, "Privado", bfdtpVigencia.Value, "Valido", DateTime.Now);
                controladorConductor.ejecutarCrearDriver();
                frmLogin login = new frmLogin(1);
                
            }
            else
            {
                if (bftxtTransitoExpendedor.Text == string.Empty)
                {
                    validacionLicencia.SetError(panelLicencia, "Es necesario introducir el transito expendedor");
                }
                else if (bfCategoria.Text == string.Empty)
                {
                    validacionLicencia.SetError(panelLicencia, "Es necesario introducir una categoria");
                }
            }
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
        private void bfbtnNext0_Click(object sender, EventArgs e)
        {
            if (bftxtxEmail.Text != bftxtConfirmarEmail.Text)
            {
                validacionLogin.SetError(panelLogin, "Los correos no coinciden");

            }else if (bftxtPassword.Text != bftxtConfirmPassword.Text)
            {
                validacionLogin.SetError(panelLogin, "Las contraseñas no coinciden");
            }
            else if (bftxtDocumentoIdentidad.Text != string.Empty && bftxtxEmail.Text != string.Empty && bftxtConfirmarEmail.Text != string.Empty
                   && bftxtPassword.Text != string.Empty && bftxtConfirmPassword.Text != string.Empty)
            {
                validacionLogin.SetError(panelLogin, "");
                bfchkLoginDetails.Checked = true;
                bfpgRegisterVehicle.PageIndex = 1;
            }
            else
            {
                if (bftxtDocumentoIdentidad.Text == string.Empty)
                {
                    validacionLogin.SetError(panelLogin, "Es necesario introducir el documento");
                }
                else if (bftxtxEmail.Text == string.Empty)
                {
                    validacionLogin.SetError(panelLogin, "Es necesario introducir el email");
                }
                else if (bftxtConfirmarEmail.Text == string.Empty)
                {
                    validacionLogin.SetError(panelLogin, "Es necesario confirmar tu email");
                }
                else if (bftxtPassword.Text == string.Empty)
                {
                    validacionLogin.SetError(panelLogin, "Es necesario introducir una contraseña");
                }
                else if (bftxtConfirmPassword.Text == string.Empty)
                {
                    validacionLogin.SetError(panelLogin, "Es necesario confirmar tu contraseña");
                }
            }
        }

        private void bfbtnNext1_Click(object sender, EventArgs e)
        {
            if (!(bftxtCilindraje.Text.All(char.IsDigit)))
            {
                   validacionLogin.SetError(panelVehicle, "En el campo cilindraje solo se aceptan datos numericos");
            }
            else if (!(bftxtModelo.Text.All(char.IsDigit)))
            {
                validacionLogin.SetError(panelVehicle, "En el campo modelo solo se aceptan datos numericos");
            }
            else if (bftxtPlacaVehiculo.Text != string.Empty && bftxtCilindraje.Text != string.Empty
                   && bftxtModelo.Text != string.Empty && bftxtMarca.Text != string.Empty && bftxtColor.Text != string.Empty)
            {
                validacionLogin.SetError(panelVehicle, "");
                bfpgRegisterVehicle.PageIndex = 2;
            }
            else
            {
                if (bftxtPlacaVehiculo.Text == string.Empty)
                {
                    validacionLogin.SetError(panelVehicle, "Es necesario introducir la placa del vehiculo");
                }
                else if (bftxtCilindraje.Text == string.Empty)
                {
                    validacionLogin.SetError(panelVehicle, "Es necesario introducir tu cilindraje");
                }
                else if (bftxtModelo.Text == string.Empty)
                {
                    validacionLogin.SetError(panelVehicle, "Es necesario introducir el modelo de la moto");
                }
                else if (bftxtMarca.Text == string.Empty)
                {
                    validacionLogin.SetError(panelVehicle, "Es necesario introducir la maraca");
                }
                else if (bftxtColor.Text == string.Empty)
                {
                    validacionLogin.SetError(panelVehicle, "Es necesario introducir el color");
                }
            }
        }
    }
}
