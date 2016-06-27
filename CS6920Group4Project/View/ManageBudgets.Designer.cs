namespace CS6920Group4Project.View
{
    partial class ManageBudgets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBudgets));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.budgetBtn = new System.Windows.Forms.Button();
            this.budgetBox = new System.Windows.Forms.TextBox();
            this.budgetDescBox = new System.Windows.Forms.TextBox();
            this.incomeDashBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(574, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Budget Source";
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
            // budgetBtn
            // 
            this.budgetBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.budgetBtn.ForeColor = System.Drawing.Color.White;
            this.budgetBtn.Location = new System.Drawing.Point(842, 430);
            this.budgetBtn.Name = "budgetBtn";
            this.budgetBtn.Size = new System.Drawing.Size(141, 36);
            this.budgetBtn.TabIndex = 8;
            this.budgetBtn.TabStop = false;
            this.budgetBtn.Text = "Add Budget";
            this.budgetBtn.UseVisualStyleBackColor = false;
            // 
            // budgetBox
            // 
            this.budgetBox.Location = new System.Drawing.Point(756, 308);
            this.budgetBox.Name = "budgetBox";
            this.budgetBox.Size = new System.Drawing.Size(227, 28);
            this.budgetBox.TabIndex = 9;
            // 
            // budgetDescBox
            // 
            this.budgetDescBox.Location = new System.Drawing.Point(756, 352);
            this.budgetDescBox.Name = "budgetDescBox";
            this.budgetDescBox.Size = new System.Drawing.Size(227, 28);
            this.budgetDescBox.TabIndex = 10;
            // 
            // incomeDashBtn
            // 
            this.incomeDashBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.incomeDashBtn.ForeColor = System.Drawing.Color.White;
            this.incomeDashBtn.Location = new System.Drawing.Point(1218, 251);
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
            this.button1.Location = new System.Drawing.Point(1218, 320);
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
            this.button2.Location = new System.Drawing.Point(1218, 389);
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
            this.button3.Location = new System.Drawing.Point(1218, 455);
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
            this.button4.Location = new System.Drawing.Point(1218, 520);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 53);
            this.button4.TabIndex = 19;
            this.button4.Text = "View Budget";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ManageBudgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1437, 762);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.incomeDashBtn);
            this.Controls.Add(this.budgetDescBox);
            this.Controls.Add(this.budgetBox);
            this.Controls.Add(this.budgetBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageBudgets";
            this.Text = "Manage Budget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //      private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button budgetBtn;
        private System.Windows.Forms.TextBox budgetBox;
        private System.Windows.Forms.TextBox budgetDescBox;
        private System.Windows.Forms.Button incomeDashBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

    }
}