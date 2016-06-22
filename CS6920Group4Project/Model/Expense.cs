using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.model
{
    public class Expense : Record
    {
        int ExpenseCategoryID { get; set; }
        decimal Amount { get; set; }
        DateTime DateSpent { get; set; }
    }
}
