using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.model
{
    public class Record
    {
        int ID { get; set; }
        int BudgetID { get; set; }
        char RecordType { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        DateTime DateCreated { get; set; }
    }
}
