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
using System.IO;

namespace CS6920Group4Project.View
{
    public partial class ManageBills : Form
    {
        
        private const int EditCol = 6, DeleteCol = 7;
        //DateTimePicker dtpDatePaid;
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
        DateTimePicker dtpDateDue, dtpDatePaid;

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

        private void ManageBills_Load(object sender, EventArgs e)
        {
            this.billGenerate();
            this.getBillslist();
            this.buildView();
            dgBills.AutoGenerateColumns = false;
            this.AddARow();
        }

        private void billGenerate()
        {
            List<string> Quotes = new List<string>();
            Random rand = new Random();

            StreamReader quoteReader = new StreamReader("billQuotes.txt");
            string line = "";

            while (!quoteReader.EndOfStream)
            {
                line = quoteReader.ReadLine();
                Quotes.Add(line);
            }
            billQuoteTxt.Text = Quotes[rand.Next(1, Quotes.Count)];
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
                dgBills.CellLeave += dgBills_CellLeave;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }       
        }

        void dgBills_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
                dtpDateDue.Visible = false;
            else if (e.ColumnIndex == 7)
                dtpDatePaid.Visible = false;
        }

        void dgBills_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                MessageBox.Show("Invalid Amount!");
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
                if ((selectedBill.Title == title) && 
                    (selectedBill.Description == desc) && 
                    (selectedBill.Amount == Convert.ToDecimal(amount)) &&
                    (selectedBill.DateDue == Convert.ToDateTime(dueDate)) && 
                    (selectedBill.DatePaid == Convert.ToDateTime(paidDate)))
                {
                    MessageBox.Show("There were no changes to the Bill Item, Item was not updated.",
                                           "USER",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Stop);
                    return;
                }

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
            if (e.ColumnIndex == 6)
            {
                dtpDateDue = new DateTimePicker();  //DateTimePicker 
                // Setting the format
                dtpDateDue.Format = DateTimePickerFormat.Custom;
                dtpDateDue.CustomFormat = "MM-dd-yyyy";
                dtpDateDue.Font = new Font("Calbri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));
                if (!String.IsNullOrEmpty(dgBills.Rows[e.RowIndex].Cells[6].Value.ToString()))
                {
                    dtpDateDue.Value = Convert.ToDateTime(dgBills.Rows[e.RowIndex].Cells[6].Value.ToString());
                }

                dtpDateDue.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                // It returns the retangular area that represents the Display area for a cell
                Rectangle oRectangleA = dgBills.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control
                dtpDateDue.Size = new Size(oRectangleA.Width, oRectangleA.Height);

                // Setting Location
                dtpDateDue.Location = new Point(oRectangleA.X, oRectangleA.Y);

                dtpDateDue.CloseUp += new EventHandler(oDateTimePicker_CloseUp);
                //Adding DateTimePicker control into DataGridView 
                dgBills.Controls.Add(dtpDateDue);
            }
            else if (e.ColumnIndex == 7)
            {
                dtpDatePaid = new DateTimePicker();  //DateTimePicker 
                // Setting the format
                dtpDatePaid.Format = DateTimePickerFormat.Custom;
                dtpDatePaid.CustomFormat = "MM-dd-yyyy";
                dtpDatePaid.Font = new Font("Calbri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((Byte)(0)));


                if (!String.IsNullOrEmpty(dgBills.Rows[e.RowIndex].Cells[7].Value.ToString()))
                {
                    dtpDatePaid.Value = Convert.ToDateTime(dgBills.Rows[e.RowIndex].Cells[7].Value.ToString());
                }

                dtpDatePaid.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                // It returns the retangular area that represents the Display area for a cell
                Rectangle oRectangle = dgBills.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control
                dtpDatePaid.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location
                dtpDatePaid.Location = new Point(oRectangle.X, oRectangle.Y);

                dtpDatePaid.CloseUp += new EventHandler(oDateTimePicker_CloseUp);
                //Adding DateTimePicker control into DataGridView 
                dgBills.Controls.Add(dtpDatePaid);
            }
            
        }

        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker) sender;
            dgBills.CurrentCell.Value = dtp.Value;
        }

        private void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            dtp.Visible = false;
        }

        private void dgBills_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 || e.ColumnIndex == 7)
            {
                dateTimeBill(e);
            }
        }
    }
}
