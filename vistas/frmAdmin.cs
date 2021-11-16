using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using final_motoDix.Controladores;
using final_motoDix.Modelos;

namespace final_motoDix.Vistas
{
    public partial class frmAdmin : Form
    {
        clsDriverController driver;
        string solicitudIdDriver = null;
        Persona infoPersona;

        public frmAdmin(Persona infoPersona)
        {
            InitializeComponent();
            this.infoPersona = infoPersona;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            driver = new clsDriverController();
            driver.ejecutarObtenerSolicitudesConductor(bfdgvSolicitudesConductor);
        }


        private void bfdgvSolicitudesConductor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila;
            fila = bfdgvSolicitudesConductor.CurrentRow.Index;

            solicitudIdDriver = bfdgvSolicitudesConductor.Rows[fila].Cells[0].Value.ToString();
            bftxtIdDocumentDrive.Text = solicitudIdDriver;
        }

        private void bfbtnAceptar_Click(object sender, EventArgs e)
        {
            if(solicitudIdDriver != null)
            {
                DialogResult result = MessageBox.Show($"Esta seguro de aprobar la solicitud {solicitudIdDriver}", "Confirmacion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        driver.ejecutarAceptarUnConductor(solicitudIdDriver, infoPersona.IdRol,"Activo","Activo");
                        bfSnackbarAdmin.Show(this, "Usted acaba de aceptar la solicitud", BunifuSnackbar.MessageTypes.Success, 4000,
                       "Completado", BunifuSnackbar.Positions.BottomRight);
                        bftxtIdDocumentDrive.Clear();
                        solicitudIdDriver = null;
                    }
                    catch (Exception err)
                    {
                        bfSnackbarAdmin.Show(this, err.Message, BunifuSnackbar.MessageTypes.Error, 4000,
                        "Error", BunifuSnackbar.Positions.BottomRight);
                    }
                }
            }

        }

        private void bfbtnRechazar_Click(object sender, EventArgs e)
        {
            if (solicitudIdDriver != null)
            {
                DialogResult result = MessageBox.Show($"Esta seguro de rechazar la solicitud {solicitudIdDriver}", "Confirmacion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        driver.ejecutarAceptarUnConductor(solicitudIdDriver, infoPersona.IdRol,"Rechazado", "Rechazado");
                        bfSnackbarAdmin.Show(this, "Usted acaba de rechazar la solicitud", BunifuSnackbar.MessageTypes.Success, 4000,
                       "Completado", BunifuSnackbar.Positions.BottomRight);
                        bftxtIdDocumentDrive.Clear();
                        solicitudIdDriver = null;

                    }
                    catch (Exception err)
                    {
                        bfSnackbarAdmin.Show(this, err.Message, BunifuSnackbar.MessageTypes.Error, 4000,
                        "Error", BunifuSnackbar.Positions.BottomRight);
                    }
                }
            }
        }

        private void lblRefrescar_Click(object sender, EventArgs e)
        {
            driver.ejecutarObtenerSolicitudesConductor(bfdgvSolicitudesConductor);

        }
    }
}