using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace dbTest2
{
    public class DataAccess
    {
        public List<Customer> GetCustomer(string customerCountry)
        {
            using (var connection = Helper.GetSqlConnection("NorthwindDB"))
            {
                var output = connection.Query<Customer>
                    ($"select * from Customers where country = '{customerCountry}'").ToList();
                return output;
            }
        }

        public List<Employees> GetEmployees(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NorthwindDB")))
            {
                return connection.Query<Employees>
                    ($"select * from Employees where @LastName = '{lastName}'").ToList();
            }
        }

        public List<Customer> ViewCustomer()
        {
            using (var connection = Helper.GetSqlConnection("NorthwindDB"))
            {
                var output = connection.Query<Customer>($"select * from Customers").ToList();
                return output;
            }
        }


    }
}
