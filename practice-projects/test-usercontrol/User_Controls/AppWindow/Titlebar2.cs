using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testUC.User_Controls.AppWindow
{
    public partial class Titlebar2 : UserControl
    {
        public Titlebar2()
        {
            InitializeComponent();
        }

        private void Titlebar2_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.ParentForm != null)
            {
                WindowManager.ReleaseCapture();
                WindowManager.SendMessage(this.ParentForm.Handle, 0x112, 0xf012, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
