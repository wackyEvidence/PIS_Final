using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.DBAdapters
{
    internal class UsersDBAdapter
    {
        private static readonly List<Dictionary<string, string>> usersList = new()
        {
            new Dictionary<string, string>() {
                { "Id", "1" }, 
                { "LastName", "Иванова" },
                { "FirstName", "Анна" },
                { "Patronymic", "Петровна" },
                { "Role", "0" },
                { "Login", "AnnaIvanova" },
                { "Password", "123456" },
                { "Workplace", "1" }
            }, 
            new Dictionary<string, string>()
            {
                { "Id", "2" },
                { "LastName", "Петров" },
                { "FirstName", "Игорь" },
                { "Patronymic", "Владимирович" },
                { "Role", "12" },
                { "Login", "IgorPetrov" },
                { "Password", "qwerty" },
                { "Workplace", "2" }
            }, 
            new Dictionary<string, string> 
            { 
                { "Id", "3" },
                { "LastName", "Смирнов" },
                { "FirstName", "Алексей" },
                { "Patronymic", "Иванович" },
                { "Role", "4" },
                { "Login", "AlexSmirnov" },
                { "Password", "pass123" },
                { "Workplace", "7" }
            }, 
            new Dictionary<string, string> 
            { 
                { "Id", "4" },
                { "LastName", "Кузнецова" },
                { "FirstName", "Юлия" },
                { "Patronymic", "Сергеевна" },
                { "Role", "11" },
                { "Login", "JuliaKuznetsova" },
                { "Password", "helloworld" },
                { "Workplace", "2" }
            }, 
            new Dictionary<string, string> 
            { 
                { "Id", "5" },
                { "LastName", "Морозов" },
                { "FirstName", "Сергей" },
                { "Patronymic", "Андреевич" },
                { "Role", "5" },
                { "Login", "SergeyMorozov" },
                { "Password", "987654" },
                { "Workplace", "3" }
            },
            new Dictionary<string, string>
            {
                { "Id", "6" },
                { "LastName", "Федорова" },
                { "FirstName", "Екатерина" },
                { "Patronymic", "Александровна" },
                { "Role", "8" },
                { "Login", "KateFedorova" },
                { "Password", "abc123" },
                { "Workplace", "5" }
            },
            new Dictionary<string, string>
            {
                { "Id", "7" },
                { "LastName", "Николаев" },
                { "FirstName", "Дмитрий" },
                { "Patronymic", "Игоревич" },
                { "Role", "2" },
                { "Login", "DmitryNikolaev" },
                { "Password", "password" },
                { "Workplace", "6" }
            },
            new Dictionary<string, string>
            {
                { "Id", "8" },
                { "LastName", "Соколова" },
                { "FirstName", "Анна" },
                { "Patronymic", "Сергеевна" },
                { "Role", "6" },
                { "Login", "AnnaSokolova" },
                { "Password", "qwerty123" },
                { "Workplace", "4" }
            },
            new Dictionary<string, string>
            {
                { "Id", "9" },
                { "LastName", "Грищенко" },
                { "FirstName", "Елена" },
                { "Patronymic", "Александровна" },
                { "Role", "10" },
                { "Login", "ElenaGrishchenko" },
                { "Password", "secret124" },
                { "Workplace", "5" }
            },
            new Dictionary<string, string>
            {
                { "Id", "10" },
                { "LastName", "Жукова" },
                { "FirstName", "Наталья" },
                { "Patronymic", "Владимировна" },
                { "Role", "3" },
                { "Login", "NatalyaZhukova" },
                { "Password", "1q2w3e4r5t" },
                { "Workplace", "2" }
            }
        }; 

        public static Dictionary<string, string> GetUserData(string login)
        {
            foreach(var user in usersList)
            {
                if (user["Login"] == login)
                    return user; 
            }
            throw new Exception("User not found!"); 
        }
    }
}
