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
using System.IO;

namespace CS6920Group4Project.View
{
    public partial class ManageExpenses : Form
    {
        private DataTable table;
        private BindingSource bSource;
        private Expense selectedExpense;
        private MySqlDataAdapter mySqlDataAdapter;
        private String editButton;
        private String deleteButton;
        private String addButton;
        private String title;
        private String desc;
        private String amount;
        private String sDate;
        private DateTimePicker dtpDateSpent;

        public ManageExpenses()
        {
            InitializeComponent();
            mySqlDataAdapter = new MySqlDataAdapter();
            table = new DataTable();
            bSource = new BindingSource();
            editButton = "Edit";
            deleteButton = "Delete";
            addButton = "Add";
        }

        private void ManageExpenses_Load(object sender, EventArgs e)
        {
            this.expenseGenerate();
            this.getExpenselist();
            this.buildView();
            dataGridView1.AutoGenerateColumns = false;
            this.AddARow();
        }
        
        private void expenseGenerate()
        {
            List<string> Quotes = new List<string>();
            Random rand = new Random();

            StreamReader quoteReader = new StreamReader("expenseQuotes.txt");
            string line = "";

            while (!quoteReader.EndOfStream)
            {
                line = quoteReader.ReadLine();
                Quotes.Add(line);
            }
            expenseQuoteTxt.Text = Quotes[rand.Next(1, Quotes.Count)];
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
                dataGridView1.Columns[6].ReadOnly = false;
                dataGridView1.Columns[6].DefaultCellStyle.Format = "d";
                dataGridView1.Columns[7].Visible = false;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //add new button column to the DataGridView
                //This column displays a add Button in each row
                DataGridViewButtonColumn addBut = new DataGridViewButtonColumn();
                addBut.Text = addButton;
                addBut.Name = addButton;
                addBut.HeaderText = "";
                addBut.Width = 100;
                addBut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                addBut.UseColumnTextForButtonValue = true;
                addBut.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Columns.Insert(8, addBut);
                
                //add new button column to the DataGridView
                //This column displays a edit Button in each row
                DataGridViewButtonColumn editbut = new DataGridViewButtonColumn();
                editbut.Text = editButton;
                editbut.Name = editButton;
                editbut.HeaderText = "";
                editbut.Width = 100;
                editbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                editbut.UseColumnTextForButtonValue = true;
                editbut.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Columns.Insert(9, editbut);
                
                //add new button column to the DataGridView
                //This column displays a delete Button in each row
                DataGridViewButtonColumn delbut = new DataGridViewButtonColumn();
                delbut.Text = deleteButton;
                delbut.Name = deleteButton;
                delbut.HeaderText = "";
                delbut.Width = 100;               
                delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                delbut.UseColumnTextForButtonValue = true;
                delbut.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Columns.Insert(10, delbut);
                
                dataGridView1.DataError += dataGridView1_DataError;
                dataGridView1.CellLeave += dataGridView1_CellLeave;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
                dtpDateSpent.Visible = false;
        }

        void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                MessageBox.Show("Invalid Amount!");
                // this.refreshView();
                // this.getExpenselist();
                e.ThrowException = false;
                // this.AddARow();
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
                    
                    title = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    desc = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    amount = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    sDate = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                    if (dataGridView1.Columns[e.ColumnIndex].Name == editButton)
                    {
                        this.editExpense(e);
                    }

                    else if (dataGridView1.Columns[e.ColumnIndex].Name == deleteButton)
                    {
                        this.deleteExpense(e);
                    }

                    else
                    {
                            MessageBox.Show("Cannot ADD an existing Expense Record.",
                                           "USER",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Stop);
                            return;
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == addButton)            // add expense
                 {
                     this.addExpense(e);
                 }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DateSpent" && e.RowIndex >= 0)
            {
                dateTimeExpense(e);
            }
        }

        private void AddARow()
        {
            try
            {
                table.Rows.Add(table.NewRow());
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[5].Value = 0.00;
                
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
                if (selectedExpense.Title == title && 
                    selectedExpense.Description == desc && 
                    selectedExpense.Amount == Convert.ToDecimal(amount) &&
                    selectedExpense.DateSpent == Convert.ToDateTime(sDate))
                {
                    MessageBox.Show("There were no changes to the Expense Item, Item was not updated.",
                                           "USER",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Stop);
                    return;
                }

                selectedExpense.Title = title;
                selectedExpense.Description = desc;
                selectedExpense.DateSpent = Convert.ToDateTime(sDate);

                try
                {
                    Decimal d = Convert.ToDecimal(amount);
                    selectedExpense.Amount = d;
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid amount: " + amount);
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
                DialogResult result = MessageBox.Show("Do you want to delete EXPENSE (Title - "
                                                     + title + " Amount - " + amount
                                                     + " DateSpent - " + sDate + ")?",
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
                        MessageBox.Show("Unable to Delete (Title - " + title + " Amount - " + amount
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
                title = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                desc = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                amount = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                sDate = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (String.IsNullOrEmpty(title) || String.IsNullOrEmpty(amount) || String.IsNullOrEmpty(sDate))
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
                    newExpense.DateSpent = DateTime.Parse(sDate);
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
                        this.AddARow();
                        Session.SessionInformation.RefreshSessionLabels();                    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void dateTimeExpense(DataGridViewCellEventArgs e)
        {
            dtpDateSpent = new DateTimePicker();  //DateTimePicker 

            // Setting the format
            dtpDateSpent.Format = DateTimePickerFormat.Custom;
            dtpDateSpent.CustomFormat = "MM-dd-yyyy";
            dtpDateSpent.Font = new Font("Calbri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            if (!String.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()))
            {
                dtpDateSpent.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            }

            dtpDateSpent.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

            // It returns the retangular area that represents the Display area for a cell
            Rectangle oRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

            //Setting area for DateTimePicker Control
            dtpDateSpent.Size = new Size(oRectangle.Width, oRectangle.Height);

            // Setting Location
            dtpDateSpent.Location = new Point(oRectangle.X, oRectangle.Y);

            dtpDateSpent.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

            //Adding DateTimePicker control into DataGridView 
            dataGridView1.Controls.Add(dtpDateSpent);
        }

        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            DateTimePicker oDateTimePicker = (DateTimePicker)sender;
            dataGridView1.CurrentCell.Value = oDateTimePicker.Text.ToString();
        }

        private void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            DateTimePicker oDateTimePicker = (DateTimePicker)sender;
            oDateTimePicker.Visible = false;
        }


    }    
 }
