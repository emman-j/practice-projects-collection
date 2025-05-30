using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testUI.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Dapper;

namespace testUI
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        private void createAccountLabel_Click(object sender, EventArgs e)
        {
            new CreateAccount_Form().Show();
            this.Hide();
        }
        private void titleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            WindowManager.ReleaseCapture();
            WindowManager.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.CredCheck(usernametxt.Text, passwordtxt.Text) == true)
            {
                Login();
                passwordtxt.Clear();
            }
        }
        public void Login()
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void showPwCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPwCheckBox.Checked)
            {
                passwordtxt.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtxt.UseSystemPasswordChar = true;
            }
        }
    }
}
