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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.percentageCht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblIncomeRemaining = new System.Windows.Forms.Label();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblExpenseAmount = new System.Windows.Forms.Label();
            this.lblIncomeAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.budgetEditBtn = new System.Windows.Forms.Button();
            this.budgetDescBox = new System.Windows.Forms.TextBox();
            this.budgetTitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgDueBills = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.valueLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resultsTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.periodBtn = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.multBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.quoteTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.percentageCht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDueBills)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // percentageCht
            // 
            this.percentageCht.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Name = "ChartArea1";
            this.percentageCht.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.percentageCht.Legends.Add(legend1);
            this.percentageCht.Location = new System.Drawing.Point(333, 281);
            this.percentageCht.Name = "percentageCht";
            this.percentageCht.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.percentageCht.Series.Add(series1);
            this.percentageCht.Size = new System.Drawing.Size(300, 300);
            this.percentageCht.TabIndex = 0;
            this.percentageCht.Text = "Budget";
            // 
            // lblIncomeRemaining
            // 
            this.lblIncomeRemaining.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIncomeRemaining.AutoSize = true;
            this.lblIncomeRemaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIncomeRemaining.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeRemaining.Location = new System.Drawing.Point(206, 423);
            this.lblIncomeRemaining.Name = "lblIncomeRemaining";
            this.lblIncomeRemaining.Size = new System.Drawing.Size(62, 25);
            this.lblIncomeRemaining.TabIndex = 10;
            this.lblIncomeRemaining.Text = "$0000";
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillAmount.Location = new System.Drawing.Point(163, 215);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(60, 23);
            this.lblBillAmount.TabIndex = 9;
            this.lblBillAmount.Text = "$0000";
            // 
            // lblExpenseAmount
            // 
            this.lblExpenseAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpenseAmount.AutoSize = true;
            this.lblExpenseAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseAmount.Location = new System.Drawing.Point(163, 184);
            this.lblExpenseAmount.Name = "lblExpenseAmount";
            this.lblExpenseAmount.Size = new System.Drawing.Size(60, 23);
            this.lblExpenseAmount.TabIndex = 8;
            this.lblExpenseAmount.Text = "$0000";
            // 
            // lblIncomeAmount
            // 
            this.lblIncomeAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIncomeAmount.AutoSize = true;
            this.lblIncomeAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeAmount.Location = new System.Drawing.Point(163, 148);
            this.lblIncomeAmount.Name = "lblIncomeAmount";
            this.lblIncomeAmount.Size = new System.Drawing.Size(60, 23);
            this.lblIncomeAmount.TabIndex = 7;
            this.lblIncomeAmount.Text = "$0000";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(50, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Income Remaining:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(91, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bills:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(61, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Expenses:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(75, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Income:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Budget Name:";
            // 
            // statisticsChart
            // 
            this.statisticsChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statisticsChart.BackColor = System.Drawing.Color.Transparent;
            this.statisticsChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statisticsChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.statisticsChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.statisticsChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.statisticsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.statisticsChart.Legends.Add(legend2);
            this.statisticsChart.Location = new System.Drawing.Point(11, 238);
            this.statisticsChart.Name = "statisticsChart";
            this.statisticsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.statisticsChart.Series.Add(series2);
            this.statisticsChart.Size = new System.Drawing.Size(312, 182);
            this.statisticsChart.TabIndex = 0;
            this.statisticsChart.Text = "Budget Statistics";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.budgetEditBtn);
            this.panel1.Controls.Add(this.budgetDescBox);
            this.panel1.Controls.Add(this.budgetTitleBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblIncomeRemaining);
            this.panel1.Controls.Add(this.statisticsChart);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblBillAmount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblExpenseAmount);
            this.panel1.Controls.Add(this.lblIncomeAmount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 465);
            this.panel1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(13, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Budget Description:";
            // 
            // budgetEditBtn
            // 
            this.budgetEditBtn.Location = new System.Drawing.Point(278, 116);
            this.budgetEditBtn.Name = "budgetEditBtn";
            this.budgetEditBtn.Size = new System.Drawing.Size(40, 23);
            this.budgetEditBtn.TabIndex = 15;
            this.budgetEditBtn.Text = "Edit";
            this.budgetEditBtn.UseVisualStyleBackColor = true;
            this.budgetEditBtn.Click += new System.EventHandler(this.budgetEditBtn_Click);
            // 
            // budgetDescBox
            // 
            this.budgetDescBox.Location = new System.Drawing.Point(218, 94);
            this.budgetDescBox.Name = "budgetDescBox";
            this.budgetDescBox.Size = new System.Drawing.Size(100, 20);
            this.budgetDescBox.TabIndex = 14;
            // 
            // budgetTitleBox
            // 
            this.budgetTitleBox.Location = new System.Drawing.Point(218, 70);
            this.budgetTitleBox.Name = "budgetTitleBox";
            this.budgetTitleBox.Size = new System.Drawing.Size(100, 20);
            this.budgetTitleBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Current Budget Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgDueBills);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(360, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 465);
            this.panel2.TabIndex = 14;
            // 
            // dgDueBills
            // 
            this.dgDueBills.AllowUserToAddRows = false;
            this.dgDueBills.AllowUserToDeleteRows = false;
            this.dgDueBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDueBills.Location = new System.Drawing.Point(10, 59);
            this.dgDueBills.Name = "dgDueBills";
            this.dgDueBills.ReadOnly = true;
            this.dgDueBills.Size = new System.Drawing.Size(309, 381);
            this.dgDueBills.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 20F);
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bills Still Due";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.valueLbl);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.resultsTxt);
            this.panel3.Controls.Add(this.addBtn);
            this.panel3.Controls.Add(this.periodBtn);
            this.panel3.Controls.Add(this.button16);
            this.panel3.Controls.Add(this.subBtn);
            this.panel3.Controls.Add(this.threeBtn);
            this.panel3.Controls.Add(this.twoBtn);
            this.panel3.Controls.Add(this.oneBtn);
            this.panel3.Controls.Add(this.equalBtn);
            this.panel3.Controls.Add(this.clearBtn);
            this.panel3.Controls.Add(this.multBtn);
            this.panel3.Controls.Add(this.sixBtn);
            this.panel3.Controls.Add(this.fiveBtn);
            this.panel3.Controls.Add(this.fourBtn);
            this.panel3.Controls.Add(this.clearAllBtn);
            this.panel3.Controls.Add(this.divBtn);
            this.panel3.Controls.Add(this.nineBtn);
            this.panel3.Controls.Add(this.eightBtn);
            this.panel3.Controls.Add(this.sevenBtn);
            this.panel3.Location = new System.Drawing.Point(703, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 253);
            this.panel3.TabIndex = 15;
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.valueLbl.Location = new System.Drawing.Point(98, 25);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(0, 13);
            this.valueLbl.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Calculator";
            // 
            // resultsTxt
            // 
            this.resultsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsTxt.Location = new System.Drawing.Point(12, 44);
            this.resultsTxt.Name = "resultsTxt";
            this.resultsTxt.Size = new System.Drawing.Size(209, 23);
            this.resultsTxt.TabIndex = 18;
            this.resultsTxt.Text = "0";
            this.resultsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(144, 198);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(35, 33);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.operator_Click);
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
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(12, 199);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(83, 33);
            this.button16.TabIndex = 15;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button_Click);
            // 
            // subBtn
            // 
            this.subBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.Location = new System.Drawing.Point(144, 157);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(35, 33);
            this.subBtn.TabIndex = 14;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.operator_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.Location = new System.Drawing.Point(100, 157);
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
            // oneBtn
            // 
            this.oneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.Location = new System.Drawing.Point(12, 157);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(35, 33);
            this.oneBtn.TabIndex = 11;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.button_Click);
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
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(187, 115);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(34, 33);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clear_Click);
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
            // clearAllBtn
            // 
            this.clearAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllBtn.Location = new System.Drawing.Point(186, 73);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(35, 33);
            this.clearAllBtn.TabIndex = 4;
            this.clearAllBtn.Text = "CE";
            this.clearAllBtn.UseVisualStyleBackColor = true;
            this.clearAllBtn.Click += new System.EventHandler(this.clearAll_Click);
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
            // sevenBtn
            // 
            this.sevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.Location = new System.Drawing.Point(12, 73);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(35, 33);
            this.sevenBtn.TabIndex = 0;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::CS6920Group4Project.Properties.Resources.QuoteBox;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.quoteTxt);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(703, 306);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 163);
            this.panel4.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15F);
            this.label10.ForeColor = System.Drawing.Color.DarkGreen;
            this.label10.Location = new System.Drawing.Point(70, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Savings Tips";
            // 
            // quoteTxt
            // 
            this.quoteTxt.BackColor = System.Drawing.Color.Ivory;
            this.quoteTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quoteTxt.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteTxt.ForeColor = System.Drawing.Color.Green;
            this.quoteTxt.Location = new System.Drawing.Point(29, 51);
            this.quoteTxt.Multiline = true;
            this.quoteTxt.Name = "quoteTxt";
            this.quoteTxt.Size = new System.Drawing.Size(184, 81);
            this.quoteTxt.TabIndex = 19;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 637);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Budget Buddy Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.percentageCht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDueBills)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //       private System.Windows.Forms.Panel dashboardpnl;
        private System.Windows.Forms.DataVisualization.Charting.Chart percentageCht;
        private System.Windows.Forms.Label lblIncomeRemaining;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label lblExpenseAmount;
        private System.Windows.Forms.Label lblIncomeAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticsChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgDueBills;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox resultsTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button periodBtn;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Label valueLbl;
        private System.Windows.Forms.Button budgetEditBtn;
        private System.Windows.Forms.TextBox budgetDescBox;
        private System.Windows.Forms.TextBox budgetTitleBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox quoteTxt;
    }
}