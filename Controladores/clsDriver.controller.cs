using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_motoDix.Modelos;
using System.Windows.Forms;
using final_motoDix.Estructuras;

namespace final_motoDix.Controladores
{
    class clsDriverController
    {
        private clsDriverModel driver;

        //public Driver infoConductor;

        public clsDriverController(string idDocumentPerson, string email, string credentialPassword, int idRol, string licenseplate, string color, int model, int cylindercapacity, string brand, DateTime expeditiondatetechnomechanics, DateTime expirationdatetechnomechanics, DateTime expeditiondatesoat, DateTime initialvaliditysoat, DateTime finalvaliditysoat, string statee, string iddocumentowner, string firstname, string secondname, string surname, string secondsurname, string transitexpender, DateTime expeditiondate, string restrictions, string category, string service, DateTime validity, string stade, DateTime assignmentdate, string assignmentstate = "Solicitado")
        {
            driver = new clsDriverModel(idDocumentPerson, email, credentialPassword, idRol, licenseplate, color, model, cylindercapacity, brand, expeditiondatetechnomechanics, expirationdatetechnomechanics, expeditiondatesoat, initialvaliditysoat, finalvaliditysoat, statee, iddocumentowner, firstname, secondname, surname, secondsurname, transitexpender, expeditiondate, restrictions, category, service, validity, stade, assignmentdate, assignmentstate);
        }

        public clsDriverController(string email, string credentialPassword, int idrol)
        {
            driver = new clsDriverModel(email, credentialPassword, idrol);
        }

        public clsDriverController()
        {
            driver = new clsDriverModel();
        }
        public clsDriverController(string idDocumentDriver)
        {
            driver = new clsDriverModel(idDocumentDriver);

        }

        public void ejecutarCrearDriver()
        {
            if (driver.RegistrarConductor())
            {
                MessageBox.Show("Conductor creado correctamente");
            }
            else
            {
                throw new Exception("Error al crear al conductor, intentalo más tarde");

            }
        }

        public Iconductor ejectutarLoginDriver()
        {
            Iconductor conductor;

            try
            {
                conductor = driver.loginDriver();

                return conductor;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);

            }


        }

        public void ejecutarObtenerSolicitudesConductor(DataGridView data)
        {
            try
            {

                data.DataSource = driver.obtenerSolicitudesConductor();
                data.Columns[0].HeaderText = "Documento de solicitud";
                data.Columns[1].HeaderText = "Estado de la solicitud";
                data.Columns[2].HeaderText = "Primer nombre";
                data.Columns[3].HeaderText = "Segundo Nombre";
                data.Columns[4].HeaderText = "Primer Apellido";
                data.Columns[5].HeaderText = "Segundo Apellido";
                data.Columns[6].HeaderText = "Genero";
                data.Columns[7].HeaderText = "Transito expendedor de licencia";
                data.Columns[8].HeaderText = "Fecha de expedicion de licencia";
                data.Columns[9].HeaderText = "Restricciones";
                data.Columns[10].HeaderText = "Categoria de licencia";
                data.Columns[11].HeaderText = "Licencia valida hasta";
                data.Columns[12].HeaderText = "Servicio";
                data.Columns[13].HeaderText = "Placa del vehiculo";
                data.Columns[14].HeaderText = "Fecha de asignacion a el vehiculo";
                data.Columns[15].HeaderText = "Estado de asignacion vehiculo-conductor ";
                data.Columns[16].HeaderText = "Color del vehiculo";
                data.Columns[17].HeaderText = "Modelo";
                data.Columns[18].HeaderText = "Cilindraje";
                data.Columns[19].HeaderText = "Marca";
                data.Columns[20].HeaderText = "Fecha de expedicion de tecnomecanica";
                data.Columns[21].HeaderText = "Fecha de expiracion de tecnomecanica";
                data.Columns[22].HeaderText = "Fecha de expedicion de Soat";
                data.Columns[23].HeaderText = "Fecha de inicio de Soat";
                data.Columns[24].HeaderText = "Fecha de expiracion de Soat";
                data.Columns[25].HeaderText = "Estado de la motocileta";
                data.Columns[26].HeaderText = "Documento del propietario";
                data.Columns[27].HeaderText = "Primer nombre del propietario";
                data.Columns[28].HeaderText = "Segundo nombre del propietario";
                data.Columns[29].HeaderText = "Primer apellido del propietario";
                data.Columns[30].HeaderText = "Segundo apellido del propietario";


            }
            catch (Exception err)
            {
                throw new Exception(err.Message);

            }
        }


        public bool ejecutarAceptarUnConductor(string idDocumentDriver,int idRol,string state,string stateAssignment)
        {
            driver = new clsDriverModel(idDocumentDriver, idRol,state, stateAssignment);
            try
            {
                if (driver.aceptarUnConductor())
                {
                    return true;
                }
                else
                {
                    throw new Exception("No se pudo aceptar la solicitud seleccionada");
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }

        }

        public bool ejecutarCheckDriver()
        {

            try
            {
                if (driver.checkDriver())
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
