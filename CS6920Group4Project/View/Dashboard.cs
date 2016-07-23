using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS6920Group4Project.Model;
using CS6920Group4Project.View;
using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.Utilities;
using CS6920Group4Project.Controller;


namespace CS6920Group4Project.View
{
    public partial class Dashboard : Form
    {
        Double result = 0;
        String calculations = "";
        bool isCalculationPerformed = false;

        private decimal BillsAmount = 0, ExpensesAmount = 0, EarningsAmount = 0;

        public Dashboard()
        {
            InitializeComponent();
            budgetTitleBox.Text = Session.SessionInformation.GetBudget().Title;
            budgetDescBox.Text = Session.SessionInformation.GetBudget().Description;
            NotesRtb.Text = Session.SessionInformation.GetBudget().Notes;
            UpdateDashboard();
            resultsTxt.KeyUp += resultsTxt_KeyUp;
            resultsTxt.Enabled = false; // Added this here as a quick fix for user entered errors
            resultsTxt.BackColor = Color.White;
        }
        /// <summary>
        ///  Consider using this in the future...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void resultsTxt_KeyUp(object sender, KeyEventArgs e)
        {
            char[] text = resultsTxt.Text.ToCharArray();
            String newText = "";
            foreach (char c in text)
            {
                if (char.IsDigit(c) || c == '/' || c == '*' || c == '-' || c == '+')
                {
                    newText += c;
                }
            }
            resultsTxt.Text = newText;
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

            lblIncomeRemaining.Text = StringUtilities.GetDisplayableDollarAmount(EarningsAmount - (BillsAmount + ExpensesAmount));

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

        private void button_Click(object sender, EventArgs e)
        {
            if ((resultsTxt.Text == "0") || (isCalculationPerformed))
                resultsTxt.Clear();

            isCalculationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if (!resultsTxt.Text.Contains("."))
                    resultsTxt.Text = resultsTxt.Text + button.Text;
            }
                else
            resultsTxt.Text = resultsTxt.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                equalBtn.PerformClick();
                calculations = button.Text;
                valueLbl.Text = result + " " + calculations;
                isCalculationPerformed = true;
            }
            else
            {
                calculations = button.Text;
                result = Double.Parse(resultsTxt.Text);
                valueLbl.Text = result + " " + calculations;
                isCalculationPerformed = true;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            resultsTxt.Text = "0";
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            resultsTxt.Text = "0";
            result = 0;
        }

        private void equal_Click(object sender, EventArgs e)
            {
            switch(calculations)
            {
                case "+":
                resultsTxt.Text = (result + Double.Parse(resultsTxt.Text)).ToString();
                    break;

                case "-":
                    resultsTxt.Text = (result - Double.Parse(resultsTxt.Text)).ToString();
                    break;

                case "*":
                    resultsTxt.Text = (result * Double.Parse(resultsTxt.Text)).ToString();
                    break;

                case "/":
                    if (Double.Parse(resultsTxt.Text) == 0)
                    {
                        MessageBox.Show("Cannot Divide by Zero, please enter a different value");
                        resultsTxt.Text = "";
                        return;
                    }
                    resultsTxt.Text = (result / Double.Parse(resultsTxt.Text)).ToString();
                    break;
                default:
                    break;

            }
            result = Double.Parse(resultsTxt.Text);
            valueLbl.Text = "";
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
            quoteTxt.Text = Quotes[rand.Next(1, Quotes.Count)];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.NotesRtb.Clear();
        }
              
    }
}
