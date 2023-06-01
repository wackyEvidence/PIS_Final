using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Organization
    {
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
