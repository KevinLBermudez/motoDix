using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final_motoDix.Modelos;
using System.Data;
using static final_motoDix.Estructuras.EViaje;

namespace final_motoDix.Controladores
{
    class clsViajeController
    {

        private clsViajeModel viaje;
        EstViaje eViaje;

        public clsViajeController( string idDocumentPerson, string startPoint, string arrivalPoint, string state)
        {
            var guid = Guid.NewGuid();
            DateTime horaActual = DateTime.Now;

            viaje = new clsViajeModel(guid.ToString(),idDocumentPerson,startPoint,arrivalPoint,horaActual,state);

        }
        public clsViajeController()
        {
            viaje = new clsViajeModel();
        }
        public clsViajeController(string travelId)
        {
            viaje = new clsViajeModel(travelId);
        }

        public clsViajeController(string travelId,string licencePlate, string idDocumentPersonDriver)
        {
            viaje = new clsViajeModel(travelId, idDocumentPersonDriver, licencePlate, "Aceptado");

        }

        public string ejecutarSolicitarViaje()
        {
            try
            {
                 string travelId = viaje.solicitudViaje();
                return travelId;
            }
            catch (Exception err)
            {

                MessageBox.Show("Error al solicitar viaje");
                return null;
            }
           

        }

        public void ejecutarObtenerViajesSolicitados(DataGridView data)
        {
            try
            {

                data.DataSource = viaje.obtenerViajesSolicitados();
                data.Columns[1].HeaderText = "Documento de solicitud";
                data.Columns[2].HeaderText = "Nombre";
                data.Columns[3].HeaderText = "Apellido";
                data.Columns[4].HeaderText = "Punto de inicio";
                data.Columns[5].HeaderText = "Destino";
                data.Columns[6].HeaderText = "Fecha de la solicitud";
                data.Columns[0].Visible = false;
                data.Columns[1].Visible = false;


            }
            catch (Exception err)
            {
                MessageBox.Show("Error interno");
            }
        }

        public bool ejecutaraceptarViaje()
        {
            try
            {
                viaje.aceptarViaje();
                return true;
            }
            catch (Exception err)
            {

                MessageBox.Show("Error interno");
                return false;
            }
        }   

        public EstViaje ejecutarMonitoreoViaje()
        {
            try
            {
                eViaje = viaje.monitorearViaje();
                return eViaje;
            }
            catch (Exception)
            {

                MessageBox.Show("Error interno");

                return eViaje;

            }

        }

    }
}
