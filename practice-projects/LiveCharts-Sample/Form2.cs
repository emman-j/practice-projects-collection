using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 


namespace LiveChartsSAmple
{
    public partial class Form2 : Form
    {
        public string Chart_ExePath { get; set; } = @"C:\Users\admin\Documents\Training\repos\VSC\gantchart\dist\GanttChartGenerator2.exe";
        [Browsable(false)] public object? Chart_Data { get; set; }
        [Browsable(false)]
        public object[] Chart_Tasks { get; set; } = new[]
            {
                new { Task = "Task A", Start = "2024-02-18", End = "2024-03-01", Resource = "Team E" },
                new { Task = "Task B", Start = "2024-01-11", End = "2024-01-23", Resource = "Team B" },
                new { Task = "Task C", Start = "2024-02-04", End = "2024-02-16", Resource = "Team D" },
                new { Task = "Task D", Start = "2024-02-09", End = "2024-02-15", Resource = "Team E" },
                new { Task = "Task E", Start = "2024-01-14", End = "2024-01-20", Resource = "Team C" },
                new { Task = "Task F", Start = "2024-01-17", End = "2024-01-22", Resource = "Team C" },
                new { Task = "Task G", Start = "2024-01-24", End = "2024-02-07", Resource = "Team D" },
                new { Task = "Task H", Start = "2024-02-07", End = "2024-02-20", Resource = "Team C" },
                new { Task = "Task I", Start = "2024-02-12", End = "2024-02-20", Resource = "Team F" },
                new { Task = "Task J", Start = "2024-02-28", End = "2024-03-14", Resource = "Team B" },
                new { Task = "Task K", Start = "2024-02-09", End = "2024-02-14", Resource = "Team B" },
                new { Task = "Task L", Start = "2024-02-24", End = "2024-03-01", Resource = "Team D" },
            };
        [Category("Chart | Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Chart_Title { get; set; } = "Activity GanttChart";
        [Category("Chart | Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Chart_xAxis_Title { get; set; } = "Custom Date";
        [Category("Chart | Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Chart_yAxis_Title { get; set; } = "Custom Tasks";
        [Category("Chart | Appearance")] public double Chart_Title_xPos { get; set; } = 0.5;
        [Category("Chart | Appearance")] public double Chart_Title_yPos { get; set; } = 0.95;
        [Category("Chart | Appearance")] public int Chart_Title_FontSize { get; set; } = 30;
        [Category("Chart | Appearance")] public int Chart_xAxis_FontSize { get; set; } = 18;
        [Category("Chart | Appearance")] public int Chart_yAxis_FontSize { get; set; } = 18;
        [Category("Chart | Appearance")] public int Chart_Legend_FontSize { get; set; } = 16;
        [Category("Chart | Appearance")] public int Chart_Default_FontSize { get; set; } = 14;
        [Category("Chart | Margin")] public int Chart_Margin_Left { get; set; } = 50;
        [Category("Chart | Margin")] public int Chart_Margin_Right { get; set; } = 50;
        [Category("Chart | Margin")] public int Chart_Margin_Top { get; set; } = 50;
        [Category("Chart | Margin")] public int Chart_Margin_Bottom { get; set; } = 30;
        public Form2()
        {
            InitializeComponent();
        }
        private async void Form2_Load(object sender, EventArgs e)
        {
            //CreateGanttChart();
            //RunPythonScript("Hello", "World");
            //RunExecutable("Hello", "World");
            //CreateGanttChart2();

            // this is another test commit
            await CreateChartAsync();
        }
        public async Task<string> GenerateChartAsync()
        {
            string output = string.Empty;
            string error = string.Empty;

            string generatedPath = await Task.Run(() =>
            {
                var chartData = new
                {
                    title = Chart_Title,
                    config = new
                    {
                        xaxis_title = Chart_xAxis_Title,
                        yaxis_title = Chart_yAxis_Title,
                        showlegend = true,
                        margin_left = Chart_Margin_Left,
                        margin_right = Chart_Margin_Right,
                        margin_top = Chart_Margin_Top,
                        margin_bottom = Chart_Margin_Bottom,
                        title_font_size = Chart_Title_FontSize,
                        xaxis_title_font_size = Chart_xAxis_FontSize,
                        yaxis_title_font_size = Chart_yAxis_FontSize,
                        legend_title_font_size = Chart_Legend_FontSize,
                        default_font_size = Chart_Default_FontSize,
                        title_x = Chart_Title_xPos,
                        title_y = Chart_Title_yPos
                    },
                    tasks = Chart_Tasks
                };

                string jsonTasks = JsonConvert.SerializeObject(chartData);
                string encodedTasks = Uri.EscapeDataString(jsonTasks);

                ProcessStartInfo start = new ProcessStartInfo
                {
                    FileName = Chart_ExePath,
                    Arguments = $"\"{encodedTasks}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(start))
                {
                    output = process.StandardOutput.ReadToEnd();
                    error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    string pathPrefix = "PATH: (";
                    if (output.Contains(pathPrefix))
                    {
                        int startIndex = output.IndexOf(pathPrefix) + pathPrefix.Length;
                        int endIndex = output.IndexOf(")", startIndex);
                        return output.Substring(startIndex, endIndex - startIndex);
                    }
                }
                return string.Empty;
            });

            if (string.IsNullOrEmpty(generatedPath))
            {
                MessageBox.Show($"Gantt chart HTML file not found.\nOutput: {output}\nError: {error}");
            }

            return generatedPath;
        }
        public async Task CreateChartAsync()
        {
            string generatedPath = await GenerateChartAsync();

            if (!string.IsNullOrEmpty(generatedPath) && File.Exists(generatedPath))
            {
                LoadHtml(generatedPath);
            }
            else
            {
                MessageBox.Show($"Gantt chart HTML file not found.");
            }
        }

        public async void LoadHtml(string outputpath)
        {
            //string htmlFilePath = @"C:\Users\admin\Documents\Training\repos\VSC\gantchart\gantt_chart.html";
            //webView21.Source = new Uri(htmlFilePath);

            await webView21.EnsureCoreWebView2Async(null);
            string htmlFilePath = @"C:\Users\admin\Documents\Training\repos\VSC\gantchart\gantt_chart.html";
            webView21.Source = new Uri(outputpath);
        }
        private void CreateGanttChart()
        {
            // Path to the executable generated by PyInstaller
            string exePath = @"C:\Users\admin\Documents\Training\repos\VSC\gantchart\dist\GanttChartGenerator.exe";
            string outputPath = @"C:\Users\admin\Documents\Training\repos\VSC\gantchart\gantt_chart.html";

            // Set up tasks and file path for the output HTML
            var tasks = new[]
            {
                new { Task = "Task A", Start = "2024-01-01", End = "2024-01-15" },
                new { Task = "Task B", Start = "2024-01-10", End = "2024-02-10" },
                new { Task = "Task C", Start = "2024-02-01", End = "2024-03-01" }
            };

            // Serialize tasks to JSON
            string jsonTasks = JsonConvert.SerializeObject(tasks);
            string encodedTasks = Uri.EscapeDataString(jsonTasks);

            Debug.WriteLine($"Serialized JSON: {jsonTasks}");

            // Create a new process
            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = exePath,
                Arguments = $"\"{encodedTasks}\"", // Pass parameters
                UseShellExecute = false, // Do not use the operating system shell to start the process
                RedirectStandardOutput = true, // Redirect the output so we can read it
                RedirectStandardError = true, // Redirect error output as well
                CreateNoWindow = true // Do not create a console window
            };

            // Start the process
            using (Process process = Process.Start(start))
            {
                // Read the output and error streams
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit(); // Wait for the process to finish

                //// Display the output or error
                //MessageBox.Show($"Output: {output}\nError: {error}");
                //Debug.WriteLine( error );

                // Load the generated HTML file in WebView2
                if (!string.IsNullOrWhiteSpace(output))
                {
                    LoadHtml(output);
                }
                else
                {
                    MessageBox.Show("Gantt chart HTML file not found.");
                }
            }

        }
        private void CreateGanttChart2()
        {
            // Path to the executable generated by PyInstaller
            string exePath = @"C:\Users\admin\Documents\Training\repos\VSC\gantchart\dist\GanttChartGenerator2.exe";

            // Define the combined data structure
            var chart = new
            {
                title = "Activity Man-Hours",
                config = new
                { 
                    xaxis_title = "Custom Date",
                    yaxis_title = "Custom Tasks",
                    showlegend = true,
                    margin_left = 50,
                    margin_right = 50,
                    margin_top = 50,
                    margin_bottom = 30,
                    title_font_size = 30,
                    xaxis_title_font_size = 18,
                    yaxis_title_font_size = 18,
                    legend_title_font_size = 16,
                    default_font_size = 14,
                    title_x = 0.5,
                    title_y = 0.95
                },
                tasks = new[]
                {
                    new { Task = "Task A", Start = "2024-02-18", End = "2024-03-01", Resource = "Team E" },
                    new { Task = "Task B", Start = "2024-01-11", End = "2024-01-23", Resource = "Team B" },
                    new { Task = "Task C", Start = "2024-02-04", End = "2024-02-16", Resource = "Team D" },
                    new { Task = "Task D", Start = "2024-02-09", End = "2024-02-15", Resource = "Team E" },
                    new { Task = "Task E", Start = "2024-01-14", End = "2024-01-20", Resource = "Team C" },
                    new { Task = "Task F", Start = "2024-01-17", End = "2024-01-22", Resource = "Team C" },
                    new { Task = "Task G", Start = "2024-01-24", End = "2024-02-07", Resource = "Team D" },
                    new { Task = "Task H", Start = "2024-02-07", End = "2024-02-20", Resource = "Team C" },
                    new { Task = "Task I", Start = "2024-02-12", End = "2024-02-20", Resource = "Team F" },
                    new { Task = "Task J", Start = "2024-02-28", End = "2024-03-14", Resource = "Team B" },
                    new { Task = "Task K", Start = "2024-02-09", End = "2024-02-14", Resource = "Team B" },
                    new { Task = "Task L", Start = "2024-02-24", End = "2024-03-01", Resource = "Team D" }, 
                }
            };

            string jsonTasks = JsonConvert.SerializeObject(chart);
            string encodedTasks = Uri.EscapeDataString(jsonTasks);

            Debug.WriteLine($"Serialized JSON: {jsonTasks}");

            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = exePath,
                Arguments = $"\"{encodedTasks}\"", // Pass parameters
                UseShellExecute = false, // Do not use the operating system shell to start the process
                RedirectStandardOutput = true, // Redirect the output so we can read it
                RedirectStandardError = true, // Redirect error output as well
                CreateNoWindow = true // Do not create a console window
            };

            // Start the process
            using (Process process = Process.Start(start))
            {
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                //MessageBox.Show($"Output: {output}\n\nError: {error}");
                Debug.WriteLine($"Output: \n{output}\n\nError: \n{error}");

                string pathPrefix = "PATH: (";
                if (output.Contains(pathPrefix))
                {
                    int startIndex = output.IndexOf(pathPrefix) + pathPrefix.Length;
                    int endIndex = output.IndexOf(")", startIndex);
                    string generatedPath = output.Substring(startIndex, endIndex - startIndex);

                    if (File.Exists(generatedPath))
                    {
                        LoadHtml(generatedPath);
                    }
                    else
                    {
                        MessageBox.Show("Gantt chart HTML file not found.");
                    }
                }
            }
        } 
        private void RunPythonScript(string param1, string param2)
        {
            // Path to the Python executable
            string pythonPath = @"C:\Users\admin\AppData\Local\Programs\Python\Python313\python.exe"; // Update to your Python installation path

            // Path to your Python script
            string scriptPath = @"C:\Users\admin\Documents\Training\repos\VSC\gantchart\script.py"; // Update to your Python script path

            // Create a new process
            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = pythonPath,
                Arguments = $"\"{scriptPath}\" \"{param1}\" \"{param2}\"", // Pass parameters
                UseShellExecute = false, // Do not use the operating system shell to start the process
                RedirectStandardOutput = true, // Redirect the output so we can read it
                RedirectStandardError = true, // Redirect error output as well
                CreateNoWindow = true // Do not create a console window
            };

            // Start the process
            using (Process process = Process.Start(start))
            {
                // Read the output and error streams
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit(); // Wait for the process to finish

                // Display the output or error
                MessageBox.Show($"Output: {output}\nError: {error}");
            }
        } 
        private void RunExecutable(string param1, string param2)
        {
            // Path to the executable generated by PyInstaller
            string exePath = @"C:\Users\admin\Documents\Training\repos\VSC\TestPy\dist\script.exe"; // Update to your executable path

            // Create a new process
            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = exePath,
                Arguments = $"\"{param1}\" \"{param2}\"", // Pass parameters
                UseShellExecute = false, // Do not use the operating system shell to start the process
                RedirectStandardOutput = true, // Redirect the output so we can read it
                RedirectStandardError = true, // Redirect error output as well
                CreateNoWindow = true // Do not create a console window
            };

            // Start the process
            using (Process process = Process.Start(start))
            {
                // Read the output and error streams
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit(); // Wait for the process to finish

                // Display the output or error
                MessageBox.Show($"Output: {output}\nError: {error}");
            }
        }
    }
}
