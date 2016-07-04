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
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.percentageCht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblBudgetTitle = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentageCht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeaderPnl.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPnl.Controls.Add(this.userNameLbl);
            this.HeaderPnl.Controls.Add(this.welcomeLbl);
            this.HeaderPnl.Location = new System.Drawing.Point(22, 6);
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.Size = new System.Drawing.Size(1338, 149);
            this.HeaderPnl.TabIndex = 0;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.userNameLbl.Location = new System.Drawing.Point(226, 52);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(98, 21);
            this.userNameLbl.TabIndex = 9;
            this.userNameLbl.Text = "User\'s Name";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLbl.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.welcomeLbl.Location = new System.Drawing.Point(44, 52);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(176, 22);
            this.welcomeLbl.TabIndex = 7;
            this.welcomeLbl.Text = "Currently Logged in As:";
            this.welcomeLbl.Click += new System.EventHandler(this.welcomeLbl_Click);
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
            // lblBudgetTitle
            // 
            this.lblBudgetTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBudgetTitle.AutoSize = true;
            this.lblBudgetTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBudgetTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBudgetTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBudgetTitle.Location = new System.Drawing.Point(777, 289);
            this.lblBudgetTitle.Name = "lblBudgetTitle";
            this.lblBudgetTitle.Size = new System.Drawing.Size(119, 28);
            this.lblBudgetTitle.TabIndex = 11;
            this.lblBudgetTitle.Text = "Budget Title";
            // 
            // lblIncomeRemaining
            // 
            this.lblIncomeRemaining.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIncomeRemaining.AutoSize = true;
            this.lblIncomeRemaining.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeRemaining.Location = new System.Drawing.Point(786, 431);
            this.lblIncomeRemaining.Name = "lblIncomeRemaining";
            this.lblIncomeRemaining.Size = new System.Drawing.Size(60, 23);
            this.lblIncomeRemaining.TabIndex = 10;
            this.lblIncomeRemaining.Text = "$0000";
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillAmount.Location = new System.Drawing.Point(784, 379);
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
            this.lblExpenseAmount.Location = new System.Drawing.Point(791, 348);
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
            this.lblIncomeAmount.Location = new System.Drawing.Point(783, 319);
            this.lblIncomeAmount.Name = "lblIncomeAmount";
            this.lblIncomeAmount.Size = new System.Drawing.Size(64, 23);
            this.lblIncomeAmount.TabIndex = 7;
            this.lblIncomeAmount.Text = "$ 0000";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(581, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Income Remaining";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(581, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bills:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(581, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Expenses:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(581, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Income:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(579, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Budget:";
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
            this.statisticsChart.Location = new System.Drawing.Point(584, 467);
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(648, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "My Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 762);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statisticsChart);
            this.Controls.Add(this.lblBudgetTitle);
            this.Controls.Add(this.lblIncomeRemaining);
            this.Controls.Add(this.lblBillAmount);
            this.Controls.Add(this.HeaderPnl);
            this.Controls.Add(this.lblExpenseAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIncomeAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Budget Buddy Dashboard";
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentageCht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPnl;
        //       private System.Windows.Forms.Panel dashboardpnl;
        private System.Windows.Forms.Label welcomeLbl;
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
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label lblBudgetTitle;
        private System.Windows.Forms.Label label1;
    }
}