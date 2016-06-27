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
using System.Data.SqlClient;

namespace CS6920Group4Project.View
{
    public partial class ManageEarnings : Form
    {
        private User user;
        private String earnDesc;
        private String earnDate;
        private String earnTitle;
        private String earnAmount;
        public List<Budget> budgetList;
        private List<EarningCategory> earnCategoryList;

        public ManageEarnings()
        {
            InitializeComponent();
            
        }

        public ManageEarnings(User userName)
        {
            InitializeComponent();
            userNameEarningsLbl.Text = Session.SessionInformation.GetSessionUser().FirstName + " "
                + Session.SessionInformation.GetSessionUser().LastName;
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
                if (budgetList == null)
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
            try
            {
                bool isValidData = this.validateData();
                if (isValidData == true)
                {
                    Earning newEarn = new Earning();
                    newEarn.Amount = Convert.ToDecimal(earnAmount);
                    newEarn.DateCreated = DateTime.Now;
                    newEarn.DateEarned = DateTime.Parse(earnDate);
                    newEarn.Title = earnTitle;
                    newEarn.Description = earnDesc;
                    newEarn.BudgetID = 1;

                    long isEarningsAdded = EarningController.Instance.InsertEarning(newEarn);
                    if (isEarningsAdded == 0)
                    {
                        MessageBox.Show("An error occured, earnings was not added to your Budget",
                                    "USER",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Earnings Successfully Added",
                                    "USER",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.None);
                        this.ClearText();
                    }
                }
                else
                {
                    this.ClearText();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            /*
            EarningController con = new EarningController();
            Record record = new Record();
            Earning earn = new Earning();
            this.PutEarningData(record, earn);
            con.AddEarning(earn);*/
        }
        
        public bool validateData()
        {
            earnDesc = earningDescBox.Text;
            earnAmount = earningAmountBox.Text;
            earnDate = monthCalendar.SelectionRange.Start.ToShortDateString();
            earnTitle = titleTxt.Text;

            if (String.IsNullOrEmpty(earnTitle) || String.IsNullOrEmpty(earnAmount) || String.IsNullOrEmpty(earnDate))
            {
                MessageBox.Show("All fields are required, Please Try Again",
                                "USER",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                return false;
            }

            return true;
        }

        private void PutEarningData(Record record, Earning earn)
        {
            /*      
            record.Title = titleTxt.Text;
            record.Description = earningDescBox.Text;
            earn.Amount = Decimal.Parse(earningAmountBox.Text);
            earn.DateEarned = DateTime.Parse(earnDate);
              */
        }

        /// <summary>
        /// if desired method to clear all fields before closing or if the user wants to start again (reset)
        /// </summary>
        private void ClearText()
        {
            titleTxt.Text = "";
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
