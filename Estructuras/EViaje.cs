using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_motoDix.Estructuras
{
    class EViaje
    {

        public struct EstViaje
        {
            private string travelId;
            private string firstNameDriver;
            private string secondNameDriver;
            private string surnameDriver;
            private string secondSurname;
            private string profilePictureDriver;
            private string brand;
            private string color;
            private string licencePLate;
            private string state;

            public string TravelId { get => travelId; set => travelId = value; }
            public string FirstNameDriver { get => firstNameDriver; set => firstNameDriver = value; }
            public string SecondNameDriver { get => secondNameDriver; set => secondNameDriver = value; }
            public string SurnameDriver { get => surnameDriver; set => surnameDriver = value; }
            public string SecondSurname { get => secondSurname; set => secondSurname = value; }
            public string ProfilePictureDriver { get => profilePictureDriver; set => profilePictureDriver = value; }
            public string Brand { get => brand; set => brand = value; }
            public string Color { get => color; set => color = value; }
            public string LicencePLate { get => licencePLate; set => licencePLate = value; }
            public string State { get => state; set => state = value; }

            public EstViaje(string travelId, string firstNameDriver, string secondNameDriver, string surnameDriver, string secondSurname, string profilePictureDriver, string brand, string color, string licencePLate, string state) : this()
            {
                TravelId = travelId;
                FirstNameDriver = firstNameDriver;
                SecondNameDriver = secondNameDriver;
                SurnameDriver = surnameDriver;
                SecondSurname = secondSurname;
                ProfilePictureDriver = profilePictureDriver;
                Brand = brand;
                Color = color;
                LicencePLate = licencePLate;
                State = state;
            }
        }

    }
}
