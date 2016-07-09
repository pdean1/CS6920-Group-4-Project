namespace CS6920Group4Project.View
{
    partial class ManageEarnings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEarnings));
            this.incomeLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.addEarningsBtn = new System.Windows.Forms.Button();
            this.earningAmountBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.earnGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.descTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.earnGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.incomeLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeLbl.Location = new System.Drawing.Point(13, 11);
            this.incomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(217, 26);
            this.incomeLbl.TabIndex = 2;
            this.incomeLbl.Text = "EARNINGS AT A GLANCE";
            this.incomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(969, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(972, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Deposit Date:";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(973, 292);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 4;
            this.monthCalendar.Tag = "Calendar";
            // 
            // addEarningsBtn
            // 
            this.addEarningsBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addEarningsBtn.ForeColor = System.Drawing.Color.White;
            this.addEarningsBtn.Location = new System.Drawing.Point(1072, 466);
            this.addEarningsBtn.Name = "addEarningsBtn";
            this.addEarningsBtn.Size = new System.Drawing.Size(109, 34);
            this.addEarningsBtn.TabIndex = 5;
            this.addEarningsBtn.TabStop = false;
            this.addEarningsBtn.Text = "Add Earnings";
            this.addEarningsBtn.UseVisualStyleBackColor = false;
            this.addEarningsBtn.Click += new System.EventHandler(this.addEarningsBtn_Click);
            // 
            // earningAmountBox
            // 
            this.earningAmountBox.Location = new System.Drawing.Point(972, 159);
            this.earningAmountBox.Name = "earningAmountBox";
            this.earningAmountBox.Size = new System.Drawing.Size(198, 28);
            this.earningAmountBox.TabIndex = 3;
            this.earningAmountBox.Tag = "Amount";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(976, 466);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(67, 34);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Reset";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(972, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Earning Title:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(976, 104);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(194, 28);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.Tag = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(968, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Add A New Earning";
            // 
            // earnGridView
            // 
            this.earnGridView.AllowUserToAddRows = false;
            this.earnGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.earnGridView.Location = new System.Drawing.Point(18, 40);
            this.earnGridView.Name = "earnGridView";
            this.earnGridView.Size = new System.Drawing.Size(932, 589);
            this.earnGridView.TabIndex = 29;
            this.earnGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.earnGridView_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1177, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "*";
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(976, 194);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(88, 21);
            this.desc.TabIndex = 31;
            this.desc.Text = "Description";
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(973, 218);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(197, 28);
            this.descTxt.TabIndex = 32;
            this.descTxt.Tag = "Description";
            // 
            // ManageEarnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 641);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.earnGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.earningAmountBox);
            this.Controls.Add(this.addEarningsBtn);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.incomeLbl);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageEarnings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manage Earnings";
            this.Load += new System.EventHandler(this.ManageEarnings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.earnGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button addEarningsBtn;
        private System.Windows.Forms.TextBox earningAmountBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView earnGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.TextBox descTxt;

    }
}