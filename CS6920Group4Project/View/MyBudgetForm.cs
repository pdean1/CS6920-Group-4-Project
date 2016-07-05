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
        ManageEarnings earnForm;
        ManageBills billForm;
        BudgetView budView;

        public MyBudgetForm()
        {
            InitializeComponent();
            this.tabDashBoad();
            this.tabManageExpense();
            this.tabManageEarnings();
            this.tabManageBills();
            this.tabBudgetView();
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
            exform = new ManageExpenses(); 
            exform.TopLevel = false;
            exform.Visible = true;
            exform.FormBorderStyle = FormBorderStyle.None;
            exform.Dock = DockStyle.Fill;
            tabControl1.TabPages[2].Controls.Add(exform);
        }

        private void MyBudgetForm_Load(object sender, EventArgs e)
        {

        }
        private void tabManageEarnings()
        {
             earnForm = new ManageEarnings();
             this.earnForm.TopLevel = false;
             this.earnForm.Visible = true;
             this.earnForm.FormBorderStyle = FormBorderStyle.None;
             this.earnForm.Dock = DockStyle.Fill;
             tabControl1.TabPages[1].Controls.Add(earnForm);        
          
        }
        private void tabManageBills()
        {
             billForm = new ManageBills();
             this.billForm.TopLevel = false;
             this.billForm.Visible = true;
             this.billForm.FormBorderStyle = FormBorderStyle.None;
             this.billForm.Dock = DockStyle.Fill;
             tabControl1.TabPages[3].Controls.Add(billForm);
           
        }

        private void tabBudgetView()
        {
             budView = new BudgetView();
             this.budView.TopLevel = false;
             this.budView.Visible = true;
             this.budView.FormBorderStyle = FormBorderStyle.None;
             this.budView.Dock = DockStyle.Fill;
             tabControl1.TabPages[4].Controls.Add(budView);
            
        }
       
    }
}
