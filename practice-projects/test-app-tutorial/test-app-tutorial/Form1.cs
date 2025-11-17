namespace test_app_tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var overlay = new TutorialOverlay(button1, "Click this button to start");
            overlay.Show();

            overlay = new TutorialOverlay(textBox1, "Click this button to start");
            overlay.Show();
        }
    }
}
