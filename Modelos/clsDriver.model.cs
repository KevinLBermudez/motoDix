using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Windows.Forms;
using System.Data;
using final_motoDix.helpers;
using final_motoDix.Estructuras;

namespace final_motoDix.Modelos
{
    
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
            conexionDriver = clsConexion.realizarConexion();

        }

        public clsDriverModel(string idDocumentPersonDriver)
        {
            this.idDocumentPersonDriver = idDocumentPersonDriver;
            conexionDriver = clsConexion.realizarConexion();

        }

        public clsDriverModel(string idDocumentPersonDriver, int idRol, string state,string assignmentstate)
        {
            this.idDocumentPersonDriver = idDocumentPersonDriver;
            this.idRol = idRol;
            this.state = state;
            this.assignmentstate = assignmentstate;
            conexionDriver = clsConexion.realizarConexion();

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
                throw new Exception("Error interno, por favor envia un reporte para mejorar nuestro servicio");

            }

        }


        public Iconductor loginDriver()
        {
            string segundoNombre = "";
            string segundoApellido = "";

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
                    if(conductor[3].ToString() != "null")
                    {
                        segundoNombre = conductor[3].ToString();
                    }
                    if(conductor[5].ToString() != "null")
                    {
                        segundoApellido = conductor[5].ToString();
                    }
                     

                    iconductor = new clsDriverModel(conductor[0].ToString(),Convert.ToDateTime(conductor[1]),conductor[2].ToString(),segundoNombre,
                        conductor[4].ToString(), segundoApellido, conductor[6].ToString(), conductor[7].ToString(),
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
            catch (Exception err)
            {
                throw new Exception("Compruebe sus credenciales");
            }

        }

        public DataTable obtenerSolicitudesConductor()
        {

            validarConexion();
            string consulta = "select * from consultar_solicitudes(); ;";

            NpgsqlCommand query = new NpgsqlCommand(consulta, conexionDriver);

            try
            {
                DataTable dtSolicitudes = new DataTable();

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query);
                adapter.Fill(dtSolicitudes);
                return dtSolicitudes;


            }
            catch (Exception err)
            {
                throw new Exception(err.Message);

            }
        }

        public bool aceptarUnConductor()
        {

            validarConexion();
            NpgsqlCommand query = new NpgsqlCommand();
            query.Connection = conexionDriver;
            query.CommandText = "SELECT public.app_accept_driver(@idDocumentDrive,@idRol,@state,@assignmentstate);";

            query.Parameters.Add("@idRol", NpgsqlTypes.NpgsqlDbType.Smallint).Value = idRol;
            query.Parameters.Add("@idDocumentDrive", NpgsqlDbType.Varchar).Value = idDocumentPersonDriver;
            query.Parameters.Add("@state", NpgsqlDbType.Varchar).Value = state;
            query.Parameters.Add("@assignmentstate", NpgsqlDbType.Varchar).Value = assignmentstate;

            try
            {
                query.ExecuteNonQuery();
                return true;
            }
            catch (NpgsqlException err)
            {
                throw new Exception(err.Message);
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);

            }

        }


        public bool checkDriver()
        {

            validarConexion();

            NpgsqlCommand query = new NpgsqlCommand();
            query.Connection = conexionDriver;
            query.CommandText = "SELECT public.checkdriver(@idDocumentDrive);";

            query.Parameters.Add("@idDocumentDrive", NpgsqlDbType.Varchar).Value = idDocumentPersonDriver;
  
            try
            {

                if (query.ExecuteNonQuery()==1)
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch (Exception err)
            {
                throw new Exception(err.Message);

            }

        }
    }
}
