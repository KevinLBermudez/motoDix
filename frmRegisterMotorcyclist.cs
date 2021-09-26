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
        }

        private void bfbtnLofinDetailsNext_Click(object sender, EventArgs e)
        {
            bfpgRegister.PageIndex = 2;
        }

        private void bfbtnLicenceNext_Click(object sender, EventArgs e)
        {
            bfpgRegister.PageIndex = 3;
        }
    }
}
