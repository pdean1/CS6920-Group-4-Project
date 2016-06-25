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
using CS6920Group4Project.Controller;

namespace CS6920Group4Project.View
{
    public partial class ManageEarnings : Form
    {
        private User user;
        public List<Budget> budgetType;

        public ManageEarnings()
        {
            InitializeComponent();
            
        }

        public ManageEarnings(User userName)
        {
            InitializeComponent();
            user = userName;
            userNameEarningsLbl.Text = user.FirstName + "" + user.LastName;
        }

      

        private void ManageEarnings_Load(object sender, EventArgs e)
        {
            
            
        }
        /// <summary>
        /// method to load a combobox -stubbed out functionality for later use
        /// </summary>
        private void LoadBudgetTypeBox()
        {
           
            try
            { 
                if (budgetType == null)
                {
                    Close();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().ToString());
            }
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
            this.Close();
            ManageBills bills = new ManageBills();
            bills.Show();
        }
        private void viewBudgetBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            BudgetView view = new BudgetView();
            view.Show();
            
        }
        private void addEarningsBtn_Click(object sender, EventArgs e)
        {
            EarningController con = new EarningController();
            Record record = new Record();
            Earning earn = new Earning();
            this.PutEarningData(record, earn);
            con.AddEarning(earn);
        }

        private void PutEarningData(Record record, Earning earn)
        {
                  
            record.Title = titleTxt.Text;
            record.Description = earningDescBox.Text;
            earn.Amount = Decimal.Parse(earningAmountBox.Text);
            
           
        }

        /// <summary>
        /// if desired method to clear all fields before closing or if the user wants to start again (reset)
        /// </summary>
        private void ClearText()
        {
            titleTxt.Text = "";
            recordTypeBox.Text = "";
            earningDescBox.Text = "";
            earningAmountBox.Text = "";
        }

        private bool IsValidData()
        {
            if(Validator.IsPresent(titleTxt))
            {
                return true;
            }
            else 
                return false;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.ClearText();
            Close();
        }

       

        
    }
}
