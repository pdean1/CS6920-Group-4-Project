namespace CS6920Group4Project.View
{
    partial class ManageExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageExpenses));
            this.incomeLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.expenseBtn = new System.Windows.Forms.Button();
            this.expenseAmountTxt = new System.Windows.Forms.TextBox();
            this.incomeDashBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.expenseCategoryBox = new System.Windows.Forms.ComboBox();
            this.expenseTitleTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.incomeLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeLbl.Location = new System.Drawing.Point(353, 236);
            this.incomeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(218, 26);
            this.incomeLbl.TabIndex = 2;
            this.incomeLbl.Text = "EXPENSE INFORMATION";
            this.incomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(574, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(573, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Due Date:";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(756, 440);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 7;
            // 
            // expenseBtn
            // 
            this.expenseBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.expenseBtn.ForeColor = System.Drawing.Color.White;
            this.expenseBtn.Location = new System.Drawing.Point(842, 629);
            this.expenseBtn.Name = "expenseBtn";
            this.expenseBtn.Size = new System.Drawing.Size(141, 36);
            this.expenseBtn.TabIndex = 8;
            this.expenseBtn.TabStop = false;
            this.expenseBtn.Text = "Add Expense";
            this.expenseBtn.UseVisualStyleBackColor = false;
            this.expenseBtn.Click += new System.EventHandler(this.expenseBtn_Click);
            // 
            // expenseAmountTxt
            // 
            this.expenseAmountTxt.Location = new System.Drawing.Point(756, 395);
            this.expenseAmountTxt.Name = "expenseAmountTxt";
            this.expenseAmountTxt.Size = new System.Drawing.Size(227, 28);
            this.expenseAmountTxt.TabIndex = 11;
            // 
            // incomeDashBtn
            // 
            this.incomeDashBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.incomeDashBtn.ForeColor = System.Drawing.Color.White;
            this.incomeDashBtn.Location = new System.Drawing.Point(1218, 260);
            this.incomeDashBtn.Name = "incomeDashBtn";
            this.incomeDashBtn.Size = new System.Drawing.Size(175, 53);
            this.incomeDashBtn.TabIndex = 14;
            this.incomeDashBtn.Text = "DashBoard";
            this.incomeDashBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1218, 327);
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
            this.button2.Location = new System.Drawing.Point(1218, 395);
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
            this.button3.Location = new System.Drawing.Point(1218, 461);
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
            this.button4.Location = new System.Drawing.Point(1218, 526);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 53);
            this.button4.TabIndex = 19;
            this.button4.Text = "View Budget";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // expenseCategoryBox
            // 
            this.expenseCategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expenseCategoryBox.FormattingEnabled = true;
            this.expenseCategoryBox.Location = new System.Drawing.Point(756, 351);
            this.expenseCategoryBox.Name = "expenseCategoryBox";
            this.expenseCategoryBox.Size = new System.Drawing.Size(227, 29);
            this.expenseCategoryBox.TabIndex = 29;
            // 
            // expenseTitleTxt
            // 
            this.expenseTitleTxt.Location = new System.Drawing.Point(756, 311);
            this.expenseTitleTxt.Name = "expenseTitleTxt";
            this.expenseTitleTxt.Size = new System.Drawing.Size(227, 28);
            this.expenseTitleTxt.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(574, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Expense Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(574, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Expense Category:";
            // 
            // ManageExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1437, 762);
            this.Controls.Add(this.expenseCategoryBox);
            this.Controls.Add(this.expenseTitleTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.incomeDashBtn);
            this.Controls.Add(this.expenseAmountTxt);
            this.Controls.Add(this.expenseBtn);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.incomeLbl);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageExpenses";
            this.Text = "Manage Expenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button expenseBtn;
        private System.Windows.Forms.TextBox expenseAmountTxt;
        private System.Windows.Forms.Button incomeDashBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox expenseCategoryBox;
        private System.Windows.Forms.TextBox expenseTitleTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;

    }
}