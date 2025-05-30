namespace LiveChartsSAmple
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pieChart4 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            cartesianChart3 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            cartesianChart2 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel1 = new Panel();
            pieChart3 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            pieChart2 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            button1 = new Button();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1345, 761);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pieChart4);
            tabPage1.Controls.Add(cartesianChart3);
            tabPage1.Controls.Add(cartesianChart2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(pieChart2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(pieChart1);
            tabPage1.Controls.Add(cartesianChart1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1337, 733);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pieChart4
            // 
            pieChart4.InitialRotation = 0D;
            pieChart4.IsClockwise = true;
            pieChart4.Location = new Point(796, 505);
            pieChart4.MaxAngle = 360D;
            pieChart4.MaxValue = null;
            pieChart4.MinValue = 0D;
            pieChart4.Name = "pieChart4";
            pieChart4.Size = new Size(150, 150);
            pieChart4.TabIndex = 18;
            // 
            // cartesianChart3
            // 
            cartesianChart3.Location = new Point(17, 493);
            cartesianChart3.Name = "cartesianChart3";
            cartesianChart3.Size = new Size(739, 204);
            cartesianChart3.TabIndex = 17;
            cartesianChart3.Load += cartesianChart3_Load;
            // 
            // cartesianChart2
            // 
            cartesianChart2.Location = new Point(17, 257);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(739, 214);
            cartesianChart2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(pieChart3);
            panel1.Location = new Point(950, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 100);
            panel1.TabIndex = 15;
            // 
            // pieChart3
            // 
            pieChart3.Dock = DockStyle.Top;
            pieChart3.InitialRotation = 0D;
            pieChart3.IsClockwise = true;
            pieChart3.Location = new Point(0, 0);
            pieChart3.MaxAngle = 360D;
            pieChart3.MaxValue = null;
            pieChart3.MinValue = 0D;
            pieChart3.Name = "pieChart3";
            pieChart3.Size = new Size(162, 156);
            pieChart3.TabIndex = 14;
            // 
            // pieChart2
            // 
            pieChart2.BorderStyle = BorderStyle.Fixed3D;
            pieChart2.InitialRotation = 0D;
            pieChart2.IsClockwise = true;
            pieChart2.Location = new Point(785, 174);
            pieChart2.Margin = new Padding(0);
            pieChart2.MaxAngle = 360D;
            pieChart2.MaxValue = null;
            pieChart2.MinValue = 0D;
            pieChart2.Name = "pieChart2";
            pieChart2.Size = new Size(150, 150);
            pieChart2.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(842, 430);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(822, 401);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1010, 401);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(34, 23);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // pieChart1
            // 
            pieChart1.BorderStyle = BorderStyle.Fixed3D;
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(785, 11);
            pieChart1.Margin = new Padding(0);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(150, 150);
            pieChart1.TabIndex = 8;
            // 
            // cartesianChart1
            // 
            cartesianChart1.BorderStyle = BorderStyle.Fixed3D;
            cartesianChart1.Location = new Point(14, 11);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(742, 219);
            cartesianChart1.TabIndex = 7;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1337, 733);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 761);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart2;
        private Button button1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private TabPage tabPage2;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart3;
        private Panel panel1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart3;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart2;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart4;
    }
}
