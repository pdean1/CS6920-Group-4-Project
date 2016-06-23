using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS6920Group4Project.model;
using CS6920Group4Project.View;
using CS6920Group4Project.DAL.Model;

namespace CS6920Group4Project.View
{
    public partial class ManageEarnings : Form
    {
        private User user;

        public ManageEarnings(User userName)
        {
            InitializeComponent();
            user = userName;
            userNameEarningsLbl.Text = user.FirstName + "" + user.LastName;
        }

        public ManageEarnings()
        {
            // TODO: Complete member initialization
        }

        private void ManageEarnings_Load(object sender, EventArgs e)
        {

        }

        private void earningsDashBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void manageEarningsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageEarnings earn = new ManageEarnings();
            earn.Show();

        }

        private void manageExpensesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageExpenses expense = new ManageExpenses();
            expense.Show();
        }

        private void manageBillsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
