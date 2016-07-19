﻿namespace CS6920Group4Project.View
{
    partial class MyBudgetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBudgetForm));
            this.percentageCht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblIncomeRemaining = new System.Windows.Forms.Label();
            this.lblIncomeRemainingPlaceholder = new System.Windows.Forms.Label();
            this.lblUserNamePlaceholder = new System.Windows.Forms.Label();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutExitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.percentageCht)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // percentageCht
            // 
            this.percentageCht.Location = new System.Drawing.Point(0, 0);
            this.percentageCht.Name = "percentageCht";
            this.percentageCht.Size = new System.Drawing.Size(300, 300);
            this.percentageCht.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1362, 734);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1354, 702);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "DashBoard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1354, 693);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Earnings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1354, 693);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Expenses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1354, 693);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Manage Bills";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1354, 693);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Budget View";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblUser.Location = new System.Drawing.Point(12, 24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(209, 24);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Current Signed in User: ";
            // 
            // lblIncomeRemaining
            // 
            this.lblIncomeRemaining.AutoSize = true;
            this.lblIncomeRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomeRemaining.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblIncomeRemaining.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblIncomeRemaining.Location = new System.Drawing.Point(12, 55);
            this.lblIncomeRemaining.Name = "lblIncomeRemaining";
            this.lblIncomeRemaining.Size = new System.Drawing.Size(260, 24);
            this.lblIncomeRemaining.TabIndex = 5;
            this.lblIncomeRemaining.Text = "Income Remaining in Budget: ";
            // 
            // lblIncomeRemainingPlaceholder
            // 
            this.lblIncomeRemainingPlaceholder.AutoSize = true;
            this.lblIncomeRemainingPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomeRemainingPlaceholder.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblIncomeRemainingPlaceholder.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblIncomeRemainingPlaceholder.Location = new System.Drawing.Point(268, 55);
            this.lblIncomeRemainingPlaceholder.Name = "lblIncomeRemainingPlaceholder";
            this.lblIncomeRemainingPlaceholder.Size = new System.Drawing.Size(268, 24);
            this.lblIncomeRemainingPlaceholder.TabIndex = 6;
            this.lblIncomeRemainingPlaceholder.Text = "Income Remaining Placeholder";
            // 
            // lblUserNamePlaceholder
            // 
            this.lblUserNamePlaceholder.AutoSize = true;
            this.lblUserNamePlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.lblUserNamePlaceholder.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblUserNamePlaceholder.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblUserNamePlaceholder.Location = new System.Drawing.Point(268, 24);
            this.lblUserNamePlaceholder.Name = "lblUserNamePlaceholder";
            this.lblUserNamePlaceholder.Size = new System.Drawing.Size(219, 24);
            this.lblUserNamePlaceholder.TabIndex = 7;
            this.lblUserNamePlaceholder.Text = "User\'s Name Placeholder";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1362, 24);
            this.MainMenuStrip.TabIndex = 8;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToCSVToolStripMenuItem,
            this.logoutExitToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exportToCSVToolStripMenuItem.Text = "Export To CSV";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportToCSVToolStripMenuItem_Click);
            // 
            // logoutExitToolStripMenuItem
            // 
            this.logoutExitToolStripMenuItem.Name = "logoutExitToolStripMenuItem";
            this.logoutExitToolStripMenuItem.Size = new System.Drawing.Size(145, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // MyBudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 812);
            this.Controls.Add(this.lblUserNamePlaceholder);
            this.Controls.Add(this.lblIncomeRemainingPlaceholder);
            this.Controls.Add(this.lblIncomeRemaining);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MainMenuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBudgetForm";
            this.Text = "My Buddy";
            this.Load += new System.EventHandler(this.MyBudgetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.percentageCht)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //       private System.Windows.Forms.Panel dashboardpnl;
        private System.Windows.Forms.DataVisualization.Charting.Chart percentageCht;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblIncomeRemaining;
        private System.Windows.Forms.Label lblIncomeRemainingPlaceholder;
        private System.Windows.Forms.Label lblUserNamePlaceholder;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator logoutExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}