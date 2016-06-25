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
            
       }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            cbBudgets.DataSource = Session.SessionInformation.GetListOfBudgets();
            cbBudgets.DisplayMember = "Title";
            cbBudgets.ValueMember = "ID";
            cbBudgets.SelectedIndexChanged += cbBudgets_SelectedIndexChanged;
            cbBudgets.SelectedIndex = 0;
        }

        private void cbBudgets_SelectedIndexChanged(Object sender, EventArgs e)
        {
            string[] xValues = { "Earnings", "Expenses", "Bills" };
            BillsAmount = Session.SessionInformation.GetListOfBudgets()[cbBudgets.SelectedIndex].GetTotalAmountOfBills();
            EarningsAmount = Session.SessionInformation.GetListOfBudgets()[cbBudgets.SelectedIndex].GetTotalAmountOfEarnings();
            ExpensesAmount = Session.SessionInformation.GetListOfBudgets()[cbBudgets.SelectedIndex].GetTotalAmountOfExpenses();

            lblBillAmount.Text = string.Format("{0:c}", BillsAmount);
            lblExpenseAmount.Text = string.Format("{0:c}", ExpensesAmount);
            lblIncomeAmount.Text = string.Format("{0:c}", EarningsAmount);

            lblIncomeRemaining.Text = string.Format("{0:c}", EarningsAmount - (BillsAmount + ExpensesAmount));

            decimal[] yValues = { EarningsAmount, ExpensesAmount, BillsAmount };
            statisticsChart.Series[0].Points.DataBindXY(xValues, yValues);
            statisticsChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            MessageBox.Show("Boom");
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
    }
}
