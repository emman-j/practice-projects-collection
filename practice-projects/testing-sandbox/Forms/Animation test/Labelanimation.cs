using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing1.Forms.Animation_test
{
    public partial class Labelanimation : Form
    {
        private Label lblConnecting;
        private Timer animationTimer;
        private int dotCount = 0;
        private const int maxDots = 5; // Maximum number of dots to display

        public Labelanimation()
        {
            InitializeComponent();
            lblConnecting = new Label();
            lblConnecting.Text = "Connecting";
            lblConnecting.Location = new Point(50, 50);
            lblConnecting.Size = new Size(150, 30);
            lblConnecting.Font = new Font("Arial", 14);

            Controls.Add(lblConnecting);

            // Initialize the Timer
            animationTimer = new Timer();
            animationTimer.Interval = 500; // Interval in milliseconds
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start(); // Start the timer to beg
        }

        
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Update the number of dots
            dotCount = (dotCount + 1) % (maxDots + 1); // Cycle through 0 to maxDots

            // Create the connecting text with the dots
            lblConnecting.Text = "Connecting" + new string('.', dotCount);
        }


        private void Labelanimation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
