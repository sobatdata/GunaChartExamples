Imports System
Imports Guna.Charts.WinForms

Namespace BasicExamples
    Friend Class Area
        Public Shared Sub Example(ByVal chart As Guna.Charts.WinForms.GunaChart)
            ' Create a new dataset
            Dim dataset As New Guna.Charts.WinForms.GunaAreaDataset()
            dataset.PointStyle = PointStyle.Circle
            Dim r As New Random()
            dataset.DataPoints.Add("January", r.Next(10, 100))
            dataset.DataPoints.Add("February", r.Next(10, 100))
            dataset.DataPoints.Add("March", r.Next(10, 100))
            dataset.DataPoints.Add("April", r.Next(10, 100))
            dataset.DataPoints.Add("May", r.Next(10, 100))
            dataset.DataPoints.Add("June", r.Next(10, 100))
            dataset.DataPoints.Add("July", r.Next(10, 100))

            ' Add a new dataset to chart.Datasets
            chart.Datasets.Add(dataset)

            ' An update was made to re-render the chart
            chart.Update()
        End Sub
    End Class
End Namespace
