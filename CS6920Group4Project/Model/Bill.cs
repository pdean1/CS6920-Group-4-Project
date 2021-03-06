﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Model
{
    public class Bill : Record
    {
        public decimal Amount { get; set; }
        public DateTime DateDue{ get; set; }
        public DateTime? DatePaid { get; set; }
    }
}
