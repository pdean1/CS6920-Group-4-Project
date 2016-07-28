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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbBudgets = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultsTxt = new System.Windows.Forms.TextBox();
            this.plusBtn = new System.Windows.Forms.Button();
            this.periodBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.Negbtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.multBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sevenbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.valueLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.percentageCht)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 178);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1286, 720);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1278, 688);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "DashBoard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1278, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Earnings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1278, 688);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Expenses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1278, 688);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Manage Bills";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1278, 688);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Budget View";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(1048, 182);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(99, 19);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Current User: ";
            // 
            // lblIncomeRemaining
            // 
            this.lblIncomeRemaining.AutoSize = true;
            this.lblIncomeRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomeRemaining.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblIncomeRemaining.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblIncomeRemaining.Location = new System.Drawing.Point(665, 84);
            this.lblIncomeRemaining.Name = "lblIncomeRemaining";
            this.lblIncomeRemaining.Size = new System.Drawing.Size(188, 24);
            this.lblIncomeRemaining.TabIndex = 5;
            this.lblIncomeRemaining.Text = "REMAINING INCOME:";
            // 
            // lblIncomeRemainingPlaceholder
            // 
            this.lblIncomeRemainingPlaceholder.AutoSize = true;
            this.lblIncomeRemainingPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomeRemainingPlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIncomeRemainingPlaceholder.Font = new System.Drawing.Font("Calibri", 16F);
            this.lblIncomeRemainingPlaceholder.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblIncomeRemainingPlaceholder.Location = new System.Drawing.Point(854, 81);
            this.lblIncomeRemainingPlaceholder.Name = "lblIncomeRemainingPlaceholder";
            this.lblIncomeRemainingPlaceholder.Size = new System.Drawing.Size(295, 29);
            this.lblIncomeRemainingPlaceholder.TabIndex = 6;
            this.lblIncomeRemainingPlaceholder.Text = "Income Remaining Placeholder";
            this.lblIncomeRemainingPlaceholder.Click += new System.EventHandler(this.lblIncomeRemainingPlaceholder_Click);
            // 
            // lblUserNamePlaceholder
            // 
            this.lblUserNamePlaceholder.AutoSize = true;
            this.lblUserNamePlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.lblUserNamePlaceholder.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblUserNamePlaceholder.ForeColor = System.Drawing.Color.Black;
            this.lblUserNamePlaceholder.Location = new System.Drawing.Point(1161, 182);
            this.lblUserNamePlaceholder.Name = "lblUserNamePlaceholder";
            this.lblUserNamePlaceholder.Size = new System.Drawing.Size(172, 19);
            this.lblUserNamePlaceholder.TabIndex = 7;
            this.lblUserNamePlaceholder.Text = "User\'s Name Placeholder";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1562, 24);
            this.MainMenuStrip.TabIndex = 8;
            this.MainMenuStrip.Text = "menuStrip1";
            this.MainMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenuStrip_ItemClicked);
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
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToCSVToolStripMenuItem.Text = "Export To CSV";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportToCSVToolStripMenuItem_Click);
            // 
            // logoutExitToolStripMenuItem
            // 
            this.logoutExitToolStripMenuItem.Name = "logoutExitToolStripMenuItem";
            this.logoutExitToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // cbBudgets
            // 
            this.cbBudgets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBudgets.Font = new System.Drawing.Font("Calibri", 14F);
            this.cbBudgets.FormattingEnabled = true;
            this.cbBudgets.Location = new System.Drawing.Point(190, 79);
            this.cbBudgets.Name = "cbBudgets";
            this.cbBudgets.Size = new System.Drawing.Size(238, 31);
            this.cbBudgets.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Orange;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.MintCream;
            this.btnDelete.Location = new System.Drawing.Point(499, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 35);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSelect.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.Color.MintCream;
            this.btnSelect.Location = new System.Drawing.Point(434, 78);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(60, 35);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "CHOOSE A BUDGET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Budget Calculator";
            // 
            // resultsTxt
            // 
            this.resultsTxt.BackColor = System.Drawing.Color.White;
            this.resultsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsTxt.Location = new System.Drawing.Point(12, 44);
            this.resultsTxt.Name = "resultsTxt";
            this.resultsTxt.Size = new System.Drawing.Size(209, 23);
            this.resultsTxt.TabIndex = 18;
            this.resultsTxt.Text = "0";
            this.resultsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultsTxt.TextChanged += new System.EventHandler(this.resultsTxt_TextChanged);
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(144, 198);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(35, 33);
            this.plusBtn.TabIndex = 17;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.operator_Click);
            // 
            // periodBtn
            // 
            this.periodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodBtn.Location = new System.Drawing.Point(100, 199);
            this.periodBtn.Name = "periodBtn";
            this.periodBtn.Size = new System.Drawing.Size(35, 33);
            this.periodBtn.TabIndex = 16;
            this.periodBtn.Text = ".";
            this.periodBtn.UseVisualStyleBackColor = true;
            this.periodBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBtn.Location = new System.Drawing.Point(12, 199);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(83, 33);
            this.zeroBtn.TabIndex = 15;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // Negbtn
            // 
            this.Negbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Negbtn.Location = new System.Drawing.Point(144, 157);
            this.Negbtn.Name = "Negbtn";
            this.Negbtn.Size = new System.Drawing.Size(35, 33);
            this.Negbtn.TabIndex = 14;
            this.Negbtn.Text = "-";
            this.Negbtn.UseVisualStyleBackColor = true;
            this.Negbtn.Click += new System.EventHandler(this.operator_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.Location = new System.Drawing.Point(103, 160);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(35, 33);
            this.threeBtn.TabIndex = 13;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.Location = new System.Drawing.Point(56, 157);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(35, 33);
            this.twoBtn.TabIndex = 12;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // OneBtn
            // 
            this.OneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneBtn.Location = new System.Drawing.Point(12, 157);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(35, 33);
            this.OneBtn.TabIndex = 11;
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = true;
            this.OneBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.Location = new System.Drawing.Point(188, 157);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(35, 75);
            this.equalBtn.TabIndex = 10;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equal_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(187, 115);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(34, 33);
            this.clear.TabIndex = 9;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click_1);
            // 
            // multBtn
            // 
            this.multBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multBtn.Location = new System.Drawing.Point(143, 115);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(35, 33);
            this.multBtn.TabIndex = 8;
            this.multBtn.Text = "*";
            this.multBtn.UseVisualStyleBackColor = true;
            this.multBtn.Click += new System.EventHandler(this.operator_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.Location = new System.Drawing.Point(99, 115);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(35, 33);
            this.sixBtn.TabIndex = 7;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveBtn.Location = new System.Drawing.Point(55, 115);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(35, 33);
            this.fiveBtn.TabIndex = 6;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.Location = new System.Drawing.Point(12, 115);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(35, 33);
            this.fourBtn.TabIndex = 5;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // clearAll
            // 
            this.clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAll.Location = new System.Drawing.Point(186, 73);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(35, 33);
            this.clearAll.TabIndex = 4;
            this.clearAll.Text = "CE";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click_1);
            // 
            // divBtn
            // 
            this.divBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divBtn.Location = new System.Drawing.Point(143, 73);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(35, 33);
            this.divBtn.TabIndex = 3;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.operator_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.Location = new System.Drawing.Point(99, 73);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(35, 33);
            this.nineBtn.TabIndex = 2;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.Location = new System.Drawing.Point(55, 73);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(35, 33);
            this.eightBtn.TabIndex = 1;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // sevenbtn
            // 
            this.sevenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenbtn.Location = new System.Drawing.Point(12, 73);
            this.sevenbtn.Name = "sevenbtn";
            this.sevenbtn.Size = new System.Drawing.Size(35, 33);
            this.sevenbtn.TabIndex = 0;
            this.sevenbtn.Text = "7";
            this.sevenbtn.UseVisualStyleBackColor = true;
            this.sevenbtn.Click += new System.EventHandler(this.button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.valueLbl);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.resultsTxt);
            this.panel3.Controls.Add(this.plusBtn);
            this.panel3.Controls.Add(this.periodBtn);
            this.panel3.Controls.Add(this.zeroBtn);
            this.panel3.Controls.Add(this.Negbtn);
            this.panel3.Controls.Add(this.threeBtn);
            this.panel3.Controls.Add(this.twoBtn);
            this.panel3.Controls.Add(this.OneBtn);
            this.panel3.Controls.Add(this.equalBtn);
            this.panel3.Controls.Add(this.clear);
            this.panel3.Controls.Add(this.multBtn);
            this.panel3.Controls.Add(this.sixBtn);
            this.panel3.Controls.Add(this.fiveBtn);
            this.panel3.Controls.Add(this.fourBtn);
            this.panel3.Controls.Add(this.clearAll);
            this.panel3.Controls.Add(this.divBtn);
            this.panel3.Controls.Add(this.nineBtn);
            this.panel3.Controls.Add(this.eightBtn);
            this.panel3.Controls.Add(this.sevenbtn);
            this.panel3.Location = new System.Drawing.Point(1301, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 253);
            this.panel3.TabIndex = 15;
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.Location = new System.Drawing.Point(97, 28);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(0, 13);
            this.valueLbl.TabIndex = 54;
            // 
            // MyBudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1562, 912);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbBudgets);
            this.Controls.Add(this.lblUserNamePlaceholder);
            this.Controls.Add(this.lblIncomeRemainingPlaceholder);
            this.Controls.Add(this.lblIncomeRemaining);
            this.Controls.Add(this.panel3);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultsTxt;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button periodBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button Negbtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label valueLbl;
    }
}