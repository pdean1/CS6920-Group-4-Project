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
                    newExpense.Description = "";
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

                dataGridView1.DataSource = bSource;

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[3].Width = 175;
                dataGridView1.Columns[3].Selected = false;

                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[4].Width = 200;
                dataGridView1.Columns[5].ReadOnly = true;
                dataGridView1.Columns[6].ReadOnly = true;

                //add new button column to the DataGridView
                //This column displays a edit Button in each row
                DataGridViewButtonColumn editbut = new DataGridViewButtonColumn();
                editbut.Text = "EDIT";
                editbut.Name = "EDIT";
                editbut.HeaderText = "Select";
                editbut.Width = 100;
                editbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                editbut.UseColumnTextForButtonValue = true;
                editbut.DefaultCellStyle.BackColor = Color.AntiqueWhite;
                dataGridView1.Columns.Add(editbut);

                //add new button column to the DataGridView
                //This column displays a delete Button in each row
                DataGridViewButtonColumn delbut = new DataGridViewButtonColumn();
                delbut.Text = "DELETE";
                delbut.Name = "DELETE";
                delbut.Width = 100;
                delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                delbut.UseColumnTextForButtonValue = true;
                delbut.DefaultCellStyle.BackColor = Color.AntiqueWhite;
                dataGridView1.Columns.Add(delbut);

                dataGridView1.DefaultCellStyle.ForeColor = Color.DarkGreen;
                dataGridView1.DefaultCellStyle.BackColor = Color.AntiqueWhite;
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
                //TODO - Button Clicked - Execute Code Here
                if (dataGridView1.Columns[e.ColumnIndex].Name == "DELETE")
                {

                    Expense selectedExpense = new Expense();
                    selectedExpense = Session.SessionInformation.GetBudget().
                            GetSelectedExpense(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));

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

                if (dataGridView1.Columns[e.ColumnIndex].Name == "EDIT")
                {

                }
            }
        }

    }
}
