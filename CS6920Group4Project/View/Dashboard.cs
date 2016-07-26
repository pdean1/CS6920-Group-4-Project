using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CS6920Group4Project.Model;
using CS6920Group4Project.Utilities;
using CS6920Group4Project.Controller;


namespace CS6920Group4Project.View
{
    public partial class Dashboard : Form
    {
        private decimal BillsAmount = 0, ExpensesAmount = 0, EarningsAmount = 0;

        public Dashboard()
        {
            InitializeComponent();
            budgetTitleBox.Text = Session.SessionInformation.GetBudget().Title;
            budgetDescBox.Text = Session.SessionInformation.GetBudget().Description;
            NotesRtb.Text = Session.SessionInformation.GetBudget().Notes;
            UpdateDashboard();
            
        }
        
        private void dashEarnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageEarnings earn = new ManageEarnings();
            earn.Show();
        }

        private void dashExpBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageExpenses expense = new ManageExpenses();
            expense.Show();
        }

        private void dashBillBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageBills bills = new ManageBills();
            bills.Show();
        }

        private void DashBudbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            BudgetView view = new BudgetView();
            view.Show();
        }

        private void UpdateDashboard()
        {
            UpdatePieChartArea();
            UpdateBillsDueDataGrid();
        }

        private void UpdatePieChartArea()
        {
            string[] xValues = { "Earnings", "Expenses", "Bills" };
            BillsAmount = Session.SessionInformation.GetBudget().GetTotalAmountOfBills();
            EarningsAmount = Session.SessionInformation.GetBudget().GetTotalAmountOfEarnings();
            ExpensesAmount = Session.SessionInformation.GetBudget().GetTotalAmountOfExpenses();

            lblBillAmount.Text = StringUtilities.GetDisplayableDollarAmount(BillsAmount);
            lblExpenseAmount.Text = StringUtilities.GetDisplayableDollarAmount(ExpensesAmount);
            lblIncomeAmount.Text = StringUtilities.GetDisplayableDollarAmount(EarningsAmount);

            decimal[] yValues = { EarningsAmount, ExpensesAmount, BillsAmount };

            statisticsChart.Series[0].Points.DataBindXY(xValues, yValues);
            statisticsChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void UpdateBillsDueDataGrid()
        {
            dgDueBills.ColumnCount = 3;
            dgDueBills.Columns[0].Name = "Title";
            dgDueBills.Columns[1].Name = "Amount";
            dgDueBills.Columns[2].Name = "Date Due";

            foreach (Bill b in Session.SessionInformation.GetBudget().Bills)
            {
                if (String.IsNullOrEmpty(b.DatePaid.ToString()))
                {
                    string[] row = new string[] {
                        b.Title,  
                        StringUtilities.GetDisplayableDollarAmount(b.Amount), 
                        b.DateDue.ToString()
                    };
                    dgDueBills.Rows.Add(row);
                    dgDueBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            
        }
        
        private void budgetEditBtn_Click(object sender, EventArgs e)
        {
            Budget budget = new Budget();
            budget.ID = Session.SessionInformation.GetBudget().ID;
            budget.Title = budgetTitleBox.Text;
            budget.Description = budgetDescBox.Text;
            budget.Notes = NotesRtb.Text;
            bool update = BudgetController.Instance.EditBudget(budget);
            if (update == true)
            {
                MessageBox.Show("Update was completed!");
                Session.SessionInformation.GetBudget().Title = budget.Title;
                Session.SessionInformation.GetBudget().Description = budget.Description;
                Session.SessionInformation.GetBudget().Notes = budget.Notes;
                Session.SessionInformation.RefreshBudgetPickerArea();
            }
            else
            {
                MessageBox.Show("Update was not completed!");
            }
           
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.Generate();
        }

        public void Generate()
        {
            List<string> Quotes = new List<string>();
            Random rand = new Random();

            StreamReader quoteReader = new StreamReader("quotes.txt");
            string line = "";

            while (!quoteReader.EndOfStream)
            {
                line = quoteReader.ReadLine();
                Quotes.Add(line);
            }
            saveQuoteTxt.Text = Quotes[rand.Next(1, Quotes.Count)];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.NotesRtb.Clear();
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
                Session.SessionInformation.RefreshBudgetPickerArea();
            }
            else
            {
                MessageBox.Show("Budget was not Created, please try again!");
            }
        }

        private void saveQuoteTxt_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
