using MySql.Data.MySqlClient;

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

        public Signup(string Inputfname,string Inputlaname, string InputBirthdate, string InputUsername, string InputPassword, string InputEmail )
        {
            fname = Inputfname;
            lname = Inputlaname;
            username = InputUsername;
            password = InputPassword;
            birthdate = InputBirthdate;
            email = InputEmail;
        
        }

       
       public string getFName()
        {
            return fname;
        }
       public void setFName(string newFName)
        {
            fname = newFName;
        }
        public string getLName()
        {
            return lname;
        }
        public void setlName(string newLName)
        {
            fname = newLName;
        }
        public string getUserName()
        {
            return username;
        }
        public void setUsername(string newUser)
        {
            username = newUser;
        }
        public string getPassword()
        {
            return password;
        }
        public void setPassword(string newPass)
        {
            password = newPass;
        }
       public string getBirthdate()
        {
            return birthdate;
        }
        public void setBirthdate(string newDOB)
        {
            birthdate = newDOB;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string newEmail)
        {
            email = newEmail;
        }

        public void SendtoDatabase()
        {
            string connstring = @"server = gammersparadise.ckcxvzkwbpvs.us-east-1.rds.amazonaws.com;userid=admin;password=WqG7E<v~;database =GammersParadise;";
            MySqlConnection conn = null;

            conn = new MySqlConnection(connstring);
            conn.Open();

            var sql = "INSERT INTO USERINFO(username, password,email,firstname,lastname,birthdate) VALUES(@username, @password,@email,@firstname,@lastname,@birthdate)";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@firstname",fname);
            cmd.Parameters.AddWithValue("@lastname", lname);
            cmd.Parameters.AddWithValue("@birthdate", birthdate);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }

        public bool CheckPassword(string UserPassword)
        {
            if(UserPassword.Length < 8 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

            


    }

    /*public static string UserSignup(string fname, string lname, string username, string password, string birthdate, string email)
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
       }*/

}
