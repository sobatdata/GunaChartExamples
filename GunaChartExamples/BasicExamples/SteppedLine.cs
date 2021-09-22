using System;
using System.Drawing; 
using Guna.Charts.WinForms;

namespace BasicExamples
{
    class SteppedLine
    {
        public static void Example(Guna.Charts.WinForms.GunaChart chart)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July" };

            //Chart configuration 
            chart.YAxes.GridLines.Display = false; 

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaSteppedLineDataset();
            var r = new Random();
            for (int i = 0; i < months.Length; i++)
            {
                //random number
                int num = r.Next(10, 100); 

                dataset.DataPoints.Add(months[i],num);
            }
            dataset.PointFillColors = Guna.Charts.WinForms.ChartUtils.Colors(months.Length, Color.Orange);
            dataset.PointBorderColors = dataset.PointFillColors; 
            dataset.PointRadius = 4;
            dataset.PointStyle = PointStyle.Triangle;

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
