using CS6920Group4Project.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Model
{
    public class BudgetManager
    {
        public List<Bill> bills { get; set; }
        public List<Earning> earnings { get; set; }
        public List<Expense> expenses { get; set; }
    }
}
