﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS6920Group4Project.Model;
using CS6920Group4Project.Controller;
using CS6920Group4Project.Utilities;

namespace CS6920Group4Project.View
{
    public partial class BudgetView : Form
    {
        public BudgetView()
        {
            InitializeComponent();
        }

        private void BudgetView_Load(object sender, EventArgs e)
        {
            List<Earning> earningsList = Session.SessionInformation.GetBudget().Earnings;
            for (int i = 0; i < earningsList.Count; i++)
            {
                Earning earning = earningsList[i];
                ListViewItem item = new ListViewItem(new[] {
                    earning.Title.ToString(), 
                    (String.IsNullOrEmpty(earning.Description)) ? "" : earning.Description.ToString(), 
                    StringUtilities.GetDisplayableDollarAmount(earning.Amount), 
                    earning.DateEarned.ToString()});
                earnView.Items.Add(item);
            }

            List<Bill> billList = Session.SessionInformation.GetBudget().Bills;
            for (int i = 0; i < billList.Count; i++)
            {
                Bill bill = billList[i];
                ListViewItem item = new ListViewItem(new[] {
                    bill.Title.ToString(),
                    (String.IsNullOrEmpty(bill.Description)) ? "" : bill.Description.ToString(), 
                    StringUtilities.GetDisplayableDollarAmount(bill.Amount),
                    bill.DateDue.ToString(), 
                    bill.DatePaid.ToString()
                });
                billView.Items.Add(item);
            }
            List<Expense> expenseList = Session.SessionInformation.GetBudget().Expenses;
            for (int i = 0; i < expenseList.Count; i++)
            {
                Expense expense = expenseList[i];
                ListViewItem item = new ListViewItem(new[] {
                    expense.Title.ToString(), 
                    expense.DateSpent.ToString(), 
                    (String.IsNullOrEmpty(expense.Description)) ? "" : expense.Description.ToString(), 
                    StringUtilities.GetDisplayableDollarAmount(expense.Amount)
                });
                expenseView.Items.Add(item);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
