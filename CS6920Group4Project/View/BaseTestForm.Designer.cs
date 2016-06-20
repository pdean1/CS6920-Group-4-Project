namespace CS6920Group4Project.View
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.tipsPnl = new System.Windows.Forms.Panel();
            this.dashboardpnl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportBtn = new System.Windows.Forms.Button();
            this.btnManageEarnings = new System.Windows.Forms.Button();
            this.btnManageExpenses = new System.Windows.Forms.Button();
            this.billsBtn = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.budgetBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnManageReports = new System.Windows.Forms.Button();
            this.btnManageBudgets = new System.Windows.Forms.Button();
            this.btnManageBills = new System.Windows.Forms.Button();
            this.HeaderPnl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPnl.Controls.Add(this.balanceLbl);
            this.HeaderPnl.Controls.Add(this.welcomeLbl);
            this.HeaderPnl.Location = new System.Drawing.Point(22, 6);
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.Size = new System.Drawing.Size(1338, 183);
            this.HeaderPnl.TabIndex = 0;
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.balanceLbl.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.balanceLbl.Location = new System.Drawing.Point(540, 52);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(183, 22);
            this.balanceLbl.TabIndex = 8;
            this.balanceLbl.Text = "Your Current balance is:";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLbl.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.welcomeLbl.Location = new System.Drawing.Point(141, 52);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(79, 22);
            this.welcomeLbl.TabIndex = 7;
            this.welcomeLbl.Text = "Welcome";
            this.welcomeLbl.Click += new System.EventHandler(this.welcomeLbl_Click);
            // 
            // tipsPnl
            // 
            this.tipsPnl.BackColor = System.Drawing.Color.Transparent;
            this.tipsPnl.Location = new System.Drawing.Point(22, 195);
            this.tipsPnl.Name = "tipsPnl";
            this.tipsPnl.Size = new System.Drawing.Size(182, 555);
            this.tipsPnl.TabIndex = 1;
            // 
            // dashboardpnl
            // 
            this.dashboardpnl.BackColor = System.Drawing.Color.Transparent;
            this.dashboardpnl.Location = new System.Drawing.Point(211, 195);
            this.dashboardpnl.Name = "dashboardpnl";
            this.dashboardpnl.Size = new System.Drawing.Size(930, 555);
            this.dashboardpnl.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnManageReports);
            this.panel3.Controls.Add(this.btnManageBudgets);
            this.panel3.Controls.Add(this.btnManageBills);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.reportBtn);
            this.panel3.Controls.Add(this.btnManageEarnings);
            this.panel3.Controls.Add(this.btnManageExpenses);
            this.panel3.Controls.Add(this.billsBtn);
            this.panel3.Controls.Add(this.btnDashBoard);
            this.panel3.Controls.Add(this.budgetBtn);
            this.panel3.Location = new System.Drawing.Point(1148, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 555);
            this.panel3.TabIndex = 3;
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(364, 436);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(113, 23);
            this.reportBtn.TabIndex = 15;
            this.reportBtn.Text = "Reports";
            this.reportBtn.UseVisualStyleBackColor = true;
            // 
            // btnManageEarnings
            // 
            this.btnManageEarnings.BackColor = System.Drawing.Color.ForestGreen;
            this.btnManageEarnings.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEarnings.ForeColor = System.Drawing.Color.MintCream;
            this.btnManageEarnings.Location = new System.Drawing.Point(-273, 241);
            this.btnManageEarnings.Name = "btnManageEarnings";
            this.btnManageEarnings.Size = new System.Drawing.Size(165, 34);
            this.btnManageEarnings.TabIndex = 17;
            this.btnManageEarnings.Text = "Manage Earnings";
            this.btnManageEarnings.UseVisualStyleBackColor = false;
            // 
            // btnManageExpenses
            // 
            this.btnManageExpenses.BackColor = System.Drawing.Color.ForestGreen;
            this.btnManageExpenses.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageExpenses.ForeColor = System.Drawing.Color.MintCream;
            this.btnManageExpenses.Location = new System.Drawing.Point(-255, 158);
            this.btnManageExpenses.Name = "btnManageExpenses";
            this.btnManageExpenses.Size = new System.Drawing.Size(147, 34);
            this.btnManageExpenses.TabIndex = 18;
            this.btnManageExpenses.Text = "Manage Expenses";
            this.btnManageExpenses.UseVisualStyleBackColor = false;
            // 
            // billsBtn
            // 
            this.billsBtn.Location = new System.Drawing.Point(364, 298);
            this.billsBtn.Name = "billsBtn";
            this.billsBtn.Size = new System.Drawing.Size(113, 23);
            this.billsBtn.TabIndex = 13;
            this.billsBtn.Text = "Manage Bills";
            this.billsBtn.UseVisualStyleBackColor = true;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDashBoard.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.MintCream;
            this.btnDashBoard.Location = new System.Drawing.Point(-255, 96);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(103, 34);
            this.btnDashBoard.TabIndex = 16;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            // 
            // budgetBtn
            // 
            this.budgetBtn.Location = new System.Drawing.Point(373, 375);
            this.budgetBtn.Name = "budgetBtn";
            this.budgetBtn.Size = new System.Drawing.Size(113, 23);
            this.budgetBtn.TabIndex = 14;
            this.budgetBtn.Text = "Manager Budgets";
            this.budgetBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MintCream;
            this.button2.Location = new System.Drawing.Point(24, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "Manage Earnings";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MintCream;
            this.button3.Location = new System.Drawing.Point(24, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 34);
            this.button3.TabIndex = 24;
            this.button3.Text = "Manage Expenses";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(637, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Manage Bills";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.ForestGreen;
            this.button5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.MintCream;
            this.button5.Location = new System.Drawing.Point(24, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 34);
            this.button5.TabIndex = 22;
            this.button5.Text = "DashBoard";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(646, 279);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Manager Budgets";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnManageReports
            // 
            this.btnManageReports.BackColor = System.Drawing.Color.ForestGreen;
            this.btnManageReports.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageReports.ForeColor = System.Drawing.Color.MintCream;
            this.btnManageReports.Location = new System.Drawing.Point(24, 364);
            this.btnManageReports.Name = "btnManageReports";
            this.btnManageReports.Size = new System.Drawing.Size(165, 34);
            this.btnManageReports.TabIndex = 26;
            this.btnManageReports.Text = "Reports";
            this.btnManageReports.UseVisualStyleBackColor = false;
            // 
            // btnManageBudgets
            // 
            this.btnManageBudgets.BackColor = System.Drawing.Color.ForestGreen;
            this.btnManageBudgets.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBudgets.ForeColor = System.Drawing.Color.MintCream;
            this.btnManageBudgets.Location = new System.Drawing.Point(24, 298);
            this.btnManageBudgets.Name = "btnManageBudgets";
            this.btnManageBudgets.Size = new System.Drawing.Size(165, 34);
            this.btnManageBudgets.TabIndex = 27;
            this.btnManageBudgets.Text = "Manage Budgets";
            this.btnManageBudgets.UseVisualStyleBackColor = false;
            // 
            // btnManageBills
            // 
            this.btnManageBills.BackColor = System.Drawing.Color.ForestGreen;
            this.btnManageBills.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBills.ForeColor = System.Drawing.Color.MintCream;
            this.btnManageBills.Location = new System.Drawing.Point(24, 241);
            this.btnManageBills.Name = "btnManageBills";
            this.btnManageBills.Size = new System.Drawing.Size(165, 34);
            this.btnManageBills.TabIndex = 25;
            this.btnManageBills.Text = "Manage Bills";
            this.btnManageBills.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 762);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dashboardpnl);
            this.Controls.Add(this.tipsPnl);
            this.Controls.Add(this.HeaderPnl);
            this.DoubleBuffered = true;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPnl;
        private System.Windows.Forms.Panel tipsPnl;
        private System.Windows.Forms.Panel dashboardpnl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Button btnManageReports;
        private System.Windows.Forms.Button btnManageBudgets;
        private System.Windows.Forms.Button btnManageBills;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button btnManageEarnings;
        private System.Windows.Forms.Button btnManageExpenses;
        private System.Windows.Forms.Button billsBtn;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button budgetBtn;
    }
}