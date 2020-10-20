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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        LogInScreen LGS = new LogInScreen();
        private void Login_Click(object sender, EventArgs e)
        {

            LGS.Show();
            Hide();
        }
       
        SignInScreen SIS = new SignInScreen();
        private void SignInButton_Click(object sender, EventArgs e)
        {
            SIS.Show();
            this.Hide();

        }
    }
}
