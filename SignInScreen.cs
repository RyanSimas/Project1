﻿using Login_Setup;
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

            Signup NewUser = new Signup(FNameTB.Text, LNameTB.Text, DOBTB.Text, UserNTB.Text, PasswordTB.Text, EmailTB.Text);
            NewUser.SendtoDatabase();

        } 
    }
}
