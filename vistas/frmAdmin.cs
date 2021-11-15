using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final_motoDix.Controladores;

namespace final_motoDix.Vistas
{
    public partial class frmAdmin : Form
    {
        clsDriverController driver;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            driver = new clsDriverController();
            driver.ejecutarObtenerSolicitudesConductor(bfdgvSolicitudesConductor);
        }
    }
}


