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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.rightDashPnl = new System.Windows.Forms.Panel();
            this.leftDashPnl = new System.Windows.Forms.Panel();
            this.percentageCht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainDashPnl = new System.Windows.Forms.Panel();
            this.HeaderPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentageCht)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPnl.Controls.Add(this.balanceLbl);
            this.HeaderPnl.Controls.Add(this.welcomeLbl);
            this.HeaderPnl.Location = new System.Drawing.Point(22, 6);
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.Size = new System.Drawing.Size(1338, 149);
            this.HeaderPnl.TabIndex = 0;
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
            this.welcomeLbl.Location = new System.Drawing.Point(141, 52);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(79, 22);
            this.welcomeLbl.TabIndex = 7;
            this.welcomeLbl.Text = "Welcome";
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
            this.leftDashPnl.Location = new System.Drawing.Point(1141, 171);
            this.leftDashPnl.Name = "leftDashPnl";
            this.leftDashPnl.Size = new System.Drawing.Size(219, 579);
            this.leftDashPnl.TabIndex = 3;
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
            this.mainDashPnl.BackColor = System.Drawing.Color.Transparent;
            this.mainDashPnl.Location = new System.Drawing.Point(297, 171);
            this.mainDashPnl.Name = "mainDashPnl";
            this.mainDashPnl.Size = new System.Drawing.Size(831, 577);
            this.mainDashPnl.TabIndex = 4;
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
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentageCht)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPnl;
        private System.Windows.Forms.Panel rightDashPnl;
        private System.Windows.Forms.Panel dashboardpnl;
        private System.Windows.Forms.Panel leftDashPnl;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart percentageCht;
        private System.Windows.Forms.Panel mainDashPnl;
    }
}