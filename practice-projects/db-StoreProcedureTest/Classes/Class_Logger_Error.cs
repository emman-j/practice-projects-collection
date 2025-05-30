using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Drawing;

namespace WindowsFormsApp1
{
    public static class ErrorLogger
    {
        private static string _logFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs", "Error Logs");
        private static string _logFilePath = GetLogFilePathWithDateTime();  
        static ErrorLogger()
        {
            EnsureFolderExists();
        }

        public static void CatchError(Exception ex, string Error, [System.Runtime.CompilerServices.CallerMemberName] string methodName = "", bool showMessageBox = true)
        { 
            if (ex.InnerException != null)
            {
                Console.WriteLine($"{Error}: {ex.Message}\nInner Exception: {ex.InnerException.Message}");
                Debug.WriteLine($"{Error}: {ex.Message}\nInner Exception: {ex.InnerException.Message}");
                LogAppError($"{Error}", $"{ex.Message}\nInner Exception: {ex.InnerException.Message}", methodName);
            }
            else
            {
                Console.WriteLine($"{Error}: {ex.Message}");
                Debug.WriteLine($"{Error}: {ex.Message}");
                LogAppError($"{Error}", $"{ex.Message}", methodName);
            }
            if (showMessageBox && ex.InnerException == null)
            {
                MessageBox.Show($"{ex.Message}", $"{Error}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                MessageBox.Show($"Target Invocation Exception: {ex.Message} \nInner Exception: {ex.InnerException.Message}",
                    "{Error}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CatchInnerError(Exception ex, string Error, [System.Runtime.CompilerServices.CallerMemberName] string methodName = "", bool showMessageBox = true)
        {
            Console.WriteLine($"{Error}: {ex.Message}\nInner Exception: {ex.InnerException.Message}");
            Debug.WriteLine($"{Error}: {ex.Message}\nInner Exception: {ex.InnerException.Message}");
            LogAppError($"{Error}", $"{ex.Message}\nInner Exception: {ex.InnerException.Message}", methodName);

            if (showMessageBox)
            { 
                MessageBox.Show($"Target Invocation Exception: {ex.Message} \nInner Exception: {ex.InnerException.Message}",
                    "{Error}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        private static void EnsureFolderExists()
        {
            if (!Directory.Exists(_logFolderPath))
            {
                Directory.CreateDirectory(_logFolderPath);
            }
        }
        private static string GetLogFilePathWithDateTime()
        {
            string dateTimeString = DateTime.Now.ToString("yyyy-MM-dd");
            string fileName = $"errorlog_{dateTimeString}.json";
            return Path.Combine(_logFolderPath, fileName);
        }
        public static void LogAppError(string error, string description, [System.Runtime.CompilerServices.CallerMemberName] string methodName = "")
        {
            var stackTrace = new StackTrace(true); // Capture the stack trace with file info
            var stackFrames = stackTrace.GetFrames();

            // Create a list to hold stack trace details
            var stackTraceDetails = new List<string>();
            if (stackFrames != null)
            {
                foreach (var frame in stackFrames)
                {
                    var method = frame.GetMethod();
                    var fileName = frame.GetFileName();
                    var lineNumber = frame.GetFileLineNumber();
                    stackTraceDetails.Add($"{method.DeclaringType?.FullName}.{method.Name} at {fileName}:{lineNumber}");
                }
            }

            var AppError = new Dictionary<string, object>
            {
                { "Date", DateTime.Now.ToString("MMM dd yyyy HH:mm:ss") },
                { "Error", error },
                { "Method", methodName },
                { "Description", description },
                { "StackTrace", stackTraceDetails }
            };

            Dictionary<string, object> ErrorData;

            if (File.Exists(_logFilePath))
            {
                string json = File.ReadAllText(_logFilePath);
                ErrorData = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

                if (ErrorData.ContainsKey("ErrorLogs"))
                {
                    var existingDatabaseConfig = ErrorData["ErrorLogs"] as JArray;
                    existingDatabaseConfig.Add(JObject.FromObject(AppError));
                }
                else
                {
                    ErrorData["ErrorLogs"] = new JArray { JObject.FromObject(AppError) };
                }
            }
            else
            {
                ErrorData = new Dictionary<string, object>
            {
                { "ErrorLogs", new JArray { JObject.FromObject(AppError) } }
            };
            }

            SaveLogs(ErrorData);
        }
        public static void LogAppError(string error, Exception ex, [System.Runtime.CompilerServices.CallerMemberName] string methodName = "")
        {
            var Details = ex.ToString(); // This captures the full exception details, including stack trace and inner exceptions

            var stackTraceDetails = new List<string>();

            if (ex != null)
            {
                var currentException = ex;
                while (currentException != null)
                {
                    var stackTrace = new StackTrace(currentException, true);
                    var stackFrames = stackTrace.GetFrames();

                    if (stackFrames != null)
                    {
                        foreach (var frame in stackFrames)
                        {
                            var method = frame.GetMethod();
                            var fileName = frame.GetFileName();
                            var lineNumber = frame.GetFileLineNumber();
                            stackTraceDetails.Add($"{method.DeclaringType?.FullName}.{method.Name} at {fileName}:{lineNumber}");
                        }
                    }

                    currentException = currentException.InnerException;
                }
            }

            var AppError = new Dictionary<string, object>
            {
                { "Date", DateTime.Now.ToString("MMM dd yyyy HH:mm:ss") },
                { "Error", error },
                { "Method", methodName },
                { "Description", ex?.Message },
                { "Details", Details },
                { "StackTrace", stackTraceDetails }
            };

            Dictionary<string, object> ErrorData;

            if (File.Exists(_logFilePath))
            {
                string json = File.ReadAllText(_logFilePath);
                ErrorData = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

                if (ErrorData.ContainsKey("ErrorLogs"))
                {
                    var existingDatabaseConfig = ErrorData["ErrorLogs"] as JArray;
                    existingDatabaseConfig.Add(JObject.FromObject(AppError));
                }
                else
                {
                    ErrorData["ErrorLogs"] = new JArray { JObject.FromObject(AppError) };
                }
            }
            else
            {
                ErrorData = new Dictionary<string, object>
            {
                { "ErrorLogs", new JArray { JObject.FromObject(AppError) } }
            };
            }

            SaveLogs(ErrorData);
        }
        public static void SaveLogs(Dictionary<string, object> ErrorData)
        {
            try
            {
                EnsureFolderExists();

                string json = JsonConvert.SerializeObject(ErrorData, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(_logFilePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to write configuration: {ex.Message}");
                MessageBox.Show($"Failed to write configuration: {ex.Message}",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
