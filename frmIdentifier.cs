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
    public partial class frmIdentifier : Form
    {
        public frmIdentifier()
        {
            InitializeComponent();
        }

        private void bfimgbtnMotorcyclist_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Visible = false;
            
        }

        private void bfimgbtnUser_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Visible = false;
        }
    }
}
