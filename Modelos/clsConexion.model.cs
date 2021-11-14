using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace final_motoDix.Modelos
{
    public class clsConexion
    {
        private static NpgsqlConnection conexion;

        private static readonly string host = "kevin-dev-uni.postgres.database.azure.com";
        private static readonly string user = "kevin";
        private static readonly string dbo = "dboMotoDix";
        private static readonly string password = "Klnmw230147";
        private static readonly string port = "5432"; 

        public static NpgsqlConnection realizarConexion()
        {
            if(conexion == null)
            {
                conexion = new NpgsqlConnection($"Server={host}; Port={port}; Database={dbo}; User Id={user}; Password={password}; Ssl Mode=Require");

                try
                {
                    conexion.Open();
                    return conexion;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);

                    return null;
                }

            }
            else
            {
                return conexion;
            }
        }

    }
}
