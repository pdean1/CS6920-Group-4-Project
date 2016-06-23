using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Model
{
    
    public class Dashboard : Record
    {
        
        public Dashboard()
        {

        }
        public decimal IncomeTotal { get; set; }

        public decimal ExpenseTotal { get; set; }

        public decimal BillTotal { get; set; }

        public decimal Balance { get; set; }

    }
}
