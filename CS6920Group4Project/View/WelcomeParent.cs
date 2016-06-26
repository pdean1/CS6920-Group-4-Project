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

namespace CS6920Group4Project.View
{
    public partial class WelcomeParent : Form        
    { 
        Dashboard dashboard;
        Dashboard dashboardParent;
        private BudgetView viewBudget;
        private ManageBudgets manageBudget;
        private ManageEarnings manageEarnings;
        private ManageExpenses manageExpenses;
        private ManageBills manageBills;

        public WelcomeParent()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.SessionInformation.InitSession();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really wish to exit the program");
            if (dialog == DialogResult.Yes)
            {
                Session.SessionInformation.InitSession();
                 this.Dispose();
            }
            else if (dialog == DialogResult.No)
            {
                this.Close();
            }
            
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the dashboard within the parent form
            if(dashboard == null) {
               dashboard = new Dashboard();
               dashboard.MdiParent = this;
               dashboard.FormClosed += new FormClosedEventHandler(dashboard_FormClosed);
               dashboard.Show();
            }
            else
                dashboard.Activate();
        }

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
 	        dashboard = null;
        }

        private void WelcomeParent_Load(object sender, EventArgs e)
        {
        if(dashboardParent == null) {
            dashboardParent = new Dashboard();
            dashboardParent.MdiParent = this;
            dashboardParent.FormClosed += new FormClosedEventHandler(dashboard_FormClosed);
            dashboardParent.Show();
        }
        else
            dashboardParent.Activate();
        }
        private void dashboardParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboardParent = null;
        }
        
        private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manageEarnings == null)
            {
                manageEarnings = new ManageEarnings();
                manageEarnings.MdiParent = this;
                manageEarnings.FormClosed += new FormClosedEventHandler(ManageEarnings_FormClosed);
                manageEarnings.Show();
            }
            else
                manageEarnings.Activate();
        }

        private void ManageEarnings_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            manageEarnings = null;
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manageExpenses == null)
            {
                manageExpenses = new ManageExpenses();
                manageExpenses.MdiParent = this;
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

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manageBills == null)
            {
                manageBills = new ManageBills();
                manageBills.MdiParent = this;
                manageBills.FormClosed += new FormClosedEventHandler(ManageExpenses_FormClosed);
                manageBills.Show();
            }
            else
                manageBills.Activate();
        }

        private void ManageBills_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            manageBills = null;
        }

        private void createBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //opens the manage budget page within the parent form
                if (manageBudget == null)
                {
                    manageBudget = new ManageBudgets();
                    manageBudget.MdiParent = this;
                    manageBudget.FormClosed += new FormClosedEventHandler(manageBudget_FormClosed);
                    manageBudget.Show();
                }
                else
                    manageBudget.Activate();
            }
        }

        private void manageBudget_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
 	        manageBudget = null;
        }

        private void viewBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the manage budget page within the parent form
            if (viewBudget == null)
            {
                viewBudget = new BudgetView();
                viewBudget.MdiParent = this;
                viewBudget.FormClosed += new FormClosedEventHandler(BudgetView_FormClosed);
                viewBudget.Show();
            }
            else
                viewBudget.Activate();
        }
        private void BudgetView_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            viewBudget = null;
        }

        private void manageIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       
    }   
  }

