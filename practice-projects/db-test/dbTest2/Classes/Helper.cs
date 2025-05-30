using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbTest2
{

    public static class Helper
    {
        //using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NorthwindDB")))
        //using (var connection = Helper.GetSqlConnection("NorthwindDB"))
        public static SqlConnection GetSqlConnection(string connectionStringName)
        {
            string connectionString = CnnVal(connectionStringName);
            return new SqlConnection(connectionString);
        }

        public static String CnnVal(string name)
        { 
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
