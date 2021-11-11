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

    public struct Persona
    {
        private string idDocumentPersona;
        private DateTime dateOfBirth;
        private string firstName;
        private string secondName;
        private string surname;
        private string secondSurname;
        private string profilePicture;
        private string gender;
        private string state ;
        private string email;
        private int idRol;
        private string rolName;

        public Persona(string idDocumentPersona, DateTime dateOfBirth, string firstName, string secondName, string surname, string secondSurname, string profilePicture, string gender, string state, string email, int idRol, string rolName)
        {
             this.idDocumentPersona = idDocumentPersona;
             this.dateOfBirth = dateOfBirth;
             this.firstName = firstName;
             this.secondName = secondName;
             this.surname = surname;
             this.secondSurname = secondSurname;
             this.profilePicture = profilePicture;
             this.gender = gender;
             this.state = state;
             this.email = email;
             this.idRol = idRol;
             this.rolName = rolName;
        }


        public string IdDocumentPersona { get => idDocumentPersona; set => idDocumentPersona = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string Surname { get => surname; set => surname = value; }
        public string SecondSurname { get => secondSurname; set => secondSurname = value; }
        public string ProfilePicture { get => profilePicture; set => profilePicture = value; }
        public string Gender { get => gender; set => gender = value; }
        public string State { get => state; set => state = value; }
        public string Email { get => email; set => email = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public string RolName { get => rolName; set => rolName = value; }
    }


    class clsPersonModel
    {

        private clsCloudinary cloud;

        private Persona persona;
        
        private NpgsqlConnection conexionPersona;

        private string idDocumentPerson;
        private DateTime dateOfBirth;
        private string firstName;
        private string secondName;
        private string surname;
        private string secondSurname;
        private string profilePicture;
        private string gender;
        private DateTime dateRegistration = DateTime.Now;
        private string state = "Activo";
        private string idCity;

        //login
        private string email;
        private string credentialPassword;
        private int idRol;

        public string IdDocumentPerson { get => idDocumentPerson; set => idDocumentPerson = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string Surname { get => surname; set => surname = value; }
        public string SecondSurname { get => secondSurname; set => secondSurname = value; }
        public string ProfilePicture { get => profilePicture; set => profilePicture = value; }
        public string Gender { get => gender; set => gender = value; }
        public string IdCity { get => idCity; set => idCity = value; }
        public string Email { get => email; set => email = value; }
        public string CredentialPassword { get => credentialPassword; set => credentialPassword = value; }
        public int IdRol { get => idRol; set => idRol = value; }

        public Persona Persona { get => persona; set => persona = value; }

        public clsPersonModel(string idDocumentPerson, DateTime dateOfBirth, string firstName, string secondName, string surname, string secondSurname, string profilePicture, string gender, string idCity, string email, string credentialPassword, int idRol)
        {

            IdDocumentPerson = idDocumentPerson;
            DateOfBirth = dateOfBirth;
            FirstName = firstName;
            SecondName = secondName;
            Surname = surname;
            SecondSurname = secondSurname;
            ProfilePicture = profilePicture;
            Gender = gender;
            IdCity = idCity;
            Email = email;
            CredentialPassword = credentialPassword;
            IdRol = idRol;

            conexionPersona = clsConexion.realizarConexion();
            cloud = new clsCloudinary();

        }

        public clsPersonModel(string email, string credentialPassword, int idRol)
        {
            Email = email;
            CredentialPassword = credentialPassword;
            IdRol = idRol;
            conexionPersona = clsConexion.realizarConexion();

        }

        public void validarConexion()
        {
            if (conexionPersona == null)
            {
                MessageBox.Show("Error en la conexión");
                return;
            }
        }

        public bool CrearPersona()
        {
            if (profilePicture.Trim() != "null")
            {

                Task.Run(async () =>
                {

                    Task<string> vs = cloud.cargarImagen(profilePicture);

                    string rutaCloudinary = await vs;

                    profilePicture = rutaCloudinary;

                }).GetAwaiter().GetResult();


            }


            validarConexion();
            NpgsqlCommand query = new NpgsqlCommand();
            query.Connection = conexionPersona;


            query.CommandText = "CALL App_users_register(@IdDocumentPerson,@DateOfBirth,@FirstName, " +
                "@SecondName,@Surname,@SecondSurname,@ProfilePicture,@Gender," +
                "@dateResgistration,@IdCity" +
                ",@Email,@CredentialPassword,@IdRol)";


            query.Parameters.Add("@IdDocumentPerson", NpgsqlTypes.NpgsqlDbType.Varchar).Value = idDocumentPerson;
            query.Parameters.Add("@DateOfBirth", NpgsqlTypes.NpgsqlDbType.Date).Value = dateOfBirth;
            query.Parameters.Add("@FirstName", NpgsqlTypes.NpgsqlDbType.Varchar).Value = firstName;
            query.Parameters.Add("@SecondName", NpgsqlTypes.NpgsqlDbType.Varchar).Value = secondName;
            query.Parameters.Add("@Surname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = surname;
            query.Parameters.Add("@SecondSurname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = secondName;
            query.Parameters.Add("@ProfilePicture", NpgsqlTypes.NpgsqlDbType.Varchar).Value = profilePicture;
            query.Parameters.Add("@Gender", NpgsqlTypes.NpgsqlDbType.Varchar).Value = gender;
            query.Parameters.Add("@dateResgistration", NpgsqlTypes.NpgsqlDbType.Date).Value = dateRegistration;
            query.Parameters.Add("@IdCity", NpgsqlTypes.NpgsqlDbType.Varchar).Value = idCity;
            query.Parameters.Add("@Email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = email;
            query.Parameters.Add("@CredentialPassword", NpgsqlTypes.NpgsqlDbType.Varchar).Value = credentialPassword;
            query.Parameters.Add("@IdRol", NpgsqlTypes.NpgsqlDbType.Smallint).Value = idRol;


            try
            {
                if(query.ExecuteNonQuery() == 1)
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

        public Persona login()
        {
            validarConexion();
            NpgsqlCommand query = new NpgsqlCommand();
            query.Connection = conexionPersona;
            query.CommandText = "select * from App_Login(@Email,@CredentialPassword,@IdRol)";

            query.Parameters.Add("@IdRol", NpgsqlTypes.NpgsqlDbType.Smallint).Value = idRol;
            query.Parameters.Add("@Email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = email;
            query.Parameters.Add("@CredentialPassword", NpgsqlTypes.NpgsqlDbType.Varchar).Value = credentialPassword;

            try
            {
                NpgsqlDataReader persona = query.ExecuteReader();

                while (persona.Read())
                {
                    if(persona["profilePicture"] == DBNull.Value)
                    {
                        ProfilePicture = "";
                    }
                    else
                    {
                        ProfilePicture = (string) persona["profilePicture"];
                    };

                    if (persona["secondName"] == DBNull.Value)
                    {
                        SecondName = "";

                    }
                    else
                    {
                        SecondName = (string)persona["secondName"];
                    };
                    if(persona["secondSurname"] ==  DBNull.Value)
                    {
                        SecondSurname = "";
                    }
                    else
                    {
                        SecondSurname = (string)persona["secondSurname"];
                    };

                    Persona = new Persona((string)persona["idDocumentPerson"],Convert.ToDateTime( persona["dateOfBirth"]), (string)persona["firstname"],
                        SecondName, (string)persona["surname"], SecondSurname,
                        ProfilePicture, (string)persona["gender"], (string)persona["state"], (string)persona["email"],Convert.ToInt16(persona["idRol"]),(string)persona["nameRol"]);

                }

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            return Persona;
        
        }

    }
}
