using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class User
    {
        public User(string lastName, string firstName, string patronymic, UserRole role, string login, string password)
        {
            FirstName = firstName;
            LastName = lastName;   
            Patronymic = patronymic;
            Role = role; 
            Login = login;
            Password = password;
            // db = new List<Dictionary<string, string>>();
        }
        
        public string FullName { get { return LastName + " " + FirstName + " " + Patronymic; } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public UserRole Role { get; set; }
        public string Login {  get; private set; }
        public string Password { get; private set; }
    }
}
