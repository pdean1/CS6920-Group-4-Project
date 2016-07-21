using System;
using System.Windows.Forms;
using CS6920Group4Project.Model;
using CS6920Group4Project.Controller;
using System.Collections.Generic;


namespace CS6920Group4Project.View
{
    public partial class MyBudgetForm : Form
    {
        Dashboard dbform;
        
        ManageExpenses exform;
        ManageEarnings earnForm;
        ManageBills billForm;
        
        BudgetView budView;

        private List<Budget> _budgets;

        private Boolean thereIsExistingBudgets;

        private const int Dashboard = 0,
                          ManageEarning = 1,
                          ManageExpense = 2,
                          ManageBill = 3,
                          BudgetView = 4;

        public MyBudgetForm()
        {
            InitializeComponent();

            UpdateBudgets();

            this.tabDashBoad();
            this.tabManageExpenses();
            this.tabManageEarnings();
            this.tabManageBills();
            this.tabBudgetView();

            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
        }

        void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTab();
        }

        private void UpdateTab()
        {
            //throw new NotImplementedException();
            switch (tabControl1.SelectedIndex)
            {
                case Dashboard:
                    tabControl1.TabPages[Dashboard].Controls.Remove(dbform);
                    tabDashBoad();
                    break;
                case ManageEarning:
                    tabControl1.TabPages[ManageEarning].Controls.Remove(earnForm);
                    tabManageEarnings();
                    break;
                case ManageExpense:
                    tabControl1.TabPages[ManageExpense].Controls.Remove(exform);
                    tabManageExpenses();
                    break;
                case ManageBill:
                    tabControl1.TabPages[ManageBill].Controls.Remove(billForm);
                    tabManageBills();
                    break;
                case BudgetView:
                    tabControl1.TabPages[BudgetView].Controls.Remove(budView);
                    tabBudgetView();
                    break;
                default:
                    throw new NotImplementedException("Tab at index: " + tabControl1.SelectedIndex.ToString() + ", not created.");

            }
            return;
        }

        private void tabDashBoad()
        {
            dbform = new Dashboard();
            dbform.TopLevel = false;
            dbform.Visible = true;
            dbform.FormBorderStyle = FormBorderStyle.None;
            dbform.Dock = DockStyle.Fill;
            tabControl1.TabPages[Dashboard].Controls.Add(dbform);
            
        }

        private void tabManageExpenses()
        {
            exform = new ManageExpenses(); 
            exform.TopLevel = false;
            exform.Visible = true;
            exform.FormBorderStyle = FormBorderStyle.None;
            exform.Dock = DockStyle.Fill;
            tabControl1.TabPages[ManageExpense].Controls.Add(exform);
        }

        private void MyBudgetForm_Load(object sender, EventArgs e)
        {
            Session.SessionInformation.SetUserNameSessionLabel(lblUserNamePlaceholder);
            Session.SessionInformation.SetIncomeRemainingSessionLabel(lblIncomeRemainingPlaceholder);
            Session.SessionInformation.RefreshSessionLabels();
        }

        private void tabManageEarnings()
        {
             earnForm = new ManageEarnings();
             this.earnForm.TopLevel = false;
             this.earnForm.Visible = true;
             this.earnForm.FormBorderStyle = FormBorderStyle.None;
             this.earnForm.Dock = DockStyle.Fill;
             tabControl1.TabPages[ManageEarning].Controls.Add(earnForm);
        }

        private void tabManageBills()
        {
             billForm = new ManageBills();
             this.billForm.TopLevel = false;
             this.billForm.Visible = true;
             this.billForm.FormBorderStyle = FormBorderStyle.None;
             this.billForm.Dock = DockStyle.Fill;
             tabControl1.TabPages[ManageBill].Controls.Add(billForm);
        }

        private void tabBudgetView()
        {
             budView = new BudgetView();
             this.budView.TopLevel = false;
             this.budView.Visible = true;
             this.budView.FormBorderStyle = FormBorderStyle.None;
             this.budView.Dock = DockStyle.Fill;
             tabControl1.TabPages[BudgetView].Controls.Add(budView);
        }

        /// <summary>
        /// Allows the user to save the current budget as a csv to their desired destination
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            sfd.Filter = "CSV (Comma Delimited *.csv)|*.csv";
            sfd.Title = "Save Budget " + Session.SessionInformation.GetBudget().Title + " to CSV";
            sfd.FileName = Session.SessionInformation.GetBudget().Title;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BudgetCSV csv = new BudgetCSV();
                if (!csv.ExportCSVToFile(sfd.FileName))
                {
                    MessageBox.Show("Unable to export to CSV! Please try again.");
                }
            }
        }

        private void btnAddBudget_Click(object sender, EventArgs e)
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
            if (BudgetController.Instance.CreateBudget(userID, title, desc) == true)
            {
                MessageBox.Show("Budget Successfully Created");
                txtTitle.Clear();
                txtDesc.Clear();
                UpdateBudgets();
            }
            else
            {
                MessageBox.Show("Budget was not Created, please try again!");
            }
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
                btnSelect.Enabled = true;
                thereIsExistingBudgets = true;
                Session.SessionInformation.SetCurrentBudget(_budgets[cbBudgets.SelectedIndex]);
                if (!BudgetController.Instance.PopulateBudgetWithRecords(Session.SessionInformation.GetBudget()))
                {
                    MessageBox.Show("Unable to populate budget with it's records.");
                    return;
                }
            }
            else
            {
                cbBudgets.DataSource = null;
                cbBudgets.Items.Add("Add a budget first");
                cbBudgets.SelectedIndex = 0;
                cbBudgets.Enabled = false;
                btnDelete.Enabled = false;
                btnSelect.Enabled = false;
                thereIsExistingBudgets = false;
                Budget budget = new Budget();
                budget.Bills = new List<Bill>();
                budget.Expenses = new List<Expense>();
                budget.Earnings = new List<Earning>();
                Session.SessionInformation.SetCurrentBudget(budget);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Session.SessionInformation.SetCurrentBudget(_budgets[cbBudgets.SelectedIndex]);
            if (!BudgetController.Instance.PopulateBudgetWithRecords(Session.SessionInformation.GetBudget()))
            {
                MessageBox.Show("Unable to populate budget with it's records.");
                return;
            }
            Session.SessionInformation.RefreshSessionLabels();
            UpdateTab();
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
            UpdateTab();
        }

    }
}
