namespace CS6920Group4Project.View
{
    partial class WelcomeParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeParent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBudgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBudgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.budgetToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1434, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signUpToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // signUpToolStripMenuItem
            // 
            this.signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            this.signUpToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.signUpToolStripMenuItem.Text = "Sign up";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // budgetToolStripMenuItem
            // 
            this.budgetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageBudgetToolStripMenuItem,
            this.viewBudgetToolStripMenuItem,
            this.manageIncomeToolStripMenuItem});
            this.budgetToolStripMenuItem.Name = "budgetToolStripMenuItem";
            this.budgetToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.budgetToolStripMenuItem.Text = "Budget";
            // 
            // manageBudgetToolStripMenuItem
            // 
            this.manageBudgetToolStripMenuItem.Name = "manageBudgetToolStripMenuItem";
            this.manageBudgetToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.manageBudgetToolStripMenuItem.Text = "Create a Budget";
            this.manageBudgetToolStripMenuItem.Click += new System.EventHandler(this.createBudgetToolStripMenuItem_Click);
            // 
            // viewBudgetToolStripMenuItem
            // 
            this.viewBudgetToolStripMenuItem.Name = "viewBudgetToolStripMenuItem";
            this.viewBudgetToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.viewBudgetToolStripMenuItem.Text = "View Budget";
            this.viewBudgetToolStripMenuItem.Click += new System.EventHandler(this.viewBudgetToolStripMenuItem_Click);
            // 
            // manageIncomeToolStripMenuItem
            // 
            this.manageIncomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomeToolStripMenuItem,
            this.expensesToolStripMenuItem,
            this.billsToolStripMenuItem});
            this.manageIncomeToolStripMenuItem.Name = "manageIncomeToolStripMenuItem";
            this.manageIncomeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.manageIncomeToolStripMenuItem.Text = "Manage";
            this.manageIncomeToolStripMenuItem.Click += new System.EventHandler(this.manageIncomeToolStripMenuItem_Click);
            // 
            // incomeToolStripMenuItem
            // 
            this.incomeToolStripMenuItem.Name = "incomeToolStripMenuItem";
            this.incomeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.incomeToolStripMenuItem.Text = "Earnings";
            this.incomeToolStripMenuItem.Click += new System.EventHandler(this.incomeToolStripMenuItem_Click);
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.expensesToolStripMenuItem.Text = "Expenses";
            this.expensesToolStripMenuItem.Click += new System.EventHandler(this.expensesToolStripMenuItem_Click);
            // 
            // billsToolStripMenuItem
            // 
            this.billsToolStripMenuItem.Name = "billsToolStripMenuItem";
            this.billsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.billsToolStripMenuItem.Text = "Bills";
            this.billsToolStripMenuItem.Click += new System.EventHandler(this.billsToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // WelcomeParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1434, 812);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WelcomeParent";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.WelcomeParent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem budgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBudgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBudgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billsToolStripMenuItem;
    }
}