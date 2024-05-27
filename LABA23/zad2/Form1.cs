using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            Chart chart1 = new Chart();
            chart1.Width = 400;
            chart1.Height = 300;
            chart1.ChartAreas.Add(new ChartArea("Main"));

            Series series = new Series("y = x");
            series.ChartType = SeriesChartType.Line;

            for (double x = -10; x <= 10; x += 0.1)
            {
                double y = Math.Sin(x);
                series.Points.AddXY(x, y);
            }

            chart1.Series.Add(series);

            this.Controls.Add(chart1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
