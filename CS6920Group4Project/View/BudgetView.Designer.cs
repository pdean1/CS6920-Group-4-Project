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
            this.Expenses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeView = new System.Windows.Forms.ListView();
            this.budgetType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billView = new System.Windows.Forms.ListView();
            this.Bills = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.budgetVewPnl = new System.Windows.Forms.Panel();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.earning = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateEarned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.budgetVewPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(641, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Budget";
            // 
            // expenseView
            // 
            this.expenseView.BackColor = System.Drawing.Color.SkyBlue;
            this.expenseView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Expenses,
            this.expenseBalance});
            this.expenseView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.expenseView.Location = new System.Drawing.Point(27, 312);
            this.expenseView.Name = "expenseView";
            this.expenseView.Size = new System.Drawing.Size(709, 97);
            this.expenseView.TabIndex = 1;
            this.expenseView.UseCompatibleStateImageBehavior = false;
            this.expenseView.View = System.Windows.Forms.View.Details;
            // 
            // Expenses
            // 
            this.Expenses.Text = "Expenses";
            this.Expenses.Width = 79;
            // 
            // expenseBalance
            // 
            this.expenseBalance.Text = "Balance";
            this.expenseBalance.Width = 78;
            // 
            // incomeView
            // 
            this.incomeView.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.incomeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateEarned,
            this.budgetType,
            this.title,
            this.description,
            this.category,
            this.earning,
            this.amount});
            this.incomeView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.incomeView.Location = new System.Drawing.Point(27, 40);
            this.incomeView.Name = "incomeView";
            this.incomeView.Size = new System.Drawing.Size(709, 97);
            this.incomeView.TabIndex = 2;
            this.incomeView.UseCompatibleStateImageBehavior = false;
            this.incomeView.View = System.Windows.Forms.View.Details;
            // 
            // budgetType
            // 
            this.budgetType.DisplayIndex = 0;
            this.budgetType.Text = "Budget Type";
            this.budgetType.Width = 105;
            // 
            // billView
            // 
            this.billView.BackColor = System.Drawing.Color.AliceBlue;
            this.billView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Bills,
            this.dueDate,
            this.billBalance});
            this.billView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.billView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.billView.Location = new System.Drawing.Point(27, 179);
            this.billView.Name = "billView";
            this.billView.Size = new System.Drawing.Size(709, 97);
            this.billView.TabIndex = 3;
            this.billView.UseCompatibleStateImageBehavior = false;
            this.billView.View = System.Windows.Forms.View.Details;
            // 
            // Bills
            // 
            this.Bills.Text = "Bills";
            this.Bills.Width = 77;
            // 
            // dueDate
            // 
            this.dueDate.DisplayIndex = 2;
            this.dueDate.Text = "Date Due";
            this.dueDate.Width = 106;
            // 
            // billBalance
            // 
            this.billBalance.DisplayIndex = 1;
            this.billBalance.Text = "Balance";
            this.billBalance.Width = 78;
            // 
            // budgetVewPnl
            // 
            this.budgetVewPnl.BackColor = System.Drawing.Color.White;
            this.budgetVewPnl.Controls.Add(this.label4);
            this.budgetVewPnl.Controls.Add(this.label3);
            this.budgetVewPnl.Controls.Add(this.label2);
            this.budgetVewPnl.Controls.Add(this.expenseView);
            this.budgetVewPnl.Controls.Add(this.billView);
            this.budgetVewPnl.Controls.Add(this.incomeView);
            this.budgetVewPnl.Location = new System.Drawing.Point(327, 255);
            this.budgetVewPnl.Name = "budgetVewPnl";
            this.budgetVewPnl.Size = new System.Drawing.Size(762, 423);
            this.budgetVewPnl.TabIndex = 4;
            // 
            // title
            // 
            this.title.DisplayIndex = 1;
            this.title.Text = "Title";
            this.title.Width = 92;
            // 
            // description
            // 
            this.description.DisplayIndex = 2;
            this.description.Text = "Description";
            this.description.Width = 109;
            // 
            // category
            // 
            this.category.DisplayIndex = 3;
            this.category.Text = "Category";
            this.category.Width = 91;
            // 
            // earning
            // 
            this.earning.DisplayIndex = 4;
            this.earning.Text = "Source";
            this.earning.Width = 86;
            // 
            // amount
            // 
            this.amount.DisplayIndex = 5;
            this.amount.Text = "Amount";
            this.amount.Width = 95;
            // 
            // dateEarned
            // 
            this.dateEarned.DisplayIndex = 6;
            this.dateEarned.Text = "Date";
            this.dateEarned.Width = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(329, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Earnings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(344, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bills";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(333, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Expenses";
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
            this.budgetVewPnl.ResumeLayout(false);
            this.budgetVewPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView expenseView;
        private System.Windows.Forms.ColumnHeader Expenses;
        private System.Windows.Forms.ColumnHeader expenseBalance;
        private System.Windows.Forms.ListView incomeView;
        private System.Windows.Forms.ListView billView;
        private System.Windows.Forms.ColumnHeader Bills;
        private System.Windows.Forms.ColumnHeader billBalance;
        private System.Windows.Forms.Panel budgetVewPnl;
        private System.Windows.Forms.ColumnHeader dueDate;
        private System.Windows.Forms.ColumnHeader budgetType;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader earning;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader dateEarned;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}