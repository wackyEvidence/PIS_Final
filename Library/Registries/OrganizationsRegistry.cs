using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DBAdapters;
using Library.Models; 

namespace Library.Registries
{
    internal class OrganizationsRegistry
    {
        private List<Filter> permissionManagerFilters;
        public OrganizationsRegistry(PermissionManager userPM) => permissionManagerFilters = userPM.GetOrganizationsReadFilters; 

        public List<Organization> GetOrganizationsList(List<Filter> userFilters, Sort sort)
        {
            var organizationsList = new List<Organization>();
            var organizationsData = OrganizationsDBAdapter.GetOrganizationsList(permissionManagerFilters.Concat(userFilters).ToList(), sort);

            foreach (var entry in organizationsData)
                organizationsList.Add(new Organization(entry));

            return organizationsList;
        }
    }
}
