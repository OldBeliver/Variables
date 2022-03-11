using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "qwerty";
            string password = "login";
            
            ShowInfo(login, password);
            InverseData(ref login, ref password);
            ShowInfo(login, password);
        }

        static void ShowInfo(string login, string password)
        {
            Console.WriteLine($"login: {login}\npassword: {password}");
        }

        static void InverseData(ref string login, ref string password)
        {
            string template = login;
            login = password;
            password = template;
        }
    }
}
