namespace CS6920Group4Project.View
{
    partial class ManageEarnings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEarnings));
            this.earningsWelcomeLbl = new System.Windows.Forms.Label();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.incomeBtn = new System.Windows.Forms.Button();
            this.incomeBox = new System.Windows.Forms.TextBox();
            this.incomeDescBox = new System.Windows.Forms.TextBox();
            this.incomeAmountBox = new System.Windows.Forms.TextBox();
            this.earningsDashBtn = new System.Windows.Forms.Button();
            this.manageEarningsBtn = new System.Windows.Forms.Button();
            this.manageExpensesBtn = new System.Windows.Forms.Button();
            this.manageBillsBtn = new System.Windows.Forms.Button();
            this.viewBudgetBtn = new System.Windows.Forms.Button();
            this.userNameEarningsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // earningsWelcomeLbl
            // 
            this.earningsWelcomeLbl.AutoSize = true;
            this.earningsWelcomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.earningsWelcomeLbl.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earningsWelcomeLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.earningsWelcomeLbl.Location = new System.Drawing.Point(64, 60);
            this.earningsWelcomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.earningsWelcomeLbl.Name = "earningsWelcomeLbl";
            this.earningsWelcomeLbl.Size = new System.Drawing.Size(175, 21);
            this.earningsWelcomeLbl.TabIndex = 0;
            this.earningsWelcomeLbl.Text = "Currently Logged in As: ";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.incomeLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeLbl.Location = new System.Drawing.Point(353, 236);
            this.incomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(231, 26);
            this.incomeLbl.TabIndex = 2;
            this.incomeLbl.Text = "EARNINGS INFORMATION";
            this.incomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(574, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Earnings Source:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(574, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(574, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(573, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Deposit Date:";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(756, 440);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 7;
            // 
            // incomeBtn
            // 
            this.incomeBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.incomeBtn.ForeColor = System.Drawing.Color.White;
            this.incomeBtn.Location = new System.Drawing.Point(842, 629);
            this.incomeBtn.Name = "incomeBtn";
            this.incomeBtn.Size = new System.Drawing.Size(141, 36);
            this.incomeBtn.TabIndex = 8;
            this.incomeBtn.TabStop = false;
            this.incomeBtn.Text = "Add Income";
            this.incomeBtn.UseVisualStyleBackColor = false;
            // 
            // incomeBox
            // 
            this.incomeBox.Location = new System.Drawing.Point(756, 308);
            this.incomeBox.Name = "incomeBox";
            this.incomeBox.Size = new System.Drawing.Size(227, 28);
            this.incomeBox.TabIndex = 9;
            // 
            // incomeDescBox
            // 
            this.incomeDescBox.Location = new System.Drawing.Point(756, 352);
            this.incomeDescBox.Name = "incomeDescBox";
            this.incomeDescBox.Size = new System.Drawing.Size(227, 28);
            this.incomeDescBox.TabIndex = 10;
            // 
            // incomeAmountBox
            // 
            this.incomeAmountBox.Location = new System.Drawing.Point(756, 395);
            this.incomeAmountBox.Name = "incomeAmountBox";
            this.incomeAmountBox.Size = new System.Drawing.Size(227, 28);
            this.incomeAmountBox.TabIndex = 11;
            // 
            // earningsDashBtn
            // 
            this.earningsDashBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.earningsDashBtn.ForeColor = System.Drawing.Color.White;
            this.earningsDashBtn.Location = new System.Drawing.Point(1218, 236);
            this.earningsDashBtn.Name = "earningsDashBtn";
            this.earningsDashBtn.Size = new System.Drawing.Size(175, 53);
            this.earningsDashBtn.TabIndex = 14;
            this.earningsDashBtn.Text = "DashBoard";
            this.earningsDashBtn.UseVisualStyleBackColor = false;
            this.earningsDashBtn.Click += new System.EventHandler(this.earningsDashBtn_Click);
            // 
            // manageEarningsBtn
            // 
            this.manageEarningsBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.manageEarningsBtn.ForeColor = System.Drawing.Color.White;
            this.manageEarningsBtn.Location = new System.Drawing.Point(1218, 308);
            this.manageEarningsBtn.Name = "manageEarningsBtn";
            this.manageEarningsBtn.Size = new System.Drawing.Size(175, 53);
            this.manageEarningsBtn.TabIndex = 16;
            this.manageEarningsBtn.Text = "Manage Earnings";
            this.manageEarningsBtn.UseVisualStyleBackColor = false;
            this.manageEarningsBtn.Click += new System.EventHandler(this.manageEarningsBtn_Click);
            // 
            // manageExpensesBtn
            // 
            this.manageExpensesBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.manageExpensesBtn.ForeColor = System.Drawing.Color.White;
            this.manageExpensesBtn.Location = new System.Drawing.Point(1218, 381);
            this.manageExpensesBtn.Name = "manageExpensesBtn";
            this.manageExpensesBtn.Size = new System.Drawing.Size(175, 53);
            this.manageExpensesBtn.TabIndex = 17;
            this.manageExpensesBtn.Text = "Manage Expenses";
            this.manageExpensesBtn.UseVisualStyleBackColor = false;
            this.manageExpensesBtn.Click += new System.EventHandler(this.manageExpensesBtn_Click);
            // 
            // manageBillsBtn
            // 
            this.manageBillsBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.manageBillsBtn.ForeColor = System.Drawing.Color.White;
            this.manageBillsBtn.Location = new System.Drawing.Point(1218, 456);
            this.manageBillsBtn.Name = "manageBillsBtn";
            this.manageBillsBtn.Size = new System.Drawing.Size(175, 53);
            this.manageBillsBtn.TabIndex = 18;
            this.manageBillsBtn.Text = "Manage Bills";
            this.manageBillsBtn.UseVisualStyleBackColor = false;
            this.manageBillsBtn.Click += new System.EventHandler(this.manageBillsBtn_Click);
            // 
            // viewBudgetBtn
            // 
            this.viewBudgetBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.viewBudgetBtn.ForeColor = System.Drawing.Color.White;
            this.viewBudgetBtn.Location = new System.Drawing.Point(1218, 530);
            this.viewBudgetBtn.Name = "viewBudgetBtn";
            this.viewBudgetBtn.Size = new System.Drawing.Size(175, 53);
            this.viewBudgetBtn.TabIndex = 19;
            this.viewBudgetBtn.Text = "View Budget";
            this.viewBudgetBtn.UseVisualStyleBackColor = false;
            // 
            // userNameEarningsLbl
            // 
            this.userNameEarningsLbl.AutoSize = true;
            this.userNameEarningsLbl.BackColor = System.Drawing.Color.Transparent;
            this.userNameEarningsLbl.Location = new System.Drawing.Point(247, 60);
            this.userNameEarningsLbl.Name = "userNameEarningsLbl";
            this.userNameEarningsLbl.Size = new System.Drawing.Size(98, 21);
            this.userNameEarningsLbl.TabIndex = 21;
            this.userNameEarningsLbl.Text = "User\'s Name";
            // 
            // ManageEarnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1437, 762);
            this.Controls.Add(this.userNameEarningsLbl);
            this.Controls.Add(this.viewBudgetBtn);
            this.Controls.Add(this.manageBillsBtn);
            this.Controls.Add(this.manageExpensesBtn);
            this.Controls.Add(this.manageEarningsBtn);
            this.Controls.Add(this.earningsDashBtn);
            this.Controls.Add(this.incomeAmountBox);
            this.Controls.Add(this.incomeDescBox);
            this.Controls.Add(this.incomeBox);
            this.Controls.Add(this.incomeBtn);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.incomeLbl);
            this.Controls.Add(this.earningsWelcomeLbl);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageEarnings";
            this.Text = "Manage Earnings";
            this.Load += new System.EventHandler(this.ManageEarnings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label earningsWelcomeLbl;
        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button incomeBtn;
        private System.Windows.Forms.TextBox incomeBox;
        private System.Windows.Forms.TextBox incomeDescBox;
        private System.Windows.Forms.TextBox incomeAmountBox;
        private System.Windows.Forms.Button earningsDashBtn;
        private System.Windows.Forms.Button manageEarningsBtn;
        private System.Windows.Forms.Button manageExpensesBtn;
        private System.Windows.Forms.Button manageBillsBtn;
        private System.Windows.Forms.Button viewBudgetBtn;
        private System.Windows.Forms.Label userNameEarningsLbl;

    }
}