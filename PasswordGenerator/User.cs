using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class User
    {
        string Login { get; set; }
        string[] passwords { get; set; }
        string Lastpassword { get; set; }
        DateTime LastPassword { get; set; }
    }
}
