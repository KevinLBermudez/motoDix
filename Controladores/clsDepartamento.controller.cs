using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_motoDix.Modelos;
using System.Windows.Forms;

namespace final_motoDix.Controladores
{
    class clsDepartamentoController
    {
        private clsDepartamentoModel departamento;

        public clsDepartamentoController()
        {

            departamento = new clsDepartamentoModel();
        }

        public void ejecutarConsultarDepartamentos(ComboBox cmb)
        {
            try
            {
                cmb.DataSource = departamento.ConsultarDepartamentos();
                cmb.DisplayMember = "name";
                cmb.ValueMember = "idDepartment";
            }
            catch (Exception )
            {
                throw new Exception("Error al cargar los departamentos");

            }

        }

    }
}
