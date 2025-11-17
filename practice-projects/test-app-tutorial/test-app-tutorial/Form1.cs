using System.Threading;

namespace test_app_tutorial
{
    public partial class Form1 : Form
    {
        TutorialManager tutorial;
        public Form1()
        {
            InitializeComponent();

            tutorial = new TutorialManager(new List<(Control, string)>
            {
                (button1, "Click here to connect to the device"),
                (textBox1, "Enter the device ID here")
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tutorial.Start();
        }
    }
}
