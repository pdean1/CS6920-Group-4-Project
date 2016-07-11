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
    public partial class CreateBudgetForm : Form
    {
        public CreateBudgetForm()
        {
            InitializeComponent();
        }

        private void CreateBudgetForm_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String title = txtTitle.Text;
            String desc = txtDesc.Text;

            if (String.IsNullOrEmpty(title) || String.IsNullOrEmpty(desc))
            {
                MessageBox.Show("All fields are required, Please Try Again",
                                "USER",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                return;
            }

            int userID = Session.SessionInformation.GetSessionUser().ID;
            bool isCreated = BudgetController.Instance.CreateBudget(userID, title, desc);
            if (isCreated == true)
            {
                MessageBox.Show("Budget Successfully Created");
                this.Close();
            }
            else
            {
                MessageBox.Show("Budget was not Created, please try again!");
            }

        }

    }
}
