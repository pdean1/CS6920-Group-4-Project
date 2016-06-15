using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.model
{
    public class Earning : Record
    {
        int RecordID { get; set; }
        int EarningCategoryID { get; set; }
        decimal Amount { get; set; }
        DateTime DateEarned { get; set; }
    }
}
