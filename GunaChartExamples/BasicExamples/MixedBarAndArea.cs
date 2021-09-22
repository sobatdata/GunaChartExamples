using System;
using System.Drawing;
using Guna.Charts.WinForms;

namespace BasicExamples
{
    class MixedBarAndArea
    {
        public static void Example(Guna.Charts.WinForms.GunaChart chart)
        {
            //Chart configuration
            chart.YAxes.GridLines.Display = false;

            //Create new barDataset
            var barDataset = new Guna.Charts.WinForms.GunaBarDataset();
            var r = new Random();
            barDataset.DataPoints.Add("January", r.Next(10, 100));
            barDataset.DataPoints.Add("February", r.Next(10, 100));
            barDataset.DataPoints.Add("March", r.Next(10, 100));
            barDataset.DataPoints.Add("April", r.Next(10, 100));
            barDataset.DataPoints.Add("May", r.Next(10, 100));
            barDataset.DataPoints.Add("June", r.Next(10, 100));
            barDataset.DataPoints.Add("July", r.Next(10, 100));

            //Create new areaDataset
            var areaDataset = new Guna.Charts.WinForms.GunaAreaDataset(); 
            areaDataset.BorderWidth = 2;
            areaDataset.FillColor = Guna.Charts.WinForms.ChartUtils.RandomColor();
            areaDataset.BorderColor = areaDataset.FillColor;
            areaDataset.DataPoints.Add("January", r.Next(10, 100));
            areaDataset.DataPoints.Add("February", r.Next(10, 100));
            areaDataset.DataPoints.Add("March", r.Next(10, 100));
            areaDataset.DataPoints.Add("April", r.Next(10, 100));
            areaDataset.DataPoints.Add("May", r.Next(10, 100));
            areaDataset.DataPoints.Add("June", r.Next(10, 100));
            areaDataset.DataPoints.Add("July", r.Next(10, 100));

            //Add a new dataset to a chart.Datasets 
            chart.Datasets.Add(barDataset);
            chart.Datasets.Add(areaDataset);

            //An update was made to re-render the chart
            chart.Update();

        }
    }
}
