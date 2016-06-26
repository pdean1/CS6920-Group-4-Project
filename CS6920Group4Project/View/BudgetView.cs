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

        }
    }
}
