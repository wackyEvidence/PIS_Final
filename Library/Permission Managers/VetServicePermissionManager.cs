﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Permission_Manager
{
    internal class VetServicePermissionManager : PermissionManager
    {
        public override bool CanChangeAnimalsRegistry => false;
        public override bool CanChangeOrganizationsRegistry => false;
        public override bool CanChangeContractsRegistry => false;

        public override List<Filter> GetAnimalsReadFilters => new List<Filter>() { new Filter("All", "All")};
        public override List<Filter> GetOrganizationsReadFilters => new List<Filter>() { new Filter("All", "All") };
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
        //    { "FullName", "All" },
        //    { "INN", "All" },
        //    { "KPP", "All" },
        //    { "RegistrationAddress", "All" },
        //    { "OrganizationPurpose", "All" },
        //    { "Type", "All" },
        //    { "Location", "All" }
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
