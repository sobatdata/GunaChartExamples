using System;
using System.Drawing;
using Guna.Charts.WinForms;

namespace BasicExamples
{
    class MixedBarAndLine
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
            var lineDataset = new Guna.Charts.WinForms.GunaLineDataset();
            lineDataset.FillColor = Guna.Charts.WinForms.ChartUtils.RandomColor();
            lineDataset.BorderColor = lineDataset.FillColor;
            for (int i = 0; i < months.Length; i++)
            {
                //random number
                int num = r.Next(10, 100);

                lineDataset.DataPoints.Add(months[i], num);
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(lineDataset);
            chart.Datasets.Add(barDataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
