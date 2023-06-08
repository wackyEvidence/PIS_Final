using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Permission_Manager
{
    internal class OMSU_PermissionManager : PermissionManager
    {
        public override bool CanChangeAnimalsRegistry => false;
        public override bool CanChangeContractsRegistry => false;
        public override bool CanChangeOrganizationsRegistry => false;
        // => new Filter { Поле = Location, Value = UserWorkplaceLocation}
        public override Dictionary<string, string> GetAnimalsReadFilter => new Dictionary<string, string>()
        {
            { "CardId", "UserWorkplaceLocation" },
            { "Location", "UserWorkplaceLocation" },
            { "Category", "UserWorkplaceLocation" },
            { "Sex", "UserWorkplaceLocation" },
            { "BirthYear", "UserWorkplaceLocation" },
            { "ChipNumber", "UserWorkplaceLocation" },
            { "Nickname", "UserWorkplaceLocation" },
            { "Photo", "UserWorkplaceLocation" },
            { "DistinguishingMarks", "UserWorkplaceLocation" },
            { "OwnerSigns", "UserWorkplaceLocation" },
            { "MedicalExaminations", "UserWorkplaceLocation" }
        }; 

        public override Dictionary<string, string> GetOrganizationsReadFilter => new Dictionary<string, string>()
        {
            { "FullName", "UserWorkplaceLocation" },
            { "INN", "UserWorkplaceLocation" },
            { "KPP", "UserWorkplaceLocation" },
            { "RegistrationAddress", "UserWorkplaceLocation" },
            { "OrganizationPurpose", "UserWorkplaceLocation" },
            { "Type", "UserWorkplaceLocation" },
            { "Location", "UserWorkplaceLocation" }
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
