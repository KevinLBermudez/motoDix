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
    public partial class frmHome : Form
    {
        public Persona infoPersona;


        public frmHome(Persona infoPersona)
        {
            this.infoPersona = infoPersona;
            
            InitializeComponent();
            if (infoPersona.IdRol == 1)
            {
                bfbtnVerSolicitudes.Enabled = false;
                bfbtnVerSolicitudes.Visible = false;
            }
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
            Form viaje = new frmTravel(infoPersona);
            viaje.TopLevel = false;
            viaje.FormBorderStyle = FormBorderStyle.None;
            viaje.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(viaje);
            viaje.Show();
            viaje.BringToFront();
            

            bflblNombreUsuario.Text = infoPersona.FirstName +" " + infoPersona.SecondName + " " + infoPersona.Surname + " " + infoPersona.SecondSurname;
            bflblTipoUsuario.Text = infoPersona.RolName;
            bfpbImagenPerfil.ImageLocation = infoPersona.ProfilePicture;
            
        }

        

        private void bfbtnMisViajes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<frmHistory>();
        }

        private void bfbtnViajar_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel<frmTravel>();
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
            AbrirFormInPanel<frmPerfil>();    
        }

        private void bfbtnTrabajaConNosotros_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<frmRegisterMotorcyclist>();

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<frmAyuda>();
        }

        private void bfbtnVerSolicitudes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<frmSolicitudViajes>();
        }
    }
}
