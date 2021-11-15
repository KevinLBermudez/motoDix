using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_motoDix.Modelos;
using System.Windows.Forms;

namespace final_motoDix.Controladores
{
    class clsCiudadController
    {
        private clsCiudadModel ciudad;


        public clsCiudadController()
        {
            ciudad = new clsCiudadModel();
        }


        public void ejecutarConsultarDepartamentos(ComboBox cmb, int idDepartment)
        {
            try
            {
                cmb.DataSource = ciudad.ConsultarCiudadesDepartamento(idDepartment);
                cmb.DisplayMember = "name";
                cmb.ValueMember = "idcity";

            }
            catch (Exception)
            {
                throw new Exception("Error al cargar las ciudades");

            }

        }
    }
}
