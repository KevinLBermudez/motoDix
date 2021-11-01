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
    public partial class frmRegisterMotorcyclist : Form
    {
        public frmRegisterMotorcyclist()
        {
            InitializeComponent();
        }

        private void frmRegisterMotorcyclist_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmRegisterMotorcyclist_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            bfchkLoginDetails.Checked = true;

            bfpgRegisterVehicle.PageIndex = 1;
            
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

            bfpgRegisterVehicle.PageIndex = 2;

        }

        private void bfbtnLicenceNext_Click(object sender, EventArgs e)
        {
            bfchkVehicleInfo.Checked = true;
            bfpgRegisterVehicle.PageIndex = 3;

        }

        private void bfbtnInfoFinish_Click(object sender, EventArgs e)
        {
            bfchkLicence.Checked = true;
        }
    }
}
