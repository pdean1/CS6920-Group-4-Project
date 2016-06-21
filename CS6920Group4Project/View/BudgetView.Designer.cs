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
            this.Income = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeBal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billView = new System.Windows.Forms.ListView();
            this.Bills = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.budgetVewPnl = new System.Windows.Forms.Panel();
            this.budgetVewPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(644, 203);
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
            this.expenseView.Location = new System.Drawing.Point(68, 274);
            this.expenseView.Name = "expenseView";
            this.expenseView.Size = new System.Drawing.Size(502, 97);
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
            this.Income,
            this.incomeBal});
            this.incomeView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeView.Location = new System.Drawing.Point(68, 36);
            this.incomeView.Name = "incomeView";
            this.incomeView.Size = new System.Drawing.Size(502, 97);
            this.incomeView.TabIndex = 2;
            this.incomeView.UseCompatibleStateImageBehavior = false;
            this.incomeView.View = System.Windows.Forms.View.Details;
            // 
            // Income
            // 
            this.Income.Text = "Income";
            this.Income.Width = 80;
            // 
            // incomeBal
            // 
            this.incomeBal.Text = "Balance";
            this.incomeBal.Width = 77;
            // 
            // billView
            // 
            this.billView.BackColor = System.Drawing.Color.AliceBlue;
            this.billView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Bills,
            this.billBalance});
            this.billView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.billView.Location = new System.Drawing.Point(68, 160);
            this.billView.Name = "billView";
            this.billView.Size = new System.Drawing.Size(502, 97);
            this.billView.TabIndex = 3;
            this.billView.UseCompatibleStateImageBehavior = false;
            this.billView.View = System.Windows.Forms.View.Details;
            // 
            // Bills
            // 
            this.Bills.Text = "Bills";
            this.Bills.Width = 77;
            // 
            // billBalance
            // 
            this.billBalance.Text = "Balance";
            this.billBalance.Width = 78;
            // 
            // budgetVewPnl
            // 
            this.budgetVewPnl.BackColor = System.Drawing.Color.White;
            this.budgetVewPnl.Controls.Add(this.expenseView);
            this.budgetVewPnl.Controls.Add(this.billView);
            this.budgetVewPnl.Controls.Add(this.incomeView);
            this.budgetVewPnl.Location = new System.Drawing.Point(405, 255);
            this.budgetVewPnl.Name = "budgetVewPnl";
            this.budgetVewPnl.Size = new System.Drawing.Size(631, 423);
            this.budgetVewPnl.TabIndex = 4;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView expenseView;
        private System.Windows.Forms.ColumnHeader Expenses;
        private System.Windows.Forms.ColumnHeader expenseBalance;
        private System.Windows.Forms.ListView incomeView;
        private System.Windows.Forms.ColumnHeader Income;
        private System.Windows.Forms.ColumnHeader incomeBal;
        private System.Windows.Forms.ListView billView;
        private System.Windows.Forms.ColumnHeader Bills;
        private System.Windows.Forms.ColumnHeader billBalance;
        private System.Windows.Forms.Panel budgetVewPnl;
    }
}