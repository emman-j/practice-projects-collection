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
        private readonly Control target;
        private readonly string message;
        private readonly Action nextStep;

        public TutorialOverlay(Control targetControl, string tutorialMessage, Action onNext)
        {
            target = targetControl;
            message = tutorialMessage;
            nextStep = onNext;

            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            TopMost = true;
            DoubleBuffered = true;

            StartPosition = FormStartPosition.Manual;
            Bounds = Screen.FromControl(target).Bounds;
            BackColor = Color.Black;
            Opacity = 0.65;

            Click += (s, e) => Proceed();
            Shown += (s, e) => CreateMask();
        }

        private void Proceed()
        {
            Close();
            nextStep?.Invoke();
        }

        private void CreateMask()
        {
            var screenRect = Screen.FromControl(target).Bounds;
            var targetRect = target.RectangleToScreen(target.ClientRectangle);

            // Full-screen region
            Region region = new Region(new Rectangle(0, 0, Width, Height));

            // Remove the target area from it
            region.Exclude(targetRect);

            this.Region = region;

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var targetRect = target.RectangleToScreen(target.ClientRectangle);

            using (var font = new Font("Segoe UI", 12))
            using (var brush = new SolidBrush(Color.White))
            {
                e.Graphics.DrawString(
                    message,
                    font,
                    brush,
                    targetRect.Left,
                    targetRect.Bottom + 8
                );
            }
        }
    }
}
