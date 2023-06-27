Imports Guna.Charts.WinForms

Public Class Sample
    Private Sub Sample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chart = New GunaChart()

        Me.Controls.Add(chart)

        'Chart configuration
        chart.YAxes.GridLines.Display = False

        'Create a new dataset
        Dim dataset As New Guna.Charts.WinForms.GunaBarDataset()
        Dim r As New Random()
        dataset.DataPoints.Add("January", r.Next(-50, 100))
        dataset.DataPoints.Add("February", r.Next(-50, 100))
        dataset.DataPoints.Add("March", r.Next(-50, 100))
        dataset.DataPoints.Add("April", r.Next(-50, 100))
        dataset.DataPoints.Add("May", r.Next(-50, 100))
        dataset.DataPoints.Add("June", r.Next(-50, 100))
        dataset.DataPoints.Add("July", r.Next(-50, 100))

        'Add a new dataset to a chart.Datasets
        chart.Datasets.Add(dataset)

        'An update was made to re-render the chart
        chart.Update()
    End Sub
End Class