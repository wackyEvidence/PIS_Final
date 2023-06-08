using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models; 
using System.Threading.Tasks;

namespace Library.Permission_Managers
{
    internal class OMSU_OperatorPermissionManager : PermissionManager
    {
        private readonly User user;
        private readonly OrganizationType[] allowedOrganizationTypes = new OrganizationType[8]
        {
            OrganizationType.AnimalShelter, 
            OrganizationType.AnimalTrappingOrganization,
            OrganizationType.AnimalTrappingAndShelteringOrganization,
            OrganizationType.AnimalTransportationOrganization, 
            OrganizationType.PrivateVetClinic, 
            OrganizationType.StateVetClinic,
            OrganizationType.CharitableFoundation,
            OrganizationType.OrganizationsForSalingGoodsAndServicesForAnimals
        }; 

        public OMSU_OperatorPermissionManager(User user) => this.user = user;

        public override bool CanChangeAnimalsRegistry => false;
        public override bool CanChangeOrganizationsRegistry => true;
        public override bool CanChangeContractsRegistry => true;

        public override List<Filter> GetAnimalsReadFilters => new List<Filter>() { { new Filter("Location", user.Workplace.Location.ToString()) } };
        public override List<Filter> GetOrganizationsReadFilters => new List<Filter>() 
        { 
            { new Filter("Location", user.Workplace.Location.ToString()) },
            { new Filter("OrganizationPurpose", string.Join(' ', allowedOrganizationTypes)) }
        };
        public override List<Filter> GetContractsReadFilters => new List<Filter>() { new Filter("LocalitiesList", user.Workplace.Location.ToString()) };
    }
}
