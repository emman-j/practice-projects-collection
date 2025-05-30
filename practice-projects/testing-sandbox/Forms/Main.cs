using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testing1.Forms;
using testing1.Forms.Animation_test;
using testing1.UserControls;

namespace testing1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManager.SwitchForm<A_syncTest>(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormManager.SwitchForm<PanelScrollTest>(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormManager.SwitchForm<MainWindow>(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormManager.SwitchForm<cascadingcombobox>(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormManager.SwitchForm<Labelanimation>(this);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormManager.SwitchForm<labelanim2>(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormManager.SwitchForm<FormResizeTest>(this);
        }
    }
}
