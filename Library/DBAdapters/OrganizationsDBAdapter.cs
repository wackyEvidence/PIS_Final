using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.DBAdapters
{
    internal static class OrganizationsDBAdapter
    {
        //private static List<Organization> _organizations = new List<Organization>()
        //{
        //    new Organization("Государственный приют для животных \"Лучик\"", "1234567890", "0987654321", "г. Тюмень, ул. Пушечная, д. 15", OrganizationType.AnimalShelter, OrganizationalAttribute.LegalEntity, new Locality("Тюмень")),
        //    new Organization("Муниципальное предприятие \"Вместе за животных\"", "9876543210", "0123456789", "г. Санкт-Петербург, ул. Невский проспект, д. 25", OrganizationType.AnimalTrappingAndShelteringOrganization, OrganizationalAttribute.LegalEntity, new Locality("Санкт-Петербург")),
        //    new Organization("Фонд защиты животных \"Спасение\"", "5555555555", "1111111111", "г. Тюмень, ул. Ленина, д. 45", OrganizationType.CharitableFoundation, OrganizationalAttribute.LegalEntity, new Locality("Тюмень")),
        //    new Organization("Государственная ветеринарная клиника \"Здоровый питомец\"", "4444444444", "7777777777", "г. Санкт-Петербург, ул. Кирова, д. 10", OrganizationType.StateVetClinic, OrganizationalAttribute.LegalEntity, new Locality("Санкт-Петербург")),
        //    new Organization("Местное самоуправление муниципального района", "8901234567", "7654321098", "г. Тюмень, ул. Советская, д. 20", OrganizationType.Council, OrganizationalAttribute.LegalEntity, new Locality("Тюмень")),
        //    new Organization("Частная ветеринарная клиника \"Ключ к здоровью\"", "7777777777", "2222222222", "г. Санкт-Петербург, ул. Ленина, д. 70", OrganizationType.PrivateVetClinic, OrganizationalAttribute.LegalEntity, new Locality("Санкт-Петербург")),
        //    new Organization("Организация по транспортировке животных \"Зооэксперт\"", "1357911133", "6172636467", "г. Санкт-Петербург, ул. Гагарина, д. 25", OrganizationType.AnimalTransportationOrganization, OrganizationalAttribute.LegalEntity, new Locality("Санкт-Петербург"))
        //};

        public static readonly List<Dictionary<string, string>> organizations = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>
            {
                { "Id", "1" },
                { "FullName",  "Государственный приют для животных \"Лучик\"" },
                { "INN", "1234567890" },
                { "KPP", "0987654321" },
                { "RegistrationAddress", "г. Тюмень, ул. Пушечная, д. 15" },
                { "Type", "2"}, 
                { "Attribute", "1" },
                { "Location", "0" }
            }, 
            new Dictionary<string, string>
            {
                { "Id", "2" },
                { "FullName",  "Муниципальное предприятие \"Вместе за животных\"" },
                { "INN", "9876543210" },
                { "KPP", "0123456789" },
                { "RegistrationAddress", "г. Санкт-Петербург, ул. Невский проспект, д. 25" },
                { "Type", "4"}, 
                { "Attribute", "1" },
                { "Location", "1" }
            }, 
            new Dictionary<string, string>
            {
                { "Id", "3" },
                { "FullName",  "Фонд защиты животных \"Спасение\"" },
                { "INN", "5555555555" },
                { "KPP", "1111111111" },
                { "RegistrationAddress", "г. Тюмень, ул. Ленина, д. 45" },
                { "Type", "9"}, 
                { "Attribute", "1" },
                { "Location", "0" }
            },
            new Dictionary<string, string>
            {
                { "Id", "4" },
                { "FullName",  "Государственная ветеринарная клиника \"Здоровый питомец\"" },
                { "INN", "4444444444" },
                { "KPP", "7777777777" },
                { "RegistrationAddress", "г. Санкт-Петербург, ул. Кирова, д. 10" },
                { "Type", "6"},
                { "Attribute", "1" },
                { "Location", "1" }
            }, 
            new Dictionary<string, string>
            {
                { "Id", "5" },
                { "FullName",  "Местное самоуправление  муниципального района" },
                { "INN", "8901234567" },
                { "KPP", "7654321098" },
                { "RegistrationAddress", "г. Тюмень, ул. Советская, д. 20" },
                { "Type", "1"}, 
                { "Attribute", "1" },
                { "Location", "0" }
            }, 
            new Dictionary<string, string> 
            { 
                { "Id", "6" },
                { "FullName",  "Частная ветеринарная клиника \"Ключ к здоровью\"" },
                { "INN", "7777777777" },
                { "KPP", "2222222222" },
                { "RegistrationAddress", "г. Санкт-Петербург, ул. Ленина, д. 70" },
                { "Type", "8"}, 
                { "Attribute", "1" },
                { "Location", "1" }
            }, 
            new Dictionary<string, string>
            {
                { "Id", "7" },
                { "FullName",  "Организация по транспортировке животных \"Зооэксперт\"" },
                { "INN", "1357911133" },
                { "KPP", "6172636467" },
                { "RegistrationAddress", "г. Санкт-Петербург, ул. Гагарина, д. 25" },
                { "Type", "5"}, 
                { "Attribute", "1" },
                { "Location", "1" }
            }
        };

        public static List<Dictionary<string, string>> GetOrganizationsList(List<Filter> filters, Sort sort)
        {
            var filteredOrganizations = new List<Dictionary<string, string>>();

            foreach(var filter in filters)
            {
                if (filter.Value == "All")
                    continue;
                else if (filter.Value == "None")
                    return new List<Dictionary<string, string>>(); 
                else
                    filteredOrganizations = organizations.Where(organization => organization[filter.Field] == filter.Value).ToList();
            }

            if (sort.Type == SortOrder.Ascending)
                filteredOrganizations = filteredOrganizations.OrderBy(organization => organization[sort.Field]).ToList();
            else if(sort.Type == SortOrder.Descending)
                filteredOrganizations = filteredOrganizations.OrderByDescending(organization => organization[sort.Field]).ToList();

            return filteredOrganizations; 
        }

        public static Dictionary<string, string> GetById(int index) => organizations.Where(organization => organization["Id"] == index.ToString()).ToList()[0]; 
    }
}
