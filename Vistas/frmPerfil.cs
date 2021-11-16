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
using final_motoDix.Controladores;
using Bunifu.UI.WinForms;

namespace final_motoDix.Vistas
{
    public partial class frmPerfil : Form
    {
        public Persona infoPersona;
        clsPersonController persona;

        public frmPerfil(Persona infoPersona)
        {
            this.infoPersona = infoPersona;
            InitializeComponent();
        }

        public frmPerfil()
        {
            InitializeComponent();
        }

 

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            bftxtPrimerNombrePerfil.Text = infoPersona.FirstName;
            bftxtSegundoNombrePerfil.Text = infoPersona.SecondName;
            bftxtPrimerApellidoPerfil.Text = infoPersona.Surname;
            bftxtSegundoApellidoperfil.Text = infoPersona.SecondName;
            bfdtpFechaNacimientoPerfil.Value = infoPersona.DateOfBirth;
            bftxtDocumentoPerfil.Text = infoPersona.IdDocumentPersona;
            cmbGeneroPerfil.Text = infoPersona.Gender;
            bftxtxEmailPerfil.Text = infoPersona.Email;
            bftxtConfirmarEmailPerfil.Text = infoPersona.Email;
            bfFotoPerfil.ImageLocation = infoPersona.ProfilePicture;


        }

        private void ptbCerrarPerfil_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMaximizarPerfil_Click(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void ptbMinizarPerfil_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bfbtnActualizar_Click(object sender, EventArgs e)
        {
                string idDocumentPerson = infoPersona.IdDocumentPersona;
                string email = bftxtxEmailPerfil.Text;
                int idRol = infoPersona.IdRol;
                string firstName = bftxtPrimerNombrePerfil.Text;
                string secondName = bftxtSegundoNombrePerfil.Text == "" ? "null" : bftxtSegundoNombrePerfil.Text;
                string surname = bftxtPrimerApellidoPerfil.Text;
                string secondSurname = bftxtSegundoApellidoperfil.Text == "" ? "null" : bftxtSegundoApellidoperfil.Text;
                string gender = cmbGeneroPerfil.Text;
                string credentialPassword = bftxtPasswordPerfil.Text;

            persona = new clsPersonController(idDocumentPerson, email, idRol, firstName, secondName, surname, secondSurname, gender, credentialPassword);
            try
            {
                if (persona.ejecutarActualizarPersona())
                {
                    MessageBox.Show("Datos actualizados correctamente");
                }
            }
            catch (Exception)
            {
                bfSnackbarPerfil.Show(this, "Contraseña invalida", BunifuSnackbar.MessageTypes.Error, 6000,
                 "Fallo de credenciales", BunifuSnackbar.Positions.BottomRight);
            }
                    
        }
    }
    
}
