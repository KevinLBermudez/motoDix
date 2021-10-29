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

namespace final_motoDix.Vistas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bftxtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            frmRegisterClient register = new frmRegisterClient();
            register.Show();
            this.Close();
        }

       

        private void bfbtnLogin_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();

            home.Show();

            this.Close();
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
