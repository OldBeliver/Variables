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

            Console.WriteLine($"login: {login}\npassword: {password}");

            string template = login;
            login = password;
            password = template;

            Console.WriteLine($"/nДанные после инверсии");
            Console.WriteLine($"login: {login}\npassword: {password}");
        }
    }
}
