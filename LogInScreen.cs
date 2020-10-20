using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GammersParadise
{
    public partial class LogInScreen : Form
    {
        public LogInScreen()
        {
            InitializeComponent();
        }

        private void LogInScreen_Load(object sender, EventArgs e)
        {

        }

       
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool isValid = false; string username; string password;
            string connstring = @"server = gammersparadise.ckcxvzkwbpvs.us-east-1.rds.amazonaws.com;userid=admin;password=WqG7E<v~;database =GammersParadise;";
            MySqlConnection conn = null;

            conn = new MySqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM USERINFO;";
             var cmd = new MySqlCommand(sql, conn);

             MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                username = rdr.GetString(1);
                password = rdr.GetString(2);
               if (username ==  UsernameTextBox.Text.ToString() && password == PaswordTextbox.Text.ToString() )
                {
                    MessageBox.Show("You have logged-in ", "Succsess");
                    isValid = true;
                }
            }
            if(isValid == false)
            {
                MessageBox.Show("Invalid username or password Please try agian!", "Invlaid Log in atempt");
            }
            

        }
        
        private void BackToMainScreen_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Hide();
            f1.Show();

        }
    }
}
