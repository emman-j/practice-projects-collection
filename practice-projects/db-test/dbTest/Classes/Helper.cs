using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace dbTest.Classes
{
    public static class Helper
    {
        public static string CnnVal(string name)
        { 
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
