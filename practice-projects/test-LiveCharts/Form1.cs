using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using System.Collections.ObjectModel;

namespace LiveChartsSAmple
{
    public partial class Form1 : Form
    {
        // Define ObservableValues for each pie chart slice 
        ObservableValue pieValue1 = new ObservableValue(10);
        ObservableValue pieValue2 = new ObservableValue(20);
        ObservableValue pieValue3 = new ObservableValue(30);
        ObservableValue pieValue4 = new ObservableValue(10);
        ObservableValue pieValue5 = new ObservableValue(20);
        ObservableValue pieValue6 = new ObservableValue(30);
        Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
            cartesianChart3.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Both;
            ValInit();
            GaugeInit();
            //InitializeStacked2();
            InitializeHorizontalBarChart();
            InitializeHorizontalGroupedChart();
            test();
            //InitializeCustomHorizontalChart();
        }

        public void ValInit()
        {
            // Create an ObservableCollection for the series
            var valueCollection = new ObservableCollection<ISeries>();
            var valueCollection2 = new ObservableCollection<ISeries>();

            // Create PieSeries with ObservableValues
            valueCollection.Add(new PieSeries<ObservableValue> { Values = new[] { pieValue1 }, Name = "Category A" });
            valueCollection.Add(new PieSeries<ObservableValue> { Values = new[] { pieValue2 }, Name = "Category B" });
            valueCollection.Add(new PieSeries<ObservableValue> { Values = new[] { pieValue3 }, Name = "Category C" });

            valueCollection2.Add(new PieSeries<ObservableValue> { Values = new[] { pieValue4 }, Name = "Category A" });
            valueCollection2.Add(new PieSeries<ObservableValue> { Values = new[] { pieValue5 }, Name = "Category B" });
            valueCollection2.Add(new PieSeries<ObservableValue> { Values = new[] { pieValue6 }, Name = "Category C" });

            // Assign the ObservableCollection to the PieChart's Series property
            pieChart1.Series = valueCollection;
            pieChart2.Series = valueCollection2;

            var viewModel = new ViewModel2();
            pieChart4.Series = viewModel.Series;

            // Example of how to update values dynamically:
            // You can change the values of pieValue1, pieValue2, or pieValue3 at any time.
            pieValue1.Value = 15; // This will automatically update the chart
            pieValue2.Value = 25;
            pieValue3.Value = 35;

            pieValue4.Value = 10; // This will automatically update the chart
            pieValue5.Value = 15;
            pieValue6.Value = 45;
        }
        public void GaugeInit()
        {
            var series = new ObservableCollection<ISeries>();

            GaugeItem gauge = new GaugeItem(pieValue1, series =>
                {
                    series.Fill = new SolidColorPaint(SKColors.YellowGreen);
                    series.DataLabelsSize = 50;
                    series.DataLabelsPaint = new SolidColorPaint(SKColors.Red);
                    series.DataLabelsPosition = PolarLabelsPosition.ChartCenter;
                    series.InnerRadius = 75;
                });
            GaugeItem gaugeBG = new GaugeItem(GaugeItem.Background, series =>
                {
                    series.InnerRadius = 75;
                    series.Fill = new SolidColorPaint(new SKColor(100, 181, 246, 90));
                });

            pieChart3.Series = GaugeGenerator.BuildSolidGauge(gauge, gaugeBG);
            pieChart3.InitialRotation = 180;
            pieChart3.MaxAngle = 180;
            pieChart3.MinValue = 0;
            pieChart3.MaxValue = 100;
        }

        public void PieInit()
        {
            //var valueCollection = new ObservableCollection<ISeries>();
            //pieChart1.Series = valueCollection;
            ////valueCollection.Add(new PieSeries<double> { Values = new double[] { pieValue1, 1, 2, 3 } }); 
            ////valueCollection.Add(new PieSeries<double> { Values = new double[] { pieValue1 } });
            //valueCollection.Add(new PieSeries<double> { Values = new double[] { 2 } });
            //valueCollection.Add(new PieSeries<double> { Values = new double[] { 3 } });

            pieChart1.Series =
            [
                new PieSeries<double> { Values = new double[] { 10 } },
                new PieSeries<double> { Values = new double[] { 4 } },
                new PieSeries<double> { Values = new double[] { 1 } },
                new PieSeries<double> { Values = new double[] { 4 } },
                new PieSeries<double> { Values = new double[] { 3 } }
            ];
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pieValue1.Value = Convert.ToInt32(numericUpDown1.Value);
            pieValue2.Value = Convert.ToInt32(numericUpDown1.Value) * _random.Next(0, 5);
            pieValue3.Value = Convert.ToInt32(numericUpDown1.Value) * _random.Next(0, 5);

            pieValue4.Value = Convert.ToInt32(numericUpDown1.Value) * _random.Next(0, 10);
            pieValue5.Value = Convert.ToInt32(numericUpDown1.Value) * _random.Next(0, 10);
            pieValue6.Value = Convert.ToInt32(numericUpDown1.Value) * _random.Next(0, 10);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pieValue1.Value = Convert.ToInt32(textBox1.Text);
        }
        private void InitializeHorizontalBarChart()
        {
            var valueCollection = new ObservableCollection<ISeries>();

            valueCollection.Add(new RowSeries<ObservableValue> { Values = new[] { pieValue1 }, Name = "Values" });
            valueCollection.Add(new RowSeries<ObservableValue> { Values = new[] { pieValue2 }, Name = "Values" });
            valueCollection.Add(new RowSeries<ObservableValue> { Values = new[] { pieValue3 }, Name = "Values" });

            // Define the data for the bars
            var categories = new string[] { "Category A", "Category B", "Category C" };
            var values = new double[] { 10, 20, 30 };

            // Use RowSeries for horizontal bars
            var seriesCollection = new ISeries[]
            {
            new RowSeries<double>
            {
                Values = values,
                MaxBarWidth = 40,
                Name = "Values"
            }
            };

            // Assign the series collection to the chart
            cartesianChart1.Series = valueCollection;

            //// Set the X and Y axis (X for values and Y for categories)
            //cartesianChart1.YAxes = new[]
            //{
            //    new Axis
            //    {
            //        Labels = categories,
            //        LabelsRotation = 0
            //    }
            //};

            //cartesianChart1.XAxes = new[]
            //{
            //    new Axis
            //    {
            //        MinLimit = 0,
            //        Name = "Values"
            //    }
            //};
        }
        private void InitializeHorizontalGroupedChart()
        {
            // Define the data for the stacked bars
            var categories = new string[] { "Category A", "Category B", "Category C" };
            var categories2 = new string[] { "Category 1", "Category 2", "Category 3" };

            // Values for each category
            var values1 = new double[] { 5, 10, 15 }; // First series values
            var values2 = new double[] { 10, 5, 10 }; // Second series values

            // Use RowSeries for horizontal stacked bars
            var seriesCollection = new ISeries[]
            {
                new RowSeries<double>
                {
                    Values = values1,
                    Name = "Series 1"
                },
                new RowSeries<double>
                {
                    Values = values2,
                    Name = "Series 2"
                },
                // Series with an offset
                new RowSeries<double>
                {
                    Values = new double[] { 15, 20, 10 }, // Higher values to start higher on the chart
                    Name = "Offset Series"
                }
            };

            // Assign the series collection to the chart
            cartesianChart2.Series = seriesCollection;

            // Set the X and Y axes
            cartesianChart2.YAxes = new[]
            {
                new Axis
                {
                    Labels = categories,
                    LabelsRotation = 0
                },
            };

            cartesianChart2.XAxes = new[]
            {
                new Axis
                {
                    MinLimit = 0,
                    Name = "Values"
                }
            };
        }
        private void InitializeCustomHorizontalChart()
        {
            // Define the data for the bars
            var categories = new string[] { "Category A", "Category B", "Category C" };

            // Values for each category (base values + offsets)
            var baseValues = new double[] { 5, 10, 15 }; // These represent the base value that will be "0"
            var offsetValues = new double[] { 10, 5, 20 }; // This will act as an offset

            // Use RowSeries for horizontal bars
            var seriesCollection = new ISeries[]
            {
            // Base series that starts at "0"
            new RowSeries<double>
            {
                Values = baseValues,
                Name = "Base Series"
            },
            // Offset series that starts from the offset value
            new RowSeries<double>
            {
                Values = new double[] { 5, 8, 12 }, // Adjust these values to represent the bar starting point
                Name = "Offset Series",
                Fill = new SolidColorPaint(new SKColor(45, 45, 45)) // Different color for offset series
           
            }
            };

            // Assign the series collection to the chart
            cartesianChart3.Series = seriesCollection;

            // Set the X and Y axes
            cartesianChart3.YAxes = new[]
            {
            new Axis
            {
                Labels = categories,
                LabelsRotation = 0
            }
        };

            cartesianChart3.XAxes = new[]
            {
            new Axis
            {
                MinLimit = 0,
                Name = "Values"
            }
        };
        }

        private void test()
        {
            var values = new ObservableCollection<int>();
            var xAxesLabels = new List<string>(); 
            int numberOfCategories = 20;

            var series = new ObservableCollection<ISeries>();

            Random _random = new Random(); 
            for (int i = 0; i < numberOfCategories; i++)
            {
                int value = _random.Next(1, 100);

                var rowSeries = new RowSeries<int>
                {
                    Values = new[] { value },
                    Name = $"Activity {i + 1}"
                };
                values.Add(value);
                xAxesLabels.Add($"Activity {i + 1}");
                series.Add(rowSeries); 
            }

            var Series = new ObservableCollection<ISeries>
                {
                    new RowSeries<int>
                    {
                        Values = values
                    }
                };
            var YAxes = new List<Axis>
                {
                    new Axis
                    {
                        Labels = xAxesLabels.ToArray(),
                        LabelsDensity = 0.25f
                    }
                };
            var XAxes = new List<Axis>
                {
                    new Axis
                    {
                        LabelsDensity = 0.25f,
                    }
                };
            cartesianChart3.Series = series; 
        }
        private void InitializeStacked()
        {
            cartesianChart1.Series = new ISeries[]
            {
                new StackedRowSeries<int>
                {
                    Values = new int[] { 3, 5, -3, 2, 5, -4, -2 },
                    Stroke = null,
                    DataLabelsPaint = new SolidColorPaint(new SKColor(45, 45, 45)),
                    DataLabelsSize = 14,
                    DataLabelsPosition = DataLabelsPosition.Middle,
                    XToolTipLabelFormatter =
                        p => $"{p.Coordinate.PrimaryValue:N} ({p.StackedValue!.Share:P})"
                },
                new StackedRowSeries<int>
                {
                    Values = new int[] { 4, 2, -3, 2, 3, 4, -2 },
                    Stroke = null,
                    DataLabelsPaint = new SolidColorPaint(new SKColor(45, 45, 45)),
                    DataLabelsSize = 14,
                    DataLabelsPosition = DataLabelsPosition.Middle,
                    XToolTipLabelFormatter =
                        p => $"{p.Coordinate.PrimaryValue:N} ({p.StackedValue!.Share:P})"
                },
                new StackedRowSeries<int>
                {
                    Values = new int[] { -2, 6, 6, 5, 4, 3, -2 },
                    Stroke = null,
                    DataLabelsPaint = new SolidColorPaint(new SKColor(45, 45, 45)),
                    DataLabelsSize = 14,
                    DataLabelsPosition = DataLabelsPosition.Middle,
                    XToolTipLabelFormatter =
                        p => $"{p.Coordinate.PrimaryValue:N} ({p.StackedValue!.Share:P})"
                }
            };
        }
        private void InitializeStacked2()
        {
            cartesianChart1.Series = new ISeries[]
            {
                 new StackedRowSeries<int>
                {
                    Values = new int[] { 3 },
                    Name = "Category 1",
                    Stroke = null,
                    DataLabelsPaint = new SolidColorPaint(new SKColor(45, 45, 45)),
                    DataLabelsSize = 14,
                    DataLabelsPosition = DataLabelsPosition.Middle,
                    XToolTipLabelFormatter =
                        p => $"{p.Coordinate.PrimaryValue:N} ({p.StackedValue!.Share:P})"
                },
                new StackedRowSeries<int>
                {
                    Values = new int[] { 6 },
                    Name = "Category 2",
                    Stroke = null,
                    DataLabelsPaint = new SolidColorPaint(new SKColor(45, 45, 45)),
                    DataLabelsSize = 14,
                    DataLabelsPosition = DataLabelsPosition.Middle,
                    XToolTipLabelFormatter =
                        p => $"{p.Coordinate.PrimaryValue:N} ({p.StackedValue!.Share:P})"
                },
                new StackedRowSeries<int>
                {
                    Values = new int[] { -2 },
                    Name = "Category 31",
                    Stroke = null,
                    DataLabelsPaint = new SolidColorPaint(new SKColor(45, 45, 45)),
                    DataLabelsSize = 14,
                    DataLabelsPosition = DataLabelsPosition.Middle,
                    XToolTipLabelFormatter =
                        p => $"{p.Coordinate.PrimaryValue:N} ({p.StackedValue!.Share:P})"
                }
            };
        }

        private void cartesianChart3_Load(object sender, EventArgs e)
        {

        }
    }
}
