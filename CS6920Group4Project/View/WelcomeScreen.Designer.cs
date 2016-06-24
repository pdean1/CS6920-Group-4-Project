namespace CS6920Group4Project.View
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.llCreateAccount = new System.Windows.Forms.LinkLabel();
            this.userLbl = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(402, 474);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(274, 20);
            this.tbUserName.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(817, 474);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(274, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLogIn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.MintCream;
            this.btnLogIn.Location = new System.Drawing.Point(658, 552);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(103, 34);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Submit";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // llCreateAccount
            // 
            this.llCreateAccount.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.llCreateAccount.AutoSize = true;
            this.llCreateAccount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llCreateAccount.LinkColor = System.Drawing.Color.DarkKhaki;
            this.llCreateAccount.Location = new System.Drawing.Point(585, 612);
            this.llCreateAccount.Name = "llCreateAccount";
            this.llCreateAccount.Size = new System.Drawing.Size(231, 19);
            this.llCreateAccount.TabIndex = 5;
            this.llCreateAccount.TabStop = true;
            this.llCreateAccount.Text = "New User? Create a New Account.";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.BackColor = System.Drawing.Color.Transparent;
            this.userLbl.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.userLbl.Location = new System.Drawing.Point(296, 472);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(97, 22);
            this.userLbl.TabIndex = 6;
            this.userLbl.Text = "User Name:";
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.BackColor = System.Drawing.Color.Transparent;
            this.PassLbl.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.PassLbl.Location = new System.Drawing.Point(717, 472);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(85, 22);
            this.PassLbl.TabIndex = 7;
            this.PassLbl.Text = "Password:";
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 762);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.llCreateAccount);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeScreen";
            this.Text = "Budget Buddy";
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.LinkLabel llCreateAccount;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label PassLbl;
    }
}