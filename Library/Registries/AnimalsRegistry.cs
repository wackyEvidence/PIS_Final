using Library.DBAdapters;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Registries
{
    public class AnimalsRegistry
    {
        private List<Filter> permissionManagerFilters;
        public AnimalsRegistry(PermissionManager userPM) => permissionManagerFilters = userPM.GetAnimalsReadFilters;

        public List<Animal> GetAnimalsList(List<Filter> userFilters, Sort sort)
        {
            var animalsList = new List<Animal>();
            var finalFilter = permissionManagerFilters.Concat(userFilters).ToList();

            var animalsData = AnimalsDBAdapter.GetAnimalsList(finalFilter, sort); 

            foreach(var entry in animalsData)
                animalsList.Add(new Animal(entry)); 

            return animalsList;
        }
    }
}
