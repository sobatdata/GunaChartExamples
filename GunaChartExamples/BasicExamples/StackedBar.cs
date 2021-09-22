using System;
using System.Drawing;
using Guna.Charts.WinForms;

namespace BasicExamples
{
    class StackedBar
    {
        public static void Example(Guna.Charts.WinForms.GunaChart chart)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July" };

            //Chart configuration 
            chart.YAxes.GridLines.Display = false;

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaStackedBarDataset();
            var r = new Random();
            for (int i = 0; i < months.Length; i++)
            {
                //random number
                int num = r.Next(10, 100);

                dataset.DataPoints.Add(months[i], num);
            }

            //Create a new dataset ;
            var dataset2 = new Guna.Charts.WinForms.GunaStackedBarDataset();
            for (int i = 0; i < months.Length; i++)
            {
                //random number
                int num = r.Next(10, 100);

                dataset2.DataPoints.Add(months[i], num);
            }
            dataset2.FillColors = Guna.Charts.WinForms.ChartUtils.RandomColors(months.Length);

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);
            chart.Datasets.Add(dataset2);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
