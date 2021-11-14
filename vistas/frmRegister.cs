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


        public frmRegisterClient()
        {

            InitializeComponent();

        }

        private void bflblCreateAccount_Click(object sender, EventArgs e)
        {

        }
        private void frmRegister_Load(object sender, EventArgs e)
        {
            bfbtnRegisterNext.Enabled = false;
            departamento = new  clsDepartamentoController();
            departamento.ejecutarConsultarDepartamentos(cmbDepartamento);
            ciudad = new clsCiudadController();

            cmbGenero.Items.Add("Masculino");
            cmbGenero.Items.Add("Femenino");

        }

        private void bftxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void bflblCreateAccount2_Click(object sender, EventArgs e)
        {

        }

        private void bfbtnRegisterNext_Click(object sender, EventArgs e)
        {
            bfpgPersonInfo.PageIndex = 1;
        }

        private void bftpInfoPersonal_Click(object sender, EventArgs e)
        {

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

        private void bftxtPrimerNombre_TextChanged(object sender, EventArgs e)
        {

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
            int idRol = 1;

            /*if(bftxtxEmail.Text != bftxtConfirmarEmail.Text)
            {
                errorProvider.SetError(bftxtConfirmarEmail, "El email no coincide");
            }
            else
            {
                errorProvider.SetError(bftxtConfirmarEmail,"");
            }

            if(bftxtPassword.Text != bftxtConfirmPassword.Text)
            {
                errorProvider.SetError(bftxtConfirmPassword, "Las contraseñas no coinciden");
            }
            else
            {
                errorProvider.SetError(bftxtConfirmPassword, "");
            }*/

            persona = new clsPersonController(idDocumentPerson, dateOfBirth, firstName, secondName, surname, secondSurname, profilePicture, gender, idCity, email, credentialPassword, idRol);

            if (persona.ejecutarCrearPersona())
            {
                frmLogin login = new frmLogin(1);
                login.Show();
                this.Close();
            }
        }

        private void vRegister()
        {
            if (bftxtPrimerNombre.Text != string.Empty || bftxtPrimerApellido.Text != string.Empty
                || bftxtDocumento.Text != string.Empty || (bfdpkFechaNacimiento.Value != null)
                || (cmbGenero.SelectedIndex <= 1) || (cmbDepartamento.SelectedIndex <= 1) 
                || (cmbCiudad.SelectedIndex <= 1))
            {
                validacionRegisterLogin.SetError(bftxtPrimerNombre, "");
                validacionRegisterLogin.SetError(bftxtPrimerApellido, "");
                validacionRegisterLogin.SetError(bftxtDocumento, "");
                validacionRegisterLogin.SetError(bfdpkFechaNacimiento, "");
                validacionRegisterLogin.SetError(cmbGenero, "");
                validacionRegisterLogin.SetError(cmbDepartamento, "");
                validacionRegisterLogin.SetError(cmbCiudad, "");
                bfbtnRegisterNext.Enabled = true;
            }
            else
            {
                if (bftxtPrimerNombre.Text == string.Empty)
                {
                    validacionRegisterLogin.SetError(bftxtPrimerNombre, "Es necesario introducir tu primer nombre");
                }
                else if (bftxtPrimerApellido.Text == string.Empty)
                {
                    validacionRegisterLogin.SetError(bftxtPrimerApellido, "Es necesario introducir tu primer apellido");
                }
                else if (bftxtDocumento.Text == string.Empty)
                {
                    validacionRegisterLogin.SetError(bftxtDocumento, "Es necesario introducir tu documento de identidad");
                }
                else if (bfdpkFechaNacimiento.Text == null)
                {
                    validacionRegisterLogin.SetError(bftxtDocumento, "Es necesario introducir tu documento de identidad");
                }
                else if (cmbGenero.SelectedIndex <= -1)
                {
                    validacionRegisterLogin.SetError(cmbGenero, "Es necesario introducir tu genero");
                }
                else if (cmbDepartamento.SelectedIndex <= -1)
                {
                    validacionRegisterLogin.SetError(cmbDepartamento, "Es necesario introducir tu departamento");
                }
                else if (cmbCiudad.SelectedIndex <= -1)
                {
                    validacionRegisterLogin.SetError(cmbCiudad, "Es necesario introducir tu ciudad");
                }
                bfbtnRegisterNext.Enabled = false;

            }
        }

        private void bftxtPrimerNombre_TextChange(object sender, EventArgs e)
        {
            vRegister();
        }

        private void bftxtPrimerApellido_TextChange(object sender, EventArgs e)
        {
            vRegister();
        }

        private void bftxtDocumento_TextChange(object sender, EventArgs e)
        {
            vRegister();
        }

        private void cmbGenero_TextChanged(object sender, EventArgs e)
        {
            vRegister();
        }

        private void cmbDepartamento_TextChanged(object sender, EventArgs e)
        {
            vRegister();
        }

        private void cmbCiudad_TextChanged(object sender, EventArgs e)
        {
            vRegister();
        }

        private void bftgLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
