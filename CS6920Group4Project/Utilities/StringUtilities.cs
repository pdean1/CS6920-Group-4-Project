using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Utilities
{
    public class StringUtilities
    {
        public static string GetDisplayableDollarAmount(decimal amount)
        {
            return string.Format("{0:c}", amount);
        }
    }
}
