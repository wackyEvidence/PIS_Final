using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Permission_Manager
{
    internal class SignatoryPermissionManager : PermissionManager
    {
        public override bool CanChangeAnimalsRegistry => false;
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

        public override Dictionary<string, string> GetOrganizationsReadFilter => new Dictionary<string, string>()
        {
            { "FullName", "All" },
            { "INN", "All" },
            { "KPP", "All" },
            { "RegistrationAddress", "All" },
            { "OrganizationPurpose", "All" },
            { "Type", "All" },
            { "Location", "All" }
        };

        public override Dictionary<string, string> GetContractsReadFilter => new Dictionary<string, string>()
        {
            { "Number", "UserWorkplaceLocation" },
            { "SigningDate", "UserWorkplaceLocation" },
            { "ValidUntil", "UserWorkplaceLocation" },
            { "Executor", "UserWorkplaceLocation" },
            { "Client", "UserWorkplaceLocation" },
            { "LocalitiesList", "UserWorkplaceLocation" }
        };
    }
}
