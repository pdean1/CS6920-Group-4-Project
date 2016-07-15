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
        private DataTable table;
        private BindingSource bind;

        public ManageEarnings()
        {
            InitializeComponent();
            mySqlDataAdapter = new MySqlDataAdapter();
            table = new DataTable();
            bind = new BindingSource();
        }

        private void ManageEarnings_Load(object sender, EventArgs e)
        {
            this.populateGridView();
            this.buildView();
            earnGridView.AutoGenerateColumns = false;
            
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

        private void addEarningsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidData())
                {
                    Earning newEarn = new Earning();
                    earnAmount = earningAmountBox.Text;
                    earnDate = monthCalendar.SelectionRange.Start.ToShortDateString();
                    earnTitle = tbTitle.Text;
                    earnDesc = descTxt.Text;
                    try
                    {
                        newEarn.Amount = Convert.ToDecimal(earnAmount);
                    }
                    catch (FormatException fex)
                    {
                        Utilities.DatabaseErrorMessageUtility.SendMessageToUser("Invalid format for amount", fex);
                        return;
                    }

                    newEarn.DateEarned = DateTime.Parse(earnDate);
                    newEarn.Title = earnTitle;
                    newEarn.Description = earnDesc;
                    newEarn.BudgetID = Session.SessionInformation.GetBudget().ID;
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
                        this.ClearText();
                        this.refreshView();
                        this.populateGridView();
                        Session.SessionInformation.RefreshSessionLabels();
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

        private void populateGridView()
        {
            try
            {
                int budgetID = Session.SessionInformation.GetBudget().ID;
                mySqlDataAdapter = EarningController.Instance.ListEarningDataGridView(budgetID);
                mySqlDataAdapter.Fill(table);
                bind.DataSource = table;
                earnGridView.DataSource = bind;
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
            earnGridView.DataSource = null;
            earnGridView.Update();
            earnGridView.Refresh();
        }
        private void buildView()
        {
            try
            {
                earnGridView.Columns[0].Visible = false;
                earnGridView.Columns[1].Visible = false;
                earnGridView.Columns[2].Visible = false;
                earnGridView.Columns[3].Width = 175;
                earnGridView.Columns[3].Selected = false;
                earnGridView.Columns[4].Width = 200;
                earnGridView.Columns[6].ReadOnly = true;
                earnGridView.Columns[7].ReadOnly = true;

                earnGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                earnGridView.Columns.Insert(8, editbut);

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
                earnGridView.Columns.Insert(9, delbut);

                earnGridView.DataError += earnGridView_DataError;
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

        void earnGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                MessageBox.Show("Invalid Amount!");
                e.ThrowException = false;
                return;
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
            descTxt.Text = "";
        }

        private bool IsValidData()
        {
            if(Validator.IsPresent(tbTitle) && Validator.IsAmountNonNegative(earningAmountBox) &&
                Validator.IsPresent(descTxt) && Validator.IsPresent(monthCalendar))
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
       
        private void earnGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (earnGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    string value = earnGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (!String.IsNullOrEmpty(value))
                    {
                        Earning selectedEarning = Session.SessionInformation.GetBudget().
                                                    GetSelectedEarning(Convert.ToInt32(value));

                        if (earnGridView.Columns[e.ColumnIndex].Name == "EDIT")
                        {
                            String title = earnGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                            String desc = earnGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                            String sendAmount = earnGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

                            selectedEarning.Title = title;
                            selectedEarning.Description = desc;
                            try
                            {
                                Decimal d = Convert.ToDecimal(sendAmount);
                                selectedEarning.Amount = d;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Invalid amount: " + sendAmount);
                                earnGridView.Rows[e.RowIndex].Cells[5].Value = Utilities.StringUtilities.Get4PointDecimal(selectedEarning.Amount);
                                return;
                            }

                            bool update = EarningController.Instance.EditEarnings(selectedEarning);

                            if (update == true)
                            {
                                MessageBox.Show("Earnings Successfully Updated");
                                Session.SessionInformation.RefreshSessionLabels();
                            }
                            else
                            {
                                MessageBox.Show("Earnings not Updated, please try again!");
                            }
                        }

                        else if (earnGridView.Columns[e.ColumnIndex].Name == "DELETE")
                        {
                            string title = selectedEarning.Title.ToString();
                            string sAmount = selectedEarning.Amount.ToString();
                            string sDateEarned = selectedEarning.DateEarned.ToString();
                            DialogResult result = MessageBox.Show("Do you want to delete EARNING (Title - "
                                                                 + title + " Amount - " + sAmount
                                                                 + " DateEarned - " + sDateEarned + ")?",
                                                                   "DELETE EARNING",
                                                                    MessageBoxButtons.YesNo,
                                                                     MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                bool isExpenseDeleted = EarningController.Instance.DeleteEarning(selectedEarning);
                                if (isExpenseDeleted == true)
                                {
                                    Session.SessionInformation.GetBudget().Earnings.Remove(selectedEarning);
                                    Session.SessionInformation.RefreshSessionLabels();
                                    this.refreshView();
                                    this.populateGridView();
                                }
                                else
                                {
                                    MessageBox.Show("Unable to Delete (Title - " + title + " Amount - " + sAmount
                                                                      + ") EARNING!",
                                                                     "DELETE EARNING",
                                                                      MessageBoxButtons.OK,
                                                                      MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
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
        
    }
}
