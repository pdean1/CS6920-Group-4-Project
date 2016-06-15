using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.model
{
    public class User
    {
        int ID { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateUpdated { get; set; }
    }
}
