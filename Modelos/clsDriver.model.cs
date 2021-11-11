using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;
using final_motoDix.helpers;

namespace final_motoDix.Modelos
{
    public struct Driver
    {
        // Estructura - Objeto ( Para tener acceso a los datos)
        private string p_idDocumentPersonCredentials;
        private string p_emailCredentials;
        private string p_credentialpasswordCredentials;
        private string p_idrolCredentials;
        private string p_iddocumentowner;
        private string p_firstnameOwner;
        private string p_secondnameOwner;
        private string p_surnameOwner;
        private string p_secondsurnameOwner;
        private string p_licenseplateVehicle;
        private int p_cylindercapacityVehicle;
        private int p_modelVehicle;
        private string p_brandVehicle;
        private string p_colorVehicle;
        //Date
        private DateTime p_expeditiondatesoatVehicle;
        //timestamp
        private DateTime p_initialvaliditysoatVehicle;
        //timestamp
        private DateTime p_finalvaliditysoatVehicle;
        //Date
        private DateTime p_expeditiondatetechnomechanicsVehicle;
        //Date
        private DateTime p_expirationdatetechnomechanicsVehicle;
        private string p_transitexpenderDriver;
        //Date
        private DateTime p_expeditiondateDriver;
        private string p_restrictionsDriver;
        private string p_categoryDriver;
        private string p_serviceDriver;
        private string p_validityDriver;
        //Date
        private DateTime p_assignmentdate;
        private string p_assignmentstate;

        //Constructor de la estructura 
        public Driver(string p_idDocumentPersonCredentials, string p_emailCredentials, string p_credentialpasswordCredentials, string p_idrolCredentials, string p_iddocumentowner, string p_firstnameOwner, string p_secondnameOwner, string p_surnameOwner, string p_secondsurnameOwner, string p_licenseplateVehicle, int p_cylindercapacityVehicle, int p_modelVehicle, string p_brandVehicle, string p_colorVehicle, DateTime p_expeditiondatesoatVehicle, DateTime p_initialvaliditysoatVehicle, DateTime p_finalvaliditysoatVehicle, DateTime p_expeditiondatetechnomechanicsVehicle, DateTime p_expirationdatetechnomechanicsVehicle, string p_transitexpenderDriver, DateTime p_expeditiondateDriver, string p_restrictionsDriver, string p_categoryDriver, string p_serviceDriver, string p_validityDriver, DateTime p_assignmentdate, string p_assignmentstate)
        {
            this.p_idDocumentPersonCredentials = p_idDocumentPersonCredentials;
            this.p_emailCredentials = p_emailCredentials;
            this.p_credentialpasswordCredentials = p_credentialpasswordCredentials;
            this.p_idrolCredentials = p_idrolCredentials;
            this.p_iddocumentowner = p_iddocumentowner;
            this.p_firstnameOwner = p_firstnameOwner;
            this.p_secondnameOwner = p_secondnameOwner;
            this.p_surnameOwner = p_surnameOwner;
            this.p_secondsurnameOwner = p_secondsurnameOwner;
            this.p_licenseplateVehicle = p_licenseplateVehicle;
            this.p_cylindercapacityVehicle = p_cylindercapacityVehicle;
            this.p_modelVehicle = p_modelVehicle;
            this.p_brandVehicle = p_brandVehicle;
            this.p_colorVehicle = p_colorVehicle;
            this.p_expeditiondatesoatVehicle = p_expeditiondatesoatVehicle;
            this.p_initialvaliditysoatVehicle = p_initialvaliditysoatVehicle;
            this.p_finalvaliditysoatVehicle = p_finalvaliditysoatVehicle;
            this.p_expeditiondatetechnomechanicsVehicle = p_expeditiondatetechnomechanicsVehicle;
            this.p_expirationdatetechnomechanicsVehicle = p_expirationdatetechnomechanicsVehicle;
            this.p_transitexpenderDriver = p_transitexpenderDriver;
            this.p_expeditiondateDriver = p_expeditiondateDriver;
            this.p_restrictionsDriver = p_restrictionsDriver;
            this.p_categoryDriver = p_categoryDriver;
            this.p_serviceDriver = p_serviceDriver;
            this.p_validityDriver = p_validityDriver;
            this.p_assignmentdate = p_assignmentdate;
            this.p_assignmentstate = p_assignmentstate;
        }

        //Propiedades, recibir y enviar datos.

        public string P_idDocumentPersonCredentials { get => p_idDocumentPersonCredentials; set => p_idDocumentPersonCredentials = value; }
        public string P_emailCredentials { get => p_emailCredentials; set => p_emailCredentials = value; }
        public string P_credentialpasswordCredentials { get => p_credentialpasswordCredentials; set => p_credentialpasswordCredentials = value; }
        public string P_idrolCredentials { get => p_idrolCredentials; set => p_idrolCredentials = value; }
        public string P_iddocumentowner { get => p_iddocumentowner; set => p_iddocumentowner = value; }
        public string P_firstnameOwner { get => p_firstnameOwner; set => p_firstnameOwner = value; }
        public string P_secondnameOwner { get => p_secondnameOwner; set => p_secondnameOwner = value; }
        public string P_surnameOwner { get => p_surnameOwner; set => p_surnameOwner = value; }
        public string P_secondsurnameOwner { get => p_secondsurnameOwner; set => p_secondsurnameOwner = value; }
        public string P_licenseplateVehicle { get => p_licenseplateVehicle; set => p_licenseplateVehicle = value; }
        public int P_cylindercapacityVehicle { get => p_cylindercapacityVehicle; set => p_cylindercapacityVehicle = value; }
        public int P_modelVehicle { get => p_modelVehicle; set => p_modelVehicle = value; }
        public string P_brandVehicle { get => p_brandVehicle; set => p_brandVehicle = value; }
        public string P_colorVehicle { get => p_colorVehicle; set => p_colorVehicle = value; }
        public DateTime P_expeditiondatesoatVehicle { get => p_expeditiondatesoatVehicle; set => p_expeditiondatesoatVehicle = value; }
        public DateTime P_initialvaliditysoatVehicle { get => p_initialvaliditysoatVehicle; set => p_initialvaliditysoatVehicle = value; }
        public DateTime P_finalvaliditysoatVehicle { get => p_finalvaliditysoatVehicle; set => p_finalvaliditysoatVehicle = value; }
        public DateTime P_expeditiondatetechnomechanicsVehicle { get => p_expeditiondatetechnomechanicsVehicle; set => p_expeditiondatetechnomechanicsVehicle = value; }
        public DateTime P_expirationdatetechnomechanicsVehicle { get => p_expirationdatetechnomechanicsVehicle; set => p_expirationdatetechnomechanicsVehicle = value; }
        public string P_transitexpenderDriver { get => p_transitexpenderDriver; set => p_transitexpenderDriver = value; }
        public DateTime P_expeditiondateDriver { get => p_expeditiondateDriver; set => p_expeditiondateDriver = value; }
        public string P_restrictionsDriver { get => p_restrictionsDriver; set => p_restrictionsDriver = value; }
        public string P_categoryDriver { get => p_categoryDriver; set => p_categoryDriver = value; }
        public string P_serviceDriver { get => p_serviceDriver; set => p_serviceDriver = value; }
        public string P_validityDriver { get => p_validityDriver; set => p_validityDriver = value; }
        public DateTime P_assignmentdate { get => p_assignmentdate; set => p_assignmentdate = value; }
        public string P_assignmentstate { get => p_assignmentstate; set => p_assignmentstate = value; }
    }
    class clsDriverModel
    {

        //Para llamar a la estructura driver
        private Driver driver;

        //variable para despues conectar a la base de datos.
        private NpgsqlConnection conexionDriver;

        //Lo que hay en el modelo de la base de datos.
        //--Credential
        private string idDocumentPerson;
        private string email;
        private string credentialPassword;
        private int idRol;
        //--Vehicle
        private string licenseplate;
        private string color;
        private int model;
        private int cylindercapacity;
        private string brand;
        private DateTime expeditiondatetechnomechanics;
        private DateTime expirationdatetechnomechanics;
        private DateTime expeditiondatesoat;
        private DateTime initialvaliditysoat;
        private DateTime finalvaliditysoat;
        private string statee = "Activo";
        //--Owner
        private string iddocumentowner;
        private string firstname;
        private string secondname;
        private string surname;
        private string secondsurname;
        //Driver
        private string transitexpender;
        private DateTime expeditiondate;
        private string restrictions;
        private string category;
        private string service;
        private DateTime validity;
        private string stade = "Activo";
        //Vehicleassignment
        private DateTime assignmentdate;
        private string assignmentstate;

        public string IdDocumentPerson { get => idDocumentPerson; set => idDocumentPerson = value; }
        public string Email { get => email; set => email = value; }
        public string CredentialPassword { get => credentialPassword; set => credentialPassword = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public string Licenseplate { get => licenseplate; set => licenseplate = value; }
        public string Color { get => color; set => color = value; }
        public int Model { get => model; set => model = value; }
        public int Cylindercapacity { get => cylindercapacity; set => cylindercapacity = value; }
        public string Brand { get => brand; set => brand = value; }
        public DateTime Expeditiondatetechnomechanics { get => expeditiondatetechnomechanics; set => expeditiondatetechnomechanics = value; }
        public DateTime Expirationdatetechnomechanics { get => expirationdatetechnomechanics; set => expirationdatetechnomechanics = value; }
        public DateTime Expeditiondatesoat { get => expeditiondatesoat; set => expeditiondatesoat = value; }
        public DateTime Initialvaliditysoat { get => initialvaliditysoat; set => initialvaliditysoat = value; }
        public DateTime Finalvaliditysoat { get => finalvaliditysoat; set => finalvaliditysoat = value; }
        public string Statee { get => statee; set => statee = value; }
        public string Iddocumentowner { get => iddocumentowner; set => iddocumentowner = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Secondname { get => secondname; set => secondname = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Secondsurname { get => secondsurname; set => secondsurname = value; }
        public string Transitexpender { get => transitexpender; set => transitexpender = value; }
        public DateTime Expeditiondate { get => expeditiondate; set => expeditiondate = value; }
        public string Restrictions { get => restrictions; set => restrictions = value; }
        public string Category { get => category; set => category = value; }
        public string Service { get => service; set => service = value; }
        public DateTime Validity { get => validity; set => validity = value; }
        public string Stade { get => stade; set => stade = value; }
        public DateTime Assignmentdate { get => assignmentdate; set => assignmentdate = value; }
        public string Assignmentstate { get => assignmentstate; set => assignmentstate = value; }

        //Propiedad de la variable de tipo estructura
        //Para enviar y recibir datos a cualquier variable que este dentro de driver

        public Driver Driver { get => driver; set => driver = value; }

        //Constructor
        //Recibir datos para asignar valor a las variables

        public clsDriverModel(string idDocumentPerson, string email, string credentialPassword, int idRol, string licenseplate, string color, int model, int cylindercapacity, string brand, DateTime expeditiondatetechnomechanics, DateTime expirationdatetechnomechanics, DateTime expeditiondatesoat, DateTime initialvaliditysoat, DateTime finalvaliditysoat, string statee, string iddocumentowner, string firstname, string secondname, string surname, string secondsurname, string transitexpender, DateTime expeditiondate, string restrictions, string category, string service, DateTime validity, string stade, DateTime assignmentdate, string assignmentstate)
        {
            IdDocumentPerson = idDocumentPerson;
            Email = email;
            CredentialPassword = credentialPassword;
            IdRol = idRol;
            Licenseplate = licenseplate;
            Color = color;
            Model = model;
            Cylindercapacity = cylindercapacity;
            Brand = brand;
            Expeditiondatetechnomechanics = expeditiondatetechnomechanics;
            Expirationdatetechnomechanics = expirationdatetechnomechanics;
            Expeditiondatesoat = expeditiondatesoat;
            Initialvaliditysoat = initialvaliditysoat;
            Finalvaliditysoat = finalvaliditysoat;
            Statee = statee;
            Iddocumentowner = iddocumentowner;
            Firstname = firstname;
            Secondname = secondname;
            Surname = surname;
            Secondsurname = secondsurname;
            Transitexpender = transitexpender;
            Expeditiondate = expeditiondate;
            Restrictions = restrictions;
            Category = category;
            Service = service;
            Validity = validity;
            Stade = stade;
            Assignmentdate = assignmentdate;
            Assignmentstate = assignmentstate;
            conexionDriver = clsConexion.realizarConexion();
        }

        //Función para validar la conexion
        public void validarConexion()
        {
            if (conexionDriver == null)
            {
                MessageBox.Show("Error en la conexión");
                return;
            }
        }

        //Función para crear un conductor

        public bool RegistrarConductor()
        {
            validarConexion();
            NpgsqlCommand query = new NpgsqlCommand();
            query.Connection = conexionDriver;

            query.CommandText = "CALL App_Motorcyclist_register(@IdDocumentPerson, @Email, @CredentialPassword, 2::smallint, @Iddocumentowner, @Firstname ,@Secondname," +
                                " @Surname, @Secondsurname, @Licenseplate, @Cylindercapacity, @Model, @Brand,"+
                                "@Color, @Expeditiondatesoat, @Initialvaliditysoat, @Finalvaliditysoat, @Expeditiondatetechnomechanics, @Expirationdatetechnomechanics," +
                                "@Transitexpender, @Expeditiondate, @Restrictions, @Category, @Service, @ValityDriver, @Assignmentdate )";

            query.Parameters.Add("@IdDocumentPerson", NpgsqlTypes.NpgsqlDbType.Varchar).Value = idDocumentPerson;
            query.Parameters.Add("@Email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = email;
            query.Parameters.Add("@CredentialPassword", NpgsqlTypes.NpgsqlDbType.Varchar).Value = credentialPassword;
            query.Parameters.Add("@IdRol", NpgsqlTypes.NpgsqlDbType.Smallint).Value = idRol;
            query.Parameters.Add("@Licenseplate", NpgsqlTypes.NpgsqlDbType.Varchar).Value = licenseplate;
            query.Parameters.Add("@Color", NpgsqlTypes.NpgsqlDbType.Varchar).Value = color;
            query.Parameters.Add("@Model", NpgsqlTypes.NpgsqlDbType.Varchar).Value = model;
            query.Parameters.Add("@Cylindercapacity", NpgsqlTypes.NpgsqlDbType.Varchar).Value = cylindercapacity;
            query.Parameters.Add("@Brand", NpgsqlTypes.NpgsqlDbType.Date).Value = brand;
            query.Parameters.Add("@Expeditiondatetechnomechanics", NpgsqlTypes.NpgsqlDbType.Varchar).Value = expeditiondatetechnomechanics;
            query.Parameters.Add("@Expirationdatetechnomechanics", NpgsqlTypes.NpgsqlDbType.Varchar).Value = expirationdatetechnomechanics;
            query.Parameters.Add("@Expeditiondatesoat", NpgsqlTypes.NpgsqlDbType.Varchar).Value = expeditiondatesoat;
            query.Parameters.Add("@Initialvaliditysoat", NpgsqlTypes.NpgsqlDbType.Smallint).Value = initialvaliditysoat;
            query.Parameters.Add("@Finalvaliditysoat", NpgsqlTypes.NpgsqlDbType.Varchar).Value = finalvaliditysoat;
            query.Parameters.Add("@Statee", NpgsqlTypes.NpgsqlDbType.Varchar).Value = statee;
            query.Parameters.Add("@Iddocumentowner", NpgsqlTypes.NpgsqlDbType.Varchar).Value = iddocumentowner;
            query.Parameters.Add("@Firstname", NpgsqlTypes.NpgsqlDbType.Smallint).Value = firstname;
            query.Parameters.Add("@Secondname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = secondname;
            query.Parameters.Add("@Surname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = surname;
            query.Parameters.Add("@Secondsurname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = secondsurname;
            query.Parameters.Add("@Transitexpender", NpgsqlTypes.NpgsqlDbType.Varchar).Value = transitexpender;
            query.Parameters.Add("@Expeditiondate", NpgsqlTypes.NpgsqlDbType.Date).Value = expeditiondate;
            query.Parameters.Add("@Restrictions", NpgsqlTypes.NpgsqlDbType.Varchar).Value = restrictions;
            query.Parameters.Add("@Category", NpgsqlTypes.NpgsqlDbType.Varchar).Value = category;
            query.Parameters.Add("@Service", NpgsqlTypes.NpgsqlDbType.Varchar).Value = service;
            query.Parameters.Add("@ValityDriver", NpgsqlTypes.NpgsqlDbType.Date).Value = validity;
            query.Parameters.Add("@Stade", NpgsqlTypes.NpgsqlDbType.Smallint).Value = stade;
            query.Parameters.Add("@Assignmentdate", NpgsqlTypes.NpgsqlDbType.Varchar).Value = assignmentdate;
            query.Parameters.Add("@Assignmentstate", NpgsqlTypes.NpgsqlDbType.Smallint).Value = assignmentstate;

            //Trata de ejecutar el procedimiento almacenado 
            //Con el try catch verificamos si no hay errores
            try
            {
                if (query.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

    }
}
