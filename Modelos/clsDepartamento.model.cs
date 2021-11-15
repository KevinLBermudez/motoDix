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
    class clsDepartamentoModel
    {

        private NpgsqlConnection conexionDepartamento;

        public clsDepartamentoModel()
        {
            conexionDepartamento = clsConexion.realizarConexion();
        }

        public void validarConexion()
        {
            if (conexionDepartamento == null)
            {
                MessageBox.Show("Error en la conexión");
                return;
            }
        }

        public DataTable ConsultarDepartamentos()
        {
            try
            {
                validarConexion();
                NpgsqlCommand query = new NpgsqlCommand();
                query.Connection = conexionDepartamento;
                query.CommandText = "select idDepartment,name from tblDepartment;";
                NpgsqlDataAdapter departamentos = new NpgsqlDataAdapter(query);
                DataTable dt = new DataTable();
                departamentos.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw new Exception("Error interno, por favor envia un reporte para mejorar nuestro servicio");
            }
           
        }

    }
}
