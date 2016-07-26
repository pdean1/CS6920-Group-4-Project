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
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblExpenseAmount = new System.Windows.Forms.Label();
            this.lblIncomeAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddBudget = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgDueBills = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.budgetEditBtn = new System.Windows.Forms.Button();
            this.budgetDescBox = new System.Windows.Forms.TextBox();
            this.budgetTitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NotesRtb = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.saveQuoteTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.percentageCht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDueBills)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // lblBillAmount
            // 
            this.lblBillAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillAmount.Location = new System.Drawing.Point(179, 232);
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
            this.lblExpenseAmount.Location = new System.Drawing.Point(179, 209);
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
            this.lblIncomeAmount.Location = new System.Drawing.Point(179, 187);
            this.lblIncomeAmount.Name = "lblIncomeAmount";
            this.lblIncomeAmount.Size = new System.Drawing.Size(60, 23);
            this.lblIncomeAmount.TabIndex = 7;
            this.lblIncomeAmount.Text = "$0000";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(107, 232);
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
            this.label4.Location = new System.Drawing.Point(77, 207);
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
            this.label3.Location = new System.Drawing.Point(91, 185);
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
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(18, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
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
            this.statisticsChart.Location = new System.Drawing.Point(23, 258);
            this.statisticsChart.Name = "statisticsChart";
            this.statisticsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.statisticsChart.Series.Add(series2);
            this.statisticsChart.Size = new System.Drawing.Size(295, 173);
            this.statisticsChart.TabIndex = 0;
            this.statisticsChart.Text = "Budget Statistics";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.statisticsChart);
            this.panel1.Controls.Add(this.btnAddBudget);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblBillAmount);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.lblIncomeAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblExpenseAmount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 457);
            this.panel1.TabIndex = 13;
            // 
            // btnAddBudget
            // 
            this.btnAddBudget.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddBudget.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddBudget.ForeColor = System.Drawing.Color.MintCream;
            this.btnAddBudget.Location = new System.Drawing.Point(239, 110);
            this.btnAddBudget.Name = "btnAddBudget";
            this.btnAddBudget.Size = new System.Drawing.Size(73, 25);
            this.btnAddBudget.TabIndex = 58;
            this.btnAddBudget.Text = "Create";
            this.btnAddBudget.UseVisualStyleBackColor = false;
            this.btnAddBudget.Click += new System.EventHandler(this.btnAddBudget_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtDesc.Location = new System.Drawing.Point(129, 74);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(183, 24);
            this.txtDesc.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15F);
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(111, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "My Statistics";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(25, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 55;
            this.label6.Text = "Description:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGreen;
            this.label13.Location = new System.Drawing.Point(25, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 22);
            this.label13.TabIndex = 54;
            this.label13.Text = "Budget Title:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 15F);
            this.label14.ForeColor = System.Drawing.Color.DarkGreen;
            this.label14.Location = new System.Drawing.Point(91, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 24);
            this.label14.TabIndex = 53;
            this.label14.Text = "Create a New Budget";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtTitle.Location = new System.Drawing.Point(129, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(183, 24);
            this.txtTitle.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15F);
            this.label12.ForeColor = System.Drawing.Color.DarkGreen;
            this.label12.Location = new System.Drawing.Point(78, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "Bills Still Due";
            // 
            // dgDueBills
            // 
            this.dgDueBills.AllowUserToAddRows = false;
            this.dgDueBills.AllowUserToDeleteRows = false;
            this.dgDueBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDueBills.Location = new System.Drawing.Point(10, 30);
            this.dgDueBills.Name = "dgDueBills";
            this.dgDueBills.ReadOnly = true;
            this.dgDueBills.Size = new System.Drawing.Size(239, 249);
            this.dgDueBills.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(17, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Budget Description:";
            // 
            // budgetEditBtn
            // 
            this.budgetEditBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.budgetEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetEditBtn.ForeColor = System.Drawing.Color.White;
            this.budgetEditBtn.Location = new System.Drawing.Point(273, 378);
            this.budgetEditBtn.Name = "budgetEditBtn";
            this.budgetEditBtn.Size = new System.Drawing.Size(46, 24);
            this.budgetEditBtn.TabIndex = 15;
            this.budgetEditBtn.Text = "Edit";
            this.budgetEditBtn.UseVisualStyleBackColor = false;
            this.budgetEditBtn.Click += new System.EventHandler(this.budgetEditBtn_Click);
            // 
            // budgetDescBox
            // 
            this.budgetDescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetDescBox.Location = new System.Drawing.Point(142, 75);
            this.budgetDescBox.Name = "budgetDescBox";
            this.budgetDescBox.Size = new System.Drawing.Size(171, 23);
            this.budgetDescBox.TabIndex = 14;
            // 
            // budgetTitleBox
            // 
            this.budgetTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetTitleBox.Location = new System.Drawing.Point(142, 41);
            this.budgetTitleBox.Name = "budgetTitleBox";
            this.budgetTitleBox.Size = new System.Drawing.Size(171, 23);
            this.budgetTitleBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(107, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Edit My Budget";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.NotesRtb);
            this.panel2.Controls.Add(this.budgetEditBtn);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.budgetDescBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.budgetTitleBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(347, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 457);
            this.panel2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(192, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NotesRtb
            // 
            this.NotesRtb.Location = new System.Drawing.Point(12, 153);
            this.NotesRtb.Name = "NotesRtb";
            this.NotesRtb.Size = new System.Drawing.Size(307, 211);
            this.NotesRtb.TabIndex = 3;
            this.NotesRtb.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15F);
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(98, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Add Budget Notes";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::CS6920Group4Project.Properties.Resources.QuoteBox;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.saveQuoteTxt);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(10, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 163);
            this.panel4.TabIndex = 16;
            // 
            // saveQuoteTxt
            // 
            this.saveQuoteTxt.BackColor = System.Drawing.Color.White;
            this.saveQuoteTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saveQuoteTxt.Enabled = false;
            this.saveQuoteTxt.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveQuoteTxt.ForeColor = System.Drawing.Color.Green;
            this.saveQuoteTxt.Location = new System.Drawing.Point(38, 52);
            this.saveQuoteTxt.Multiline = true;
            this.saveQuoteTxt.Name = "saveQuoteTxt";
            this.saveQuoteTxt.Size = new System.Drawing.Size(175, 81);
            this.saveQuoteTxt.TabIndex = 19;
            this.saveQuoteTxt.TextChanged += new System.EventHandler(this.saveQuoteTxt_TextChanged);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.dgDueBills);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(689, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 457);
            this.panel3.TabIndex = 59;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 762);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgDueBills)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //       private System.Windows.Forms.Panel dashboardpnl;
        private System.Windows.Forms.DataVisualization.Charting.Chart percentageCht;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label lblExpenseAmount;
        private System.Windows.Forms.Label lblIncomeAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticsChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgDueBills;
        private System.Windows.Forms.Button budgetEditBtn;
        private System.Windows.Forms.TextBox budgetDescBox;
        private System.Windows.Forms.TextBox budgetTitleBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox saveQuoteTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox NotesRtb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddBudget;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Panel panel3;
    }
}