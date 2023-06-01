using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Organization
    {
        public string FullName { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public string Address { get; set; }
        public OrganizationType OrganizationPurpose { get; set; }
        public OrganizationalAttribute Type { get; set; }
    }
}
