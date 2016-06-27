namespace CS6920Group4Project.View
{
    partial class BudgetView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetView));
            this.label1 = new System.Windows.Forms.Label();
            this.expenseView = new System.Windows.Forms.ListView();
            this.expenseCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.earnView = new System.Windows.Forms.ListView();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.earning = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateEarned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billView = new System.Windows.Forms.ListView();
            this.billTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datePaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.budgetVewPnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.budgetVewPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(634, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Budget";
            // 
            // expenseView
            // 
            this.expenseView.BackColor = System.Drawing.Color.SkyBlue;
            this.expenseView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.expenseTitle,
            this.expenseDate,
            this.expenseDescription,
            this.expenseAmount,
            this.expenseCategory});
            this.expenseView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.expenseView.Location = new System.Drawing.Point(27, 346);
            this.expenseView.Name = "expenseView";
            this.expenseView.Size = new System.Drawing.Size(709, 120);
            this.expenseView.TabIndex = 1;
            this.expenseView.UseCompatibleStateImageBehavior = false;
            this.expenseView.View = System.Windows.Forms.View.Details;
            // 
            // expenseCategory
            // 
            this.expenseCategory.Text = "Category";
            this.expenseCategory.Width = 92;
            // 
            // expenseTitle
            // 
            this.expenseTitle.Text = "Expense Title";
            this.expenseTitle.Width = 120;
            // 
            // expenseDescription
            // 
            this.expenseDescription.Text = "Description";
            this.expenseDescription.Width = 121;
            // 
            // expenseDate
            // 
            this.expenseDate.Text = "Date";
            this.expenseDate.Width = 107;
            // 
            // expenseAmount
            // 
            this.expenseAmount.Text = "Amount";
            this.expenseAmount.Width = 102;
            // 
            // earnView
            // 
            this.earnView.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.earnView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.description,
            this.category,
            this.earning,
            this.amount,
            this.dateEarned});
            this.earnView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earnView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.earnView.Location = new System.Drawing.Point(27, 39);
            this.earnView.Name = "earnView";
            this.earnView.Size = new System.Drawing.Size(709, 123);
            this.earnView.TabIndex = 2;
            this.earnView.UseCompatibleStateImageBehavior = false;
            this.earnView.View = System.Windows.Forms.View.Details;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 112;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 109;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 120;
            // 
            // earning
            // 
            this.earning.Text = "Earning Title";
            this.earning.Width = 117;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 122;
            // 
            // dateEarned
            // 
            this.dateEarned.Text = "Date";
            this.dateEarned.Width = 83;
            // 
            // billView
            // 
            this.billView.BackColor = System.Drawing.Color.AliceBlue;
            this.billView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.billTitle,
            this.billAmount,
            this.dueDate,
            this.billDescription,
            this.billBalance,
            this.datePaid});
            this.billView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.billView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.billView.Location = new System.Drawing.Point(27, 190);
            this.billView.Name = "billView";
            this.billView.Size = new System.Drawing.Size(709, 121);
            this.billView.TabIndex = 3;
            this.billView.UseCompatibleStateImageBehavior = false;
            this.billView.View = System.Windows.Forms.View.Details;
            // 
            // billTitle
            // 
            this.billTitle.Text = "Bill Title";
            this.billTitle.Width = 111;
            // 
            // billAmount
            // 
            this.billAmount.DisplayIndex = 3;
            this.billAmount.Text = "Amount";
            this.billAmount.Width = 112;
            // 
            // dueDate
            // 
            this.dueDate.Text = "Date Due";
            this.dueDate.Width = 120;
            // 
            // billDescription
            // 
            this.billDescription.DisplayIndex = 4;
            this.billDescription.Text = "Description";
            this.billDescription.Width = 118;
            // 
            // billBalance
            // 
            this.billBalance.DisplayIndex = 1;
            this.billBalance.Text = "Balance";
            this.billBalance.Width = 111;
            // 
            // datePaid
            // 
            this.datePaid.Text = "Date Paid";
            this.datePaid.Width = 92;
            // 
            // budgetVewPnl
            // 
            this.budgetVewPnl.BackColor = System.Drawing.Color.White;
            this.budgetVewPnl.Controls.Add(this.label4);
            this.budgetVewPnl.Controls.Add(this.label3);
            this.budgetVewPnl.Controls.Add(this.label2);
            this.budgetVewPnl.Controls.Add(this.expenseView);
            this.budgetVewPnl.Controls.Add(this.billView);
            this.budgetVewPnl.Controls.Add(this.earnView);
            this.budgetVewPnl.Location = new System.Drawing.Point(327, 255);
            this.budgetVewPnl.Name = "budgetVewPnl";
            this.budgetVewPnl.Size = new System.Drawing.Size(762, 477);
            this.budgetVewPnl.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(332, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Expenses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(344, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bills";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(329, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Earnings";
            // 
            // BudgetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 762);
            this.Controls.Add(this.budgetVewPnl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BudgetView";
            this.Text = "BudgetView";
            this.Load += new System.EventHandler(this.BudgetView_Load);
            this.budgetVewPnl.ResumeLayout(false);
            this.budgetVewPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView expenseView;
        private System.Windows.Forms.ColumnHeader expenseTitle;
        private System.Windows.Forms.ColumnHeader expenseDate;
        private System.Windows.Forms.ListView earnView;
        private System.Windows.Forms.ListView billView;
        private System.Windows.Forms.ColumnHeader billTitle;
        private System.Windows.Forms.ColumnHeader billBalance;
        private System.Windows.Forms.Panel budgetVewPnl;
        private System.Windows.Forms.ColumnHeader dueDate;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader earning;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader dateEarned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader billAmount;
        private System.Windows.Forms.ColumnHeader billDescription;
        private System.Windows.Forms.ColumnHeader datePaid;
        private System.Windows.Forms.ColumnHeader expenseDescription;
        private System.Windows.Forms.ColumnHeader expenseAmount;
        private System.Windows.Forms.ColumnHeader expenseCategory;
    }
}