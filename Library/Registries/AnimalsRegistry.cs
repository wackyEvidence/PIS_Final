using Library.DBAdapters;
using Library.Models;
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
        public AnimalsRegistry(PermissionManager userPM) => permissionManagerFilters = userPM.GetAnimalsReadFilters;

        public List<Animal> GetAnimalsList(List<Filter> userFilters, Sort sort)
        {
            var animalsList = new List<Animal>();
            var animalsData = AnimalsDBAdapter.GetAnimalsList(permissionManagerFilters.Concat(userFilters).ToList(), sort); 

            foreach(var entry in animalsData)
                animalsList.Add(new Animal(entry)); 

            return animalsList;
        }
    }
}
