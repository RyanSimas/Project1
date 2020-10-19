using System;
using System.Collections.Generic;
using System.Text;

namespace Login_Setup
{
    class Login
    {
        public static string UserLogin(string username, string password)
        {
            bool validLength = false;
            while (validLength == false)
            {
                Console.WriteLine("Enter your Username: ");
                username = Console.ReadLine();
                if (username.Length < 1)
                {
                    Console.WriteLine("Invalid name! Please enter your username.");
                    validLength = false;
                }
                else
                {
                    validLength = true;
                }
            }

            bool passLength = true;
            while (passLength)
            {
                Console.WriteLine("Enter your password: ");
                password = Console.ReadLine();
                if (password.Length < 13)
                {
                    Console.WriteLine("The password you have entered is too short. Please enter a password with 13 or more characters.");
                    passLength = true;
                }
                else
                {
                    passLength = false;
                }
            }

            string success;
            Console.WriteLine("Login Successful");
            success = Console.ReadLine();
            return success;
        }
    }
}
