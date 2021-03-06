﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS6920Group4Project.Utilities;
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
        public List<Budget> budgetList;
        private DataTable table;
        private BindingSource bind;
        DateTimePicker dtpDateEarned;

        public ManageEarnings()
        {
            InitializeComponent();
            mySqlDataAdapter = new MySqlDataAdapter();
            table = new DataTable();
            bind = new BindingSource();
        }

        private void ManageEarnings_Load(object sender, EventArgs e)
        {
            this.Generate();
            this.populateGridView();
            this.buildView();
            earnGridView.AutoGenerateColumns = false;
            this.AddARow();
            
        }
        public void Generate()
        {
            List<string> Quotes = new List<string>();
            Random rand = new Random();

            StreamReader quoteReader = new StreamReader("earnQuotes.txt");
            string line = "";

            while (!quoteReader.EndOfStream)
            {
                line = quoteReader.ReadLine();
                Quotes.Add(line);
            }
            earnQuoteTxt.Text = Quotes[rand.Next(1, Quotes.Count)];
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
                earnGridView.Columns[5].DefaultCellStyle.Format = "c";
                earnGridView.Columns[6].ReadOnly = false;
                earnGridView.Columns[6].DefaultCellStyle.Format = "d";
                earnGridView.Columns[7].Visible = false;
                
                earnGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //add new button column to the DataGridView
                //This column displays a add Button in each row
                DataGridViewButtonColumn addbut = new DataGridViewButtonColumn();
                addbut.Text = "ADD";
                addbut.Name = "ADD";
                addbut.HeaderText = "";
                addbut.Width = 100;
                addbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                addbut.UseColumnTextForButtonValue = true;
                addbut.DefaultCellStyle.BackColor = Color.White;
                earnGridView.Columns.Insert(8, addbut);

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
                earnGridView.Columns.Insert(9, editbut);

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
                earnGridView.Columns.Insert(10, delbut);

                earnGridView.DataError += earnGridView_DataError;
                earnGridView.CellLeave += earnGridView_CellLeave;
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

        void earnGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                dtpDateEarned.Visible = false;
            }
        }

        void earnGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Invalid Amount!");
            //this.refreshView();
            //this.populateGridView();
            e.ThrowException = false;
            //this.AddARow();
            return;
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
                            String amount = earnGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                            String eDate = earnGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

                            if (selectedEarning.Title == title && 
                                selectedEarning.Description == desc &&
                                selectedEarning.Amount == Convert.ToDecimal(amount) && 
                                selectedEarning.DateEarned == Convert.ToDateTime(eDate))
                            {
                                MessageBox.Show("There were no changes to the Expense Item, Item was not updated.",
                                                       "USER",
                                                       MessageBoxButtons.OK,
                                                       MessageBoxIcon.Stop);
                                return;
                            }

                            selectedEarning.Title = title;
                            selectedEarning.Description = desc;
                            try
                            {
                                Decimal d = Convert.ToDecimal(amount);
                                selectedEarning.Amount = d;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Invalid amount: " + amount);
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
                                    earnGridView.Rows.RemoveAt(e.RowIndex);
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

                        else
                        {
                            MessageBox.Show("Cannot ADD an existing Earning record.",
                                           "USER",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Stop);
                            return;
                        }
                    }
                    else
                    {
                        if (earnGridView.Columns[e.ColumnIndex].Name == "ADD")
                        {
                            try
                            {
                                Earning newEarn = new Earning();
                                string earnAmount = earnGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                                string earnDate = earnGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                                string earnTitle = earnGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                                string earnDesc = earnGridView.Rows[e.RowIndex].Cells[4].Value.ToString();


                                if ((Validator.IsPresent("Title", earnTitle) && Validator.IsAmountNonNegative("Amount", earnAmount) &&
                                     Validator.IsPresent("Description", earnDesc) && Validator.IsPresent("DateEarned", earnDate)) == false)
                                {
                                    return;
                                }

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
                                    this.refreshView();
                                    this.populateGridView();
                                    this.AddARow();
                                    Session.SessionInformation.RefreshSessionLabels();
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
                        else
                        {
                            MessageBox.Show("Cannot UPDATE or DELETE a new earning record.",
                                           "USER",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Stop);
                            return;
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

        private void AddARow()
        {
            try
            {
                table.Rows.Add(table.NewRow());
                earnGridView.Rows[earnGridView.RowCount - 1].Cells[5].Value = 0.00;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void dateTimeExpense(DataGridViewCellEventArgs e)
        {
            dtpDateEarned = new DateTimePicker();  //DateTimePicker 

            // Setting the format
            dtpDateEarned.Format = DateTimePickerFormat.Custom;
            dtpDateEarned.CustomFormat = "MM-dd-yyyy";
            dtpDateEarned.Font = new Font("Calbri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
            if (!String.IsNullOrEmpty(earnGridView.Rows[e.RowIndex].Cells[6].Value.ToString()))
            {
                dtpDateEarned.Value = Convert.ToDateTime(earnGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
            }

            dtpDateEarned.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

            // It returns the retangular area that represents the Display area for a cell
            Rectangle oRectangle = earnGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

            //Setting area for DateTimePicker Control
            dtpDateEarned.Size = new Size(oRectangle.Width, oRectangle.Height);

            // Setting Location
            dtpDateEarned.Location = new Point(oRectangle.X, oRectangle.Y);

            dtpDateEarned.CloseUp += new EventHandler(oDateTimePicker_CloseUp);
            //Adding DateTimePicker control into DataGridView 
            earnGridView.Controls.Add(dtpDateEarned);
        }

        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            DateTimePicker oDateTimePicker = (DateTimePicker)sender;
            earnGridView.CurrentCell.Value = oDateTimePicker.Text.ToString();   
        }

        private void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            DateTimePicker oDateTimePicker = (DateTimePicker)sender;
            oDateTimePicker.Visible = false;
        }

        private void earnGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (earnGridView.Columns[e.ColumnIndex].Index == 6 && e.RowIndex >= 0)
            {
                dateTimeExpense(e);
            }
        }
        
    }
}
