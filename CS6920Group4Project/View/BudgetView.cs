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
using CS6920Group4Project.Controller;

namespace CS6920Group4Project.View
{
    public partial class BudgetView : Form
    {
        EarningController earnController;
        ExpenseController expenseController;
        BillController billController;

        public BudgetView()
        {
            InitializeComponent();
            earnController = new EarningController();
            expenseController = new ExpenseController();
            billController = new BillController();
        }

        private void BudgetView_Load(object sender, EventArgs e)
        {
            int budgetID = 1;

            List<Earning> earningsList = earnController.GetEarningsByBudgetID(budgetID);
            for (int i = 0; i < earningsList.Count; i++)
            {
                Earning earning = earningsList[i];
                ListViewItem item = new ListViewItem(new[] {earning.Title.ToString(), earning.Description.ToString(), 
                earning.Category.Description.ToString(), earning.Category.Title.ToString(),
                earning.Amount.ToString(), earning.DateEarned.ToString()});
                earnView.Items.Add(item);
            }

            List<Bill> billList = billController.GetBillsByBudgetID(budgetID);
            for (int i = 0; i < billList.Count; i++)
            {
                Bill bill = billList[i];
                ListViewItem item = new ListViewItem(new[] {bill.Title.ToString(), bill.Amount.ToString(),
                bill.DateDue.ToString(), bill.Description.ToString(), bill.DatePaid.ToString()});
                billView.Items.Add(item);

            }
            List<Expense> expenseList = expenseController.GetExpensesByBudgetID(budgetID);
            for (int i = 0; i < expenseList.Count; i++)
            {
                Expense expense = expenseList[i];
                ListViewItem item = new ListViewItem(new[] {expense.Title.ToString(), expense.DateSpent.ToString(),
                expense.Description.ToString(), expense.Amount.ToString(), expense.Category.Description.ToString()});
                expenseView.Items.Add(item);


            }
        }

    }
}
