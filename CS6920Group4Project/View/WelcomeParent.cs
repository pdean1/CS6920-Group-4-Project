﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS6920Group4Project.View
{
    public partial class WelcomeParent : Form        
    { 
        Dashboard dashboard;
        public WelcomeParent()
        {
            InitializeComponent();
        }

        private void viewBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the dashboard within the parent form
            if(dashboard == null) {
               dashboard = new Dashboard();
               dashboard.MdiParent = this;
               dashboard.FormClosed += new FormClosedEventHandler(dashboard_FormClosed);
               dashboard.Show();
            }
            else
                dashboard.Activate();
        }

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
 	        dashboard = null;
        }
    
  }
}