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
        private const int Dashboard = 0,
                          ManageEarning = 1,
                          ManageExpense = 2,
                          ManageBill = 3,
                          BudgetView = 4;
        public MyBudgetForm()
        {
            InitializeComponent();
            this.tabDashBoad();
            this.tabManageExpenses();
            this.tabManageEarnings();
            this.tabManageBills();
            this.tabBudgetView();
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
        }
        void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            switch (tabControl1.SelectedIndex)
            {
                case Dashboard:
                    tabControl1.TabPages[Dashboard].Controls.Remove(dbform);
                    tabDashBoad();
                    break;
                case ManageEarning:
                    tabControl1.TabPages[ManageEarning].Controls.Add(earnForm);
                    tabManageEarnings();
                    break;
                case ManageExpense:
                    tabControl1.TabPages[ManageExpense].Controls.Add(exform);
                    tabManageExpenses();
                    break;
                case ManageBill:
                    tabControl1.TabPages[ManageBill].Controls.Remove(billForm);
                    tabManageBills();
                    break;
                case BudgetView:
                    tabControl1.TabPages[BudgetView].Controls.Remove(budView);
                    tabBudgetView();
                    break;
                default:
                    throw new NotImplementedException("Tab at index: " + tabControl1.SelectedIndex.ToString() + ", not created.");
                
            }
            return;
        }
        private void tabDashBoad()
        {
            dbform = new Dashboard();
            dbform.TopLevel = false;
            dbform.Visible = true;
            dbform.FormBorderStyle = FormBorderStyle.None;
            dbform.Dock = DockStyle.Fill;
            tabControl1.TabPages[Dashboard].Controls.Add(dbform);
            
        }
        private void tabManageExpenses()
        {
            exform = new ManageExpenses(); 
            exform.TopLevel = false;
            exform.Visible = true;
            exform.FormBorderStyle = FormBorderStyle.None;
            exform.Dock = DockStyle.Fill;
            tabControl1.TabPages[ManageExpense].Controls.Add(exform);
        }
        private void MyBudgetForm_Load(object sender, EventArgs e)
        {
            Session.SessionInformation.SetUserNameSessionLabel(lblUserNamePlaceholder);
            Session.SessionInformation.SetIncomeRemainingSessionLabel(lblIncomeRemainingPlaceholder);
            Session.SessionInformation.RefreshSessionLabels();
        }
        private void tabManageEarnings()
        {
             earnForm = new ManageEarnings();
             this.earnForm.TopLevel = false;
             this.earnForm.Visible = true;
             this.earnForm.FormBorderStyle = FormBorderStyle.None;
             this.earnForm.Dock = DockStyle.Fill;
             tabControl1.TabPages[ManageEarning].Controls.Add(earnForm);
          
        }
        private void tabManageBills()
        {
             billForm = new ManageBills();
             this.billForm.TopLevel = false;
             this.billForm.Visible = true;
             this.billForm.FormBorderStyle = FormBorderStyle.None;
             this.billForm.Dock = DockStyle.Fill;
             tabControl1.TabPages[ManageBill].Controls.Add(billForm);
        }
        private void tabBudgetView()
        {
             budView = new BudgetView();
             this.budView.TopLevel = false;
             this.budView.Visible = true;
             this.budView.FormBorderStyle = FormBorderStyle.None;
             this.budView.Dock = DockStyle.Fill;
             tabControl1.TabPages[BudgetView].Controls.Add(budView);
        }

        /// <summary>
        /// Allows the user to save the current budget as a csv to their desired destination
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            sfd.Filter = "CSV (Comma Delimited *.csv)|*.csv";
            sfd.Title = "Save Budget " + Session.SessionInformation.GetBudget().Title + " to CSV";
            sfd.FileName = Session.SessionInformation.GetBudget().Title;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BudgetCSV csv = new BudgetCSV();
                if (!csv.ExportCSVToFile(sfd.FileName))
                {
                    MessageBox.Show("Unable to export to CSV! Please try again.");
                }
            }
        }
    }
}
