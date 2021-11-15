using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final_motoDix.helpers;


namespace final_motoDix.Vistas
{
    public partial class frmInfConductor : Form
    {
        clsMapa mapa;
        string travelId;
        string nombrePersona;
        string apellidoPersona;
        string puntoInicial;
        string destino;

        public frmInfConductor(string travelId,string nombrePersona,string apellidoPersona, string puntoInicial,string destino)
        {


            InitializeComponent();
        }

        private void frmInfConductor_Load(object sender, EventArgs e)
        {
            mapa = new clsMapa(gMapControl);
            mapa.cargarConfiguracionesMapa();
        }


    }
}
