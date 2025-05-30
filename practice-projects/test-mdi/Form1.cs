using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing_MDI
{
    public partial class Form1 : Form
    {
        private int childFormNumber = 0;
        public Form1()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form childForm = new Form2();
            childForm.Text = "Window " + childFormNumber++;
            childForm.MdiParent = this;  // 'this' is the MDI container
            childForm.Show();
            //OpenMdiChild(new Form2());

        }

        private void OpenMdiChild(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.Sizable;
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Show();

            // Create a button for the taskbar
            Button taskbarButton = new Button
            {
                Text = childForm.Text,
                Width = 100,
                Tag = childForm // associate the form
            };

            // On button click, bring form to front
            taskbarButton.Click += (s, e) =>
            {
                childForm.Activate();
                if (childForm.WindowState == FormWindowState.Maximized || childForm.WindowState == FormWindowState.Normal) childForm.WindowState = FormWindowState.Minimized;
                else
                {
                    childForm.WindowState = FormWindowState.Normal;
                    childForm.Show();
                    return;
                }
            };

            childForm.SizeChanged += (s, e) =>
            {
                if (childForm.WindowState == FormWindowState.Minimized)
                {
                    childForm.Hide();
                    return;
                }
                //else
                //{
                //    childForm.Show();
                //    return;
                //}
            };

            // Handle form closing to remove taskbar button
            childForm.FormClosed += (s, e) =>
            {
                flowLayoutPanel1.Controls.Remove(taskbarButton);
            };

            // Add the button to the taskbar
            flowLayoutPanel1.Controls.Add(taskbarButton);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
