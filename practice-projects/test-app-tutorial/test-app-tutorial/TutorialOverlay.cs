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
        private readonly Action onStepComplete;

        public TutorialOverlay(Control targetControl, string tutorialText, Action nextStep)
        {
            target = targetControl;
            message = tutorialText;
            onStepComplete = nextStep;

            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            BackColor = Color.Black;
            Opacity = 0.65;
            TopMost = true;
            Bounds = Screen.PrimaryScreen.Bounds;

            Click += (s, e) => CloseAndNext();
        }

        void CloseAndNext()
        {
            Close();
            onStepComplete?.Invoke();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle r = target.RectangleToScreen(target.ClientRectangle);

            using var brush = new SolidBrush(Color.FromArgb(180, Color.Black));
            e.Graphics.FillRectangle(brush, this.ClientRectangle);

            e.Graphics.FillRectangle(Brushes.Transparent, r);

            e.Graphics.DrawString(
                message,
                new Font("Segoe UI", 14),
                Brushes.White,
                new PointF(r.Left, r.Bottom + 10)
            );
        }
    }

}
