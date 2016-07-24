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
        private DataTable table;
        private BindingSource bSource;
        private Expense selectedExpense;
        private List<Budget> _budgets;
        private MySqlDataAdapter mySqlDataAdapter;
        DateTimePicker oDateTimePicker;

        public ManageExpenses()
        {
            InitializeComponent();
            mySqlDataAdapter = new MySqlDataAdapter();
            table = new DataTable();
            bSource = new BindingSource();
            _budgets = new List<Budget>();
        }

        private void ManageExpenses_Load(object sender, EventArgs e)
        {
            this.getExpenselist();
            this.buildView();
            dataGridView1.AutoGenerateColumns = false;
            this.AddARow();
        }
        
        private void getExpenselist()
        {
            try
            {
                int budgetID = Session.SessionInformation.GetBudget().ID;
                mySqlDataAdapter = ExpenseController.Instance.GetExpensesByBudgetIDDataGridView(budgetID);         
                mySqlDataAdapter.Fill(table);
                bSource.DataSource = table;
                dataGridView1.DataSource = bSource;
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

        private void refreshView()
        {
            table.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void buildView()
        {
            try
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Width = 175;
                dataGridView1.Columns[3].Selected = false;
                dataGridView1.Columns[4].Width = 200;
                dataGridView1.Columns[5].DefaultCellStyle.Format = "c";
                dataGridView1.Columns[6].Name = "DateSpent";
                dataGridView1.Columns[7].ReadOnly = true;
                dataGridView1.Columns[7].DefaultCellStyle.Format = "d";
                dataGridView1.Columns[7].DefaultCellStyle.BackColor = Color.LightGray;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //add new button column to the DataGridView
                //This column displays a edit Button in each row
                DataGridViewButtonColumn editbut = new DataGridViewButtonColumn();
                editbut.Text = "UPDATE EXPENSE";
                editbut.Name = "UPDATE EXPENSE";
                editbut.HeaderText = "";
                editbut.Width = 100;
                editbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                editbut.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Columns.Insert(8, editbut);
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[8].Value = "Update Expense"; //Column Index for the dataGridViewButtonColumn           
                }

                //add new button column to the DataGridView
                //This column displays a delete Button in each row
                DataGridViewButtonColumn delbut = new DataGridViewButtonColumn();
                delbut.Text = "DELETE EXPENSE";
                delbut.Name = "DELETE EXPENSE";
                delbut.HeaderText = "";
                delbut.Width = 100;               
                delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
 //               delbut.UseColumnTextForButtonValue = true;
                delbut.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Columns.Insert(9, delbut);
                
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[9].Value = "Delete Expense"; //Column Index for the dataGridViewButtonColumn  
                    dataGridView1.Rows[i].Height = 28;
                }


                dataGridView1.DataError += dataGridView1_DataError;
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

        void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                MessageBox.Show("Invalid Amount!");
                this.refreshView();
                this.getExpenselist();
                e.ThrowException = false;
                return;            
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
            {
                string value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (!String.IsNullOrEmpty(value))
                {
                    selectedExpense = null;
                    try
                    {
                        selectedExpense = Session.SessionInformation.GetBudget().
                                                GetSelectedExpense(Convert.ToInt32(value));
                    }
                    catch (Exception)
                    {
                        return;
                    }

                    if (dataGridView1.Columns[e.ColumnIndex].Name == "Update Expense")
                    {
                        this.editExpense(e);
                    }

                    else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete Expense")
                    {
                        this.deleteExpense(e);
                    }
                }
                else
                {
                    if (dataGridView1.Columns[e.ColumnIndex].Index == 8)            // add expense
                    {
                        this.addExpense(e);
                    }
                    else if (dataGridView1.Columns[e.ColumnIndex].Index == 9)       // clear expense
                    {
                        this.clearExpense(e);
                        this.refreshView();
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DateSpent")
            {
                dateTimeExpense(e);
            }
        }

        private void AddARow()
        {
            try
            {
                if (dataGridView1.RowCount == 0)
                {
                    DataGridViewCell addCell = dataGridView1.Rows[dataGridView1.RowCount].Cells[8]; //Column Index for the dataGridViewButtonColumn           
                    addCell.Value = "Add Expense";
                    dataGridView1.Rows[dataGridView1.RowCount].Height = 28;

                    DataGridViewCell clearCell = dataGridView1.Rows[dataGridView1.RowCount].Cells[9]; //Column Index for the dataGridViewButtonColumn           
                    clearCell.Value = "Clear Expense";
                }
                else
                {
                    // Use the NewRow method to create a DataRow with 
                    // the table's schema.
                    DataRow newRow = table.NewRow();

                    // Add the row to the rows collection.
                    table.Rows.Add(newRow);

                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[5].Value = 0.00;

                    DataGridViewCell addCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[8]; //Column Index for the dataGridViewButtonColumn           
                    addCell.Value = "Add Expense";
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Height = 28;

                    DataGridViewCell clearCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[9]; //Column Index for the dataGridViewButtonColumn           
                    clearCell.Value = "Clear Expense";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void editExpense(DataGridViewCellEventArgs e)
        {
            try
            {
                String title = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                String desc = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                String sendAmount = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                String newDate = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                selectedExpense.Title = title;
                selectedExpense.Description = desc;
                selectedExpense.DateSpent = Convert.ToDateTime(newDate);

                try
                {
                    Decimal d = Convert.ToDecimal(sendAmount);
                    selectedExpense.Amount = d;
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid amount: " + sendAmount);
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = Utilities.StringUtilities.Get4PointDecimal(selectedExpense.Amount);
                    dataGridView1.Refresh();
                    return;
                }

                bool update = ExpenseController.Instance.EditExpenses(selectedExpense);

                if (update == true)
                {
                    MessageBox.Show("Expense Successfully Updated");
                    Session.SessionInformation.RefreshSessionLabels();
                }
                else
                {
                    MessageBox.Show("Expense not Updated, please try again!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void deleteExpense(DataGridViewCellEventArgs e)
        {
            try
            {
                String title = selectedExpense.Title.ToString();
                String sAmount = selectedExpense.Amount.ToString();
                String sDateSpent = selectedExpense.DateSpent.ToString();
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
                        Session.SessionInformation.GetBudget().Expenses.Remove(selectedExpense);
                        Session.SessionInformation.RefreshSessionLabels();
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void addExpense(DataGridViewCellEventArgs e)
        {
            try
            {
                String title = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                String desc = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                String amount = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                String spentDate = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (String.IsNullOrEmpty(title) || String.IsNullOrEmpty(amount) || String.IsNullOrEmpty(spentDate))
                {
                    MessageBox.Show("All fields are required, Please Try Again",
                                    "USER",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    Expense newExpense = new Expense();
                    try
                    {
                        newExpense.Amount = Convert.ToDecimal(amount);
                    }
                    catch (FormatException fe)
                    {
                        Utilities.DatabaseErrorMessageUtility.SendMessageToUser("Invalid amount format!", fe);
                        return;
                    }

                    newExpense.DateCreated = DateTime.Now;
                    newExpense.DateSpent = DateTime.Parse(spentDate);
                    newExpense.Title = title;
                    newExpense.Description = desc;
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
                        this.refreshView();
                        this.getExpenselist();
                        this.buildView();
                        Session.SessionInformation.RefreshSessionLabels();
                        this.AddARow();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void clearExpense(DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = "";
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = "";
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = 0.00;
                dataGridView1.Rows[e.RowIndex].Cells[6].Value = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void dateTimeExpense(DataGridViewCellEventArgs e)
        {
            try
            {
                oDateTimePicker = new DateTimePicker();  //DateTimePicker 

                //Adding DateTimePicker control into DataGridView 
                dataGridView1.Controls.Add(oDateTimePicker);

                // Intially made it invisible
                oDateTimePicker.Visible = false;

                // Setting the format
                oDateTimePicker.Format = DateTimePickerFormat.Custom;
                oDateTimePicker.CustomFormat = "MM-dd-yyyy";

                if (!String.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()))
                {
                    oDateTimePicker.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                }

                oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                // Now make it visible
                oDateTimePicker.Visible = true;

                // It returns the retangular area that represents the Display area for a cell
                Rectangle oRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control
                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location
                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);

                oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.CurrentCell.Value = oDateTimePicker.Text.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            try
            {
                oDateTimePicker.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


    }    
 }
