using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testing1.UserControls;

namespace testing1.Forms
{
    public partial class PanelScrollTest : Form
    {
        public PanelScrollTest()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormManager.SwitchForm<Main>(this);
        }

        private void PanelScrollTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
