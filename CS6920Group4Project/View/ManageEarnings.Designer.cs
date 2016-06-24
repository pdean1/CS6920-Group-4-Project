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
            this.addEarningsBtn = new System.Windows.Forms.Button();
            this.earningTypeBox = new System.Windows.Forms.TextBox();
            this.earningDescBox = new System.Windows.Forms.TextBox();
            this.earningAmountBox = new System.Windows.Forms.TextBox();
            this.earningsDashBtn = new System.Windows.Forms.Button();
            this.manageExpensesBtn = new System.Windows.Forms.Button();
            this.manageBillsBtn = new System.Windows.Forms.Button();
            this.viewBudgetBtn = new System.Windows.Forms.Button();
            this.userNameEarningsLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
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
            this.incomeLbl.Location = new System.Drawing.Point(330, 193);
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
            this.label2.Location = new System.Drawing.Point(573, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type:";
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
            // addEarningsBtn
            // 
            this.addEarningsBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addEarningsBtn.ForeColor = System.Drawing.Color.White;
            this.addEarningsBtn.Location = new System.Drawing.Point(842, 629);
            this.addEarningsBtn.Name = "addEarningsBtn";
            this.addEarningsBtn.Size = new System.Drawing.Size(141, 36);
            this.addEarningsBtn.TabIndex = 8;
            this.addEarningsBtn.TabStop = false;
            this.addEarningsBtn.Text = "Add Earnings";
            this.addEarningsBtn.UseVisualStyleBackColor = false;
            this.addEarningsBtn.Click += new System.EventHandler(this.addEarningsBtn_Click);
            // 
            // earningTypeBox
            // 
            this.earningTypeBox.Location = new System.Drawing.Point(756, 308);
            this.earningTypeBox.Name = "earningTypeBox";
            this.earningTypeBox.Size = new System.Drawing.Size(227, 28);
            this.earningTypeBox.TabIndex = 9;
            // 
            // earningDescBox
            // 
            this.earningDescBox.Location = new System.Drawing.Point(756, 352);
            this.earningDescBox.Name = "earningDescBox";
            this.earningDescBox.Size = new System.Drawing.Size(227, 28);
            this.earningDescBox.TabIndex = 10;
            // 
            // earningAmountBox
            // 
            this.earningAmountBox.Location = new System.Drawing.Point(756, 395);
            this.earningAmountBox.Name = "earningAmountBox";
            this.earningAmountBox.Size = new System.Drawing.Size(227, 28);
            this.earningAmountBox.TabIndex = 11;
            // 
            // earningsDashBtn
            // 
            this.earningsDashBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.earningsDashBtn.ForeColor = System.Drawing.Color.White;
            this.earningsDashBtn.Location = new System.Drawing.Point(1215, 243);
            this.earningsDashBtn.Name = "earningsDashBtn";
            this.earningsDashBtn.Size = new System.Drawing.Size(175, 53);
            this.earningsDashBtn.TabIndex = 14;
            this.earningsDashBtn.Text = "DashBoard";
            this.earningsDashBtn.UseVisualStyleBackColor = false;
            this.earningsDashBtn.Click += new System.EventHandler(this.earningsDashBtn_Click);
            // 
            // manageExpensesBtn
            // 
            this.manageExpensesBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.manageExpensesBtn.ForeColor = System.Drawing.Color.White;
            this.manageExpensesBtn.Location = new System.Drawing.Point(1215, 316);
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
            this.manageBillsBtn.Location = new System.Drawing.Point(1215, 391);
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
            this.viewBudgetBtn.Location = new System.Drawing.Point(1215, 465);
            this.viewBudgetBtn.Name = "viewBudgetBtn";
            this.viewBudgetBtn.Size = new System.Drawing.Size(175, 53);
            this.viewBudgetBtn.TabIndex = 19;
            this.viewBudgetBtn.Text = "View Budget";
            this.viewBudgetBtn.UseVisualStyleBackColor = false;
            this.viewBudgetBtn.Click += new System.EventHandler(this.viewBudgetBtn_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(574, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Title *";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(756, 268);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(100, 28);
            this.titleTxt.TabIndex = 25;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(756, 629);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 36);
            this.cancelBtn.TabIndex = 26;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ManageEarnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1437, 762);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userNameEarningsLbl);
            this.Controls.Add(this.viewBudgetBtn);
            this.Controls.Add(this.manageBillsBtn);
            this.Controls.Add(this.manageExpensesBtn);
            this.Controls.Add(this.earningsDashBtn);
            this.Controls.Add(this.earningAmountBox);
            this.Controls.Add(this.earningDescBox);
            this.Controls.Add(this.earningTypeBox);
            this.Controls.Add(this.addEarningsBtn);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.Button addEarningsBtn;
        private System.Windows.Forms.TextBox earningTypeBox;
        private System.Windows.Forms.TextBox earningDescBox;
        private System.Windows.Forms.TextBox earningAmountBox;
        private System.Windows.Forms.Button earningsDashBtn;
        private System.Windows.Forms.Button manageExpensesBtn;
        private System.Windows.Forms.Button manageBillsBtn;
        private System.Windows.Forms.Button viewBudgetBtn;
        private System.Windows.Forms.Label userNameEarningsLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Button cancelBtn;

    }
}