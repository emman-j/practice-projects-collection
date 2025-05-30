using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.Extensions;

namespace LiveChartsSAmple
{
    public class ViewModel
    {
        public IEnumerable<ISeries> Series { get; set; } =
            GaugeGenerator.BuildSolidGauge
            (
                new GaugeItem
                (
                    30, series =>
                    {
                        series.Fill = new SolidColorPaint(SKColors.YellowGreen);
                        series.DataLabelsSize = 50;
                        series.DataLabelsPaint = new SolidColorPaint(SKColors.Red);
                        series.DataLabelsPosition = PolarLabelsPosition.ChartCenter;
                        series.InnerRadius = 75;
                    }
                ),
                new GaugeItem
                (
                    GaugeItem.Background, series =>
                    {
                        series.InnerRadius = 75;
                        series.Fill = new SolidColorPaint(new SKColor(100, 181, 246, 90));
                    }
                )
            )
        ;
    }
    public class ViewModel2
    {
        public IEnumerable<ISeries> Series { get; set; }

        public ViewModel2()
        {
            var outer = 0;
            var data = new[] { 6, 5, 4, 3, 2 };

            // you can convert any array, list or IEnumerable<T> to a pie series collection:
            Series = data.AsPieSeries((value, series) =>
            {
                // this method is called once per element in the array
                // we are decrementing the outer radius 50px
                // on every element in the array.

                series.InnerRadius = 15;
                series.OuterRadiusOffset = outer;
                outer -= 5;
            });
        }
    }
}
