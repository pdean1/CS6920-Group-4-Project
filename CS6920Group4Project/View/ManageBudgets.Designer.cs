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
            this.budgetBtn.Click += new System.EventHandler(this.budgetBtn_Click);
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
            // ManageBudgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1437, 762);
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

    }
}