using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Library.Models; 

namespace Library.Permission_Manager
{
    internal class VetPermMan : PermissionManager
    {
        public override bool CanChangeAnimalsRegistry => true;
        public override bool CanChangeContractsRegistry => false;
        public override bool CanChangeOrganizationsRegistry => false;
        public override Dictionary<string, string> GetAnimalsReadFilter => new Dictionary<string, string>() 
        {
                    { "CardId", "All" },
                    { "Location", "All" },
                    { "Category", "All" },
                    { "Sex", "All" },
                    { "BirthYear", "All" },
                    { "ChipNumber", "All" },
                    { "Nickname", "All" },
                    { "Photo", "All" },
                    { "DistinguishingMarks", "All" },
                    { "OwnerSigns", "All" },
                    { "MedicalExaminations", "All" }
        }; 

        public override Dictionary<string, string> GetOrganizationsReadFilter => new Dictionary<string, string>();
        public override Dictionary<string, string> GetContractsReadFilter => new Dictionary<string, string>();
    }
}
