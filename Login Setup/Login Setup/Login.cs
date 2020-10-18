using System;
using System.Collections.Generic;
using System.Text;

namespace Login_Setup
{
    class Login
    {
        public static string UserLogin(string username, string password)
        {
            Console.WriteLine("Enter your username: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter your Password: ");
            password = Console.ReadLine();

            string success;
            Console.WriteLine("Login Successful");
            success = Console.ReadLine();
            return success;
        }
    }
}
