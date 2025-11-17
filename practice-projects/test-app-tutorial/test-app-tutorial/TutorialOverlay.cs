using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_app_tutorial
{
    public class TutorialOverlay : Form
    {
        private Control target;
        private string message;

        public TutorialOverlay(Control targetControl, string tutorialText)
        {
            this.target = targetControl;
            this.message = tutorialText;

            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            BackColor = Color.Black;
            Opacity = 0.6;
            TopMost = true;
            Bounds = Screen.PrimaryScreen.Bounds;

            Click += (s, e) => Close(); // Click to continue
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Highlight rectangle
            Rectangle r = target.RectangleToScreen(target.ClientRectangle);

            using var brush = new SolidBrush(Color.FromArgb(220, Color.Black));
            e.Graphics.FillRectangle(brush, this.ClientRectangle);

            using var gp = new GraphicsPath();
            gp.AddRectangle(r);

            using var region = new Region(this.ClientRectangle);
            region.Exclude(r);

            e.Graphics.SetClip(region, CombineMode.Replace);

            // Draw message
            e.Graphics.ResetClip();
            e.Graphics.DrawString(
                message,
                new Font("Segoe UI", 14),
                Brushes.White,
                new PointF(r.Left, r.Bottom + 10)
            );
        }
    }
}
