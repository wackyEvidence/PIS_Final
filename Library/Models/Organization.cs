using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Organization
    {
        public Organization(Dictionary<string, string> organization)
        {
            Id = int.Parse(organization["Id"]);
            FullName = organization["FullName"]; 
            INN = organization["INN"];
            KPP = organization["KPP"];
            RegistrationAddress = organization["RegistrationAddress"];
            Type = (OrganizationType)int.Parse(organization["Type"]);
            Attribute = (OrganizationalAttribute)int.Parse(organization["Attribute"]);
            //Location = (Location)int.Parse(organization["Location"]); 
            Location = organization["Location"]; 
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public string RegistrationAddress { get; set; }
        public OrganizationType Type { get; set; } // тип организации
        public OrganizationalAttribute Attribute { get; set; } // признак организации
        //public Location Location { get; set; }
        public string Location { get; set; }
    }
}
