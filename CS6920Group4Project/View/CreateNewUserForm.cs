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
            txtPasswordTwo.PasswordChar = '●';
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
            String passwordTwo = txtPasswordTwo.Text;

            if (String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName) ||
                String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) ||
                String.IsNullOrEmpty(passwordTwo))
            {
                MessageBox.Show("Please fill in each field, Please Try Again",
                                "USER",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                this.clearData();
                return;
            }

            if (!password.Equals(passwordTwo))
            {
                MessageBox.Show("Passwords do not match, please try again.",
                                "USER",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                this.clearData();
                return;
            }

            User newUser = new User();
            newUser.FirstName = firstName;
            newUser.LastName = lastName;
            newUser.UserName = username;
            newUser.Password = password;

            long newUserAdded = UserController.Instance.InsertUser(newUser);

            if (newUserAdded > 0)
            {
                MessageBox.Show("New user successfully added!",
                             "USER",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.None);
                this.Close();
            }
            else
            {
                MessageBox.Show("Unable to add new user, please try again",
                            "USER",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                this.clearData();
            }
        }

        private void clearData()
        {
            txtPassword.Text = "";
            txtPasswordTwo.Text = "";
        }

    }
}
