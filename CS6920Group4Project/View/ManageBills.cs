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
    public partial class ManageBills : Form
    {
        private String billDesc;
        private String billAmount;
        private String billDate;
        private String billTitle;

        private List<Budget> budgetList;

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
            billDescTxt.Text = "";
            billCategoryBox.SelectedIndex = -1 ;
            billAmountTxt.Text = "";
            monthCalendar.Text = "";
        }

        private void getUserID()
        {
            budgetList = Session.SessionInformation.GetListOfBudgets();     
        }
    }
}
