namespace CS6920Group4Project.View
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
            this.cbBudgets = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnAddBudget = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 720);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1112, 688);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "DashBoard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1112, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Earnings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1112, 688);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Expenses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1112, 688);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Manage Bills";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1112, 688);
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
            this.lblUser.Location = new System.Drawing.Point(12, 34);
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
            this.lblIncomeRemaining.Location = new System.Drawing.Point(12, 58);
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
            this.lblIncomeRemainingPlaceholder.Location = new System.Drawing.Point(268, 58);
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
            this.lblUserNamePlaceholder.Location = new System.Drawing.Point(268, 34);
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
            // cbBudgets
            // 
            this.cbBudgets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBudgets.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cbBudgets.FormattingEnabled = true;
            this.cbBudgets.Location = new System.Drawing.Point(896, 12);
            this.cbBudgets.Name = "cbBudgets";
            this.cbBudgets.Size = new System.Drawing.Size(265, 34);
            this.cbBudgets.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.MintCream;
            this.btnDelete.Location = new System.Drawing.Point(1036, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 35);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Budget";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSelect.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.Color.MintCream;
            this.btnSelect.Location = new System.Drawing.Point(896, 55);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(125, 35);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "Select Budget";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtTitle.Location = new System.Drawing.Point(1130, 216);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(220, 33);
            this.txtTitle.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(1126, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Create a Budget";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(1140, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(1140, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Title:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtDesc.Location = new System.Drawing.Point(1130, 277);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(220, 33);
            this.txtDesc.TabIndex = 51;
            // 
            // btnAddBudget
            // 
            this.btnAddBudget.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddBudget.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddBudget.ForeColor = System.Drawing.Color.MintCream;
            this.btnAddBudget.Location = new System.Drawing.Point(1225, 316);
            this.btnAddBudget.Name = "btnAddBudget";
            this.btnAddBudget.Size = new System.Drawing.Size(125, 35);
            this.btnAddBudget.TabIndex = 52;
            this.btnAddBudget.Text = "Create Budget";
            this.btnAddBudget.UseVisualStyleBackColor = false;
            this.btnAddBudget.Click += new System.EventHandler(this.btnAddBudget_Click);
            // 
            // MyBudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 812);
            this.Controls.Add(this.btnAddBudget);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cbBudgets);
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
            this.Text = "Create a Budget";
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
        private System.Windows.Forms.ComboBox cbBudgets;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAddBudget;
    }
}