using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Model
{
    
    class Dashboard
    {
        private decimal incomeTotal;
        private decimal expenseTotal;
        private decimal billTotal;
        private decimal balance;

        public Dashboard()
        {

        }
        public decimal IncomeTotal { get; set; }

        public decimal ExpenseTotal { get; set; }

        public decimal BillTotal { get; set; }

        public decimal Balance { get; set; }

        public decimal IncomeRemaining()
        {
            return incomeTotal - billTotal - expenseTotal;
        }
    }
}
