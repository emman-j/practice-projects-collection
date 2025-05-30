using LiveChartsCore.SkiaSharpView.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveChartsSAmple
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            Size = new System.Drawing.Size(50, 50);

            var viewModel = new ViewModel();

            PieChart pieChart = new PieChart
            {
                Series = viewModel.Series,
                InitialRotation = 180,
                MaxAngle = 180,
                MinValue = 0,
                MaxValue = 100,

                // out of livecharts properties...
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(50, 50),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };

            Controls.Add(pieChart);
        }
    }
}
