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
using CS6920Group4Project.Utilities;


namespace CS6920Group4Project.View
{
    public partial class MyBudgetForm : Form
    {
        Dashboard dbform;
        ManageExpenses exform;
        ExpenseView exViewForm;

        public MyBudgetForm()
        {
            InitializeComponent();
            this.tabDashBoad();
            this.tabManageExpense();
        }
        
        private void tabDashBoad()
        {
            dbform = new Dashboard();
            dbform.TopLevel = false;
            dbform.Visible = true;
            dbform.FormBorderStyle = FormBorderStyle.None;
            dbform.Dock = DockStyle.Fill;
            tabControl1.TabPages[0].Controls.Add(dbform);
        }

        private void tabManageExpense()
        {
            exViewForm = new ExpenseView();
            exViewForm.TopLevel = false;
            exViewForm.Visible = true;
            exViewForm.FormBorderStyle = FormBorderStyle.None;
            exViewForm.Dock = DockStyle.Fill;
            tabControl1.TabPages[2].Controls.Add(exViewForm);
        }

    }
}
