Imports System
Imports System.Drawing
Imports Guna.Charts.WinForms

Namespace BasicExamples
    Friend Class Spline
        Public Shared Sub Example(ByVal chart As Guna.Charts.WinForms.GunaChart)
            Dim months As String() = {"January", "February", "March", "April", "May", "June", "July"}

            ' Chart configuration
            chart.YAxes.GridLines.Display = False

            ' Create a new dataset
            Dim dataset As New Guna.Charts.WinForms.GunaSplineDataset()
            dataset.PointRadius = 3
            dataset.PointStyle = PointStyle.Circle
            Dim r As New Random()
            For i As Integer = 0 To months.Length - 1
                ' random number
                Dim num As Integer = r.Next(10, 100)

                dataset.DataPoints.Add(months(i), num)
            Next

            ' Add a new dataset to chart.Datasets
            chart.Datasets.Add(dataset)

            ' An update was made to re-render the chart
            chart.Update()
        End Sub
    End Class
End Namespace
