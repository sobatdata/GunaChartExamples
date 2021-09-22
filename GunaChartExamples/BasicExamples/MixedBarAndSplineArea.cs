using System;
using System.Drawing;
using Guna.Charts.WinForms;

namespace BasicExamples
{
    class MixedBarAndSplineArea
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
            var splineAreaDataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            splineAreaDataset.FillColor = Guna.Charts.WinForms.ChartUtils.RandomColor();
            splineAreaDataset.BorderColor = splineAreaDataset.FillColor;
            for (int i = 0; i < months.Length; i++)
            {
                //random number
                int num = r.Next(10, 100);

                splineAreaDataset.DataPoints.Add(months[i], num);
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(barDataset);
            chart.Datasets.Add(splineAreaDataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
