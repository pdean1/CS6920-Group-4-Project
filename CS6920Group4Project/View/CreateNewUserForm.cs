using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS6920Group4Project.View
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
    //        InitializePasswordBox();
        }

        private void InitializePasswordBox()
        {
            throw new NotImplementedException();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String username = tbUserName.Text;
           // String password = tbPassword.Text;
           // if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please provide a username and password");
                tbPassword.Clear();
                return;
            }
                MessageBox.Show("Login not yet implemented");
        }

        private void llCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Create User not yet implemented");
            Form cuForm = new CreateUserForm1();
            cuForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            cuForm.Show();
        }


        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    }
}
