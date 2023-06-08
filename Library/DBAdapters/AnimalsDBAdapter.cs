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
                { "Location", "0" },
                { "Category", "1" },
                { "Sex", "Мужской" },
                { "BirthYear", "2015" }, 
                { "ChipNumber", "567890123" },
                { "Nickname", "Мурзик" },
                { "Photo", @"D:\Учеба\ПИС\app\murzik.jpg" },
                { "DistinguishingMarks", "Полностью белый" }, 
                { "OwnerSigns", "0" },
                { "MedicalExaminations", "1" }
            },
            new Dictionary<string, string>()
            {
                { "Id", "2" },
                { "RegCardNumber", "5678" },
                { "Location", "1" },
                { "Category", "0" },
                { "Sex", "Женский" },
                { "BirthYear", "2018" },
                { "ChipNumber", "34567890" },
                { "Nickname", "Рэм" },
                { "Photo", @"D:\Учеба\ПИС\app\ram.jpg" },
                { "DistinguishingMarks", "Черная с белыми пятнами" },
                { "OwnerSigns", "3" },
                { "MedicalExaminations", "2" }
            },
            new Dictionary<string, string>()
            {
                { "Id", "3" },
                { "RegCardNumber", "9012" },
                { "Location", "0" },
                { "Category", "0" },
                { "Sex", "Мужской" },
                { "BirthYear", "2019" },
                { "ChipNumber", "123456789" },
                { "Nickname", "Рэкс" },
                { "Photo", @"D:\Учеба\ПИС\app\rex.jpg" },
                { "DistinguishingMarks", "Черный, немецкая овчарка, ухоженная шерсть" },
                { "OwnerSigns", "0 1 2" },
                { "MedicalExaminations", "3" }
            },
            new Dictionary<string, string>()
            {
                { "Id", "4" },
                { "RegCardNumber", "2345" },
                { "Location", "1" },
                { "Category", "1" },
                { "Sex", "Женский" },
                { "BirthYear", "2017" },
                { "ChipNumber", "678901234" },
                { "Nickname", "Буся" },
                { "Photo", @"D:\Учеба\ПИС\app\ram.jpg" },
                { "DistinguishingMarks", "Трехцветная" },
                { "OwnerSigns", "4" },
                { "MedicalExaminations", "4" }
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
                    filteredAnimals = animals.Where(animal => animal[filter.Field] == filter.Value).ToList();
            }

            if (sort.Type == SortOrder.Ascending)
                filteredAnimals = filteredAnimals.OrderBy(animal => animal[sort.Field]).ToList();
            else if (sort.Type == SortOrder.Descending)
                filteredAnimals = filteredAnimals.OrderByDescending(animal => animal[sort.Field]).ToList();

            return filteredAnimals;
        }
    }
}
