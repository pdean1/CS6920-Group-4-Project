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
            this.btnManageReports = new System.Windows.Forms.Button();
            this.btnManageBudgets = new System.Windows.Forms.Button();
            this.btnManageBills = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.btnManageEarnings = new System.Windows.Forms.Button();
            this.btnManageExpenses = new System.Windows.Forms.Button();
            this.billsBtn = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.budgetBtn = new System.Windows.Forms.Button();
            this.cmboxBudget = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewExpense = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.HeaderPnl.SuspendLayout();
            this.tipsPnl.SuspendLayout();
            this.dashboardpnl.SuspendLayout();
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
            this.tipsPnl.Controls.Add(this.label5);
            this.tipsPnl.Controls.Add(this.cmboxBudget);
            this.tipsPnl.Location = new System.Drawing.Point(22, 195);
            this.tipsPnl.Name = "tipsPnl";
            this.tipsPnl.Size = new System.Drawing.Size(320, 555);
            this.tipsPnl.TabIndex = 1;
            // 
            // dashboardpnl
            // 
            this.dashboardpnl.BackColor = System.Drawing.Color.Transparent;
            this.dashboardpnl.Controls.Add(this.dateTimePicker1);
            this.dashboardpnl.Controls.Add(this.btnNewExpense);
            this.dashboardpnl.Controls.Add(this.label4);
            this.dashboardpnl.Controls.Add(this.label2);
            this.dashboardpnl.Controls.Add(this.textBox1);
            this.dashboardpnl.Controls.Add(this.label3);
            this.dashboardpnl.Controls.Add(this.textBox3);
            this.dashboardpnl.Controls.Add(this.labelFirstName);
            this.dashboardpnl.Controls.Add(this.textBox2);
            this.dashboardpnl.Controls.Add(this.label1);
            this.dashboardpnl.Location = new System.Drawing.Point(339, 195);
            this.dashboardpnl.Name = "dashboardpnl";
            this.dashboardpnl.Size = new System.Drawing.Size(813, 555);
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
            // cmboxBudget
            // 
            this.cmboxBudget.BackColor = System.Drawing.Color.ForestGreen;
            this.cmboxBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxBudget.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxBudget.ForeColor = System.Drawing.Color.ForestGreen;
            this.cmboxBudget.FormattingEnabled = true;
            this.cmboxBudget.Location = new System.Drawing.Point(14, 62);
            this.cmboxBudget.Name = "cmboxBudget";
            this.cmboxBudget.Size = new System.Drawing.Size(121, 26);
            this.cmboxBudget.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(217, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Manage Expenses";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelFirstName.Location = new System.Drawing.Point(182, 156);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(111, 22);
            this.labelFirstName.TabIndex = 12;
            this.labelFirstName.Text = "Expense Title:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(193, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Description:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(297, 210);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(276, 130);
            this.textBox3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(193, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Amount:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(193, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Due Date:";
            // 
            // btnNewExpense
            // 
            this.btnNewExpense.AutoSize = true;
            this.btnNewExpense.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNewExpense.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewExpense.ForeColor = System.Drawing.Color.MintCream;
            this.btnNewExpense.Location = new System.Drawing.Point(299, 492);
            this.btnNewExpense.Name = "btnNewExpense";
            this.btnNewExpense.Size = new System.Drawing.Size(165, 34);
            this.btnNewExpense.TabIndex = 27;
            this.btnNewExpense.Text = "Add New Expense";
            this.btnNewExpense.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 420);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(51, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Expenses:";
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
            this.tipsPnl.ResumeLayout(false);
            this.tipsPnl.PerformLayout();
            this.dashboardpnl.ResumeLayout(false);
            this.dashboardpnl.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboxBudget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnNewExpense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBox2;
    }
}