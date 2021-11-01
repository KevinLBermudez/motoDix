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
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu texto se envio correctamente", "Perfecto");
            this.Close();
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {
            cmbTipoComentario.Items.Add("Problema");
            cmbTipoComentario.Items.Add("Duda");
            cmbTipoComentario.Items.Add("Sugerencias");
            cmbTipoComentario.Items.Add("Felicitaciones");
        }
    }
}
