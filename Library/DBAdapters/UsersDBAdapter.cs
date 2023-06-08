using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.DBAdapters
{
    internal class UsersDBAdapter
    {
        public static List<User> GetAnimalsList(Filter filter, Sort sort)
        {
            return new List<User>()
            {
                new User("Иванова", "Анна", "Петровна", UserRole.VetServiceCurator, "AnnaIvanova", "123456", null)

            };
        }
    }
}
