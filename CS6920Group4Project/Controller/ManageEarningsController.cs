﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.Model;

namespace CS6920Group4Project.Controller
{
    class ManageEarningsController
    {
        private static ManageEarningsController instance;

        private readonly ManageEarningsDAL earningDAL = new ManageEarningsDAL();

        private ManageEarningsController()
        {

        }
    }
}
