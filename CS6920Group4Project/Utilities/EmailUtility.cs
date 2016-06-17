using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Utilities
{
    public static class EmailUtility
    {
        public static Boolean ValidEmail(String Email)
        {
            if (String.IsNullOrEmpty(Email))
            {
                return false;
            }

            try
            {
                var MailAddr = new System.Net.Mail.MailAddress(Email);
                return String.Compare(MailAddr.Address, Email) == 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
