using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;
using final_motoDix.helpers;
using final_motoDix.Estructuras;

namespace final_motoDix.Modelos
{
    /*public struct Driver
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
    }*/
    public class clsDriverModel : Iconductor 
    {
        public string idDocumentPersonDriver { get; set; }
        public DateTime dateofbirth { get ; set ; }
        public string firstname { get ; set ; }
        public string secondname { get ; set ; }
        public string surname { get ; set ; }
        public string secondsurname { get ; set ; }
        public string profilePicture { get ; set ; }
        public string gender { get ; set ; }
        public string state { get ; set ; }
        public string idcity { get ; set ; }
        public string email { get ; set ; }
        public int idRol { get ; set ; }
        public string licensetransitexpender { get ; set ; }
        public DateTime licenseexpeditiondate { get ; set ; }
        public string licenserestrictions { get ; set ; }
        public string licensecategory { get ; set ; }
        public DateTime licensevalidity { get ; set ; }
        public string driverstade { get ; set ; }
        public string assignmentstate { get ; set ; }
        public string licenseplate { get ; set ; }
        public string iddocumentowner { get ; set ; }
        public string color { get ; set ; }
        public int model { get ; set ; }
        public int cylindercapacity { get ; set ; }
        public string brand { get ; set ; }
        public DateTime expeditiondatetechnomechanics { get ; set ; }
        public DateTime expirationdatetechnomechanics { get ; set ; }
        public DateTime expeditiondatesoat { get ; set ; }
        public DateTime initialvaliditysoat { get ; set ; }
        public DateTime finalvaliditysoat { get ; set ; }
        public string statee { get ; set ; }
        public string ownerfirstname { get ; set ; }
        public string ownersecondname { get ; set ; }
        public string ownersurname { get ; set ; }
        public string ownersecondsurname { get ; set ; }
        public string CredentialPassword { get => credentialPassword; set => credentialPassword = value; }
        public string Transitexpender { get => transitexpender; set => transitexpender = value; }
        public DateTime Assignmentdate { get => assignmentdate; set => assignmentdate = value; }
        public string Service { get => service; set => service = value; }

        Iconductor iconductor;

        private NpgsqlConnection conexionDriver;

        private string credentialPassword;
        private string transitexpender;
        private DateTime assignmentdate;
        private string service;

        public clsDriverModel(string idDocumentPerson, string email, string credentialPassword, int idRol, string licenseplate, string color, int model, int cylindercapacity, string brand, DateTime expeditiondatetechnomechanics, DateTime expirationdatetechnomechanics, DateTime expeditiondatesoat, DateTime initialvaliditysoat, DateTime finalvaliditysoat, string statee, string iddocumentowner, string firstname, string secondname, string surname, string secondsurname, string transitexpender, DateTime expeditiondate, string restrictions, string category, string service, DateTime validity, string stade, DateTime assignmentdate, string assignmentstate)
        {
            idDocumentPersonDriver = idDocumentPerson;
            this.email = email;
            CredentialPassword = credentialPassword;
            this.idRol = idRol;
            this.licenseplate = licenseplate;
            this.color = color;
            this.model = model;
            this.cylindercapacity = cylindercapacity;
            this.brand = brand;
            this.expeditiondatetechnomechanics = expeditiondatetechnomechanics;
            this.expirationdatetechnomechanics = expirationdatetechnomechanics;
            this.expeditiondatesoat = expeditiondatesoat;
            this.initialvaliditysoat = initialvaliditysoat;
            this.finalvaliditysoat = finalvaliditysoat;
            this.statee = statee;
            this.iddocumentowner = iddocumentowner;
            this.ownerfirstname = firstname;
            this.ownersecondname = secondname;
            this.ownersurname = surname;
            this.ownersecondsurname = secondsurname;
            this.Transitexpender = transitexpender;
            this.licenseexpeditiondate = expeditiondate;
            this.licenserestrictions = restrictions;
            this.licensecategory = category;
            this.Service = service;
            this.licensevalidity = validity;
            this.driverstade = stade;
            this.Assignmentdate = assignmentdate;
            this.assignmentstate = assignmentstate;
            conexionDriver = clsConexion.realizarConexion();
        }
        
        public clsDriverModel(string email, string credentialPassword, int idRol)
        {
            this.email = email;
            CredentialPassword = credentialPassword;
            this.idRol = idRol;
            conexionDriver = clsConexion.realizarConexion();
        }
        public clsDriverModel()
        {

        }

        public clsDriverModel(string idDocumentPersonDriver, DateTime dateofbirth, string firstname, string secondname, string surname, string secondsurname, string profilePicture, string gender, string state, string idcity, string email, int idRol, string licensetransitexpender, DateTime licenseexpeditiondate, string licenserestrictions, string licensecategory, DateTime licensevalidity, string driverstade, string assignmentstate, string licenseplate, string iddocumentowner, string color, int model, int cylindercapacity, string brand, DateTime expeditiondatetechnomechanics, DateTime expirationdatetechnomechanics, DateTime expeditiondatesoat, DateTime initialvaliditysoat, DateTime finalvaliditysoat, string statee, string ownerfirstname, string ownersecondname, string ownersurname, string ownersecondsurname)
        {
            this.idDocumentPersonDriver = idDocumentPersonDriver;
            this.dateofbirth = dateofbirth;
            this.firstname = firstname;
            this.secondname = secondname;
            this.surname = surname;
            this.secondsurname = secondsurname;
            this.profilePicture = profilePicture;
            this.gender = gender;
            this.state = state;
            this.idcity = idcity;
            this.email = email;
            this.idRol = idRol;
            this.licensetransitexpender = licensetransitexpender;
            this.licenseexpeditiondate = licenseexpeditiondate;
            this.licenserestrictions = licenserestrictions;
            this.licensecategory = licensecategory;
            this.licensevalidity = licensevalidity;
            this.driverstade = driverstade;
            this.assignmentstate = assignmentstate;
            this.licenseplate = licenseplate;
            this.iddocumentowner = iddocumentowner;
            this.color = color;
            this.model = model;
            this.cylindercapacity = cylindercapacity;
            this.brand = brand;
            this.expeditiondatetechnomechanics = expeditiondatetechnomechanics;
            this.expirationdatetechnomechanics = expirationdatetechnomechanics;
            this.expeditiondatesoat = expeditiondatesoat;
            this.initialvaliditysoat = initialvaliditysoat;
            this.finalvaliditysoat = finalvaliditysoat;
            this.statee = statee;
            this.ownerfirstname = ownerfirstname;
            this.ownersecondname = ownersecondname;
            this.ownersurname = ownersurname;
            this.ownersecondsurname = ownersecondsurname;
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

            query.Parameters.Add("@IdDocumentPerson", NpgsqlTypes.NpgsqlDbType.Varchar).Value = idDocumentPersonDriver;
            query.Parameters.Add("@Email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = email;
            query.Parameters.Add("@CredentialPassword", NpgsqlTypes.NpgsqlDbType.Varchar).Value = CredentialPassword;
            query.Parameters.Add("@IdRol", NpgsqlTypes.NpgsqlDbType.Smallint).Value = idRol;
            query.Parameters.Add("@Licenseplate", NpgsqlTypes.NpgsqlDbType.Varchar).Value = licenseplate;
            query.Parameters.Add("@Color", NpgsqlTypes.NpgsqlDbType.Varchar).Value = color;
            query.Parameters.Add("@Model", NpgsqlTypes.NpgsqlDbType.Integer).Value = model;
            query.Parameters.Add("@Cylindercapacity", NpgsqlTypes.NpgsqlDbType.Integer).Value = cylindercapacity;
            query.Parameters.Add("@Brand", NpgsqlTypes.NpgsqlDbType.Varchar).Value = brand;
            query.Parameters.Add("@Expeditiondatetechnomechanics", NpgsqlTypes.NpgsqlDbType.Date).Value = expeditiondatetechnomechanics;
            query.Parameters.Add("@Expirationdatetechnomechanics", NpgsqlTypes.NpgsqlDbType.Date).Value = expirationdatetechnomechanics;
            query.Parameters.Add("@Expeditiondatesoat", NpgsqlTypes.NpgsqlDbType.Date).Value = expeditiondatesoat;
            query.Parameters.Add("@Initialvaliditysoat", NpgsqlTypes.NpgsqlDbType.Date).Value = initialvaliditysoat;
            query.Parameters.Add("@Finalvaliditysoat", NpgsqlTypes.NpgsqlDbType.Date).Value = finalvaliditysoat;
            query.Parameters.Add("@Statee", NpgsqlTypes.NpgsqlDbType.Varchar).Value = statee;
            query.Parameters.Add("@Iddocumentowner", NpgsqlTypes.NpgsqlDbType.Varchar).Value = iddocumentowner;
            query.Parameters.Add("@Firstname", NpgsqlTypes.NpgsqlDbType.Varchar).Value =ownerfirstname;
            query.Parameters.Add("@Secondname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = ownersecondname;
            query.Parameters.Add("@Surname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = ownersurname;
            query.Parameters.Add("@Secondsurname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = ownersecondsurname;
            query.Parameters.Add("@Transitexpender", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Transitexpender;
            query.Parameters.Add("@Expeditiondate", NpgsqlTypes.NpgsqlDbType.Date).Value = licenseexpeditiondate;
            query.Parameters.Add("@Restrictions", NpgsqlTypes.NpgsqlDbType.Varchar).Value = licenserestrictions;
            query.Parameters.Add("@Category", NpgsqlTypes.NpgsqlDbType.Varchar).Value = licensecategory;
            query.Parameters.Add("@Service", NpgsqlTypes.NpgsqlDbType.Varchar).Value = Service;
            query.Parameters.Add("@ValityDriver", NpgsqlTypes.NpgsqlDbType.Date).Value = licensevalidity;
            query.Parameters.Add("@Stade", NpgsqlTypes.NpgsqlDbType.Varchar).Value = driverstade;
            query.Parameters.Add("@Assignmentdate", NpgsqlTypes.NpgsqlDbType.Date).Value = Assignmentdate;
            query.Parameters.Add("@Assignmentstate", NpgsqlTypes.NpgsqlDbType.Varchar).Value = assignmentstate;

            //Con el try catch verificamos si no hay errores
            try
            {
                query.ExecuteNonQuery();
                return true;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }


        public Iconductor loginDriver()
        {

            validarConexion();
            NpgsqlCommand query = new NpgsqlCommand();
            query.Connection = conexionDriver;
            query.CommandText = "select * from App_login_driver(@Email,@CredentialPassword,@IdRol)";

            query.Parameters.Add("@IdRol", NpgsqlTypes.NpgsqlDbType.Smallint).Value = idRol;
            query.Parameters.Add("@Email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = email;
            query.Parameters.Add("@CredentialPassword", NpgsqlTypes.NpgsqlDbType.Varchar).Value = CredentialPassword;

            try
            {
                NpgsqlDataReader conductor = query.ExecuteReader();

                while (conductor.Read())
                {
                    iconductor = new clsDriverModel(conductor[0].ToString(),Convert.ToDateTime(conductor[1]),conductor[2].ToString(),conductor[3].ToString(),
                        conductor[4].ToString(), conductor[5].ToString(), conductor[6].ToString(), conductor[7].ToString(),
                        conductor[8].ToString(), conductor[9].ToString(), conductor[10].ToString(), Int32.Parse(conductor[11].ToString()),
                        conductor[12].ToString(), Convert.ToDateTime(conductor[13]), conductor[14].ToString(), conductor[15].ToString(),
                        Convert.ToDateTime(conductor[16]), conductor[17].ToString(), conductor[18].ToString(), conductor[19].ToString(),
                        conductor[20].ToString(), conductor[21].ToString(), Int32.Parse(conductor[22].ToString()), Int32.Parse(conductor[23].ToString()),
                        conductor[24].ToString(), Convert.ToDateTime(conductor[25]), Convert.ToDateTime(conductor[26]), Convert.ToDateTime(conductor[27]),
                        Convert.ToDateTime(conductor[28]), Convert.ToDateTime(conductor[29]), conductor[30].ToString(), conductor[31].ToString(),
                        conductor[32].ToString(), conductor[33].ToString(), conductor[34].ToString());
                }
                conductor.Close();

                return iconductor;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return null;
        }
    }
}
