using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Organization
    {
        public Organization(string fullName, string INN, string KPP, string regAddress, OrganizationType orgType, OrganizationalAttribute type, Locality location)
        {
            FullName = fullName;
            this.INN = INN;
            this.KPP = KPP;
            RegistrationAddress = regAddress;
            OrganizationPurpose = orgType;
            Type = type; 
            Location = location;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public string RegistrationAddress { get; set; }
        /// <summary>
        /// Функциональное назначение  
        /// </summary>
        public OrganizationType OrganizationPurpose { get; set; }
        /// <summary>
        /// Признак организации: юридическое лицо или индивидуальный предприниматель 
        /// </summary>
        public OrganizationalAttribute Type { get; set; }
        public Locality Location { get; set; }
    }
}
