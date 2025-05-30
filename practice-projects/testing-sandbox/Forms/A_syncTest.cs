using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing1.Forms
{
    public partial class A_syncTest : Form
    {
        private Button fetchDataButton;
        private Label resultLabel;

        public A_syncTest()
        {
            InitializeComponent();
            InitializeComponent();
            fetchDataButton = new Button { Text = "Fetch Data", Dock = DockStyle.Top };
            //fetchDataButton.Click += async (sender, e) => await FetchDataAsync();
            fetchDataButton.Click += FetchDataButton_Click;

            resultLabel = new Label { Text = "Data not loaded", Dock = DockStyle.Fill };

            Controls.Add(resultLabel);
            Controls.Add(fetchDataButton);
        }

        private async Task FetchDataAsync()
        {
            resultLabel.Text = "Fetching data...";

            // Simulate a long-running operation
            var data = await Task.Run(() => GetDataFromDatabase());

            resultLabel.Text = $"Data: {data}";
        }

        private string GetDataFromDatabase()
        {
            // Simulate database access delay
            System.Threading.Thread.Sleep(2000);
            return "Sample Data";
        }

        private async void FetchDataButton_Click(object sender, EventArgs e)
        {
            await FetchDataAsync(); // Call the async method
        }

        private void A_syncTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
