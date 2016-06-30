using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS6920Group4Project.Model;
using CS6920Group4Project.View;
using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.Controller;


namespace CS6920Group4Project.View
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '●';
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            this.Show();                                    // code added for guestLogin
            this.guestLogin();                              // code added for guestLogin
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String username = tbUserName.Text;
            String password = tbPassword.Text;
           
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please provide a valid username and password, Please Try Again",
                                "USER",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                tbPassword.Clear();
                return;
            }

            Boolean findUser = UserController.Instance.Login(username, password);
            if (findUser == true)
            {
                Form bpForm = new BudgetPickerForm();
                bpForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
                this.Hide();
                bpForm.Show();
            }  
            else
            {
                MessageBox.Show("Invalid User Information, Please Try Again!"
                               , "USER"
                               , MessageBoxButtons.OK
                               , MessageBoxIcon.Stop);  
            }
        }

        private void llCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Create User not yet implemented");
            Form cuForm = new CreateNewUserForm();
            cuForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            cuForm.Show();
        }


        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void guestLogin()                      // code added for guestLogin
        {
            DialogResult result = MessageBox.Show("Do you want to Login as a Guest to use the sandbox version of the BudgetBuddy application?"
                                                 , "LOGIN"
                                                 , MessageBoxButtons.YesNo
                                                 , MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tbUserName.Text = "guest";
                tbPassword.Text = "guest";
            }
            else if (result == DialogResult.No)
            {
                tbUserName.Text = "";
                tbPassword.Text = "";
            }
        }

    }
}
