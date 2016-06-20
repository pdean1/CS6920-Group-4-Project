using CS6920Group4Project.model;
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
    public partial class CreateUserForm1 : Form
    {

        private User user = new User();

        public CreateUserForm1()
        {
            InitializeComponent();
            InitializePasswordTextFields();
        }

        private void InitializePasswordTextFields()
        {
            tbPasswordOne.PasswordChar = '*';
            tbPasswordTwo.PasswordChar = '*';
        }

        private Boolean PasswordsMatch(String passwordOne, String passwordTwo)
        {
            return String.Compare(passwordOne, passwordTwo) == 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbEmail.Clear();
            tbPasswordOne.Clear();
            tbPasswordTwo.Clear();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet Implemented");
        }
    }
}
