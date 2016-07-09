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
using MySql.Data.MySqlClient;

namespace CS6920Group4Project.View
{
    public partial class ManageExpenses : Form
    {
        private String expenseAmount;
        private String expenseDate;
        private String expenseTitle;

        private MySqlDataAdapter mySqlDataAdapter;

        public ManageExpenses()
        {
            InitializeComponent();
        }

        private void ManageExpenses_Load(object sender, EventArgs e)
        {
            this.getExpenselist();
        }
        private void expenseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValidData = this.validateData();
                if (isValidData == true)
                {
                    Expense newExpense = new Expense();
                    try
                    {
                        newExpense.Amount = Convert.ToDecimal(expenseAmount);
                    } 
                    catch (FormatException fe)
                    {
                        Utilities.DatabaseErrorMessageUtility.SendMessageToUser("Invalid amount format!", fe);
                        return;
                    }

                    newExpense.DateCreated = DateTime.Now;
                    newExpense.DateSpent = DateTime.Parse(expenseDate);
                    newExpense.Title = expenseTitle;
                    newExpense.Description = descTxt.Text;
                    newExpense.BudgetID = Session.SessionInformation.GetBudget().ID;

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
                        this.getExpenselist();
                        Session.SessionInformation.RefreshSessionLabels();
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
            expenseAmountTxt.Text = "";
            monthCalendar.Text = "";
            expenseTitleTxt.Text = "";
            descTxt.Text = "";
        }
        
        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.clearData();
        }

        private void getExpenselist()
        {
            try
            {
                int budgetID = Session.SessionInformation.GetBudget().ID;
                mySqlDataAdapter = ExpenseController.Instance.GetExpensesByBudgetIDDataGridView(budgetID);

                DataTable table = new DataTable();
                mySqlDataAdapter.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                dataGridView1.Refresh();
                dataGridView1.DataSource = bSource;

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //add new button column to the DataGridView
                //This column displays a edit Button in each row
                DataGridViewButtonColumn editbut = new DataGridViewButtonColumn();
                editbut.Text = "EDIT";
                editbut.Name = "EDIT";
                editbut.HeaderText = "";
                editbut.Width = 100;
                editbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                editbut.UseColumnTextForButtonValue = true;
                editbut.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Columns.Add(editbut);

                //add new button column to the DataGridView
                //This column displays a delete Button in each row
                DataGridViewButtonColumn delbut = new DataGridViewButtonColumn();
                delbut.Text = "DELETE";
                delbut.Name = "DELETE";
                delbut.HeaderText = "";
                delbut.Width = 100;
                delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                delbut.UseColumnTextForButtonValue = true;
                delbut.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Columns.Add(delbut);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)                 
                {
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "EDIT")
                        {
                            int recordI = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                            int budgetID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                            char recordType = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString())[0];
                            string title = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                            string desc = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                            decimal amount = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                            DateTime dateSpent = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                            DateTime dateCreated = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());

                            //Earning currentEarning = Session.SessionInformation.GetBudget().GetSelectedEarning(recordI);

                            Expense expense = new Expense();
                            expense.ID = recordI;
                            expense.BudgetID = budgetID;
                            expense.RecordType = recordType;
                            expense.Title = title;
                            expense.Description = desc;
                            expense.Amount = amount;
                            expense.DateSpent = dateSpent;
                            expense.DateCreated = dateCreated;
                        
                            bool update = ExpenseController.Instance.EditExpenses(expense);

                            if (update == true)
                            {
                                MessageBox.Show("Expense Successfully Updated");
                            }
                            else
                            {
                                MessageBox.Show("Expense is not Updated, please try again!");
                            }

                        }
                        else if (dataGridView1.Columns[e.ColumnIndex].Name == "DELETE")
                        {
                           Expense selectedExpense = Session.SessionInformation.GetBudget().
                               GetSelectedExpense(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                                                       
                            if (selectedExpense == null)
                            {
                               MessageBox.Show("Unable to delete Expense!");
                               return;
                            }
                            string title = selectedExpense.Title.ToString();
                            string sAmount = selectedExpense.Amount.ToString();
                            string sDateSpent = selectedExpense.DateSpent.ToString();
                            DialogResult result = MessageBox.Show("Do you want to delete EXPENSE (Title - "
                                                                 + title + " Amount - " + sAmount
                                                                 + " DateSpent - " + sDateSpent + ")?",
                                                                   "DELETE EXPENSE",
                                                                    MessageBoxButtons.YesNo,
                                                                     MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                bool isExpenseDeleted = ExpenseController.Instance.DeleteExpense(selectedExpense);
                                if (isExpenseDeleted == true)
                                {
                                    MessageBox.Show("EXPENSE (Title - " + title + " Amount - " + sAmount
                                                                        + ") has been DELETED!",
                                                                 "DELETE EXPENSE",
                                                                  MessageBoxButtons.OK,
                                                                  MessageBoxIcon.Information);
                                    this.getExpenselist();
                                    Session.SessionInformation.GetBudget().Expenses.Remove(selectedExpense);
                                    Session.SessionInformation.RefreshSessionLabels();
                                }
                                else
                                {
                                    MessageBox.Show("Unable to Delete (Title - " + title + " Amount - " + sAmount
                                                                      + ") EXPENSE!",
                                                                     "DELETE EXPENSE",
                                                                      MessageBoxButtons.OK,
                                                                      MessageBoxIcon.Information);
                                }

                            }
                        }
                        
                    }
                }
            }
            
        }
