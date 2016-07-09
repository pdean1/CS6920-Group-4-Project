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
using CS6920Group4Project.Utilities;

namespace CS6920Group4Project.View
{
    public partial class ManageBills : Form
    {
        private String billDesc;
        private String billAmount;
        private String billDate;
        private String billTitle;

       // private List<Budget> budgetList;

        public ManageBills()
        {
            InitializeComponent();
        }

        private void billBtn_Click(object sender, EventArgs e)
        { 
            try
            {
                bool isValidData = this.validateData();
                if (isValidData == true)
                {
                    Bill newBill = new Bill();
                    try
                    {
                        newBill.Amount = Convert.ToDecimal(billAmount);
                    }
                    catch (FormatException fe)
                    {
                        Utilities.DatabaseErrorMessageUtility.SendMessageToUser("Invalid amount format!", fe);
                        return;
                    }
                    newBill.DateCreated = DateTime.Now;
                    newBill.DateDue = DateTime.Parse(billDate);
                    newBill.Title = billTitle;
                    newBill.Description = billDesc;
                    newBill.BudgetID = 1;

                    long isBillAdded = BillController.Instance.InsertBill(newBill);
                    if (isBillAdded == 0)
                    {
                        MessageBox.Show("An error occured, Bill was not added to your Budget",
                                    "USER",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Bill Successfully Added",
                                    "USER",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.None);
                        this.clearData();
                        AddRowToDataGrid(newBill);
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
             billDesc = billDescTxt.Text;
             billAmount = billAmountTxt.Text;
             billDate = monthCalendar.SelectionRange.Start.ToShortDateString();
             billTitle = billTitleTxt.Text;
            
             if (String.IsNullOrEmpty(billTitle) || String.IsNullOrEmpty(billAmount) || String.IsNullOrEmpty(billDate))
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
            billTitleTxt.Text = "";
            billDescTxt.Text = "";
            billAmountTxt.Text = "";
            monthCalendar.Text = "";
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.clearData();
        }

        private void ManageBills_Load(object sender, EventArgs e)
        {
            lblTitle.Text += " " + Session.SessionInformation.GetBudget().Title;

            dgBills.ColumnCount = 5;

            dgBills.Columns[0].Name = "Record ID";
            dgBills.Columns[1].Name = "Title";
            dgBills.Columns[2].Name = "Amount";
            dgBills.Columns[3].Name = "Date Due";
            dgBills.Columns[4].Name = "Date Paid";

            foreach (Bill b in Session.SessionInformation.GetBudget().Bills)
            {
                AddRowToDataGrid(b);
            }

            DataGridViewButtonColumn editBtnCol = new DataGridViewButtonColumn();
            dgBills.Columns.Add(editBtnCol);
            editBtnCol.HeaderText = " ";
            editBtnCol.Text = "Edit Bill";
            editBtnCol.Name = "btnEdit";
            editBtnCol.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn deleteBtnCol = new DataGridViewButtonColumn();
            dgBills.Columns.Add(deleteBtnCol);
            deleteBtnCol.HeaderText = " ";
            deleteBtnCol.Text = "Delete Bill";
            deleteBtnCol.Name = "btnDelete";
            deleteBtnCol.UseColumnTextForButtonValue = true;
            dgBills.CellClick += dgBills_CellClick;

            dgBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int id = Int32.Parse(dgBills.Rows[e.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show("Edit bill not yet needed.");
                // Session.SessionInformation.RefreshSessionLabels(); // uncomment once implemented
            }
            else if (e.ColumnIndex == 6)
            {
                int id = Int32.Parse(dgBills.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (DeleteBillClicked(id))
                {
                    dgBills.Rows.RemoveAt(e.RowIndex);
                }
            }   
        }

        private void AddRowToDataGrid(Bill b)
        {
            string[] row = new string[] { 
                    b.ID.ToString(), 
                    b.Title, 
                    StringUtilities.GetDisplayableDollarAmount(b.Amount),
                    b.DateDue.ToShortDateString(),
                    b.DatePaid.ToString()
                };
            dgBills.Rows.Add(row);
        }

        private Boolean DeleteBillClicked(int id)
        {
            Bill bill = Session.SessionInformation.GetBudget().GetSelectedBill(id);
            if (bill == null)
            {
                MessageBox.Show("Unable to delete bill!");
                return false;
            }
            if (!BillController.Instance.DeleteBill(bill))
            {
                MessageBox.Show("Unable to delete bill!");
                return false;
            }
            Session.SessionInformation.GetBudget().Bills.Remove(bill);
            Session.SessionInformation.RefreshSessionLabels();
            return true;
        }

    }
}
