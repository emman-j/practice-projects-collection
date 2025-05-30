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

namespace testing1.Forms.Animation_test
{
    public partial class labelanim2 : Form
    {
        private int dotCount = 0;
        private const int maxDots = 5; // Maximum number of dots to display

        Timer animationTimer2;


        public labelanim2()
        {
            InitializeComponent();
            animationtimer.Start();
            InitializeAnimationTimer2(500);

        }

        private void animationtimer_Tick(object sender, EventArgs e)
        {
            dotCount = (dotCount + 1) % (maxDots + 1); // Cycle through 0 to maxDots

            // Create the connecting text with the dots
            connectionanimlbl.Text = "Connecting" + new string('.', dotCount);
            //await Timer_TickAsync();
            Debug.WriteLine("Timer1 tick");
        }
        private void InitializeAnimationTimer2(int interval)
        {
            if (animationTimer2 == null)
            {
                animationTimer2 = new Timer();
                animationTimer2.Interval = interval; // Interval in milliseconds
                //animationTimer2.Tick += AnimationTimer2_Tick;
                animationTimer2.Tick += async (sender, e) => await Timer_TickAsync();
                animationTimer2.Start(); // Start the timer to begin
            }
            else
            {
                animationTimer2.Start(); // Start the timer to begin
            }
        }
        private void AnimationTimer2_Tick(object sender, EventArgs e)
        {
            //dotCount = (dotCount + 1) % (maxDots + 1); // Cycle through 0 to maxDots
            // Create the connecting text with the dots
            //connectionanimlbl2.Text = "Connecting" + new string('.', dotCount);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            connectionanimlbl.Visible = false;
            animationtimer.Stop();
            animationtimer.Dispose();
        }

        private void start_Click(object sender, EventArgs e)
        {
            connectionanimlbl.Visible = true;
            animationtimer.Start();
        }

        private async Task Timer_TickAsync()
        {

            Debug.WriteLine("Timer2 Started");
            // Perform background work asynchronously
            await Task.Run(() =>
            {
                dotCount = (dotCount + 1) % (maxDots + 1); // Cycle through 0 to maxDots
                // Create the connecting text with the dots
                UpdateLabelText("Connecting" + new string('.', dotCount));
            });

            // Update after background work
            Debug.WriteLine("Timer2 Stopped");
        }

        private void UpdateLabelText(string text)
        {
            if (connectionanimlbl2.InvokeRequired)
            {
                connectionanimlbl2.Invoke((MethodInvoker)delegate
                {
                    connectionanimlbl2.Text = text;
                });
            }
            else
            {
                connectionanimlbl2.Text = text;
            }
        }
        private void labelanim2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
