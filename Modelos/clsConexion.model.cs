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

        private static readonly string host = "";
        private static readonly string user = "";
        private static readonly string dbo = "";
        private static readonly string password = "";
        private static readonly string port = ""; 

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
