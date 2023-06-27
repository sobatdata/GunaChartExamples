Imports System
Imports System.Drawing
Imports Guna.Charts.WinForms

Namespace BasicExamples
    Friend Class SteppedLine
        Public Shared Sub Example(ByVal chart As Guna.Charts.WinForms.GunaChart)
            Dim months As String() = {"January", "February", "March", "April", "May", "June", "July"}

            ' Chart configuration
            chart.YAxes.GridLines.Display = False

            ' Create a new dataset
            Dim dataset As New Guna.Charts.WinForms.GunaSteppedLineDataset()
            Dim r As New Random()
            For i As Integer = 0 To months.Length - 1
                ' random number
                Dim num As Integer = r.Next(10, 100)

                dataset.DataPoints.Add(months(i), num)
            Next
            dataset.PointFillColors = Guna.Charts.WinForms.ChartUtils.Colors(months.Length, Color.Orange)
            dataset.PointBorderColors = dataset.PointFillColors
            dataset.PointRadius = 4
            dataset.PointStyle = PointStyle.Triangle

            ' Add a new dataset to chart.Datasets
            chart.Datasets.Add(dataset)

            ' An update was made to re-render the chart
            chart.Update()
        End Sub
    End Class
End Namespace
