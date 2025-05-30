using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    public class Database 
    {
        private static bool connectionStatus = false;
        private static bool dbnull = false; // for checking if tables/database is empty
        public static string _Server { get; set; } = "10.10.10.25,1433"; //"DESKTOP-8KEBO4O";
        public static string _Database { get; set; } = "TrackerDB";  //"TrackerTest";
        public static string _UserId { get; set; } = "sa";  //"sa";
        public static string _Password { get; set; } = "s@"; //"s@"; 
        public static int ConnectionTimeout { get; set; } = 45;
        public static bool IsConnectionTrusted { get; set; } = false;
        public static bool IsDBConnected
        {
            get { return connectionStatus; }
            set
            {
                if (connectionStatus != value)
                {
                    connectionStatus = value;
                    NotifyPropertyChanged(nameof(IsDBConnected));
                }
            }
        }
        public static string connectionString
        {
            get
            {
                if (IsConnectionTrusted)
                {
                    return $"Server={_Server};Database={_Database};Trusted_Connection=True;Connection Timeout={ConnectionTimeout};";
                }
                else
                {
                    return $"Server={_Server};Database={_Database};User ID={_UserId};Password={_Password};Connection Timeout={ConnectionTimeout};";
                }
            }
        }
        public void SetConnectionParameters(string server, string database, string password, string userId, bool trustedconnection)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(server))
                    throw new ArgumentException("Server name cannot be null or empty", nameof(server));

                if (string.IsNullOrWhiteSpace(database))
                    throw new ArgumentException("Database name cannot be null or empty", nameof(database));

                if (trustedconnection == false)
                {
                    if (string.IsNullOrWhiteSpace(userId))
                        throw new ArgumentException("Username/User ID cannot be null or empty", nameof(userId));

                    if (string.IsNullOrWhiteSpace(password))
                        throw new ArgumentException("Password cannot be null or empty", nameof(password));
                    _UserId = userId;
                    _Password = password;
                }

                _Server = server;
                _Database = database;
                IsConnectionTrusted = trustedconnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input." + $"\n{ex.Message}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region -------------PROPERTY CHANGE----------------

        public static event Action<string> PropertyChanged;

        private static void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(propertyName);
        }
        #endregion

        public static async Task<bool> IsConnected()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    IsDBConnected = true;
                    return true;
                }
            }
            #region CATCH
            catch (SqlException ex) when (ex.Number == -2)
            {
                Debug.WriteLine("-----------------------------Connection Timeout------------------------------");
                Debug.WriteLine($"SQL Exception: {ex.Message}");
                Console.WriteLine($"SQL Exception: {ex.Message}");
                IsDBConnected = false;
                return false;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("-----------------------------Cannot connect to Database------------------------------");
                Debug.WriteLine($"SQL Exception: {ex.Message}");
                Console.WriteLine($"SQL Exception: {ex.Message}");
                IsDBConnected = false;
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("-----------------------------Cannot connect to Database------------------------------");
                Debug.WriteLine($"General Exception: {ex.Message}");
                Console.WriteLine($"General Exception: {ex.Message}");
                IsDBConnected = false;
                return false;
            }
            #endregion
        }
        public async Task TestDBConnectionAsync(System.Windows.Forms.Label label)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    label.Visible = true;
                    label.Text = "Connecting";
                    await connection.OpenAsync();
                    label.Text = "Connected to Database";
                    IsDBConnected = true;
                }
            }
            #region CATCH
            catch (SqlException ex) when (ex.Number == -2)
            {
                label.Text = "Connection Timeout";
                Debug.WriteLine("-----------------------------Connection Timeout------------------------------");
                Debug.WriteLine($"SQL Exception: {ex.Message}");
                Console.WriteLine($"SQL Exception: {ex.Message}");
                IsDBConnected = false;
            }
            catch (SqlException ex)
            {
                label.Text = "Cannot connect to Database";

                Debug.WriteLine("-----------------------------Cannot connect to Database------------------------------");
                Debug.WriteLine($"SQL Exception: {ex.Message}");
                Console.WriteLine($"SQL Exception: {ex.Message}");
                IsDBConnected = false;
            }
            catch (Exception ex)
            {
                label.Text = "Cannot connect to Database";
                Debug.WriteLine("-----------------------------Cannot connect to Database------------------------------");
                Debug.WriteLine($"General Exception: {ex.Message}");
                Console.WriteLine($"General Exception: {ex.Message}");
                IsDBConnected = false;
            }
            #endregion
        }
        public async Task TestDBConnectionAsync()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    IsDBConnected = true;
                }
            }
            #region CATCH
            catch (SqlException ex) when (ex.Number == -2)
            {
                Debug.WriteLine("-----------------------------Connection Timeout------------------------------");
                Debug.WriteLine($"SQL Exception: {ex.Message}");
                Console.WriteLine($"SQL Exception: {ex.Message}");
                IsDBConnected = false;
            }
            catch (SqlException ex)
            {
                Debug.WriteLine("-----------------------------Cannot connect to Database------------------------------");
                Debug.WriteLine($"SQL Exception: {ex.Message}");
                Console.WriteLine($"SQL Exception: {ex.Message}");
                IsDBConnected = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("-----------------------------Cannot connect to Database------------------------------");
                Debug.WriteLine($"General Exception: {ex.Message}");
                Console.WriteLine($"General Exception: {ex.Message}");
                IsDBConnected = false;
            }
            #endregion
        }

        public async Task<DataTable> GetTables(string storedProcedure)
        {
            DataTable dataTable = new DataTable();
            if (IsDBConnected)
            {
                try
                {

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(storedProcedure, connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        await Task.Run(() => dataAdapter.Fill(dataTable));
                    }
                    if (dataTable == null || dataTable.Rows.Count == 0)
                    {
                        Console.WriteLine("No data returned from the database.");
                        ErrorLogger.LogAppError("Database Error", $"No data returned from the stored procedure: {storedProcedure}");
                        //MessageBox.Show("No data returned from the database. \nYou can add new Projects/Activities in the Projects/Activities Manager",
                        //    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbnull = true;
                        return dataTable;
                    }
                    else
                    {
                        dbnull = false;
                        return dataTable;
                    }
                }
                #region Catch
                catch (SqlException ex) when (ex.Number == -2) // Handle timeout exceptions specifically
                {
                    Debug.WriteLine("-----------------------------Connection Timeout------------------------------");
                    ErrorLogger.CatchError(ex, "SQL Exception");
                    IsDBConnected = false;
                    return dataTable;
                }
                catch (SqlException ex)
                {
                    ErrorLogger.CatchError(ex, "SQL Exception");
                    IsDBConnected = false;
                    return dataTable;
                }
                catch (TargetInvocationException ex)
                {
                    ErrorLogger.CatchError(ex, "Target Invocation Exception");
                    IsDBConnected = false;
                    return dataTable;
                }
                catch (Exception ex)
                {
                    ErrorLogger.CatchError(ex, "General Exception");  
                    IsDBConnected = false;
                    return dataTable;
                }
                #endregion
            }
            else { return dataTable; }
        }
        public async Task<DataTable> GetTables(string storedProcedure, string mode)
        {
            string user = null;
            DataTable dataTable = new DataTable();
            if (await IsConnected())
            {
                try
                {

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Mode", mode);
                           command.Parameters.AddWithValue("@UserID", user);
                            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                            {
                                dataAdapter.Fill(dataTable);
                                //await Task.Run(() => );
                            }
                        }
                    }
                    if (dataTable == null || dataTable.Rows.Count == 0)
                    {
                        Console.WriteLine("No data returned from the database.");
                        ErrorLogger.LogAppError("Database Error", $"No data returned from the stored procedure: {storedProcedure}");
                        //MessageBox.Show("No data returned from the database. \nYou can add new Projects/Activities in the Projects/Activities Manager",
                        //                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbnull = true;
                        return dataTable;
                    }
                    else
                    {
                        dbnull = false;
                        return dataTable;
                    }
                }
                #region Catch
                catch (SqlException ex) when (ex.Number == -2) // Handle timeout exceptions specifically
                {
                    Debug.WriteLine("-----------------------------Connection Timeout------------------------------");
                    ErrorLogger.CatchError(ex, "SQL Exception");
                    IsDBConnected = false;
                    return dataTable;
                }
                catch (SqlException ex)
                {
                    ErrorLogger.CatchError(ex, "SQL Exception");
                    IsDBConnected = false;
                    return dataTable;
                }
                catch (TargetInvocationException ex)
                {
                    ErrorLogger.CatchError(ex, "Target Invocation Exception");
                    IsDBConnected = false;
                    return dataTable;
                }
                catch (Exception ex)
                {
                    ErrorLogger.CatchError(ex, "General Exception");
                    IsDBConnected = false;
                    return dataTable;
                }
                #endregion
            }
            else { return dataTable; }

        }
        public async Task<DataTable> SearchAllActivities(string selectedColumn, string columnItem)
        {
            DataTable ActivitiesDataTable = new DataTable();

            if (await IsConnected())
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("dbo.Activity_SearchAll", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@SelectedColumn", selectedColumn);
                            command.Parameters.AddWithValue("@ColumnItem", columnItem);
                            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                            {
                                dataAdapter.Fill(ActivitiesDataTable);
                               // await Task.Run(() => );
                            }
                        }
                    }
                    if (ActivitiesDataTable == null || ActivitiesDataTable.Rows.Count == 0)
                    {
                        Console.WriteLine("No data returned from the database. ");
                        ErrorLogger.LogAppError("Database Error", $"No data returned from the stored procedure: dbo.Activity_SearchAll");
                        //MessageBox.Show("No data returned from the database. \nYou can add new Projects/Activities in the Projects/Activities Manager", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbnull = true;
                        return ActivitiesDataTable;
                    }
                    else 
                    {
                        dbnull = false;
                        return ActivitiesDataTable;
                    }
                }
                #region Catch
                catch (SqlException ex) when (ex.Number == -2) // Handle timeout exceptions specifically
                {
                    Debug.WriteLine("-----------------------------Connection Timeout------------------------------");
                    ErrorLogger.CatchError(ex, "SQL Exception");
                    IsDBConnected = false;
                    return ActivitiesDataTable;
                }
                catch (SqlException ex)
                {
                    ErrorLogger.CatchError(ex, "SQL Exception");
                    IsDBConnected = false;
                    return ActivitiesDataTable;
                }
                catch (TargetInvocationException ex)
                {
                    ErrorLogger.CatchError(ex, "Target Invocation Exception");
                    IsDBConnected = false;
                    return ActivitiesDataTable;
                }
                catch (Exception ex)
                {
                    ErrorLogger.CatchError(ex, "General Exception");
                    IsDBConnected = false;
                    return ActivitiesDataTable;
                }
                #endregion
            }
            else { return ActivitiesDataTable; }
        }
        public void GetCount(System.Windows.Forms.Label label, string count)
        {
            if (IsDBConnected)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand("dbo.Get_AllCount", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            SqlParameter userIdParameter = new SqlParameter("@UserID", SqlDbType.Int);
                            //userIdParameter.Value = (object)user.UserID ?? DBNull.Value;
                            command.Parameters.Add(userIdParameter);

                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int countColumnIndex = reader.GetOrdinal(count); 
                                    int countValue = 0;

                                    if (!reader.IsDBNull(countColumnIndex))
                                    {
                                        countValue = reader.GetInt32(countColumnIndex);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Count is null");
                                        label.Text = "0";
                                        return;
                                    }
                                    label.Text = countValue.ToString();
                                }
                            }
                        }
                    }
                }
                #region Catch
                catch (SqlException ex) when (ex.Number == -2) // Handle timeout exceptions specifically
                {
                    Debug.WriteLine("-----------------------------Connection Timeout------------------------------");
                    ErrorLogger.CatchError(ex, "SQL Exception");
                    IsDBConnected = false;
                    return;
                }
                catch (SqlException ex)
                {
                    ErrorLogger.CatchError(ex, "SQL Exception");
                    IsDBConnected = false;
                    return;
                }
                catch (TargetInvocationException ex)
                {
                    ErrorLogger.CatchError(ex, "Target Invocation Exception");
                    IsDBConnected = false;
                    return;
                }
                catch (Exception ex)
                {
                    ErrorLogger.CatchError(ex, "General Exception");
                    IsDBConnected = false;
                    return;
                }
                #endregion
            }
        }
        public async void GetSearchResults(string selectedColumn, string columnItem, System.Windows.Forms.DataGridView dataGridView)
        {
            Database database = new Database();
            DataTable ActivitiesDataTable = await database.SearchAllActivities(selectedColumn, columnItem);
            if (dbnull == true)
            { return; }
            dataGridView.DataSource = ActivitiesDataTable;
        }
        public async void LoadAllActivities(System.Windows.Forms.DataGridView dataGridView)
        {
            DataTable ActivitiesDataTable = await GetTables("dbo.Get_AllActivity");
            if (dbnull == true)
            { return; }
            dataGridView.DataSource = ActivitiesDataTable;
            dataGridView.AutoGenerateColumns = false;
            if (dataGridView.Columns.Contains("ActivityID"))
            {
                dataGridView.Columns.Remove("ActivityID");
            }
        }
        public async void LoadAllPriorities(System.Windows.Forms.DataGridView dataGridView)
        {
            DataTable dataTable = await GetTables("dbo.Get_TablesByModes", "Priority");
            if (dbnull == true)
            { return; }
            dataGridView.DataSource = dataTable;
        }
        public async void LoadAllUnfinished(System.Windows.Forms.DataGridView dataGridView)
        {
            DataTable dataTable = await GetTables("dbo.Get_AllUnfinished");
            if (dbnull == true)
            { return; }
            dataGridView.DataSource = dataTable;
        }
        public async void LoadAllStatus(System.Windows.Forms.DataGridView dataGridView)
        {
            DataTable dataTable = await GetTables("dbo.Get_TablesByModes", "Status");
            if (dbnull == true)
            { return; }
            dataGridView.DataSource = dataTable;
        }
        public async void LoadAllOngoing(System.Windows.Forms.DataGridView dataGridView)
        {
            DataTable dataTable = await GetTables("dbo.Get_TablesByModes", "Status_OnGoing");
            if (dbnull == true)
            { return; }
            dataGridView.DataSource = dataTable;
        }
        public async void LoadAllCompleted(System.Windows.Forms.DataGridView dataGridView)
        {
            DataTable dataTable = await GetTables("dbo.TEST_GetAllCompleted");
            if (dbnull == true)
            { return; }
            dataGridView.DataSource = dataTable;
        }
        public async void LoadAllProjects(System.Windows.Forms.DataGridView dataGridView)
        {
            DataTable dataTable = await GetTables("dbo.Get_AllProjects");
            if (dbnull == true)
            { return; }
            dataGridView.DataSource = dataTable;
            dataGridView.AutoGenerateColumns = false;
            if (dataGridView.Columns.Contains("ProjectID"))
            {
                dataGridView.Columns.Remove("ProjectID");
            }
            
        }
    }
}
