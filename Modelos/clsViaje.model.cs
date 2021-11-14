﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using static final_motoDix.Estructuras.EViaje;

namespace final_motoDix.Modelos
{
    class clsViajeModel
    {
        EstViaje viaje;

        private NpgsqlConnection conexionViaje;

        private string travelId;
        private string idDocumentPerson;
        private string idDocumentPersonDriver;
        private int rol;
        private DateTime fechaViajeDesde;
        private DateTime fechaViajeHasta;


        private string startPoint;
        private string arrivalPoint;
        private double valueTravel;
        private DateTime dateTimeTrip;
        private string licensePlate;
        private string state;
        private string timeTravel;
        private int rating;
        private double discount;

        public string TravelId { get => travelId; set => travelId = value; }
        public string IdDocumentPerson { get => idDocumentPerson; set => idDocumentPerson = value; }
        public string IdDocumentPersonDriver { get => idDocumentPersonDriver; set => idDocumentPersonDriver = value; }
        public string StartPoint { get => startPoint; set => startPoint = value; }
        public string ArrivalPoint { get => arrivalPoint; set => arrivalPoint = value; }
        public double ValueTravel { get => valueTravel; set => valueTravel = value; }
        public DateTime DateTimeTrip { get => dateTimeTrip; set => dateTimeTrip = value; }
        public string LicensePlate { get => licensePlate; set => licensePlate = value; }
        public string State { get => state; set => state = value; }
        public string TimeTravel { get => timeTravel; set => timeTravel = value; }
        public int Rating { get => rating; set => rating = value; }
        public double Discount { get => discount; set => discount = value; }
        public int Rol { get => rol; set => rol = value; }
        public DateTime FechaViajeDesde { get => fechaViajeDesde; set => fechaViajeDesde = value; }
        public DateTime FechaViajeHasta { get => fechaViajeHasta; set => fechaViajeHasta = value; }

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
        public clsViajeModel(string travelId)
        {
            TravelId = travelId;
            conexionViaje = clsConexion.realizarConexion();

        }

        public clsViajeModel(string travelId, string idDocumentPersonDriver, string licensePlate, string state)
        {
            TravelId = travelId;
            IdDocumentPersonDriver = idDocumentPersonDriver;
            LicensePlate = licensePlate;
            State = state;
            conexionViaje = clsConexion.realizarConexion();

        }

        public clsViajeModel(string travelId, double valueTravel, string state, string timeTravel,int rating,double discount) 
        {
            TravelId = travelId;
            ValueTravel = valueTravel;
            State = state;
            TimeTravel = timeTravel;
            Rating = rating;
            Discount = discount;
            conexionViaje = clsConexion.realizarConexion();

        }
        public clsViajeModel(string idDocumentPerson, int rol, DateTime desde,DateTime hasta )
        {
            IdDocumentPerson = idDocumentPerson;
            Rol = rol;
            FechaViajeDesde = desde;
            FechaViajeHasta = hasta;
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

        public string solicitudViaje()
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
                
                return travelId;
               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
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

     
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la conexion");
                return null;
               
            }


        }

        public bool aceptarViaje()
        {
            validarConexion();

            NpgsqlCommand query = new NpgsqlCommand();
            query.Connection = conexionViaje;

            query.CommandText = "CALL public.app_accept_travel(@travelId,@licenseplate,@idDocumentPersonDriver,@state)";

            query.Parameters.Add("@travelId", NpgsqlTypes.NpgsqlDbType.Varchar).Value = travelId;
            query.Parameters.Add("@idDocumentPersonDriver", NpgsqlTypes.NpgsqlDbType.Varchar).Value = idDocumentPersonDriver;
            query.Parameters.Add("@licenseplate", NpgsqlTypes.NpgsqlDbType.Varchar).Value = licensePlate;
            query.Parameters.Add("@state", NpgsqlTypes.NpgsqlDbType.Varchar).Value = state;


            try
            {
                query.ExecuteNonQuery();
                
                return true;
               
            }
            catch (NpgsqlException err)
            {
                throw new Exception(err.Message);
            }
        }

        public EstViaje monitorearViaje()
        {
            validarConexion();
            NpgsqlCommand query = new NpgsqlCommand();
            query.Connection = conexionViaje;

            query.CommandText = "select * from Ver_estadoViaje(@travelId)";

            query.Parameters.Add("@travelId", NpgsqlTypes.NpgsqlDbType.Varchar).Value = travelId;

            try
            {
                NpgsqlDataReader data = query.ExecuteReader();
                string secondName;
                string secondSurname;
                while (data.Read())
                {
                    if (data[2].ToString() == "null")
                    {
                        secondName = "";
                    }
                    else
                    {
                        secondName = data[2].ToString();
                    }
                    if (data[4].ToString() == "null")
                    {
                        secondSurname = "";
                    }
                    else
                    {
                        secondSurname = data[4].ToString();
                    }


                    viaje = new EstViaje(data[0].ToString(), data[1].ToString(), secondName, data[3].ToString(),
                        secondSurname, data[5].ToString(), data[6].ToString(), data[7].ToString(), data[8].ToString(),
                        data[9].ToString());

                }
                data.Close();

                return viaje;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return viaje;
        }

        public bool completarViaje()
        {

            validarConexion();
            NpgsqlCommand query = new NpgsqlCommand();
            query.Connection = conexionViaje;

            query.CommandText = "CALL public.app_complet_travel(@travelId,@valueTravel,@timeTravel,@rating,@state)";

            query.Parameters.Add("@travelId", NpgsqlTypes.NpgsqlDbType.Varchar).Value = travelId;
            query.Parameters.Add("@valueTravel", NpgsqlTypes.NpgsqlDbType.Integer).Value = valueTravel;
            query.Parameters.Add("@discount", NpgsqlTypes.NpgsqlDbType.Integer).Value = discount;
            query.Parameters.Add("@timeTravel", NpgsqlTypes.NpgsqlDbType.Varchar).Value = timeTravel;
            query.Parameters.Add("@rating", NpgsqlTypes.NpgsqlDbType.Integer).Value = rating;
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



        public DataTable obtenerHistorial()
        {

            validarConexion();
            string consulta = "select * from app_see_history(@idDocumentPersona,@idRol,@desde,@hasta);";

            NpgsqlCommand query = new NpgsqlCommand(consulta, conexionViaje);
            
            query.Parameters.Add("@idDocumentPersona", NpgsqlTypes.NpgsqlDbType.Varchar).Value = idDocumentPerson;
            query.Parameters.Add("@idRol", NpgsqlTypes.NpgsqlDbType.Integer).Value = rol;
            query.Parameters.Add("@desde", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = fechaViajeDesde;
            query.Parameters.Add("@hasta", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = fechaViajeHasta;


            try
            {

                DataTable dtHistorial = new DataTable();

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query);
                adapter.Fill(dtHistorial);
                return dtHistorial;

            }
            catch (Exception)
            {
                throw new Exception("No se pudo optener la informacion");
            }

        }



    }
}
