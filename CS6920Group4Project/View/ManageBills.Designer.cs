﻿namespace CS6920Group4Project.View
{
    partial class ManageBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBills));
            this.billsWelcomeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.billAmountBox = new System.Windows.Forms.TextBox();
            this.budgetLbl = new System.Windows.Forms.Label();
            this.currentBudgetLbl = new System.Windows.Forms.Label();
            this.incomeDashBtn = new System.Windows.Forms.Button();
            this.incomeReportBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.currencyLbl = new System.Windows.Forms.Label();
            this.billDescBox = new System.Windows.Forms.TextBox();
            this.billBox = new System.Windows.Forms.TextBox();
            this.billBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // billsWelcomeLbl
            // 
            this.billsWelcomeLbl.AutoSize = true;
            this.billsWelcomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.billsWelcomeLbl.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billsWelcomeLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.billsWelcomeLbl.Location = new System.Drawing.Point(85, 60);
            this.billsWelcomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.billsWelcomeLbl.Name = "billsWelcomeLbl";
            this.billsWelcomeLbl.Size = new System.Drawing.Size(74, 21);
            this.billsWelcomeLbl.TabIndex = 0;
            this.billsWelcomeLbl.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(542, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Current Balance is:";
            // 
            // inLbl
            // 
            this.inLbl.AutoSize = true;
            this.inLbl.BackColor = System.Drawing.Color.Transparent;
            this.inLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLbl.Location = new System.Drawing.Point(353, 236);
            this.inLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inLbl.Name = "inLbl";
            this.inLbl.Size = new System.Drawing.Size(176, 26);
            this.inLbl.TabIndex = 2;
            this.inLbl.Text = "BILL INFORMATION";
            this.inLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(574, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bill Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(574, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(574, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(573, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Deposit Date";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(756, 440);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 7;
            // 
            // billAmountBox
            // 
            this.billAmountBox.Location = new System.Drawing.Point(756, 395);
            this.billAmountBox.Name = "billAmountBox";
            this.billAmountBox.Size = new System.Drawing.Size(227, 28);
            this.billAmountBox.TabIndex = 11;
            // 
            // budgetLbl
            // 
            this.budgetLbl.AutoSize = true;
            this.budgetLbl.BackColor = System.Drawing.Color.Transparent;
            this.budgetLbl.Location = new System.Drawing.Point(38, 236);
            this.budgetLbl.Name = "budgetLbl";
            this.budgetLbl.Size = new System.Drawing.Size(121, 21);
            this.budgetLbl.TabIndex = 12;
            this.budgetLbl.Text = "Current Budget:";
            // 
            // currentBudgetLbl
            // 
            this.currentBudgetLbl.AutoSize = true;
            this.currentBudgetLbl.BackColor = System.Drawing.Color.Transparent;
            this.currentBudgetLbl.Location = new System.Drawing.Point(165, 236);
            this.currentBudgetLbl.Name = "currentBudgetLbl";
            this.currentBudgetLbl.Size = new System.Drawing.Size(74, 21);
            this.currentBudgetLbl.TabIndex = 13;
            this.currentBudgetLbl.Text = "Personal ";
            // 
            // incomeDashBtn
            // 
            this.incomeDashBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.incomeDashBtn.ForeColor = System.Drawing.Color.White;
            this.incomeDashBtn.Location = new System.Drawing.Point(1218, 236);
            this.incomeDashBtn.Name = "incomeDashBtn";
            this.incomeDashBtn.Size = new System.Drawing.Size(175, 53);
            this.incomeDashBtn.TabIndex = 14;
            this.incomeDashBtn.Text = "DashBoard";
            this.incomeDashBtn.UseVisualStyleBackColor = false;
            // 
            // incomeReportBtn
            // 
            this.incomeReportBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.incomeReportBtn.ForeColor = System.Drawing.Color.White;
            this.incomeReportBtn.Location = new System.Drawing.Point(1218, 295);
            this.incomeReportBtn.Name = "incomeReportBtn";
            this.incomeReportBtn.Size = new System.Drawing.Size(175, 53);
            this.incomeReportBtn.TabIndex = 15;
            this.incomeReportBtn.Text = "Reports";
            this.incomeReportBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1218, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 53);
            this.button1.TabIndex = 16;
            this.button1.Text = "Manage Income";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1218, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 53);
            this.button2.TabIndex = 17;
            this.button2.Text = "Manage Expenses";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1218, 472);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 53);
            this.button3.TabIndex = 18;
            this.button3.Text = "Manage Bills";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1218, 530);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 53);
            this.button4.TabIndex = 19;
            this.button4.Text = "View Budget";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // currencyLbl
            // 
            this.currencyLbl.AutoSize = true;
            this.currencyLbl.BackColor = System.Drawing.Color.Transparent;
            this.currencyLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currencyLbl.Location = new System.Drawing.Point(724, 60);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(79, 23);
            this.currencyLbl.TabIndex = 20;
            this.currencyLbl.Text = "$1000.00";
            // 
            // billDescBox
            // 
            this.billDescBox.Location = new System.Drawing.Point(756, 345);
            this.billDescBox.Name = "billDescBox";
            this.billDescBox.Size = new System.Drawing.Size(227, 28);
            this.billDescBox.TabIndex = 22;
            // 
            // billBox
            // 
            this.billBox.Location = new System.Drawing.Point(756, 301);
            this.billBox.Name = "billBox";
            this.billBox.Size = new System.Drawing.Size(227, 28);
            this.billBox.TabIndex = 21;
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.billBtn.ForeColor = System.Drawing.Color.White;
            this.billBtn.Location = new System.Drawing.Point(842, 642);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(141, 36);
            this.billBtn.TabIndex = 23;
            this.billBtn.TabStop = false;
            this.billBtn.Text = "Add Bill";
            this.billBtn.UseVisualStyleBackColor = false;
            // 
            // ManageBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1437, 762);
            this.Controls.Add(this.billBtn);
            this.Controls.Add(this.billDescBox);
            this.Controls.Add(this.billBox);
            this.Controls.Add(this.currencyLbl);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.incomeReportBtn);
            this.Controls.Add(this.incomeDashBtn);
            this.Controls.Add(this.currentBudgetLbl);
            this.Controls.Add(this.budgetLbl);
            this.Controls.Add(this.billAmountBox);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billsWelcomeLbl);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageBills";
            this.Text = "Manage Budget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label billsWelcomeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label inLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar;
 //       private System.Windows.Forms.Button incomeBtn;
 //       private System.Windows.Forms.TextBox incomeBox;
 //       private System.Windows.Forms.TextBox incomeDescBox;
        private System.Windows.Forms.TextBox billAmountBox;
        private System.Windows.Forms.Label budgetLbl;
        private System.Windows.Forms.Label currentBudgetLbl;
        private System.Windows.Forms.Button incomeDashBtn;
        private System.Windows.Forms.Button incomeReportBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label currencyLbl;
        private System.Windows.Forms.TextBox billDescBox;
        private System.Windows.Forms.TextBox billBox;
        private System.Windows.Forms.Button billBtn;

    }
}