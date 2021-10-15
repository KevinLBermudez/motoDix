using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_motoDix
{
    public partial class Form1 : Form
    {
        public Form1()
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


            frmRegisterMotorcyclist register = new frmRegisterMotorcyclist();
            register.Show();
            this.Close();
        }
    }
}
