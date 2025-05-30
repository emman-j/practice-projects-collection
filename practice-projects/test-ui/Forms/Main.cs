using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testUI.Forms;
using Dapper;

namespace testUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Account_Manager().Show();
            this.Hide();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void titleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            WindowManager.ReleaseCapture();
            WindowManager.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
