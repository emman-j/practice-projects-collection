using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testUI.Forms
{
    public partial class CreateAccount_Form : Form
    {
        public CreateAccount_Form()
        {
            InitializeComponent();
        }

        private void backToLoginLabel_Click(object sender, EventArgs e)
        {
            new Login_Form().Show();
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

        private void registerButton_Click(object sender, EventArgs e)
        {

            if
            (
                    string.IsNullOrWhiteSpace(usernametxt.Text) ||
                    string.IsNullOrWhiteSpace(passwordtxt.Text) ||
                    string.IsNullOrWhiteSpace(lastnametxt.Text) ||
                    string.IsNullOrWhiteSpace(idNumbertxt.Text) ||
                    string.IsNullOrWhiteSpace(emailtxt.Text) ||
                    string.IsNullOrWhiteSpace(firstnametxt.Text)
            )
            {
                MessageBox.Show("Fields cannot be empty!" + Environment.NewLine +
                     "Please try again.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passwordtxt.Text != comPasswordtxt.Text || !int.TryParse(idNumbertxt.Text, out _))
            {
                MessageBox.Show("Passwords do not match or Invalid ID Number!" + Environment.NewLine +
                      "Please try again.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database db = new Database();
                int idNumber = Convert.ToInt32(idNumbertxt.Text);
                db.CreateAccount(usernametxt.Text, passwordtxt.Text, firstnametxt.Text, lastnametxt.Text, emailtxt.Text, idNumber);
                usernametxt.Clear();
                passwordtxt.Clear();
                comPasswordtxt.Clear();
                firstnametxt.Clear();
                lastnametxt.Clear();
                emailtxt.Clear();
                idNumbertxt.Clear();
                
                new Login_Form().Show();
                this.Hide();
            }
        }

    }
}
