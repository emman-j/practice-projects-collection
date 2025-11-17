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
        private readonly Action prevStep;

        private readonly Button btnNext;
        private readonly Button btnPrev;

        public TutorialOverlay(Control targetControl, string tutorialMessage, Action onNext, Action onPrevious)
        {
            target = targetControl;
            message = tutorialMessage;
            nextStep = onNext;
            prevStep = onPrevious;

            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            TopMost = true;
            DoubleBuffered = true;

            StartPosition = FormStartPosition.Manual;
            Bounds = Screen.FromControl(target).Bounds;
            BackColor = Color.Black;
            Opacity = 0.65;

            Click += (s, e) => ProceedNext();
            Shown += (s, e) => CreateMask();

            // NEXT BUTTON
            btnNext = new Button
            {
                Text = "Next ▶",
                AutoSize = true,
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
            };
            btnNext.Click += (s, e) => ProceedNext();

            // PREVIOUS BUTTON
            btnPrev = new Button
            {
                Text = "◀ Previous",
                AutoSize = true,
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
            };
            btnPrev.Click += (s, e) => ProceedPrev();

            Controls.Add(btnNext);
            Controls.Add(btnPrev);
        }

        private void ProceedNext()
        {
            Close();
            nextStep?.Invoke();
        }

        private void ProceedPrev()
        {
            Close();
            prevStep?.Invoke();
        }

        private void CreateMask()
        {
            var screenRect = Screen.FromControl(target).Bounds;
            var targetRect = target.RectangleToScreen(target.ClientRectangle);

            Region region = new Region(new Rectangle(0, 0, Width, Height));
            region.Exclude(targetRect);
            this.Region = region;

            PositionButtons(targetRect);
            Invalidate();
        }

        private void PositionButtons(Rectangle targetRect)
        {
            int centerX = (targetRect.Left + targetRect.Right) / 2;

            // Space below target
            int y = targetRect.Bottom + 40;

            btnPrev.Location = new Point(centerX - btnPrev.Width - 10, y);
            btnNext.Location = new Point(centerX + 10, y);

            btnPrev.BringToFront();
            btnNext.BringToFront();
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
                    new PointF(targetRect.Left, targetRect.Bottom + 8)
                );
            }
        }
    }
}
