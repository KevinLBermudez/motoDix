﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final_motoDix.Modelos;
using System.Data;
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
        public clsViajeController()
        {
            viaje = new clsViajeModel();
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

        public void ejecutarObtenerViajesSolicitados(DataGridView data)
        {
            try
            {
                data.DataSource = viaje.obtenerViajesSolicitados();
                data.Columns[1].HeaderText = "Persona de solicitud";
                data.Columns[2].HeaderText = "Punto de inicio";
                data.Columns[3].HeaderText = "Punto de llegada";
                data.Columns[4].HeaderText = "Fecha de solicitud";

                data.Columns[0].Visible = false;

            }
            catch (Exception err)
            {
                MessageBox.Show("Error interno");
            }
        }

    }
}
