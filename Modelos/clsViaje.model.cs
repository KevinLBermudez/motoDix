using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace final_motoDix.Modelos
{
    class clsViajeModel
    {
        private NpgsqlConnection conexionViaje;

        private string travelId;
        private string idDocumentPerson;
        private string idDocumentPersonDriver;

        private string startPoint;
        private string arrivalPoint;
        private double valueTravel;
        private DateTime dateTimeTrip;
        private string licensePlate;
        private string state;

        public string TravelId { get => travelId; set => travelId = value; }
        public string IdDocumentPerson { get => idDocumentPerson; set => idDocumentPerson = value; }
        public string IdDocumentPersonDriver { get => idDocumentPersonDriver; set => idDocumentPersonDriver = value; }
        public string StartPoint { get => startPoint; set => startPoint = value; }
        public string ArrivalPoint { get => arrivalPoint; set => arrivalPoint = value; }
        public double ValueTravel { get => valueTravel; set => valueTravel = value; }
        public DateTime DateTimeTrip { get => dateTimeTrip; set => dateTimeTrip = value; }
        public string LicensePlate { get => licensePlate; set => licensePlate = value; }
        public string State { get => state; set => state = value; }

        public clsViajeModel(string travelId, string idDocumentPerson, string startPoint, string arrivalPoint, DateTime dateTimeTrip, string state)
        {
            TravelId = travelId;
            IdDocumentPerson = idDocumentPerson;
            StartPoint = startPoint;
            ArrivalPoint = arrivalPoint;
            DateTimeTrip = dateTimeTrip;
            State = state;
            conexionViaje = clsConexion.realizarConexion();

        }
        public clsViajeModel()
        {
            conexionViaje = clsConexion.realizarConexion();

        }
        public void validarConexion()
        {
            if (conexionViaje == null)
            {
                MessageBox.Show("Error en la conexión");
                return;
            }
        }

        public bool solicitudViaje()
        {
            validarConexion();
            NpgsqlCommand query = new NpgsqlCommand();
            query.Connection = conexionViaje;

            query.CommandText = "CALL public.app_travel_init(@travelId,@idDocumentPerson,@startPoint,@arrivalPoint,@dateTimeTrip ,@state)";

            query.Parameters.Add("@travelId", NpgsqlTypes.NpgsqlDbType.Varchar).Value = travelId;
            query.Parameters.Add("@idDocumentPerson", NpgsqlTypes.NpgsqlDbType.Varchar).Value = IdDocumentPerson;
            query.Parameters.Add("@startPoint", NpgsqlTypes.NpgsqlDbType.Varchar).Value = startPoint;
            query.Parameters.Add("@arrivalPoint", NpgsqlTypes.NpgsqlDbType.Varchar).Value = arrivalPoint;
            query.Parameters.Add("@dateTimeTrip", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = dateTimeTrip;
            query.Parameters.Add("@state", NpgsqlTypes.NpgsqlDbType.Varchar).Value = state;


            try
            {
                query.ExecuteNonQuery();
                
                return true;
               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }

        }

        public DataTable obtenerViajesSolicitados()
        {

            validarConexion();
            string consulta = "select * from public.listar_viajes_solicitados();";

            NpgsqlCommand query = new NpgsqlCommand(consulta,conexionViaje);


            try
            {
                DataTable dtViajes = new DataTable();

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query);
                adapter.Fill(dtViajes);
                return dtViajes;

                /* NpgsqlDataReader viajes = query.ExecuteReader();
                 DataTable dtViajes = new DataTable();
                 dtViajes.Load(viajes);
                 return dtViajes;*/
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la conexion");
                return null;
               
            }


        }



    }
}
