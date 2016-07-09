﻿namespace CS6920Group4Project.View
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
            this.expenseTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.earnView = new System.Windows.Forms.ListView();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateEarned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billView = new System.Windows.Forms.ListView();
            this.billTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datePaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(542, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Budget";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // expenseView
            // 
            this.expenseView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.expenseView.BackColor = System.Drawing.Color.SkyBlue;
            this.expenseView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.expenseTitle,
            this.expenseDate,
            this.expenseDescription,
            this.expenseAmount,
            this.expenseCategory});
            this.expenseView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.expenseView.Location = new System.Drawing.Point(362, 419);
            this.expenseView.Name = "expenseView";
            this.expenseView.Size = new System.Drawing.Size(500, 85);
            this.expenseView.TabIndex = 1;
            this.expenseView.UseCompatibleStateImageBehavior = false;
            this.expenseView.View = System.Windows.Forms.View.Details;
            // 
            // expenseTitle
            // 
            this.expenseTitle.Text = "Expense Title";
            this.expenseTitle.Width = 120;
            // 
            // expenseDate
            // 
            this.expenseDate.Text = "Date";
            this.expenseDate.Width = 68;
            // 
            // expenseDescription
            // 
            this.expenseDescription.Text = "Description";
            this.expenseDescription.Width = 100;
            // 
            // expenseAmount
            // 
            this.expenseAmount.Text = "Amount";
            this.expenseAmount.Width = 80;
            // 
            // expenseCategory
            // 
            this.expenseCategory.Text = "Category";
            this.expenseCategory.Width = 92;
            // 
            // earnView
            // 
            this.earnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.earnView.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.earnView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.description,
            this.amount,
            this.dateEarned});
            this.earnView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earnView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.earnView.Location = new System.Drawing.Point(362, 171);
            this.earnView.Name = "earnView";
            this.earnView.Size = new System.Drawing.Size(500, 85);
            this.earnView.TabIndex = 2;
            this.earnView.UseCompatibleStateImageBehavior = false;
            this.earnView.View = System.Windows.Forms.View.Details;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 84;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 168;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 101;
            // 
            // dateEarned
            // 
            this.dateEarned.Text = "Date";
            this.dateEarned.Width = 83;
            // 
            // billView
            // 
            this.billView.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.billView.Location = new System.Drawing.Point(362, 294);
            this.billView.Name = "billView";
            this.billView.Size = new System.Drawing.Size(500, 85);
            this.billView.TabIndex = 3;
            this.billView.UseCompatibleStateImageBehavior = false;
            this.billView.View = System.Windows.Forms.View.Details;
            // 
            // billTitle
            // 
            this.billTitle.Text = "Bill Title";
            this.billTitle.Width = 77;
            // 
            // billAmount
            // 
            this.billAmount.DisplayIndex = 3;
            this.billAmount.Text = "Amount";
            this.billAmount.Width = 77;
            // 
            // dueDate
            // 
            this.dueDate.Text = "Date Due";
            this.dueDate.Width = 79;
            // 
            // billDescription
            // 
            this.billDescription.DisplayIndex = 4;
            this.billDescription.Text = "Description";
            this.billDescription.Width = 121;
            // 
            // billBalance
            // 
            this.billBalance.DisplayIndex = 1;
            this.billBalance.Text = "Balance";
            this.billBalance.Width = 78;
            // 
            // datePaid
            // 
            this.datePaid.Text = "Date Paid";
            this.datePaid.Width = 92;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(581, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Earnings";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(594, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bills";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(581, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Expenses";
            // 
            // BudgetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(196)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 641);
            this.Controls.Add(this.expenseView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.billView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.earnView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BudgetView";
            this.Text = "BudgetView";
            this.Load += new System.EventHandler(this.BudgetView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView expenseView;
        private System.Windows.Forms.ColumnHeader expenseTitle;
        private System.Windows.Forms.ColumnHeader expenseDate;
        private System.Windows.Forms.ListView earnView;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader dateEarned;
        private System.Windows.Forms.ColumnHeader expenseDescription;
        private System.Windows.Forms.ColumnHeader expenseAmount;
        private System.Windows.Forms.ColumnHeader expenseCategory;
        private System.Windows.Forms.ListView billView;
        private System.Windows.Forms.ColumnHeader billTitle;
        private System.Windows.Forms.ColumnHeader billAmount;
        private System.Windows.Forms.ColumnHeader dueDate;
        private System.Windows.Forms.ColumnHeader billDescription;
        private System.Windows.Forms.ColumnHeader billBalance;
        private System.Windows.Forms.ColumnHeader datePaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}