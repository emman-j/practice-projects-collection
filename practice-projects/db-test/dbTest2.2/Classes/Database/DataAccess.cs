using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace dbTest2
{
    public class DataAccess
    {
        // using stored procedure format 
        //return connection.Query<Employees>("dbo.Employee_GetByLastName @LastName", new { LastName = lastName }).ToList();
               
        public List<Customer> GetCustomer(string customerCountry)
        {
            using (var connection = Helper.GetSqlConnection("NorthwindDB"))
            {
                var output = connection.Query<Customer>
                    //($"select * from Customers where country = '{customerCountry}'").ToList();
                    ("dbo.CustListByCountry @Country", new { Country = customerCountry }).ToList();
                return output;
            }
        }

        public List<Employees> GetEmployees(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NorthwindDB")))
            {
                return connection.Query<Employees>
                    //($"select * from Employees where LastName = '{lastName}'").ToList();
                    ("dbo.EmpListByLastName @LastName", new { LastName = lastName }).ToList();
            }
        }

        public List<Customer> ViewCustomer()
        {
           // SqlDataAdapter sda = new SqlDataAdapter(cmd);
           
            using (var connection = Helper.GetSqlConnection("NorthwindDB"))
            {
                var output = connection.Query<Customer>($"select * from Customers").ToList();
                return output;
            }
        }

        public List<Employees> ViewEmployees()
        {
            using (var connection = Helper.GetSqlConnection("NorthwindDB"))
            {
                var output = connection.Query<Employees>($"select * from Employees").ToList();
                return output;
            }
        }

    }
}
