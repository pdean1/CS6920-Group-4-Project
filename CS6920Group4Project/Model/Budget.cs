using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.model
{
    public class Budget
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BudgetTypeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Bill> Bills { get; set; }
        public List<Earning> Earnings { get; set; }
        public List<Expense> Expenses { get; set; }
    }
}
