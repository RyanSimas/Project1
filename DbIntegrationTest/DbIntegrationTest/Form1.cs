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



namespace DbIntegrationTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DBCall_Click(object sender, EventArgs e)
        {
           
            string connstring = @"server = gammersparadise.ckcxvzkwbpvs.us-east-1.rds.amazonaws.com;userid=admin;password=WqG7E<v~;database =GammersParadise;";
            MySqlConnection conn = null;

            conn = new MySqlConnection(connstring);
            conn.Open();

            var sql = "INSERT INTO USERINFO(username, password,email,firstname,lastname,birthdate) VALUES(@username, @password,@email,@firstname,@lastname,@birthdate)";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@username", "RyanS12");
            cmd.Parameters.AddWithValue("@password", "IamSooCool");
            cmd.Parameters.AddWithValue("@email", "Ryan.Simas@snhu.edu");
            cmd.Parameters.AddWithValue("@firstname", "Ryan");
            cmd.Parameters.AddWithValue("@lastname", "Simas");
            cmd.Parameters.AddWithValue("@birthdate", "08/25/2001");
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            /*cmd.CommandText = "INSERT INTO USERINFO(username, password,email,firstname,lastname,birthdate) VALUES('NG','1234', 'Test@test.conm', 'Nicholas', 'Gaston', '01/21/2001')";
            cmd.ExecuteNonQuery();*/

            MessageBox.Show("Finished", "finished");



            /* string query = "SELECT * FROM USERINFO;";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string text = reader.GetString("ID");

            MessageBox.Show(text, "DAMMM");*/

            /* while (reader.Read())
            {
                data2txt.Text += $"{reader.GetString("ID")};";
                datatxt.Text += $"{reader.GetString("username")};";
            }*/
        }
    }
    

}
