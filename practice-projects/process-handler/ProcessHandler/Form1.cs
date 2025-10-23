using ProcessHandler.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessHandler
{
    public partial class Form1 : Form
    {
        ProcessManager ProcessHandler;
        string processPath = "E:\\DTME PC\\Files\\repos\\github\\ProcessHandler\\ProcessHandler\\SampleProcess\\bin\\Debug\\SampleProcess.exe";
        string logtext { get; set; }
        string lastlog => ProcessHandler.LastOutput;

        public Form1()
        {
            InitializeComponent();
            textBox3.Text = processPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessHandler = new ProcessManager(null);
            ProcessHandler.RunExternalApp(textBox3.Text, textBox4.Text);
            WriteLine("[APP] Process started.");
        }
        private void WriteLine(string message)
        {
            logtext += message + Environment.NewLine;

            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new Action(() => textBox1.AppendText(message + Environment.NewLine)));
            }
            else
            {
                textBox1.AppendText(message + Environment.NewLine);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string response = Query(textBox2.Text);
            if (response.Contains("Path"))
                MessageBox.Show("Expected response received: " + response);
        }


        private string Query(string command)
        {
            ProcessHandler.SendCommand(textBox2.Text);
            Thread.Sleep(150); // Wait for response
            return ProcessHandler.LastOutput;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProcessHandler.StopExternalApp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
