Imports System
Imports System.Drawing
Imports Guna.Charts.WinForms

Namespace BasicExamples
    Friend Class MixedBarAndSteppedLine
        Public Shared Sub Example(ByVal chart As Guna.Charts.WinForms.GunaChart)
            Dim months As String() = {"January", "February", "March", "April", "May", "June", "July"}

            ' Chart configuration
            chart.YAxes.GridLines.Display = False

            ' Create new barDataset
            Dim barDataset As New Guna.Charts.WinForms.GunaBarDataset()
            Dim r As New Random()
            For i As Integer = 0 To months.Length - 1
                ' random number
                Dim num As Integer = r.Next(10, 100)

                barDataset.DataPoints.Add(months(i), num)
            Next

            ' Create new steppedLineDataset
            Dim steppedLineDataset As New Guna.Charts.WinForms.GunaSteppedLineDataset()
            steppedLineDataset.FillColor = Guna.Charts.WinForms.ChartUtils.RandomColor()
            steppedLineDataset.BorderColor = steppedLineDataset.FillColor
            For i As Integer = 0 To months.Length - 1
                ' random number
                Dim num As Integer = r.Next(10, 100)

                steppedLineDataset.DataPoints.Add(months(i), num)
            Next

            ' Add a new dataset to chart.Datasets
            chart.Datasets.Add(steppedLineDataset)
            chart.Datasets.Add(barDataset)

            ' An update was made to re-render the chart
            chart.Update()
        End Sub
    End Class
End Namespace
