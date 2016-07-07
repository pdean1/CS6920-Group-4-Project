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
using MySql.Data.MySqlClient;

namespace CS6920Group4Project.View
{
    public partial class ManageEarnings : Form
    {
        MySqlDataAdapter mySqlDataAdapter;
        private String earnDesc;
        private String earnDate;
        private String earnTitle;
        private String earnAmount;
        public List<Budget> budgetList;

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
                    try
                    {
                        newEarn.Amount = Convert.ToDecimal(earnAmount);
                    }
                    catch (FormatException fe)
                    {
                        Utilities.DatabaseErrorMessageUtility.SendMessageToUser("Invalid format for amount", fe);
                        return;
                    }

                    newEarn.DateEarned = DateTime.Parse(earnDate);
                    newEarn.Title = earnTitle;
                    newEarn.Description = earnDesc;
                    newEarn.BudgetID = 1; // TODO Hard Coded value will need to change in the future
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
                        this.populateGridView();
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
           
        }

        public void populateGridView()
        {
            try
            {
                int budgetID = Session.SessionInformation.GetBudget().ID;                
                mySqlDataAdapter = EarningController.Instance.ListEarningDataGridView(budgetID);

                DataTable table = new DataTable();
                mySqlDataAdapter.Fill(table);

                BindingSource bind = new BindingSource();

                bind.DataSource = table;
                earnGridView.DataSource = bind;

                earnGridView.Columns[0].Visible = false;
                earnGridView.Columns[1].Visible = false;
                earnGridView.Columns[2].Visible = false;

                DataGridViewButtonColumn editbut = new DataGridViewButtonColumn();
                editbut.Text = "EDIT";
                editbut.Name = "EDIT";
                editbut.HeaderText = "Select";
                editbut.Width = 100;
                editbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                editbut.UseColumnTextForButtonValue = true;
                editbut.DefaultCellStyle.BackColor = Color.DarkGreen;
                editbut.DefaultCellStyle.ForeColor = Color.White;
                earnGridView.Columns.Add(editbut);

                //add new button column to the DataGridView
                //This column displays a delete Button in each row
                DataGridViewButtonColumn delbut = new DataGridViewButtonColumn();
                delbut.Text = "DELETE";
                delbut.Name = "DELETE";
                delbut.Width = 100;
                delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                delbut.UseColumnTextForButtonValue = true;
                delbut.DefaultCellStyle.BackColor = Color.AntiqueWhite;
                earnGridView.Columns.Add(delbut);

                earnGridView.DefaultCellStyle.ForeColor = Color.DarkGreen;
                earnGridView.DefaultCellStyle.BackColor = Color.AntiqueWhite;
               
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
            earnAmount = earningAmountBox.Text;
            earnDate = monthCalendar.SelectionRange.Start.ToShortDateString();
            earnTitle = tbTitle.Text;

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

       
        /// <summary>
        /// if desired method to clear all fields before closing or if the user wants to start again (reset)
        /// </summary>
        private void ClearText()
        {
            tbTitle.Text = "";
            earningAmountBox.Text = "";
        }

        private bool IsValidData()
        {
            if(Validator.IsPresent(tbTitle))
            {
                return true;
            }
            else 
                return false;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.ClearText();
            
        }

        private void ManageEarnings_Load(object sender, EventArgs e)
        {
            this.populateGridView();
        }

       
        private void earnGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (earnGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                if (earnGridView.Columns[e.ColumnIndex].Name == "EDIT")
                {
                    int recordI = Convert.ToInt32(earnGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int budgetID = Convert.ToInt32(earnGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
                    string recordType = earnGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string title = earnGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string desc = earnGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string sendAmount = earnGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string sendDateEarned = earnGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    DateTime dateCreated = Convert.ToDateTime(earnGridView.Rows[e.RowIndex].Cells[7].Value.ToString());

                    decimal amount = Convert.ToDecimal(sendAmount);
                    DateTime dateEarned = Convert.ToDateTime(sendDateEarned);

                    Earning editEarn = new Earning();
                    editEarn.ID = recordI;
                    editEarn.BudgetID = budgetID;
                    editEarn.Title = title;
                    editEarn.Description = desc;
                    editEarn.Amount = amount;
                    editEarn.DateEarned = dateEarned;
                    editEarn.DateCreated = dateCreated;
                    
                    //bool update = EarningController.Instance.EditEarnings(newEarning, oldEarning);

                }
                else if (earnGridView.Columns[e.ColumnIndex].Name == "DELETE")
                {
                    Earning selectedEarning = new Earning();
                    selectedEarning = Session.SessionInformation.GetBudget().
                            GetSelectedEarning(Convert.ToInt32(earnGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));

                    string title = selectedEarning.Title.ToString();
                    string sAmount = selectedEarning.Amount.ToString();
                    string sDateSpent = selectedEarning.DateEarned.ToString();
                    DialogResult result = MessageBox.Show("Do you want to delete Earning (Title - "
                                                           + title + " Amount - " + sAmount
                                                           + " DateSpent - " + sDateSpent + ")?",
                                                          "DELETE Earning",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bool isEarningDeleted = EarningController.Instance.DeleteEarning(selectedEarning);
                        if (isEarningDeleted == true)
                        {
                            MessageBox.Show("Earning (Title - " + title + " Amount - " + sAmount
                                                                + ") has been DELETED!",
                                                          "DELETE Earning",
                                                          MessageBoxButtons.OK,
                                                          MessageBoxIcon.Information);
                            this.populateGridView();
                        }
                        else
                        {
                            MessageBox.Show("Unable to Delete (Title - " + title + " Amount - " + sAmount
                                                                + ") Earning!",
                                                          "DELETE Earning",
                                                          MessageBoxButtons.OK,
                                                          MessageBoxIcon.Information);
                        }

                    }
                }
            }
        }

        
    }
}
