using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.DBAdapters
{
    public static class AnimalsDBAdapter
    {
        private static int lastId; 

        private static List<Dictionary<string, string>> animals = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>()
            {
                { "Id", "1" },
                { "RegCardNumber", "1234" },
                { "Location", "Тюмень" },
                { "Category", "Кот" },
                //{ "Location", "0" },
                //{ "Category", "1" },
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
                { "Location", "Санкт-Петербург" },
                { "Category", "Собака" },
                //{ "Location", "1" },
                //{ "Category", "0" },
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
                { "Location", "Тюмень" },
                { "Category", "Собака" },
                //{ "Location", "0" },
                //{ "Category", "0" },
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
                { "Location", "Санкт-Петербург" },
                { "Category", "Кошка" },
                //{ "Location", "1" },
                //{ "Category", "1" },
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

            if (sort.Order == SortOrder.Ascending)
                filteredAnimals = filteredAnimals.OrderBy(animal => animal[sort.Field]).ToList();
            else if (sort.Order == SortOrder.Descending)
                filteredAnimals = filteredAnimals.OrderByDescending(animal => animal[sort.Field]).ToList();

            // Если нет фильтров, кроме разрешающих все, список отфильтрованных организаций останется пустым
            // в этом случае нужно вернуть все содержащиеся в адаптере записи 
            if (filteredAnimals.Count == 0)
                return animals;
            
            return filteredAnimals;
        }


        public static int GetLastId => lastId;
        public static void Add(Dictionary<string, string> animalInfo) => animals.Add(animalInfo); 
        public static void RemoveAt(int index) => animals.RemoveAt(index); 
    }
}
