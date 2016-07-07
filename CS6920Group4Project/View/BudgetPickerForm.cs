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
        private Boolean thereIsExistingBudgets;
        public BudgetPickerForm()
        {
            InitializeComponent();
            UpdateBudgets();
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
            Form myBForm = new MyBudgetForm();
            myBForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            myBForm.Show();
        }

        private void UpdateBudgets()
        {
            _budgets = // Populating a list of the signed in user's budgets
                BudgetController.Instance.GetUsersBudgets(Session.SessionInformation.GetSessionUser().ID);
            if (_budgets.Count != 0)
            {
                cbBudgets.DataSource = _budgets;
                cbBudgets.ValueMember = "ID";
                cbBudgets.DisplayMember = "Title";
                cbBudgets.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                thereIsExistingBudgets = true;
            }
            else
            {
                cbBudgets.DataSource = null;
                cbBudgets.Items.Add("Add a budget first");
                cbBudgets.SelectedIndex = 0;
                cbBudgets.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                thereIsExistingBudgets = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!thereIsExistingBudgets)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Do you want to delete Budget " + _budgets[cbBudgets.SelectedIndex].Title,
                "Delete Budget",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            int id = _budgets[cbBudgets.SelectedIndex].ID;
            if (BudgetController.Instance.DeleteBudget(id))
            {
                MessageBox.Show("Budget Deleted!");
            }
            UpdateBudgets();
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
