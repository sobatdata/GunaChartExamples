using System;
using System.Drawing;
using Guna.Charts.WinForms;

namespace BasicExamples
{
    class MixedBarAndSpline
    {
        public static void Example(Guna.Charts.WinForms.GunaChart chart)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July" };

            //Chart configuration 
            chart.YAxes.GridLines.Display = false;

            //Create new barDataset
            var barDataset = new Guna.Charts.WinForms.GunaBarDataset(); 
            var r = new Random();
            for (int i = 0; i < months.Length; i++)
            {
                //random number
                int num = r.Next(10, 100);
                
                barDataset.DataPoints.Add(months[i], num);
            }

            //Create new areaDataset
            var splineDataset = new Guna.Charts.WinForms.GunaSplineDataset(); 
            splineDataset.FillColor = Guna.Charts.WinForms.ChartUtils.RandomColor();
            splineDataset.BorderColor = splineDataset.FillColor;
            for (int i = 0; i < months.Length; i++)
            {
                //random number
                int num = r.Next(10, 100);

                splineDataset.DataPoints.Add(months[i], num);
            }

            //Add a new dataset to a chart.Datasets  
            chart.Datasets.Add(splineDataset); 
            chart.Datasets.Add(barDataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
