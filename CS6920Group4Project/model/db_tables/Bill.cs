using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.model
{
    public class Bill
    {
        int RecordID { get; set; }
        int BillCateogryID { get; set; }
        decimal Amount { get; set; }
        DateTime DateDue{ get; set; }
        DateTime? DatePaid { get; set; }
    }
}
