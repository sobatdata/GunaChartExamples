Imports System
Imports System.Drawing
Imports Guna.Charts.WinForms

Namespace BasicExamples
    Friend Class Bubble
        Public Shared Sub Example(ByVal chart As Guna.Charts.WinForms.GunaChart)
            ' Create a new dataset
            Dim dataset As New Guna.Charts.WinForms.GunaBubbleDataset()
            Dim r As New Random()
            For i As Integer = 0 To 14
                ' random number
                Dim radius As Integer = r.Next(5, 30)
                Dim x As Integer = r.Next(10, 100)
                Dim y As Integer = r.Next(10, 100)

                dataset.DataPoints.Add(radius, x, y)
            Next

            ' Add a new dataset to chart.Datasets
            chart.Datasets.Add(dataset)

            ' An update was made to re-render the chart
            chart.Update()
        End Sub
    End Class
End Namespace
