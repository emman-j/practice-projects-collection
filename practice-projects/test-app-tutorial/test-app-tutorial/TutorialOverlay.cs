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
        private Rectangle targetRect;

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

            //Click += (s, e) => ProceedNext();
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
            targetRect = target.RectangleToScreen(target.ClientRectangle);
            Invalidate(); // redraw
            PositionButtons();
        }

        private void PositionButtons()
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

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 1. Draw full semi-transparent overlay
            using (Brush dimBrush = new SolidBrush(Color.FromArgb(160, Color.Black)))
                g.FillRectangle(dimBrush, this.ClientRectangle);

            // 2. Draw highlight rectangle (border, glow, or semi-transparent fill)
            using (Pen highlightPen = new Pen(Color.Yellow, 3))
            {
                g.DrawRectangle(highlightPen, targetRect);
            }

            using (Brush highlightFill = new SolidBrush(Color.FromArgb(50, Color.Yellow)))
            {
                g.FillRectangle(highlightFill, targetRect);
            }

            // 3. Draw message below highlight
            using (var font = new Font("Segoe UI", 11))
            using (var brush = new SolidBrush(Color.White))
            {
                g.DrawString(message, font, brush, targetRect.Left, targetRect.Bottom + 8);
            }
        }


    }
}
