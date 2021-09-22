using System;
using System.Drawing; 
using System.Windows.Forms;
using Guna.Charts.WinForms;

namespace GunaChartExamples
{
    public partial class Sample : Form
    {
        private GunaChart chart;
        public Sample()
        {
            InitializeComponent();

            this.chart = new GunaChart() ;

            this.Controls.Add(this.chart);

            //Chart configuration 
            chart.YAxes.GridLines.Display = false;

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaBarDataset();
            var r = new Random();
            dataset.DataPoints.Add("January", r.Next(-50, 100));
            dataset.DataPoints.Add("February", r.Next(-50, 100));
            dataset.DataPoints.Add("March", r.Next(-50, 100));
            dataset.DataPoints.Add("April", r.Next(-50, 100));
            dataset.DataPoints.Add("May", r.Next(-50, 100));
            dataset.DataPoints.Add("June", r.Next(-50, 100));
            dataset.DataPoints.Add("July", r.Next(-50, 100));

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
