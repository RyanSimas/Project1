using System;

namespace Login_Setup
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            Console.WriteLine("--------Welcome to Gamers Paradise!--------");
            Console.WriteLine("Enter 1 to Login or 2 to Sign up");
            option = Console.ReadLine();
            bool endApp = false;

            while(!endApp)
            {
                switch(option)
                {
                    case "1":
                        string username = "", password = "";
                        Login.UserLogin(username, password);
                        endApp = true;
                        break;
                    case "2":
                        string firstname = "", lastname = "", user = "", pass = "", birthdate = "", email = "";
                        Signup.UserSignup(firstname, lastname, user, pass, birthdate, email);
                        endApp = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        endApp = true;
                        break;
                }
            }
        }
    }
}
