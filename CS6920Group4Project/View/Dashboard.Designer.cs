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
            this.balanceLbl = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.rightDashPnl = new System.Windows.Forms.Panel();
            this.leftDashPnl = new System.Windows.Forms.Panel();
            this.DashBudbtn = new System.Windows.Forms.Button();
            this.dashBillBtn = new System.Windows.Forms.Button();
            this.dashExpBtn = new System.Windows.Forms.Button();
            this.dashEarnBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.percentageCht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainDashPnl = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HeaderPnl.SuspendLayout();
            this.leftDashPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentageCht)).BeginInit();
            this.mainDashPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPnl.Controls.Add(this.userNameLbl);
            this.HeaderPnl.Controls.Add(this.balanceLbl);
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
            this.userNameLbl.Location = new System.Drawing.Point(227, 54);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(98, 21);
            this.userNameLbl.TabIndex = 9;
            this.userNameLbl.Text = "User\'s Name";
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.balanceLbl.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.balanceLbl.Location = new System.Drawing.Point(540, 52);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(183, 22);
            this.balanceLbl.TabIndex = 8;
            this.balanceLbl.Text = "Your Current balance is:";
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
            // rightDashPnl
            // 
            this.rightDashPnl.BackColor = System.Drawing.Color.Transparent;
            this.rightDashPnl.Location = new System.Drawing.Point(22, 171);
            this.rightDashPnl.Name = "rightDashPnl";
            this.rightDashPnl.Size = new System.Drawing.Size(261, 579);
            this.rightDashPnl.TabIndex = 1;
            // 
            // leftDashPnl
            // 
            this.leftDashPnl.BackColor = System.Drawing.Color.Transparent;
            this.leftDashPnl.Controls.Add(this.DashBudbtn);
            this.leftDashPnl.Controls.Add(this.dashBillBtn);
            this.leftDashPnl.Controls.Add(this.dashExpBtn);
            this.leftDashPnl.Controls.Add(this.dashEarnBtn);
            this.leftDashPnl.Controls.Add(this.button1);
            this.leftDashPnl.Location = new System.Drawing.Point(1141, 171);
            this.leftDashPnl.Name = "leftDashPnl";
            this.leftDashPnl.Size = new System.Drawing.Size(219, 579);
            this.leftDashPnl.TabIndex = 3;
            // 
            // DashBudbtn
            // 
            this.DashBudbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.DashBudbtn.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBudbtn.ForeColor = System.Drawing.Color.White;
            this.DashBudbtn.Location = new System.Drawing.Point(23, 311);
            this.DashBudbtn.Name = "DashBudbtn";
            this.DashBudbtn.Size = new System.Drawing.Size(175, 53);
            this.DashBudbtn.TabIndex = 6;
            this.DashBudbtn.Text = "View Budget";
            this.DashBudbtn.UseVisualStyleBackColor = false;
            this.DashBudbtn.Click += new System.EventHandler(this.DashBudbtn_Click);
            // 
            // dashBillBtn
            // 
            this.dashBillBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.dashBillBtn.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBillBtn.ForeColor = System.Drawing.Color.White;
            this.dashBillBtn.Location = new System.Drawing.Point(23, 235);
            this.dashBillBtn.Name = "dashBillBtn";
            this.dashBillBtn.Size = new System.Drawing.Size(175, 53);
            this.dashBillBtn.TabIndex = 5;
            this.dashBillBtn.Text = "Manage Bills";
            this.dashBillBtn.UseVisualStyleBackColor = false;
            this.dashBillBtn.Click += new System.EventHandler(this.dashBillBtn_Click);
            // 
            // dashExpBtn
            // 
            this.dashExpBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.dashExpBtn.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashExpBtn.ForeColor = System.Drawing.Color.White;
            this.dashExpBtn.Location = new System.Drawing.Point(23, 161);
            this.dashExpBtn.Name = "dashExpBtn";
            this.dashExpBtn.Size = new System.Drawing.Size(175, 53);
            this.dashExpBtn.TabIndex = 4;
            this.dashExpBtn.Text = "Manage Expenses";
            this.dashExpBtn.UseVisualStyleBackColor = false;
            this.dashExpBtn.Click += new System.EventHandler(this.dashExpBtn_Click);
            // 
            // dashEarnBtn
            // 
            this.dashEarnBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.dashEarnBtn.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashEarnBtn.ForeColor = System.Drawing.Color.White;
            this.dashEarnBtn.Location = new System.Drawing.Point(23, 90);
            this.dashEarnBtn.Name = "dashEarnBtn";
            this.dashEarnBtn.Size = new System.Drawing.Size(175, 53);
            this.dashEarnBtn.TabIndex = 3;
            this.dashEarnBtn.Text = "Manage Earnings";
            this.dashEarnBtn.UseVisualStyleBackColor = false;
            this.dashEarnBtn.Click += new System.EventHandler(this.dashEarnBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1218, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
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
            // mainDashPnl
            // 
            this.mainDashPnl.BackColor = System.Drawing.Color.White;
            this.mainDashPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDashPnl.Controls.Add(this.label10);
            this.mainDashPnl.Controls.Add(this.label9);
            this.mainDashPnl.Controls.Add(this.label8);
            this.mainDashPnl.Controls.Add(this.label7);
            this.mainDashPnl.Controls.Add(this.label6);
            this.mainDashPnl.Controls.Add(this.label5);
            this.mainDashPnl.Controls.Add(this.label4);
            this.mainDashPnl.Controls.Add(this.label3);
            this.mainDashPnl.Controls.Add(this.label2);
            this.mainDashPnl.Controls.Add(this.label1);
            this.mainDashPnl.Controls.Add(this.statisticsChart);
            this.mainDashPnl.Location = new System.Drawing.Point(297, 171);
            this.mainDashPnl.Name = "mainDashPnl";
            this.mainDashPnl.Size = new System.Drawing.Size(831, 577);
            this.mainDashPnl.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(484, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "$0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(485, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "$0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "$0000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "$ 0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(281, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Income Remaining";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(281, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bills:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(281, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Expenses:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(281, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Income:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(118, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Budget:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(338, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // statisticsChart
            // 
            this.statisticsChart.BackColor = System.Drawing.Color.Transparent;
            this.statisticsChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statisticsChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.statisticsChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.statisticsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.statisticsChart.Legends.Add(legend2);
            this.statisticsChart.Location = new System.Drawing.Point(307, 361);
            this.statisticsChart.Name = "statisticsChart";
            this.statisticsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.statisticsChart.Series.Add(series2);
            this.statisticsChart.Size = new System.Drawing.Size(221, 194);
            this.statisticsChart.TabIndex = 0;
            this.statisticsChart.Text = "Budget Statistics";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 762);
            this.Controls.Add(this.mainDashPnl);
            this.Controls.Add(this.leftDashPnl);
            this.Controls.Add(this.rightDashPnl);
            this.Controls.Add(this.HeaderPnl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Budget Buddy Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            this.leftDashPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.percentageCht)).EndInit();
            this.mainDashPnl.ResumeLayout(false);
            this.mainDashPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPnl;
        private System.Windows.Forms.Panel rightDashPnl;
 //       private System.Windows.Forms.Panel dashboardpnl;
        private System.Windows.Forms.Panel leftDashPnl;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart percentageCht;
        private System.Windows.Forms.Panel mainDashPnl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticsChart;
        private System.Windows.Forms.Button dashBillBtn;
        private System.Windows.Forms.Button dashExpBtn;
        private System.Windows.Forms.Button dashEarnBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DashBudbtn;
        private System.Windows.Forms.Label userNameLbl;
    }
}