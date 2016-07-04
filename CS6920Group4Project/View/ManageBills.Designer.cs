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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.billAmountTxt = new System.Windows.Forms.TextBox();
            this.billBtn = new System.Windows.Forms.Button();
            this.billTitleTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.billDescTxt = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inLbl
            // 
            this.inLbl.AutoSize = true;
            this.inLbl.BackColor = System.Drawing.Color.Transparent;
            this.inLbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLbl.Location = new System.Drawing.Point(309, 188);
            this.inLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inLbl.Name = "inLbl";
            this.inLbl.Size = new System.Drawing.Size(176, 26);
            this.inLbl.TabIndex = 2;
            this.inLbl.Text = "BILL INFORMATION";
            this.inLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(1200, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bill Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1201, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Deposit Date:";
            // 
            // billAmountTxt
            // 
            this.billAmountTxt.Location = new System.Drawing.Point(1160, 394);
            this.billAmountTxt.Name = "billAmountTxt";
            this.billAmountTxt.Size = new System.Drawing.Size(183, 28);
            this.billAmountTxt.TabIndex = 4;
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.billBtn.ForeColor = System.Drawing.Color.White;
            this.billBtn.Location = new System.Drawing.Point(1269, 629);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(97, 30);
            this.billBtn.TabIndex = 6;
            this.billBtn.TabStop = false;
            this.billBtn.Text = "Add Bill";
            this.billBtn.UseVisualStyleBackColor = false;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // billTitleTxt
            // 
            this.billTitleTxt.Location = new System.Drawing.Point(1160, 282);
            this.billTitleTxt.Name = "billTitleTxt";
            this.billTitleTxt.Size = new System.Drawing.Size(183, 28);
            this.billTitleTxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(1215, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Bill Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1191, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Bill Description:";
            // 
            // billDescTxt
            // 
            this.billDescTxt.Location = new System.Drawing.Point(1160, 339);
            this.billDescTxt.Name = "billDescTxt";
            this.billDescTxt.Size = new System.Drawing.Size(183, 28);
            this.billDescTxt.TabIndex = 3;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(1139, 455);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 5;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(1188, 629);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 30);
            this.resetBtn.TabIndex = 32;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1177, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Add A New Bill";
            // 
            // ManageBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 762);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.billDescTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billTitleTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.billBtn);
            this.Controls.Add(this.billAmountTxt);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
 //       private System.Windows.Forms.Button incomeBtn;
 //       private System.Windows.Forms.TextBox incomeBox;
 //       private System.Windows.Forms.TextBox incomeDescBox;
        private System.Windows.Forms.TextBox billAmountTxt;
        private System.Windows.Forms.Button billBtn;
        private System.Windows.Forms.TextBox billTitleTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox billDescTxt;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label1;

    }
}