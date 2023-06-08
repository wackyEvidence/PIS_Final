using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Permission_Managers
{
    internal class TrappingOperatorPermissionManager : PermissionManager
    {
        public override bool CanChangeAnimalsRegistry => false;
        public override bool CanChangeOrganizationsRegistry => false;
        public override bool CanChangeContractsRegistry => false;


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
