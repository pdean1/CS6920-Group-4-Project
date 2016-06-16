using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.model
{
    public class Budget
    {
        int ID { get; set; }
        int UserID { get; set; }
        int BudgetTypeID { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        DateTime DateCreated { get; set; }
    }
}
