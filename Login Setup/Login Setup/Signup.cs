using System;
using System.Collections.Generic;
using System.Text;

namespace Login_Setup
{
    class Signup
    {
        public static string UserSignup(string fname, string lname, string username, string password, string birthdate, string email)
        {
            Console.WriteLine("Enter your First Name: ");
            fname = Console.ReadLine();
            Console.WriteLine("Enter your Last Name: ");
            lname = Console.ReadLine();
            Console.WriteLine("Enter your Username: ");
            username = Console.ReadLine();
            bool passLength = true;
            while (passLength)
            {
                Console.WriteLine("Enter your password (must be longer than 13 characters): ");
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
            Console.WriteLine("Enter your Birth date: ");
            birthdate = Console.ReadLine();
            Console.WriteLine("Enter your Email: ");
            email = Console.ReadLine();

            string success;
            Console.WriteLine("Sign Up Successful");
            success = Console.ReadLine();
            return success;
        }
    }
}
