using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_motoDix.Vistas
{
    public partial class frmRegisterClient : Form
    {
        public frmRegisterClient()
        {

            InitializeComponent();

        }

        private void bflblCreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

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

        private void bfbtnInfoFinish_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}
