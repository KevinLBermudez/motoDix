﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_motoDix.Modelos;
using System.Windows.Forms;

namespace final_motoDix.Controladores
{
    class clsPersonController
    {

        private clsPersonModel persona;

        public Persona infoPersona;


        public clsPersonController(string idDocumentPerson, DateTime dateOfBirth, string firstName, string secondName, string surname, string secondSurname, string profilePicture, string gender, string idCity, string email, string credentialPassword, int idRol)
        {

            persona = new clsPersonModel(idDocumentPerson, dateOfBirth, firstName, secondName, surname, secondSurname, profilePicture, gender, idCity,email,credentialPassword,idRol);
        }

        public clsPersonController(string email, string credentialPassword, int idRol)
        {
            persona = new clsPersonModel(email, credentialPassword, idRol);

        }

        public void ejecutarCrearPersona()
        {
            if (persona.CrearPersona())
            {
                MessageBox.Show("Persona creado correctamente");

            }
            else
            {
                MessageBox.Show("Error interno");

            }
        }


        public Persona ejecutarLogin()
        {
           infoPersona =  persona.login();

            return infoPersona;
        
        }

    }
}
