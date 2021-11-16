using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using final_motoDix.Controladores;
using final_motoDix.helpers;

namespace final_motoDix.Vistas
{
    public partial class frmRegisterClient : Form
    {
        clsPersonController persona;
        clsDepartamentoController departamento;
        clsCiudadController ciudad;
        clsCloudinary cloud;
        string profilePicture = "null";
        int rol = 1;

        public frmRegisterClient(int idRol)
        {
            rol = idRol;
            InitializeComponent();
            ptbCrearCuentaMinimizar.Enabled = false;
            ptbCrearCuentaMinimizar.Visible = false;

        }

        public frmRegisterClient()
        {
            InitializeComponent();
        }
        private void frmRegister_Load(object sender, EventArgs e)
        {
            departamento = new  clsDepartamentoController();
            departamento.ejecutarConsultarDepartamentos(cmbDepartamento);
            ciudad = new clsCiudadController();

            cmbGenero.Items.Add("Masculino");
            cmbGenero.Items.Add("Femenino");

        }
        private void bfbtnRegisterNext_Click(object sender, EventArgs e)
        {
            if (bftxtPrimerNombre.Text != string.Empty && bftxtPrimerApellido.Text != string.Empty
                && bftxtDocumento.Text != string.Empty && (cmbGenero.SelectedIndex != -1) && (cmbDepartamento.SelectedIndex != -1)
                && (cmbCiudad.SelectedIndex != -1))
            {
                validacionRegister.SetError(panelDatosPersonales, "");
                bfpgPersonInfo.PageIndex = 1;
            }
            else
            {
                if (bftxtPrimerNombre.Text == string.Empty)
                {
                    validacionRegister.SetError(panelDatosPersonales, "Es necesario introducir tu primer nombre");
                }
                else if (bftxtPrimerApellido.Text == string.Empty)
                {
                    validacionRegister.SetError(panelDatosPersonales, "Es necesario introducir tu primer apellido");
                }
                else if (bftxtDocumento.Text == string.Empty)
                {
                    validacionRegister.SetError(panelDatosPersonales, "Es necesario introducir tu documento de identidad");
                }
                else if (cmbGenero.SelectedIndex <= -1)
                {
                    validacionRegister.SetError(panelDatosPersonales, "Es necesario introducir tu genero");
                }
                else if (cmbDepartamento.SelectedIndex <= -1)
                {
                    validacionRegister.SetError(panelDatosPersonales, "Es necesario introducir tu departamento");
                }
                else if (cmbCiudad.SelectedIndex <= -1)
                {
                    validacionRegister.SetError(panelDatosPersonales, "Es necesario introducir tu ciudad");
                }       
            }
            
        }
        private void bfbtnInfoFinish_Click_1(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin(1);
            login.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbCrearCuentaMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num;

            if(int.TryParse(cmbDepartamento.SelectedValue.ToString() , out num))
            {

                MessageBox.Show(cmbDepartamento.SelectedValue.ToString());

                ciudad.ejecutarConsultarDepartamentos(cmbCiudad,Int32.Parse(cmbDepartamento.SelectedValue.ToString()));

            }
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num;

            if (int.TryParse(cmbCiudad.SelectedValue.ToString(), out num))
            {

                MessageBox.Show(cmbCiudad.SelectedValue.ToString());

            }
        }

        private  void brbtnCargarImagenPerfil_Click(object sender, EventArgs e)
        {
            cloud = new clsCloudinary();

            profilePicture = cloud.cargarUnArchivo(bfImagenPerfil);

        }

        private void bfbtnInfoFinishPerson_Click(object sender, EventArgs e)
        {
            if (bftxtxEmail.Text != bftxtConfirmarEmail.Text)
            {
                validacionLogin.SetError(panelCredenciales, "Los correos no coinciden");

            }
            else if (bftxtPassword.Text != bftxtConfirmPassword.Text)
            {
                validacionLogin.SetError(panelCredenciales, "Las contraseñas no coinciden");
            }
            else if (bftxtxEmail.Text != string.Empty && bftxtConfirmarEmail.Text != string.Empty
                   && bftxtPassword.Text != string.Empty && bftxtConfirmPassword.Text != string.Empty)
            {
                validacionLogin.SetError(panelCredenciales, "");
                string idDocumentPerson = bftxtDocumento.Text;
                DateTime dateOfBirth = bfdpkFechaNacimiento.Value;
                string firstName = bftxtPrimerNombre.Text;
                string secondName = bftxtSegundoNombre.Text == "" ? "null" : bftxtSegundoNombre.Text;
                string surname = bftxtPrimerApellido.Text;
                string secondSurname = bftxtSegundoApellido.Text == "" ? "null" : bftxtSegundoApellido.Text;
                string gender = cmbGenero.Text;
                string idCity = cmbCiudad.SelectedValue.ToString();
                //login
                string email = bftxtxEmail.Text;
                string credentialPassword = bftxtPassword.Text;

                persona = new clsPersonController(idDocumentPerson, dateOfBirth, firstName, secondName, surname, secondSurname, profilePicture, gender, idCity, email, credentialPassword, rol);

                if (persona.ejecutarCrearPersona())
                {
                    try
                    {
                        frmLogin login = new frmLogin(1);
                        login.Show();
                        this.Close();
                    }
                    catch (Exception err)
                    {

                        bfSnackbarRegister.Show(this, err.Message, BunifuSnackbar.MessageTypes.Error, 6000,
                        "Error", BunifuSnackbar.Positions.BottomRight);
                    }
                 
                }
            }
            else
            {
                if (bftxtxEmail.Text == string.Empty)
                {
                    validacionRegister.SetError(panelCredenciales, "Es necesario introducir el email");
                }
                else if (bftxtConfirmarEmail.Text == string.Empty)
                {
                    validacionRegister.SetError(panelCredenciales, "Es necesario confirmar tu email");
                }
                else if (bftxtPassword.Text == string.Empty)
                {
                    validacionRegister.SetError(panelCredenciales, "Es necesario introducir una contraseña");
                }

                else if (bftxtConfirmPassword.Text == string.Empty)
                {
                    validacionRegister.SetError(panelCredenciales, "Es necesario confirmar tu contraseña");
                }
            }
        }
    }
}
