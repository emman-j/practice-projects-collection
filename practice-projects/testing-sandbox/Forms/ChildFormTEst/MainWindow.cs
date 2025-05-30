using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testing1.Forms.ChildFormTEst;
using testing1.UserControls;

namespace testing1.Forms
{
    public partial class MainWindow : Form
    {
        public Form activeForm = null;
        public MainWindow()
        {
            InitializeComponent();
            OpenChildForm(new Childform1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Childform1());
        }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null){ activeForm.Close(); }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Childform2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormManager.SwitchForm<Main>(this);
        }
    }
}
