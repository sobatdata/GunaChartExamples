Imports System
Imports System.Drawing
Imports Guna.Charts.WinForms

Namespace BasicExamples
    Friend Class StackedHorizontalBar
        Public Shared Sub Example(ByVal chart As Guna.Charts.WinForms.GunaChart)
            Dim months As String() = {"January", "February", "March", "April", "May", "June", "July"}

            ' Chart configuration
            chart.YAxes.GridLines.Display = False

            ' Create a new dataset
            Dim dataset As New Guna.Charts.WinForms.GunaStackedHorizontalBarDataset()
            Dim r As New Random()
            For i As Integer = 0 To months.Length - 1
                ' random number
                Dim num As Integer = r.Next(10, 100)

                dataset.DataPoints.Add(months(i), num)
            Next

            ' Create a new dataset
            Dim dataset2 As New Guna.Charts.WinForms.GunaStackedHorizontalBarDataset()
            For i As Integer = 0 To months.Length - 1
                ' random number
                Dim num As Integer = r.Next(10, 100)

                dataset2.DataPoints.Add(months(i), num)
            Next
            dataset2.FillColors = Guna.Charts.WinForms.ChartUtils.RandomColors(months.Length)

            ' Add new datasets to chart.Datasets
            chart.Datasets.Add(dataset)
            chart.Datasets.Add(dataset2)

            ' An update was made to re-render the chart
            chart.Update()
        End Sub
    End Class
End Namespace
