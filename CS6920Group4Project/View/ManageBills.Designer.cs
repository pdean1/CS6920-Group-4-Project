namespace CS6920Group4Project.View
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
            this.inLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.billAmountTxt = new System.Windows.Forms.TextBox();
            this.billBtn = new System.Windows.Forms.Button();
            this.billCategoryBox = new System.Windows.Forms.ComboBox();
            this.billTitleTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.billDescTxt = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(575, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bill Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(574, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bill Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(573, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Deposit Date:";
            // 
            // billAmountTxt
            // 
            this.billAmountTxt.Location = new System.Drawing.Point(756, 395);
            this.billAmountTxt.Name = "billAmountTxt";
            this.billAmountTxt.Size = new System.Drawing.Size(227, 28);
            this.billAmountTxt.TabIndex = 4;
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.billBtn.ForeColor = System.Drawing.Color.White;
            this.billBtn.Location = new System.Drawing.Point(842, 642);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(141, 36);
            this.billBtn.TabIndex = 6;
            this.billBtn.TabStop = false;
            this.billBtn.Text = "Add Bill";
            this.billBtn.UseVisualStyleBackColor = false;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // billCategoryBox
            // 
            this.billCategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.billCategoryBox.FormattingEnabled = true;
            this.billCategoryBox.Location = new System.Drawing.Point(757, 306);
            this.billCategoryBox.Name = "billCategoryBox";
            this.billCategoryBox.Size = new System.Drawing.Size(227, 29);
            this.billCategoryBox.TabIndex = 2;
            // 
            // billTitleTxt
            // 
            this.billTitleTxt.Location = new System.Drawing.Point(756, 261);
            this.billTitleTxt.Name = "billTitleTxt";
            this.billTitleTxt.Size = new System.Drawing.Size(227, 28);
            this.billTitleTxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(574, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Bill Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(575, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Bill Description:";
            // 
            // billDescTxt
            // 
            this.billDescTxt.Location = new System.Drawing.Point(756, 354);
            this.billDescTxt.Name = "billDescTxt";
            this.billDescTxt.Size = new System.Drawing.Size(227, 28);
            this.billDescTxt.TabIndex = 3;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(756, 440);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 5;
            // 
            // ManageBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1437, 762);
            this.Controls.Add(this.billDescTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billTitleTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.billCategoryBox);
            this.Controls.Add(this.billBtn);
            this.Controls.Add(this.billAmountTxt);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inLbl);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageBills";
            this.Text = "Manage Bills";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
 //       private System.Windows.Forms.Button incomeBtn;
 //       private System.Windows.Forms.TextBox incomeBox;
 //       private System.Windows.Forms.TextBox incomeDescBox;
        private System.Windows.Forms.TextBox billAmountTxt;
        private System.Windows.Forms.Button billBtn;
        private System.Windows.Forms.ComboBox billCategoryBox;
        private System.Windows.Forms.TextBox billTitleTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox billDescTxt;
        private System.Windows.Forms.MonthCalendar monthCalendar;

    }
}