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
using CS6920Group4Project.Utilities;


namespace CS6920Group4Project.View
{
    public partial class Dashboard : Form
    {

        private decimal BillsAmount = 0, ExpensesAmount = 0, EarningsAmount = 0;

        public Dashboard()
        {
            InitializeComponent();
            userNameLbl.Text = Session.SessionInformation.GetSessionUser().FirstName + " " 
                + Session.SessionInformation.GetSessionUser().LastName;
            UpdateDashboard();
            
       }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            cbBudgets.SelectedIndex = 0;
        }

        private void cbBudgets_SelectedIndexChanged(Object sender, EventArgs e)
        {
            //UpdateDashboard();
            return; // working on this
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
            string[] xValues = { "Earnings", "Expenses", "Bills" };
            BillsAmount = Session.SessionInformation.GetBudget().GetTotalAmountOfBills();
            EarningsAmount = Session.SessionInformation.GetBudget().GetTotalAmountOfEarnings();
            ExpensesAmount = Session.SessionInformation.GetBudget().GetTotalAmountOfExpenses();

            lblBillAmount.Text = StringUtilities.GetDisplayableDollarAmount(BillsAmount);
            lblExpenseAmount.Text = StringUtilities.GetDisplayableDollarAmount(ExpensesAmount);
            lblIncomeAmount.Text = StringUtilities.GetDisplayableDollarAmount(EarningsAmount);

            lblIncomeRemaining.Text = StringUtilities.GetDisplayableDollarAmount(EarningsAmount - (BillsAmount + ExpensesAmount));

            decimal[] yValues = { EarningsAmount, ExpensesAmount, BillsAmount };
            statisticsChart.Series[0].Points.DataBindXY(xValues, yValues);
            statisticsChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }
    }
}
