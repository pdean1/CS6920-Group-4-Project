using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Model
{
    public class Expense : Record
    {
        public decimal Amount { get; set; }
        public DateTime DateSpent { get; set; }
      }
}
