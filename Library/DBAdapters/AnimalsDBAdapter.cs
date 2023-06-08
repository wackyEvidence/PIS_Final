using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.DBAdapters
{
    internal static class AnimalsDBAdapter
    {
        public static readonly List<Dictionary<string, string>> animals = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>()
            {
                { "Id", "1" },
                { "RegCardNumber", "1234" },
                { "Location", "Тюмень" },
                { "Category", "1" }, 


            }
        }; 

        public static List<Dictionary<string, string>> GetAnimalsList(List<Filter> filters, Sort sort)
        {
            var filteredAnimals = new List<Dictionary<string, string>>();

            foreach (var filter in filters)
            {
                if (filter.Value == "All")
                    continue;
                else if (filter.Value == "None")
                    return new List<Dictionary<string, string>>();
                else
                    filteredAnimals = animals.Where(organization => organization[filter.Field] == filter.Value).ToList();
            }

            if (sort.Type == SortOrder.Ascending)
                filteredAnimals = filteredAnimals.OrderBy(organization => organization[sort.Field]).ToList();
            else if (sort.Type == SortOrder.Descending)
                filteredAnimals = filteredAnimals.OrderByDescending(organization => organization[sort.Field]).ToList();

            return filteredAnimals;
        }
    }
}
