using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_motoDix.Modelos;
using System.Windows.Forms;

namespace final_motoDix.Controladores
{
    class clsDriverController
    {
        private clsDriverModel driver;

        //public Driver infoConductor;

        public clsDriverController(string idDocumentPerson, string email, string credentialPassword, int idRol, string licenseplate, string color, int model, int cylindercapacity, string brand, DateTime expeditiondatetechnomechanics, DateTime expirationdatetechnomechanics, DateTime expeditiondatesoat, DateTime initialvaliditysoat, DateTime finalvaliditysoat, string statee, string iddocumentowner, string firstname, string secondname, string surname, string secondsurname, string transitexpender, DateTime expeditiondate, string restrictions, string category, string service, DateTime validity, string stade, DateTime assignmentdate, string assignmentstate)
        {
            driver = new clsDriverModel(idDocumentPerson, email, credentialPassword, idRol, licenseplate, color, model, cylindercapacity, brand, expeditiondatetechnomechanics, expirationdatetechnomechanics, expeditiondatesoat, initialvaliditysoat, finalvaliditysoat, statee, iddocumentowner, firstname, secondname, surname, secondsurname, transitexpender, expeditiondate, restrictions, category, service, validity, stade, assignmentdate, assignmentstate);
        }

        public void ejecutarCrearDriver()
        {
            if (driver.RegistrarConductor())
            {
                MessageBox.Show("Conductor creado correctamente");
            }
            else
            {
                MessageBox.Show("Error interno");
            }
        }
    }
}
