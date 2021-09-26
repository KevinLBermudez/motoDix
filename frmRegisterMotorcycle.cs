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
    public partial class frmRegisterMotorcycle : Form
    {
        public frmRegisterMotorcycle()
        {
            InitializeComponent();
        }

        private void frmRegisterMotorcycle_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 2;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
                bunifuPages1.PageIndex = 0;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 1;

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            bunifuProgressBar1.Value = 33;
            bunifuPages1.PageIndex = 1;
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            bunifuProgressBar1.Value = 66;
            bunifuPages1.PageIndex = 2;
        }
    }
}
