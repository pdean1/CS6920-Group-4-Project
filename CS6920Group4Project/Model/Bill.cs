using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Model
{
    public class Bill : Record
    {
        int BillCateogryID { get; set; }
        decimal Amount { get; set; }
        DateTime DateDue{ get; set; }
        DateTime? DatePaid { get; set; }
    }
}
