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
    public partial class frmRegisterMotorcyclist : Form
    {
        public frmRegisterMotorcyclist()
        {
            InitializeComponent();
        }

        private void frmRegisterMotorcyclist_Load(object sender, EventArgs e)
        {
            
        }

        private void bfbtnProfileInfoNext_Click(object sender, EventArgs e)
        {
            bfpgRegister.PageIndex = 1;
            bfchkProfileInfo.Checked = true;
        }

        private void bfbtnLofinDetailsNext_Click(object sender, EventArgs e)
        {
            bfpgRegister.PageIndex = 2;
            bfchkLoginDetails.Checked = true;
        }

        private void bfbtnLicenceNext_Click(object sender, EventArgs e)
        {
            bfpgRegister.PageIndex = 3;
            bfchkLicence.Checked = true;
        }

        private void bfbtnVehicleNext_Click(object sender, EventArgs e)
        {
            bfpgRegister.PageIndex = 4;
        }

        private void bfbtnPropietarioNext_Click(object sender, EventArgs e)
        {
            bfpgRegister.PageIndex = 5;
        }

        private void bfbtnSoatNext_Click(object sender, EventArgs e)
        {
            bfpgRegister.PageIndex = 6;
        }

        private void bfbtnInfoFinish_Click(object sender, EventArgs e)
        {
            bfchkVehicleInfo.Checked = true;
        }

       

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmRegisterMotorcyclist_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir de la aplicacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }
    }
}
