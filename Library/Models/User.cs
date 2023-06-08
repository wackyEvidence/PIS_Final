using Library.DBAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class User
    {
        public User(string lastName, string firstName, string patronymic, int roleId, string login, string password, int organizationId)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Role = (UserRole) roleId;
            Login = login;
            Password = password;
            Workplace = OrganizationsDBAdapter.GetById(organizationId);
            // db = new List<Dictionary<string, string>>();
        }

        public int Id { get; set; }
        public string FullName { get { return LastName + " " + FirstName + " " + Patronymic; } }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Patronymic { get; private set; }
        public UserRole Role { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Organization Workplace { get; private set; }
        public PermissionManager PermissionManager { get; set; }
    }
}
