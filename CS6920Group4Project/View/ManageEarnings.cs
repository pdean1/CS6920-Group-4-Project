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
using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.Controller;

namespace CS6920Group4Project.View
{
    public partial class ManageEarnings : Form
    {
        private User user;
        public List<Budget> budgetType;

        public ManageEarnings()
        {
            InitializeComponent();
            
        }

        public ManageEarnings(User userName)
        {
            InitializeComponent();
            user = userName;
            userNameEarningsLbl.Text = user.FirstName + "" + user.LastName;
        }

      

        private void ManageEarnings_Load(object sender, EventArgs e)
        {
            this.LoadBudgetTypeBox();
            
        }
        private void LoadBudgetTypeBox()
        {
            BudgetController bud = new BudgetController();
            try
            { 
                if (budgetType == null)
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

        }

        private void addEarningsBtn_Click(object sender, EventArgs e)
        {
            
            String title = titleTxt.Text;
            String type = earningTypeBox.Text;
            String desc = earningDescBox.Text;
            decimal amount = Decimal.Parse(earningAmountBox.Text);


            Record record = new Record();
            record.Title = title;
            record.Description = desc;

            Earning earn = new Earning();

            //comboBox1.GetItemText();
            EarningController con = new EarningController();
            con.AddEarning(record, earn);
            
        }
        /// <summary>
        /// if desired method to clear all fields before closing or if the user wants to start again (reset)
        /// </summary>
        private void ClearText()
        {
            titleTxt.Text = "";
            earningTypeBox.Text = "";
            earningDescBox.Text = "";
            earningAmountBox.Text = "";
        }
           
    }
}
