using Library.DBAdapters;
using Library.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Authorizer
    {
        public static User CurrentUser; 
        public static bool AuthorizeUser(string login, string password)
        {
            var userData = UsersDBAdapter.GetUserData(login);

            if(userData["Password"] == password)
            {
                CurrentUser = new User(userData);
                CurrentUser.PermissionManager = PermissionManagerFactory.GetPermissionManager(CurrentUser); 
                return true; 
            }
            else
                throw new Exception("Неправильный логин или пароль"); 
        }
    }
}
