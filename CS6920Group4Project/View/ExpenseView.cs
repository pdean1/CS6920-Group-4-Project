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
    public partial class ExpenseView : Form
    {
        MySqlDataAdapter mySqlDataAdapter;
        private ManageExpenses manageExpenses;

        public ExpenseView()
        {
            InitializeComponent();
            this.getExpenselist();
        }  

        public void getExpenselist()
        {
            try
            {
                int budgetID = 1;
                mySqlDataAdapter = ExpenseController.Instance.GetExpensesByBudgetIDDataGridView(budgetID);

                DataTable table = new DataTable();               
                mySqlDataAdapter.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;

                dataGridView1.DataSource = bSource;

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[0].Width = 200;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].ReadOnly = true; 
                dataGridView1.Columns[3].ReadOnly = true; 

                //add new button column to the DataGridView
                //This column displays a edit Button in each row
                DataGridViewButtonColumn editbut = new DataGridViewButtonColumn();
                editbut.Text = "EDIT";
                editbut.HeaderText = "Select";
                editbut.Name = "editBtn";
                editbut.Width = 100;
                editbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                editbut.UseColumnTextForButtonValue = true;
                editbut.DefaultCellStyle.BackColor = Color.AntiqueWhite;
                dataGridView1.Columns.Add(editbut);

                //add new button column to the DataGridView
                //This column displays a delete Button in each row
                DataGridViewButtonColumn delbut = new DataGridViewButtonColumn();
                delbut.Text = "DELETE";
                delbut.Width = 100;
                delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                delbut.UseColumnTextForButtonValue = true;
                delbut.DefaultCellStyle.BackColor = Color.AntiqueWhite;
                dataGridView1.Columns.Add(delbut);

                dataGridView1.DefaultCellStyle.ForeColor = Color.DarkGreen;
                dataGridView1.DefaultCellStyle.BackColor = Color.AntiqueWhite;              
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

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                ((DataTable)dataGridView1.DataSource).AcceptChanges();
            }
        }

        private void ExpenseView_Load(object sender, EventArgs e)
        {

        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            if (manageExpenses == null)
            {
                manageExpenses = new ManageExpenses(this);
                manageExpenses.FormClosed += new FormClosedEventHandler(ManageExpenses_FormClosed);
                manageExpenses.Show();
            }
            else
                manageExpenses.Activate();
        }

        private void ManageExpenses_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            manageExpenses = null;
        }
                
    }
}
