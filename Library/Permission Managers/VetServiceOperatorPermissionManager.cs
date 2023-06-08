namespace Library.Permission_Managers
{
    internal class VetServiceOperatorPermissionManager : PermissionManager
    {
        private readonly OrganizationType[] allowedOrganizationTypes = new OrganizationType[]
        {
            OrganizationType.ExecutiveBranchOfStatePower,
            OrganizationType.Council,
            OrganizationType.StateVetClinic,
        };

        public override bool CanChangeAnimalsRegistry => false;
        public override bool CanChangeOrganizationsRegistry => true;
        public override bool CanChangeContractsRegistry => false;

        public override List<Filter> GetAnimalsReadFilters => new List<Filter>() { new Filter("All", "All") };
        public override List<Filter> GetOrganizationsReadFilters => new List<Filter>() { new Filter("OrganizationPurpose", string.Join(' ', allowedOrganizationTypes)) };
        public override List<Filter> GetContractsReadFilters => new List<Filter>() { new Filter("All", "All") };

        //public override Dictionary<string, string> GetAnimalsReadFilter => new Dictionary<string, string>()
        //{
        //    { "CardId", "All" },
        //    { "Location", "All" },
        //    { "Category", "All" },
        //    { "Sex", "All" },
        //    { "BirthYear", "All" },
        //    { "ChipNumber", "All" },
        //    { "Nickname", "All" },
        //    { "Photo", "All" },
        //    { "DistinguishingMarks", "All" },
        //    { "OwnerSigns", "All" },
        //    { "MedicalExaminations", "All" }
        //};

        //public override Dictionary<string, string> GetOrganizationsReadFilter => new Dictionary<string, string>()
        //{
        //    { "FullName", "VetServiceTypes" },
        //    { "INN", "VetServiceTypes" },
        //    { "KPP", "VetServiceTypes" },
        //    { "RegistrationAddress", "VetServiceTypes" },
        //    { "OrganizationPurpose", "VetServiceTypes" },
        //    { "Type", "VetServiceTypes" },
        //    { "Location", "VetServiceTypes" }
        //};

        //public override Dictionary<string, string> GetContractsReadFilter => new Dictionary<string, string>()
        //{
        //    { "Number", "All" },
        //    { "SigningDate", "All" },
        //    { "ValidUntil", "All" },
        //    { "Executor", "All" },
        //    { "Client", "All" },
        //    { "LocalitiesList", "All" }
        //};
    }
}
