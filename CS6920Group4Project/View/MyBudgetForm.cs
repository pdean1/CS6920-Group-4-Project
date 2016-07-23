using System;
using System.Windows.Forms;
using CS6920Group4Project.Model;
using CS6920Group4Project.Controller;
using System.Collections.Generic;
using CS6920Group4Project.View;
using System.Text;
using System.IO;


namespace CS6920Group4Project.View
{
    public partial class MyBudgetForm : Form
    {
        Dashboard dbform;
        
        ManageExpenses exform;
        ManageEarnings earnForm;
        ManageBills billForm;
        
        BudgetView budView;

        private const int Dashboard = 0,
                          ManageEarning = 1,
                          ManageExpense = 2,
                          ManageBill = 3,
                          BudgetView = 4;

        public MyBudgetForm()
        {
            InitializeComponent();

            Session.SessionInformation.SetBudgetPickerArea(cbBudgets, btnSelect, btnDelete);

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
            Budget budget = new Budget();
            budget.UserID = userID;
            budget.Title = title;
            budget.Description = desc;
            budget.Notes = "";

            if (BudgetController.Instance.CreateBudget(budget) == true)
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
            Session.SessionInformation.RefreshBudgetPickerArea();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Session.SessionInformation.SetCurrentBudget(Session.SessionInformation.GetBudgets()[cbBudgets.SelectedIndex]);
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
            if (Session.SessionInformation.GetBudgets().Count == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Do you want to delete Budget " + Session.SessionInformation.GetBudgets()[cbBudgets.SelectedIndex].Title,
                "Delete Budget",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            int id = Session.SessionInformation.GetBudgets()[cbBudgets.SelectedIndex].ID;
            if (BudgetController.Instance.DeleteBudget(id))
            {
                MessageBox.Show("Budget Deleted!");
            }
            UpdateBudgets();
            Session.SessionInformation.RefreshSessionLabels();
            UpdateTab();
        }

        private void MainMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblIncomeRemainingPlaceholder_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           HelpMsgBox.Show("Welcome to Budget Buddy" + Environment.NewLine
               + Environment.NewLine
               + "1. To begin start by adding a new budget." + Environment.NewLine
               + "2. Use Manage earnings to add income." + Environment.NewLine
               + "3. Use manage expense to add expenses." + Environment.NewLine
               + "such as groceries, and pet care." + Environment.NewLine
               + "4. Use manage bills to enter revolving bills." + Environment.NewLine
               + "such as car payments, and credit cards." + Environment.NewLine
               + "5. Create multiple budgets." + Environment.NewLine
               + "6. See all your entries in view budget." + Environment.NewLine
               + Environment.NewLine
               + "More Information" + Environment.NewLine
               + Environment.NewLine
               + "With Budget Buddy application you will able" + Environment.NewLine
               + "to create a custom log in, manage multiple" + Environment.NewLine
               + "budgets at one time, or remove, edit and" + Environment.NewLine 
               + "delete earnings, expenses, and bills " + Environment.NewLine
               + "Use dashboard for helpful tips, " + Environment.NewLine
               + "to see how your spending your money " + Environment.NewLine
               + "to calculate upcoming expenses " + Environment.NewLine
               + "and to edit your budget information" + Environment.NewLine
               + Environment.NewLine
               + "Thank you for using Budget Buddy" + Environment.NewLine
               + "", "", "OK", "Cancel");
        }
    }
}
