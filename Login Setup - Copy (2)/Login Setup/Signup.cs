using System;
using System.Collections.Generic;
using System.Text;

namespace Login_Setup
{
    class Signup
    {
        private string fname;
        private string lname;
        private string username;
        private string password;
        private string birthdate;
        private string email;

        public static string UserSignup(string fname, string lname, string username, string password, string birthdate, string email)
        {
            bool validLength;

            Console.WriteLine("Enter your First Name: ");
            fname = Console.ReadLine();
            //CheckFirstNameValid(fname);

            validLength = false;
            while (validLength == false)
            {
                Console.WriteLine("Enter your Last Name: ");
                lname = Console.ReadLine();
                if (lname.Length < 1)
                {
                    Console.WriteLine("Invalid name! Please enter your last name.");
                    validLength = false;
                }
                else
                {
                    validLength = true;
                }
            }
            validLength = false;
            while (validLength == false)
            {
                Console.WriteLine("Enter your Username: ");
                username = Console.ReadLine();
                if (username.Length < 1)
                {
                    Console.WriteLine("Invalid username! Please enter your username.");
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
            validLength = false;
            while (validLength == false)
            {
                Console.WriteLine("Enter your Birthdate in terms of MM/DD/YYYY: ");
                birthdate = Console.ReadLine();
                if (birthdate.Length != 10)
                {
                    Console.WriteLine("Invalid birthdate! Please reenter your birthdate.");
                    validLength = false;
                }
                else
                {
                    validLength = true;
                }
            }
            validLength = false;
            while (validLength == false)
            {
                Console.WriteLine("Enter your Email: ");
                email = Console.ReadLine();
                if (email.Length < 10)
                {
                    Console.WriteLine("Invalid name! Please enter your email again.");
                    validLength = false;
                }
                else
                {
                    validLength = true;
                }
            }
            string success;
            Console.WriteLine("Sign Up Successful");
            success = Console.ReadLine();
            return success;
        }

        private string getFName()
        {
            return fname;
        }
        private void setFName(string newFName)
        {
            fname = newFName;
        }
        private string getLName()
        {
            return lname;
        }
        private void setlName(string newLName)
        {
            fname = newLName;
        }
        private string getUserName()
        {
            return username;
        }
        private void setUsername(string newUser)
        {
            username = newUser;
        }
        private string getPassword()
        {
            return password;
        }
        private void setPassword(string newPass)
        {
            password = newPass;
        }
        private string getBirthdate()
        {
            return birthdate;
        }
        private void setBirthdate(string newDOB)
        {
            birthdate = newDOB;
        }
        private string getEmail()
        {
            return email;
        }
        private void setEmail(string newEmail)
        {
            email = newEmail;
        }
    }
}
