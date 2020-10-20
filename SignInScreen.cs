using Login_Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GammersParadise
{
    public partial class SignInScreen : Form
    {
        public SignInScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void SignInSubmitButton_Click(object sender, EventArgs e)
        {
          
            Signup NewUser = new Signup(FNameTB.Text, LNameTB.Text, dobPicker.Value.ToString(), UserNTB.Text, PasswordTB.Text, EmailTB.Text);
            ErrorMessage.Text = NewUser.checkInput(UserNTB.Text.ToString(), PasswordTB.Text.ToString(),dobPicker.Value.ToString("yyyy-MM-dd"), EmailTB.Text.ToString());
            if(ErrorMessage.Text.ToString() == "")
            {
                NewUser.SendtoDatabase();
                MessageBox.Show("Thank you for Signing Up!");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BackToMainScreen_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            Hide();
            f2.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
