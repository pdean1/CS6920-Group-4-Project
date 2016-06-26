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
                ListViewItem item = new ListViewItem();
                earnView.Items.Add((i + 1).ToString());
                earnView.Items[i].SubItems.Add(earning.Title.ToString());
                earnView.Items[i].SubItems.Add(earning.Description.ToString());
                earnView.Items[i].SubItems.Add(earning.Category.Description.ToString());
                earnView.Items[i].SubItems.Add(earning.Category.Title.ToString());
                earnView.Items[i].SubItems.Add(earning.Amount.ToString());
                earnView.Items[i].SubItems.Add(earning.DateEarned.ToString());
            }
           
            List<Bill> billList = billController.GetBillsByBudgetID(budgetID);
            for (int i = 0; i < billList.Count; i++)
            {
                Bill bill = billList[i];
                ListViewItem item = new ListViewItem();
                billView.Items.Add((i + 1).ToString());
                billView.Items[i].SubItems.Add(bill.Title.ToString());
                billView.Items[i].SubItems.Add(bill.Amount.ToString());
                billView.Items[i].SubItems.Add(bill.DateDue.ToString());
                billView.Items[i].SubItems.Add(bill.Description.ToString());
                billView.Items[i].SubItems.Add(bill.DatePaid.ToString());
                               
            }
            List<Expense> expenseList = expenseController.GetExpensesByBudgetID(budgetID);
            for (int i = 0; i < expenseList.Count; i++)
            {
                Expense expense = expenseList[i];
                ListViewItem item = new ListViewItem();
                expenseView.Items.Add((i + 1).ToString());
                expenseView.Items[i].SubItems.Add(expense.Title.ToString());
                expenseView.Items[i].SubItems.Add(expense.DateSpent.ToString());
                expenseView.Items[i].SubItems.Add(expense.Description.ToString());
                expenseView.Items[i].SubItems.Add(expense.Amount.ToString());
                expenseView.Items[i].SubItems.Add(expense.Category.Description.ToString());


            }
        }

    }
}
