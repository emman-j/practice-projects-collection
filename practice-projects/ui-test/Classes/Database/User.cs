using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUI
{
    public class UserCredentials
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

    }

    public class UserProfile
    {
        public int user_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }

    }

    public class UserAccount
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
    }
}
