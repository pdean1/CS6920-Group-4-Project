﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS6920Group4Project.Model;
using CS6920Group4Project.View;
using CS6920Group4Project.model;
using CS6920Group4Project.DAL.Model;


namespace CS6920Group4Project.View
{
    public partial class Dashboard : Form
    {
        private User user;

        public Dashboard(User userName)
        {
            InitializeComponent();
            user = userName;
            userNameLbl.Text = user.FirstName + "" + user.LastName;
            
       }

        public Dashboard()
        {
            // TODO: Complete member initialization
        }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
