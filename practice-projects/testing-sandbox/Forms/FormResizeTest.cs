using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using testing1.UserControls;

namespace testing1.Forms
{
    public partial class FormResizeTest : Form
    {
        public FormResizeTest()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }

        private const int cGrip = 16; // Grip size for resizing
        private const int cCaption = 32; // Caption bar height for dragging

        protected override void WndProc(ref Message m)
        {
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            const int WM_NCHITTEST = 0x84;
            const int WM_MOVING = 0x0216;
            const int WM_EXITSIZEMOVE = 0x0232;

            if (m.Msg == WM_NCHITTEST)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);

                if (pos.Y < cCaption && pos.X < this.ClientSize.Width)
                {
                    m.Result = (IntPtr)2; // HTCAPTION: Move the form
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)HTBOTTOMRIGHT; // Resize from bottom-right corner
                    return;
                }
                if (pos.X <= cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)HTBOTTOMLEFT; // Resize from bottom-left corner
                    return;
                }
                if (pos.X <= cGrip && pos.Y <= cGrip)
                {
                    m.Result = (IntPtr)HTTOPLEFT; // Resize from top-left corner
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y <= cGrip)
                {
                    m.Result = (IntPtr)HTTOPRIGHT; // Resize from top-right corner
                    return;
                }
                if (pos.X <= cGrip)
                {
                    m.Result = (IntPtr)HTLEFT; // Resize from left border
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip)
                {
                    m.Result = (IntPtr)HTRIGHT; // Resize from right border
                    return;
                }
                if (pos.Y <= cGrip)
                {
                    m.Result = (IntPtr)HTTOP; // Resize from top border
                    return;
                }
                if (pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)HTBOTTOM; // Resize from bottom border
                    return;
                }
            }

            // Handle window snapping
            if (m.Msg == WM_MOVING || m.Msg == WM_EXITSIZEMOVE)
            {
                SnapToScreenEdges();
            }

            base.WndProc(ref m);
        }

        private void SnapToScreenEdges()
        {
            Rectangle screenBounds = Screen.FromControl(this).WorkingArea;
            int snapMargin = 20; // Pixels from screen edge to trigger snap

            if (Math.Abs(this.Left - screenBounds.Left) < snapMargin)
            {
                this.Left = screenBounds.Left;
            }
            else if (Math.Abs(this.Right - screenBounds.Right) < snapMargin)
            {
                this.Left = screenBounds.Right - this.Width;
            }

            if (Math.Abs(this.Top - screenBounds.Top) < snapMargin)
            {
                this.Top = screenBounds.Top;
            }
            else if (Math.Abs(this.Bottom - screenBounds.Bottom) < snapMargin)
            {
                this.Top = screenBounds.Bottom - this.Height;
            }

            // Maximize the form if dragged to the top edge of the screen
            if (this.Top == screenBounds.Top)
            {
                this.WindowState = FormWindowState.Maximized;

            }
        }

        private void FormResizeTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormManager.SwitchForm<Main>(this);
        }
    }
}
