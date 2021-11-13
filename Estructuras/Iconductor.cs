using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_motoDix.Estructuras
{
    public interface Iconductor
    {
		string idDocumentPersonDriver { get; set; } 
		DateTime dateofbirth { get; set; }
		string firstname { get; set; } 
		string secondname { get; set; }
		string surname { get; set; } 
		string secondsurname { get; set; } 
		string profilePicture { get; set; } 
		string gender { get; set; } 
		string state { get; set; }
		string idcity { get; set; } 
		string email { get; set; }
		int idRol  { get; set; } 
		string licensetransitexpender  { get; set; }
		DateTime licenseexpeditiondate   { get; set; }
		string licenserestrictions  { get; set; }
		string	licensecategory  { get; set; }
		DateTime licensevalidity  { get; set; }
		string driverstade  { get; set; }
		string assignmentstate  { get; set; }
		string licenseplate  { get; set; }
		string iddocumentowner  { get; set; }
		string color   { get; set; }
		int model  { get; set; }
		int cylindercapacity { get; set; }
		string brand  { get; set; }
		DateTime expeditiondatetechnomechanics { get; set; }
		DateTime expirationdatetechnomechanics { get; set; }
		DateTime expeditiondatesoat{ get; set; }
		DateTime initialvaliditysoat { get; set; }
		DateTime finalvaliditysoat  { get; set; }
		string statee{ get; set; } 
		string ownerfirstname { get; set; }
		string ownersecondname { get; set; }
		string ownersurname { get; set; }
		string ownersecondsurname { get; set; }

	}

}
