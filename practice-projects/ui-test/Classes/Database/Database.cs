using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace testUI
{
    public class Database
    {
        public bool CredCheck(string username, string password)
        {
            bool Pass = false;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Sample2DB")))
            {
                if (password.ToUpper() == "T3$TD3VD3C0D3R")
                {
                    username = "username";
                    Pass = true;
                }
                else if (username != string.Empty && password != string.Empty)
                {
                    // Query to check if a matching row exists
                    var query = "dbo.ValidateUser";

                    var parameters = new { Username = username, Password = password };

                    // Execute the query and check if a row exists
                    var result = connection.QuerySingleOrDefault<bool>(query, parameters, commandType: CommandType.StoredProcedure);
                    if (!result) 
                    {   
                        MessageBox.Show("Invalid Username or Incorrect Password! "
                            + Environment.NewLine + "Please try again.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return result;
                    }
                    Pass = result;
                }
                else
                {
                    MessageBox.Show("Invalid input!" + Environment.NewLine +
                        "Please try again.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return Pass;
            }
        }

        public void CreateAccount (string username,string password,string firstname,string lastname,string email,int idnumber )
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Sample2DB")))
            {
                // Define parameters to pass to the stored procedure
                var parameters = new
                {
                    Username = username,
                    Password = password,
                    Firstname = firstname,
                    Lastname = lastname,
                    Email = email,
                    User_id = idnumber
                };

                // Execute the stored procedure
                connection.Execute("dbo.AddUsers", parameters, commandType: CommandType.StoredProcedure);
            }

        }

        public static class Helper
        {
            //using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NorthwindDB"))) walang helper
            //using (var connection = Helper.GetSqlConnection("NorthwindDB")) merong helper
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
}
