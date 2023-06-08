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
        public User(Dictionary<string, string> user)
        {
            Id = int.Parse(user["Id"]); 
            FirstName = user["FirstName"];
            LastName = user["LastName"];
            Patronymic = user["Patronymic"];
            Role = (UserRole)int.Parse(user["Role"]);
            Login = user["Login"];
            Password = user["Password"]; 
            Workplace = new Organization(OrganizationsDBAdapter.GetById(int.Parse(user["Workplace"])));
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
