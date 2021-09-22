using System;
using System.Drawing;
using Guna.Charts.WinForms;

namespace BasicExamples
{
    class Bubble
    {
        public static void Example(Guna.Charts.WinForms.GunaChart chart)
        {
            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaBubbleDataset();
            var r = new Random();
            for (int i = 0; i < 15; i++)
            {
                //random number
                int radius = r.Next(5, 30);
                int x = r.Next(10, 100);
                int y = r.Next(10, 100);


                dataset.DataPoints.Add(radius, x, y);
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
