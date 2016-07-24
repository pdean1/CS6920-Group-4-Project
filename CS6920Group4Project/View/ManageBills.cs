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
        private const int EditCol = 6, DeleteCol = 7;

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
                    newBill.BudgetID = Session.SessionInformation.GetBudget().ID;

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
            this.buildView();
        }

        private void buildView()
        {
            dgBills.ColumnCount = 6;

            dgBills.Columns[0].Name = "Record ID";
            dgBills.Columns[0].Visible = false;
            dgBills.Columns[1].Name = "Title";
            dgBills.Columns[2].Name = "Description";
            dgBills.Columns[3].Name = "Amount";
            dgBills.Columns[4].Name = "Date Due";
            dgBills.Columns[5].Name = "Date Paid";
            dgBills.Columns[4].ReadOnly = true;
            dgBills.Columns[5].ReadOnly = true;
            dgBills.Columns[3].DefaultCellStyle.Format = "c";
            dgBills.Columns[4].DefaultCellStyle.Format = "d";
            dgBills.Columns[5].DefaultCellStyle.Format = "d";
            

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
            if (e.ColumnIndex == EditCol)
            {
                int id = Int32.Parse(dgBills.Rows[e.RowIndex].Cells[0].Value.ToString());
                Bill selectedBill = Session.SessionInformation.GetBudget().
                                                    GetSelectedBill(id);

                String title = dgBills.Rows[e.RowIndex].Cells[1].Value.ToString();
                String desc = dgBills.Rows[e.RowIndex].Cells[2].Value.ToString();
                String sendAmount = dgBills.Rows[e.RowIndex].Cells[3].Value.ToString();

                selectedBill.Title = title;
                selectedBill.Description = desc;
                try
                {
                    Decimal d = Convert.ToDecimal(sendAmount);
                    selectedBill.Amount = d;
                }
                catch (Exception)
                {
                    MessageBox.Show("Amount invalid: " + dgBills.Rows[e.RowIndex].Cells[3].Value.ToString());
                    dgBills.Rows[e.RowIndex].Cells[3].Value = Utilities.StringUtilities.Get4PointDecimal(selectedBill.Amount);
                    return;

                }

                bool update = BillController.Instance.EditBills(selectedBill);

                if (update == true)
                {
                    MessageBox.Show("Bills Successfully Updated");
                    Session.SessionInformation.RefreshSessionLabels();
                }
                else
                {
                    MessageBox.Show("Bills not Updated, please try again!");
                }
            }
            else if (e.ColumnIndex == DeleteCol)
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
            String sDatePaid;
            DateTime billDatePaid;

            if (b.DatePaid != null)
            {
                billDatePaid = Convert.ToDateTime(b.DatePaid);
                sDatePaid = billDatePaid.ToShortDateString();
            }
            else
            {
                sDatePaid = null;
            }
            
            string[] row = new string[] { 
                    b.ID.ToString(), 
                    b.Title, 
                    (String.IsNullOrEmpty(b.Description)) ? "" : b.Description,
                    // StringUtilities.Get4PointDecimal(b.Amount),
                    // b.DateDue.ToString(),
                    // b.DatePaid.ToString()
                    StringUtilities.GetDisplayableDollarAmount(b.Amount),
                    b.DateDue.ToShortDateString(),
                    sDatePaid                    
                };
            dgBills.Rows.Add(row);
        }

        private Boolean DeleteBillClicked(int id)
        {
            Bill bill = Session.SessionInformation.GetBudget().GetSelectedBill(id);
            DialogResult dr = MessageBox.Show(
                "Do you want to delete BILL (Title - " + bill.Title + " Amount - " 
                + Utilities.StringUtilities.GetDisplayableDollarAmount(bill.Amount) + ")?"
                , "DELETE BILL"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
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
            }
            return true;
        }

    }
}
