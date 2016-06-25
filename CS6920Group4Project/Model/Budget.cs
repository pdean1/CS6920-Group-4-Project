using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Model
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

        public decimal GetTotalAmountOfBills ()
        {
            decimal amount = 0;
            foreach (Bill b in Bills)
            {
                amount += b.Amount;
            }
            return amount;
        }
        
        public decimal GetTotalAmountOfEarnings()
        {
            decimal amount = 0;
            foreach (Earning e in Earnings)
            {
                amount += e.Amount;
            }
            return amount;
        }
        
        public decimal GetTotalAmountOfExpenses()
        {
            decimal amount = 0;
            foreach (Expense e in Expenses)
            {
                amount += e.Amount;
            }
            return amount;
        }
    }
}
