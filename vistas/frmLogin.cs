using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using final_motoDix.Modelos;
using final_motoDix.Controladores;
using final_motoDix.Estructuras;

namespace final_motoDix.Vistas
{
    public partial class frmLogin : Form
    {
        int rol;
        clsPersonController persona;
        clsDriverController driver;

        public Persona infoPersona;
        public Iconductor infoConductor;
        

        public frmLogin(int rol)
        {
            this.rol =rol;
            InitializeComponent();
        }


        private void lblSignIn_Click(object sender, EventArgs e)
        {
            frmRegisterClient register = new frmRegisterClient();
            register.Show();
            this.Close();
        }

       

        private void bfbtnLogin_Click(object sender, EventArgs e)
        {

            if(rol == 1)
            {
                string email = bftxtEmail.Text;
                string password = bftxtContraseña.Text;
                persona = new clsPersonController(email, password, rol);
                infoPersona = persona.ejecutarLogin();
                frmHome home = new frmHome(infoPersona);
                home.Show();
                this.Close();

            }else if(rol == 2)
            {
                string email = bftxtEmail.Text;
                string password = bftxtContraseña.Text;
                driver = new clsDriverController(email, password, rol);
                try
                {
                    infoConductor = driver.ejectutarLoginDriver();
                    frmHome home = new frmHome(infoConductor);
                    home.Show();
                    this.Close();
                }
                catch (Exception err)
                {
                     MessageBox.Show("Compruebe sus credenciales");

                }
               
            }
        
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
