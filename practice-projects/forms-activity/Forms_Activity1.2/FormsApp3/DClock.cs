using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp3
{
   public partial class DClock : UserControl
  {
    Timer tm;
    public DClock()
    {
      InitializeComponent();
      tm = new Timer();
      tm.Interval = 1;
      tm.Tick += tm_Tick;
      tm.Start();
    }
    void tm_Tick(object sender, EventArgs e)
    {
      label1.Text = DateTime.Now.ToString("HH:mm:ss");
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
