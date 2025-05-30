using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing1.UserControls
{
    public partial class TitleBar : UserControl
    {
        private bool isMaximized = false; 

        public TitleBar()
        {
            InitializeComponent();

        }
        #region Accessible Properties
        // Expose a property for the panel's background color
        [Category("Appearance")]
        [Description("Gets or sets the background color of the panel.")]
        public Color PanelBackColor
        {
            get { return titleBarPanel.BackColor; }
            set { titleBarPanel.BackColor = value; }
        }

        // Expose a property for the button's background color
        [Category("Appearance")]
        [Description("Gets or sets the background color of the button.")]
        public Color ExitLabelBackColor
        {
            get { return ExitLabel.BackColor; }
            set { ExitLabel.BackColor = value; }
        }

        // Expose a property for the button's text color
        [Category("Appearance")]
        [Description("Gets or sets the text color of the button.")]
        public Color ExitLabelTextColor
        {
            get { return ExitLabel.ForeColor; }
            set { ExitLabel.ForeColor = value; }
        }

        [Category("Appearance")]
        [Description("Gets or sets the background color of the button.")]
        public Color MaximizeLabelBackColor
        {
            get { return MaximizeLabel.BackColor; }
            set { MaximizeLabel.BackColor = value; }
        }

        [Category("Appearance")]
        [Description("Gets or sets the text color of the button.")]
        public Color MaximizeLabelTextColor
        {
            get { return MaximizeLabel.ForeColor; }
            set { MaximizeLabel.ForeColor = value; }
        }

        [Category("Appearance")]
        [Description("Gets or sets the background color of the button.")]
        public Color MinimizeLabelBackColor
        {
            get { return MinimizeLabel.BackColor; }
            set { MinimizeLabel.BackColor = value; }
        }

        [Category("Appearance")]
        [Description("Gets or sets the text color of the button.")]
        public Color MinimizeLabelTextColor
        {
            get { return MinimizeLabel.ForeColor; }
            set { MinimizeLabel.ForeColor = value; }
        }

        // Property to control the enabled state of the maximize button
        [Category("Behavior")]
        [Description("Gets or sets whether the maximize button is enabled.")]
        public bool MaximizeButtonVisible
        {
            get { return MaximizeLabel.Visible; }
            set { MaximizeLabel.Visible = value; }
        }


        #endregion


        ////// Optionally expose other properties
        ////[Category("Appearance")]
        ////[Description("Gets or sets the text of the button.")]
        ////public string ButtonText
        ////{
        ////    get { return myButton.Text; }
        ////    set { myButton.Text = value; }
        ////}

        private void titleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.ParentForm != null)
            {
                FormManager.ReleaseCapture();
                FormManager.SendMessage(this.ParentForm.Handle, 0x112, 0xf012, 0);
            }
        }

        private void TitleBarExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                this.ParentForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                if (isMaximized)
                {
                    this.ParentForm.WindowState = FormWindowState.Normal;
                    isMaximized = false;
                }
                else
                {
                    this.ParentForm.WindowState = FormWindowState.Maximized;
                    isMaximized = true;
                }
            }
        }
    }
}
