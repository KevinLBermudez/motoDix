using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final_motoDix.Estructuras;
using final_motoDix.Modelos;

namespace final_motoDix.Vistas
{
    public partial class frmHome : Form
    {
        public Persona infoPersona;
        public Iconductor infoDriver;
        int rolActivo = 0;
        Form viajeFormulario;
        Form history;
        Form viajeConductor = null;

        public frmHome(Persona infoPersona)
        {
            this.infoPersona = infoPersona;
            rolActivo = 1;
            InitializeComponent();
            bfbtnDetallesViaje.Visible = false;
            bfbtnDetallesViaje.Enabled = false;

        }
        public frmHome(Iconductor infoDriver)
        {
            this.infoDriver = infoDriver;
            rolActivo = 2;
            InitializeComponent();
            bfbtnViajar.Enabled = false;
            bfbtnViajar.Visible = false;

        }

        private void AbrirFormInPanel<MiFormulario> () where MiFormulario : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiFormulario>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiFormulario();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();

            }

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
            if(rolActivo == 1)
            {
                Form viaje = new frmTravel(infoPersona);
                viaje.TopLevel = false;
                viaje.FormBorderStyle = FormBorderStyle.None;
                viaje.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(viaje);
                viaje.Show();
                viaje.BringToFront();
                viajeFormulario = viaje;
                bflblNombreUsuario.Text = infoPersona.FirstName + " " + infoPersona.SecondName + " " + infoPersona.Surname + " " + infoPersona.SecondSurname;
                bflblTipoUsuario.Text = infoPersona.RolName;
                bfpbImagenPerfil.ImageLocation = infoPersona.ProfilePicture;

            }else if(rolActivo == 2)
            {
                Form viajes = new frmViajeConductor(infoDriver);
                viajes.TopLevel = false;
                viajes.FormBorderStyle = FormBorderStyle.None;
                viajes.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(viajes);
                viajes.Show();
                viajes.BringToFront();
                viajeConductor = viajes;
                bflblNombreUsuario.Text = infoDriver.firstname + " " + infoDriver.secondname + " " + infoDriver.surname + " " + infoDriver.secondname;
                bflblTipoUsuario.Text = "Conductor";
                bfpbImagenPerfil.ImageLocation = infoDriver.profilePicture;
            }

        }


        private void bfbtnMisViajes_Click(object sender, EventArgs e)
        {
            if (rolActivo == 1)
            {
                Form history = new frmHistory(infoPersona);
                history.TopLevel = false;
                history.FormBorderStyle = FormBorderStyle.None;
                history.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(history);
                history.Show();
                history.BringToFront();
                this.history = history;
         

            }
            else if (rolActivo == 2)
            {
                Form history = new frmHistory(infoDriver);
                history.TopLevel = false;
                history.FormBorderStyle = FormBorderStyle.None;
                history.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(history);
                history.Show();
                history.BringToFront();
                this.history = history;
            }

        }

        private void bfbtnViajar_Click(object sender, EventArgs e)
        {

            viajeFormulario.BringToFront();

        }

        private void ptbMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbMaximizar_Click(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =  MessageBox.Show("Seguro que deseas salir de la aplicación", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void bfpbImagenPerfil_Click(object sender, EventArgs e)
        {
            if (rolActivo == 1)
            {
                frmPerfil perfil = new frmPerfil(infoPersona);
                //perfil.Show();
                //AbrirFormInPanel <frmPerfil>();  

                perfil.TopLevel = false;
                perfil.FormBorderStyle = FormBorderStyle.None;
                perfil.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(perfil);
                panelContenedor.Tag = perfil;
                perfil.Show();
                perfil.BringToFront();
            }

            else if (rolActivo == 2)
            {
                frmPerfilConductor perfilConductor = new frmPerfilConductor(infoDriver);
                //perfil.Show();
                //AbrirFormInPanel <frmPerfil>();  
                perfilConductor.TopLevel = false;
                perfilConductor.FormBorderStyle = FormBorderStyle.None;
                perfilConductor.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(perfilConductor);
                panelContenedor.Tag = perfilConductor;
                perfilConductor.Show();
                perfilConductor.BringToFront();
            }
            
        }

        private void bfbtnTrabajaConNosotros_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<frmRegisterMotorcyclist>();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<frmAyuda>();
        }


        private void bfbtnDetallesViaje_Click(object sender, EventArgs e)
        {
           if(viajeConductor != null)
           {
                viajeConductor.BringToFront();
           }

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
