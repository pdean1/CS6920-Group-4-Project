using CS6920Group4Project.Controller;
using CS6920Group4Project.Model;
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
    public partial class BudgetPickerForm : Form
    {

        private List<Budget> _budgets;

        public BudgetPickerForm()
        {
            InitializeComponent();
            _budgets = // Populating a list of the signed in user's budgets
                BudgetController.Instance.GetUsersBudgets(Session.SessionInformation.GetSessionUser().ID);
            if (_budgets.Count != 0)
            {
                cbBudgets.DataSource = _budgets;
                cbBudgets.ValueMember = "ID";
                cbBudgets.DisplayMember = "Title";
            }
            else
            {
                cbBudgets.Items.Add("Add a budget first");
                cbBudgets.SelectedIndex = 0;
                cbBudgets.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
            this.CenterToScreen();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Session.SessionInformation.SetCurrentBudget(_budgets[cbBudgets.SelectedIndex]);
            if (!BudgetController.Instance.PopulateBudgetWithRecords(Session.SessionInformation.GetBudget()))
            {
                MessageBox.Show("Unable to populate budget with it's records.");
                return;
            }
            Form welcomeParentForm = new WelcomeParent();
            welcomeParentForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            welcomeParentForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete budget functionality not yet implemented");
        }

        private void btnCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Create budget functionality not yet implemented");
        }

        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
