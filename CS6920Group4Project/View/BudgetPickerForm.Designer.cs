namespace CS6920Group4Project.View
{
    partial class BudgetPickerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetPickerForm));
            this.cbBudgets = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cbBudgets
            // 
            this.cbBudgets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBudgets.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cbBudgets.FormattingEnabled = true;
            this.cbBudgets.Location = new System.Drawing.Point(12, 30);
            this.cbBudgets.Name = "cbBudgets";
            this.cbBudgets.Size = new System.Drawing.Size(260, 34);
            this.cbBudgets.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.MintCream;
            this.btnEdit.Location = new System.Drawing.Point(12, 70);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Budget";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.MintCream;
            this.btnDelete.Location = new System.Drawing.Point(147, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Budget";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a Budget to Edit or Delete";
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveLinkColor = System.Drawing.Color.Green;
            this.btnCreate.AutoSize = true;
            this.btnCreate.LinkColor = System.Drawing.Color.Magenta;
            this.btnCreate.Location = new System.Drawing.Point(9, 119);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(107, 13);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.TabStop = true;
            this.btnCreate.Text = "Create a new Budget";
            this.btnCreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCreate_LinkClicked);
            // 
            // BudgetPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(284, 138);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbBudgets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BudgetPickerForm";
            this.Text = "Let\'s manage!";
            this.Load += new System.EventHandler(this.BudgetPickerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBudgets;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel btnCreate;
    }
}