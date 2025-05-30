using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace dbTest.Classes
{
    public class DataAccess
    {
        public List<Employees> FindEmployees(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NorthwindDB")))
            {
                return connection.Query<Employees>($"select * from Employees where LastName = '{ lastName }'").ToList();
/*                var output = connection.Query<Employees>("dbo.Employee_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;*/
            }
        }

/*        public List<Employees> GetAllEmployees()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NorthwindDB")))
            {
               return connection.Query<Employees>($"select * from Employees").ToList();
            }
        }*/
    }
}
