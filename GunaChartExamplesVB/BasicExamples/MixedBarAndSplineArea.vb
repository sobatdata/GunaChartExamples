Imports System
Imports System.Drawing
Imports Guna.Charts.WinForms

Namespace BasicExamples
    Friend Class MixedBarAndSplineArea
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

            ' Create new splineAreaDataset
            Dim splineAreaDataset As New Guna.Charts.WinForms.GunaSplineAreaDataset()
            splineAreaDataset.FillColor = Guna.Charts.WinForms.ChartUtils.RandomColor()
            splineAreaDataset.BorderColor = splineAreaDataset.FillColor
            For i As Integer = 0 To months.Length - 1
                ' random number
                Dim num As Integer = r.Next(10, 100)

                splineAreaDataset.DataPoints.Add(months(i), num)
            Next

            ' Add a new dataset to chart.Datasets
            chart.Datasets.Add(barDataset)
            chart.Datasets.Add(splineAreaDataset)

            ' An update was made to re-render the chart
            chart.Update()
        End Sub
    End Class
End Namespace
