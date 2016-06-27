using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS6920Group4Project.Controller;
using CS6920Group4Project.Model;
using System.Data.SqlClient;

namespace CS6920Group4Project.View
{
    public partial class ManageExpenses : Form
    {
        private String expenseDesc;
        private String expenseAmount;
        private String expenseDate;
        private String expenseTitle;

        private ExpenseCategory expenseCategory;
        private List<ExpenseCategory> categoryList;
        private List<Budget> budgetList;

        public ManageExpenses()
        {
            InitializeComponent();
            this.getExpenseCategoryList();
        }


        private void expenseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValidData = this.validateData();
                if (isValidData == true)
                {
                    Expense newExpense = new Expense();
                    newExpense.Amount = Convert.ToDecimal(expenseAmount);
                    newExpense.DateCreated = DateTime.Now;
                    newExpense.DateSpent = DateTime.Parse(expenseDate);
                    newExpense.Title = expenseTitle;
                    newExpense.Description = expenseDesc;
                    newExpense.Category = categoryList[expenseCategoryBox.SelectedIndex];
                    newExpense.BudgetID = 1;

                    long isExpenseAdded = ExpenseController.Instance.InsertExpense(newExpense);
                    if (isExpenseAdded == 0)
                    {
                        MessageBox.Show("An error occured, Expense was not added to your Budget",
                                    "USER",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Expense Successfully Added",
                                    "USER",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.None);
                        this.clearData();
                    }
                }
                else
                {
                    this.clearData();
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
        }

        public bool validateData()
        {
             expenseAmount = expenseAmountTxt.Text;
             expenseDate = monthCalendar.SelectionRange.Start.ToShortDateString();
             expenseTitle = expenseTitleTxt.Text;
            
             if (String.IsNullOrEmpty(expenseTitle) || String.IsNullOrEmpty(expenseAmount) || String.IsNullOrEmpty(expenseDate))
             {
                 MessageBox.Show("All fields are required, Please Try Again",
                                 "USER",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Stop);
                 return false;
             }

             return true;
        }

        private void clearData()
        {
            expenseCategoryBox.SelectedIndex = -1 ;
            expenseAmountTxt.Text = "";
            monthCalendar.Text = "";
        }

        private void getExpenseCategoryList()
        {
            categoryList = ExpenseController.Instance.GetExpenseCategoryList();
            expenseCategoryBox.DataSource = categoryList;
            expenseCategoryBox.DisplayMember = "Title";
            expenseCategoryBox.ValueMember = "ID";
        }

        private void getUserID()
        {
            budgetList = Session.SessionInformation.GetListOfBudgets();     
        }
    
    }
}
