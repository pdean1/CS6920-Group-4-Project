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
    public partial class CreateNewUserForm : Form
    {
        public CreateNewUserForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '●';
        }

        private void CreateNewUserForm_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String firstName = txtFirstName.Text;
            String lastName = txtLastName.Text;
            String username = txtUserName.Text;
            String password = txtPassword.Text;

            if (String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName) ||
                String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in each field, Please Try Again",
                                "USER",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                this.clearData();
                return;
            }

            else
            {
                User newUser = new User();
                newUser.FirstName = firstName;
                newUser.LastName = lastName;
                newUser.UserName = username;
                newUser.Password = password;

                long newUserAdded = UserController.Instance.InsertUser(newUser);
                if (newUserAdded > 0)
                {
                    MessageBox.Show("New User Successfully added!",
                                 "USER",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.None);

                    Form wsForm = new WelcomeScreen();
                    wsForm.FormClosed += new FormClosedEventHandler(wsForm_FormClosed);
                    this.Close();
                    wsForm.Show();
                }
                else
                {
                    MessageBox.Show("Unable to add new user, Please Try Again",
                                "USER",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                    this.clearData();
                }
            }
        }

        void wsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void clearData()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

    }
}
