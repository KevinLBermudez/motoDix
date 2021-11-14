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

namespace final_motoDix.Vistas
{
    public partial class frmPerfil : Form
    {

        public Persona infoPersona;

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
            //bftxtPasswordPerfil.Text = infoPersona.;
            //bftxtConfirmPasswordPerfil = infoPersona.Email;
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
    }
}
