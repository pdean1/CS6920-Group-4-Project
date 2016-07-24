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
using MySql.Data.MySqlClient;

namespace CS6920Group4Project.View
{
    public partial class ManageBills : Form
    {
        private String billDesc;
        private String billAmount;
        private String billDate;
        private String billTitle;
        private const int EditCol = 6, DeleteCol = 7;
        DateTimePicker oDateTimePicker;
        private DataTable table;
        private BindingSource bSource;
        private MySqlDataAdapter mySqlDataAdapter;
        private Bill selectedBill;
        private String title;
        private String desc;
        private String amount;
        private String dueDate;
        private String paidDate;
        private String editButton;
        private String deleteButton;
        private String addButton;

        public ManageBills()
        {
            InitializeComponent();
            mySqlDataAdapter = new MySqlDataAdapter();
            table = new DataTable();
            bSource = new BindingSource();
            editButton = "Edit";
            deleteButton = "Delete";
            addButton = "Add";
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
                     //   AddRowToDataGrid(newBill);
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
            this.getBillslist();
            this.buildView();
            dgBills.AutoGenerateColumns = false;
            this.AddARow();
        }

        private void getBillslist()
        {
            try
            {
                int budgetID = Session.SessionInformation.GetBudget().ID;
                mySqlDataAdapter = BillController.Instance.GetListOfBillsByBudgetIDDataGridView(budgetID);
                mySqlDataAdapter.Fill(table);
                bSource.DataSource = table;
                dgBills.DataSource = bSource;
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

        private void buildView()
        {
            try
            {
                dgBills.Columns[0].Visible = false;
                dgBills.Columns[1].Visible = false;
                dgBills.Columns[2].Visible = false;
                dgBills.Columns[3].Width = 175;
                dgBills.Columns[3].Selected = false;
                dgBills.Columns[4].Width = 200;
                dgBills.Columns[5].DefaultCellStyle.Format = "c";
                dgBills.Columns[6].DefaultCellStyle.Format = "d";
                dgBills.Columns[7].DefaultCellStyle.Format = "d";
                dgBills.Columns[8].Visible = false;

                dgBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                dgBills.Columns.Insert(9, addBut);
                
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
                dgBills.Columns.Insert(10, editbut);

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
                dgBills.Columns.Insert(11, delbut);

                dgBills.DataError += dgBills_DataError;           
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }       
        }

        void dgBills_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                MessageBox.Show("Invalid Amount!");
                this.refreshView();
                this.getBillslist();
                e.ThrowException = false;
                return;
            }
        }

        private void refreshView()
        {
            table.Clear();
            dgBills.DataSource = null;
            dgBills.Update();
            dgBills.Refresh();
        }
        
        private void dgBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgBills.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
            {
                string value = dgBills.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (!String.IsNullOrEmpty(value))
                {
                    selectedBill = null;
                    try
                    {
                        selectedBill = Session.SessionInformation.GetBudget().
                                                GetSelectedBill(Convert.ToInt32(value));
                    }
                    catch (Exception)
                    {
                        return;
                    }

                    title = dgBills.Rows[e.RowIndex].Cells[3].Value.ToString();
                    desc = dgBills.Rows[e.RowIndex].Cells[4].Value.ToString();
                    amount = dgBills.Rows[e.RowIndex].Cells[5].Value.ToString();
                    dueDate = dgBills.Rows[e.RowIndex].Cells[6].Value.ToString();
                    paidDate = dgBills.Rows[e.RowIndex].Cells[7].Value.ToString();

                    if (dgBills.Columns[e.ColumnIndex].Name == editButton)
                    {
                        this.editBill(e);
                    }
                    else if (dgBills.Columns[e.ColumnIndex].Name == deleteButton)
                    {
                        this.deleteBill(e);
                    }
                    else
                    {
                        MessageBox.Show("Cannot ADD an existing Bill record.",
                                       "USER",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Stop);
                        return;
                    }
                }
                else
                {
                    if (dgBills.Columns[e.ColumnIndex].Name == addButton)            // add Bill
                    {
                        this.addBill(e);
                    }
                }
            }
        }

        private void deleteBill(DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to delete Bill (Title - "
                                                     + title + " Amount - " + amount
                                                     + " DateDue - " + dueDate + ")?",
                                                       "DELETE Bill",
                                                        MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool isBillDeleted = BillController.Instance.DeleteBill(selectedBill);
                    if (isBillDeleted == true)
                    {
                        Session.SessionInformation.GetBudget().Bills.Remove(selectedBill);
                        Session.SessionInformation.RefreshSessionLabels();
                        dgBills.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete (Title - " + title + " Amount - " + amount
                                                          + ") Bill!",
                                                         "DELETE Bill",
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
        private void editBill(DataGridViewCellEventArgs e)
        {
            try
            {
                selectedBill.Title = title;
                selectedBill.Description = desc;
                selectedBill.DateDue = Convert.ToDateTime(dueDate);
                selectedBill.DatePaid = Convert.ToDateTime(paidDate);

                try
                {
                    Decimal d = Convert.ToDecimal(amount);
                    selectedBill.Amount = d;
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid amount: " + amount);
                    dgBills.Rows[e.RowIndex].Cells[5].Value = Utilities.StringUtilities.Get4PointDecimal(selectedBill.Amount);
                    dgBills.Refresh();
                    return;
                }

                bool update = BillController.Instance.EditBills(selectedBill);

                if (update == true)
                {
                    MessageBox.Show("Bill Successfully Updated");
                    Session.SessionInformation.RefreshSessionLabels();
                }
                else
                {
                    MessageBox.Show("Bill not Updated, please try again!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void addBill(DataGridViewCellEventArgs e)
        {
            try
            {
                title = dgBills.Rows[e.RowIndex].Cells[3].Value.ToString();
                desc = dgBills.Rows[e.RowIndex].Cells[4].Value.ToString();
                amount = dgBills.Rows[e.RowIndex].Cells[5].Value.ToString();
                dueDate = dgBills.Rows[e.RowIndex].Cells[6].Value.ToString();
                paidDate = dgBills.Rows[e.RowIndex].Cells[7].Value.ToString();

                if (String.IsNullOrEmpty(title) || String.IsNullOrEmpty(amount) ||
                    String.IsNullOrEmpty(dueDate))
                {
                    MessageBox.Show("All fields are required, except DatePaid. Please Try Again",
                                    "USER",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    Bill newBill = new Bill();
                    try
                    {
                        newBill.Amount = Convert.ToDecimal(amount);
                    }
                    catch (FormatException fe)
                    {
                        Utilities.DatabaseErrorMessageUtility.SendMessageToUser("Invalid amount format!", fe);
                        return;
                    }

                    newBill.DateCreated = DateTime.Now;
                    newBill.DateDue = DateTime.Parse(dueDate);
                    newBill.DatePaid = DateTime.Parse(paidDate);
                    newBill.Title = title;
                    newBill.Description = desc;
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
                        this.refreshView();
                        this.getBillslist();
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

        private void AddARow()
        {
            try
            {
                table.Rows.Add(table.NewRow());
                dgBills.Rows[dgBills.RowCount - 1].Cells[5].Value = 0.00;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void dateTimeBill(DataGridViewCellEventArgs e)
        {
            try
            {
                oDateTimePicker = new DateTimePicker();  //DateTimePicker 

                //Adding DateTimePicker control into DataGridView 
                dgBills.Controls.Add(oDateTimePicker);

                // Intially made it invisible
                oDateTimePicker.Visible = false;

                // Setting the format
                oDateTimePicker.Format = DateTimePickerFormat.Custom;
                oDateTimePicker.CustomFormat = "MM-dd-yyyy";

                if (dgBills.Columns[e.ColumnIndex].Index == 6)
                {
                    if (!String.IsNullOrEmpty(dgBills.Rows[e.RowIndex].Cells[6].Value.ToString()))
                    {
                        oDateTimePicker.Value = Convert.ToDateTime(dgBills.Rows[e.RowIndex].Cells[6].Value.ToString());
                    }
                }

                if (dgBills.Columns[e.ColumnIndex].Index == 7)
                {
                    if (!String.IsNullOrEmpty(dgBills.Rows[e.RowIndex].Cells[7].Value.ToString()))
                    {
                        oDateTimePicker.Value = Convert.ToDateTime(dgBills.Rows[e.RowIndex].Cells[7].Value.ToString());
                    }
                }

                oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                // Now make it visible
                oDateTimePicker.Visible = true;

                // It returns the retangular area that represents the Display area for a cell
                Rectangle oRectangle = dgBills.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

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
                dgBills.CurrentCell.Value = oDateTimePicker.Text.ToString();
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

        private void dgBills_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgBills.Columns[e.ColumnIndex].Index == 6 || dgBills.Columns[e.ColumnIndex].Index == 7)
            {
                dateTimeBill(e);
            }
        }

 /*     Delete Code  ----------------------------------
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

        private void buildView1()
        {
            dgBills.ColumnCount = 6;

            dgBills.Columns[0].Name = "Record ID";
            dgBills.Columns[0].Visible = false;
            dgBills.Columns[1].Name = "Title";
            dgBills.Columns[2].Name = "Description";
            dgBills.Columns[3].Name = "Amount";
            dgBills.Columns[4].Name = "Date Due";
            dgBills.Columns[5].Name = "Date Paid";
            dgBills.Columns[3].DefaultCellStyle.Format = "c";
            dgBills.Columns[4].DefaultCellStyle.Format = "d";
            dgBills.Columns[5].DefaultCellStyle.Format = "d";

            //            foreach (Bill b in Session.SessionInformation.GetBudget().Bills)
            //            {
            //                AddRowToDataGrid(b);
            //            }

            DataGridViewButtonColumn editBtnCol = new DataGridViewButtonColumn();
            dgBills.Columns.Add(editBtnCol);
            editBtnCol.HeaderText = " ";
            editBtnCol.Text = "Edit Bill";
            editBtnCol.Name = "btnEdit";
            //          editBtnCol.UseColumnTextForButtonValue = true;
            for (int i = 0; i < dgBills.RowCount; i++)
            {
                dgBills.Rows[i].Cells[6].Value = "Update Bill"; //Column Index for the dataGridViewButtonColumn           
            }

            DataGridViewButtonColumn deleteBtnCol = new DataGridViewButtonColumn();
            dgBills.Columns.Add(deleteBtnCol);
            deleteBtnCol.HeaderText = " ";
            deleteBtnCol.Text = "Delete Bill";
            deleteBtnCol.Name = "btnDelete";
            //        deleteBtnCol.UseColumnTextForButtonValue = true;
            dgBills.CellClick += dgBills_CellClick;

            dgBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < dgBills.RowCount; i++)
            {
                dgBills.Rows[i].Cells[7].Value = "Delete Bill"; //Column Index for the dataGridViewButtonColumn  
            }
        }

        private void dgBills1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EditCol)
            {
                int id = Int32.Parse(dgBills.Rows[e.RowIndex].Cells[0].Value.ToString());
                Bill selectedBill = Session.SessionInformation.GetBudget().
                                                    GetSelectedBill(id);

                String title = dgBills.Rows[e.RowIndex].Cells[3].Value.ToString();
                String desc = dgBills.Rows[e.RowIndex].Cells[4].Value.ToString();
                String sendAmount = dgBills.Rows[e.RowIndex].Cells[5].Value.ToString();

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
  */

    }
}
