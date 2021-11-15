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

        public clsViajeController( string idDocumentPerson, string startPoint, string arrivalPoint,double valueTravel,double discount, string state, string latInicio, string longInicio, string latFinal, string longFinal)
        {
            var guid = Guid.NewGuid();
            DateTime horaActual = DateTime.Now;

            viaje = new clsViajeModel(guid.ToString(),idDocumentPerson,startPoint,arrivalPoint,horaActual, valueTravel,discount,state,  latInicio,  longInicio,  latFinal,  longFinal);

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
                throw new Exception(err.Message);

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
                data.Columns[7].Visible = false;
                data.Columns[8].Visible = false;
                data.Columns[9].Visible = false;
                data.Columns[10].Visible = false;


            }
            catch (Exception err)
            {
                throw new Exception(err.Message);

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
                throw new Exception(err.Message);
            }
        }   

        public EstViaje ejecutarMonitoreoViaje()
        {
            try
            {
                eViaje = viaje.monitorearViaje();
                return eViaje;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);


            }

        }

        public bool ejecutarCompletarViaje(string travelId, string timeTravel, int rating)
        {
            viaje = new clsViajeModel(travelId, "Completado", timeTravel, rating);

            try
            {
                if (viaje.completarViaje())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error interno");
                return false;

            }
        }


        public bool ejecutarObtenerHistorial(string idDocumentPerson, int rol, DateTime desde, DateTime hasta,DataGridView data)
        {
            viaje = new clsViajeModel(idDocumentPerson, rol, desde, hasta);

            try
            {

                data.DataSource = viaje.obtenerHistorial();
                data.Columns[0].HeaderText = "Cliente";
                data.Columns[1].HeaderText = "Conductor";
                data.Columns[2].HeaderText = "Fecha del viaje";
                data.Columns[3].HeaderText = "Punto de inicio";
                data.Columns[4].HeaderText = "Destino";
                data.Columns[5].HeaderText = "Valor del viaje";
                data.Columns[6].HeaderText = "Descuento";
                data.Columns[7].HeaderText = "Placa del vehiculo";
                data.Columns[8].HeaderText = "Calificacion del viaje";
                data.Columns[9].HeaderText = "Estado";
                return true;
            }
            catch (Exception err )
            {
                throw new Exception(err.Message);
            }

        }


        public EstViaje ejecutarMonitorearViajeConductor(string travelId)
        {
            try
            {
                viaje = new clsViajeModel(travelId);

                eViaje = viaje.monitorearViajeConductor();
                return eViaje;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);


            }
        }

    }
}
