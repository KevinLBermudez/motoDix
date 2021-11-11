using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final_motoDix.Modelos;

namespace final_motoDix.Controladores
{
    class clsViajeController
    {

        private clsViajeModel viaje;


        public clsViajeController( string idDocumentPerson, string startPoint, string arrivalPoint, string state)
        {
            var guid = Guid.NewGuid();
            DateTime horaActual = DateTime.Now;

            viaje = new clsViajeModel(guid.ToString(),idDocumentPerson,startPoint,arrivalPoint,horaActual,state);

        }

        public void ejecutarSolicitarViaje()
        {
            if (viaje.solicitudViaje())
            {
                MessageBox.Show("Se solicito el viaje exitosamente");
            }
            else
            {
                MessageBox.Show("Error al solicitar viaje");
            }

        }

    }
}
