﻿namespace CS6920Group4Project.View
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
            this.earningsWelcomeLbl = new System.Windows.Forms.Label();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.addEarningsBtn = new System.Windows.Forms.Button();
            this.earningAmountBox = new System.Windows.Forms.TextBox();
            this.userNameEarningsLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEarnings = new System.Windows.Forms.ComboBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // earningsWelcomeLbl
            // 
            this.earningsWelcomeLbl.AutoSize = true;
            this.earningsWelcomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.earningsWelcomeLbl.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earningsWelcomeLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.earningsWelcomeLbl.Location = new System.Drawing.Point(64, 60);
            this.earningsWelcomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.earningsWelcomeLbl.Name = "earningsWelcomeLbl";
            this.earningsWelcomeLbl.Size = new System.Drawing.Size(175, 21);
            this.earningsWelcomeLbl.TabIndex = 0;
            this.earningsWelcomeLbl.Text = "Currently Logged in As: ";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.incomeLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeLbl.Location = new System.Drawing.Point(330, 193);
            this.incomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(231, 26);
            this.incomeLbl.TabIndex = 2;
            this.incomeLbl.Text = "EARNINGS INFORMATION";
            this.incomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(574, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(574, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Deposit Date:";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(756, 422);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 4;
            // 
            // addEarningsBtn
            // 
            this.addEarningsBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addEarningsBtn.ForeColor = System.Drawing.Color.White;
            this.addEarningsBtn.Location = new System.Drawing.Point(842, 596);
            this.addEarningsBtn.Name = "addEarningsBtn";
            this.addEarningsBtn.Size = new System.Drawing.Size(141, 36);
            this.addEarningsBtn.TabIndex = 5;
            this.addEarningsBtn.TabStop = false;
            this.addEarningsBtn.Text = "Add Earnings";
            this.addEarningsBtn.UseVisualStyleBackColor = false;
            this.addEarningsBtn.Click += new System.EventHandler(this.addEarningsBtn_Click);
            // 
            // earningAmountBox
            // 
            this.earningAmountBox.Location = new System.Drawing.Point(756, 364);
            this.earningAmountBox.Name = "earningAmountBox";
            this.earningAmountBox.Size = new System.Drawing.Size(227, 28);
            this.earningAmountBox.TabIndex = 3;
            // 
            // userNameEarningsLbl
            // 
            this.userNameEarningsLbl.AutoSize = true;
            this.userNameEarningsLbl.BackColor = System.Drawing.Color.Transparent;
            this.userNameEarningsLbl.Location = new System.Drawing.Point(247, 60);
            this.userNameEarningsLbl.Name = "userNameEarningsLbl";
            this.userNameEarningsLbl.Size = new System.Drawing.Size(98, 21);
            this.userNameEarningsLbl.TabIndex = 21;
            this.userNameEarningsLbl.Text = "User\'s Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(574, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Earning Category:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(756, 596);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 36);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(574, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Earning Title:";
            // 
            // cbEarnings
            // 
            this.cbEarnings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEarnings.FormattingEnabled = true;
            this.cbEarnings.Location = new System.Drawing.Point(756, 313);
            this.cbEarnings.Name = "cbEarnings";
            this.cbEarnings.Size = new System.Drawing.Size(227, 29);
            this.cbEarnings.TabIndex = 2;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(756, 272);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(227, 28);
            this.tbTitle.TabIndex = 1;
            // 
            // ManageEarnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1437, 762);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.cbEarnings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userNameEarningsLbl);
            this.Controls.Add(this.earningAmountBox);
            this.Controls.Add(this.addEarningsBtn);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.incomeLbl);
            this.Controls.Add(this.earningsWelcomeLbl);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageEarnings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manage Earnings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label earningsWelcomeLbl;
        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button addEarningsBtn;
        private System.Windows.Forms.TextBox earningAmountBox;
        private System.Windows.Forms.Label userNameEarningsLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEarnings;
        private System.Windows.Forms.TextBox tbTitle;

    }
}