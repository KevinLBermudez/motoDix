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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
    
        private void AbrirFormInPanel<MiFormulario> () where MiFormulario : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiFormulario>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiFormulario();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            AbrirFormInPanel<frmTravel>();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bfbtnMisViajes_Click(object sender, EventArgs e)
        {

            AbrirFormInPanel<frmHistory>();

        }
    }
}
