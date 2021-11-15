using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;


namespace final_motoDix.Modelos
{
    class clsCiudadModel
    {

        private NpgsqlConnection conexionCiudad;

        public clsCiudadModel()
        {

            conexionCiudad = clsConexion.realizarConexion();

        }

        public void validarConexion()
        {
            if (conexionCiudad == null)
            {
                MessageBox.Show("Error en la conexión");
                return;
            }
        }


        public DataTable ConsultarCiudadesDepartamento(int codigoDepartamento)
        {
            try
            {
                string idDeparment = codigoDepartamento.ToString();
                validarConexion();
                NpgsqlCommand query = new NpgsqlCommand();
                query.Connection = conexionCiudad;
                query.CommandText = "select idcity,name from tblcity where idDepartment = @idDepartment;";
                query.Parameters.Add("@idDepartment", NpgsqlTypes.NpgsqlDbType.Varchar).Value = idDeparment;

                NpgsqlDataAdapter ciudades = new NpgsqlDataAdapter(query);
                DataTable dt = new DataTable();
                ciudades.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error interno, por favor envia un reporte para mejorar nuestro servicio");

            }

        }

    }
}
