using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing1.Forms
{
    public partial class DateTimeNow : UserControl
    {
        Timer tm;
        public DateTimeNow()
        {
            InitializeComponent();
            tm = new Timer();
            tm.Interval = 1;
            tm.Tick += tm_Tick;
            tm.Start();
        }
        void tm_Tick(object sender, EventArgs e)
        {
            timedate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy HH:mm:ss");
        }
    }
}
