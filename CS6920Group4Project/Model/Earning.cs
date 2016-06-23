﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Model
{
    public class Earning : Record
    {
        public int RecordID { get; set; }
        public int EarningCategoryID { get; set; }
        public EarningCategory Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateEarned { get; set; }
    }
}
