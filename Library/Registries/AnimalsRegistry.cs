using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Registries
{
    internal class AnimalsRegistry
    {
        private List<Filter> permissionManagerFilters;
        private List<Filter> userFilters;
        private Sort userSort;
        private PermissionManager userPM; 

        public AnimalsRegistry(PermissionManager userPM) 
        {
            this.userPM = userPM;
            permissionManagerFilters = userPM.GetAnimalsReadFilters; 
        }

        public void AddSort(Sort sort) => userSort = sort; 
        public void AddFilters(List<Filter> filters) => userFilters = filters;
            
        public List<Filter> FinalFilter { get { return permissionManagerFilters.Concat(userFilters).ToList(); } } 
    }
}
