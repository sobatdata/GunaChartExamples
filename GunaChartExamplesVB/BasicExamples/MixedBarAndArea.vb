Imports System
Imports System.Drawing
Imports Guna.Charts.WinForms

Namespace BasicExamples
    Friend Class MixedBarAndArea
        Public Shared Sub Example(ByVal chart As Guna.Charts.WinForms.GunaChart)
            ' Chart configuration
            chart.YAxes.GridLines.Display = False

            ' Create new barDataset
            Dim barDataset As New Guna.Charts.WinForms.GunaBarDataset()
            Dim r As New Random()
            barDataset.DataPoints.Add("January", r.Next(10, 100))
            barDataset.DataPoints.Add("February", r.Next(10, 100))
            barDataset.DataPoints.Add("March", r.Next(10, 100))
            barDataset.DataPoints.Add("April", r.Next(10, 100))
            barDataset.DataPoints.Add("May", r.Next(10, 100))
            barDataset.DataPoints.Add("June", r.Next(10, 100))
            barDataset.DataPoints.Add("July", r.Next(10, 100))

            ' Create new areaDataset
            Dim areaDataset As New Guna.Charts.WinForms.GunaAreaDataset()
            areaDataset.BorderWidth = 2
            areaDataset.FillColor = Guna.Charts.WinForms.ChartUtils.RandomColor()
            areaDataset.BorderColor = areaDataset.FillColor
            areaDataset.DataPoints.Add("January", r.Next(10, 100))
            areaDataset.DataPoints.Add("February", r.Next(10, 100))
            areaDataset.DataPoints.Add("March", r.Next(10, 100))
            areaDataset.DataPoints.Add("April", r.Next(10, 100))
            areaDataset.DataPoints.Add("May", r.Next(10, 100))
            areaDataset.DataPoints.Add("June", r.Next(10, 100))
            areaDataset.DataPoints.Add("July", r.Next(10, 100))

            ' Add a new dataset to chart.Datasets
            chart.Datasets.Add(barDataset)
            chart.Datasets.Add(areaDataset)

            ' An update was made to re-render the chart
            chart.Update()
        End Sub
    End Class
End Namespace
