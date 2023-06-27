Imports Guna.Charts.WinForms
Public Class Form1
    Private selected As String = String.Empty


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim names As String() = {"Area", "Bar", "Bubble", "Doughnut", "HorizontalBar", "Line", "Pie", "PolarArea", "Radar", "RoundedBar", "Scatter", "Spline", "SplineArea", "StackedBar", "StackedHorizontalBar", "SteppedArea", "SteppedLine", "MixedBarAndArea", "MixedBarAndLine", "MixedBarAndSpline", "MixedBarAndSplineArea", "MixedBarAndSteppedArea", "MixedBarAndSteppedLine"}
        panel1.BackColor = Color.FromArgb(20, 0, 0, 0)
        For i As Integer = names.Length - 1 To 0 Step -1
            Dim button = New Button() With {
                   .BackColor = Color.Empty,
                   .Text = names(i),
                   .TextAlign = ContentAlignment.MiddleLeft,
                   .Dock = DockStyle.Top,
                   .Height = 25,
                   .FlatStyle = FlatStyle.Flat,
                   .Padding = New Padding(10, 0, 0, 0)
               }
            button.FlatAppearance.BorderSize = 0
            button.FlatAppearance.MouseOverBackColor = Color.DodgerBlue

            AddHandler button.Click, Sub(s, evnt)
                                         selected = button.Text
                                         SelectBasicExamples(selected)
                                         panel2.Size = New Size(5, button.Height)
                                         panel2.Location = New Point(panel1.Width - 5, button.Top)
                                         panel2.BringToFront()
                                     End Sub

            panel1.Controls.Add(button)
        Next i

        AddHandler button1.Click, Sub(s, evnt)
                                      Dim form2 = New Form2()
                                      form2.ShowForm(selected)
                                  End Sub

        AddHandler radioButton1.CheckedChanged, Sub(s, evnt)
                                                    If radioButton1.Checked Then
                                                        SelectBasicExamples(selected)
                                                        BackColor = Color.FromArgb(38, 41, 59)
                                                        ForeColor = Color.LightSteelBlue
                                                    End If
                                                End Sub

        AddHandler radioButton2.CheckedChanged, Sub(s, evnt)
                                                    If radioButton2.Checked Then
                                                        SelectBasicExamples(selected)
                                                        BackColor = Color.White
                                                        ForeColor = Color.Black
                                                    End If
                                                End Sub

        radioButton1.Checked = True
    End Sub

    Private Sub ApplyConfig()
        If radioButton1.Checked Then
            gunaChart1.ApplyConfig(ConfigExamples.Dark.Config(), Color.FromArgb(38, 41, 59))
        Else
            gunaChart1.ApplyConfig(ConfigExamples.Light.Config(), Color.White)
        End If
    End Sub

    Private Sub SelectBasicExamples(ByVal name As String)
        gunaChart1.Datasets.Clear()
        ApplyConfig()

        If name = "Area" Then
            BasicExamples.Area.Example(gunaChart1)
        ElseIf name = "Bar" Then
            BasicExamples.Bar.Example(gunaChart1)
        ElseIf name = "RoundedBar" Then
            BasicExamples.RoundedBar.Example(gunaChart1)
        ElseIf name = "Bubble" Then
            BasicExamples.Bubble.Example(gunaChart1)
        ElseIf name = "Doughnut" Then
            BasicExamples.Doughnut.Example(gunaChart1)
        ElseIf name = "HorizontalBar" Then
            BasicExamples.HorizontalBar.Example(gunaChart1)
        ElseIf name = "Line" Then
            BasicExamples.Line.Example(gunaChart1)
        ElseIf name = "Pie" Then
            BasicExamples.Pie.Example(gunaChart1)
        ElseIf name = "PolarArea" Then
            BasicExamples.PolarArea.Example(gunaChart1)
        ElseIf name = "Radar" Then
            BasicExamples.Radar.Example(gunaChart1)
        ElseIf name = "Scatter" Then
            BasicExamples.Scatter.Example(gunaChart1)
        ElseIf name = "Spline" Then
            BasicExamples.Spline.Example(gunaChart1)
        ElseIf name = "SplineArea" Then
            BasicExamples.SplineArea.Example(gunaChart1)
        ElseIf name = "StackedBar" Then
            BasicExamples.StackedBar.Example(gunaChart1)
        ElseIf name = "StackedHorizontalBar" Then
            BasicExamples.StackedHorizontalBar.Example(gunaChart1)
        ElseIf name = "SteppedArea" Then
            BasicExamples.SteppedArea.Example(gunaChart1)
        ElseIf name = "SteppedLine" Then
            BasicExamples.SteppedLine.Example(gunaChart1)
        ElseIf name = "MixedBarAndArea" Then
            BasicExamples.MixedBarAndArea.Example(gunaChart1)
        ElseIf name = "MixedBarAndSpline" Then
            BasicExamples.MixedBarAndSpline.Example(gunaChart1)
        ElseIf name = "MixedBarAndSplineArea" Then
            BasicExamples.MixedBarAndSplineArea.Example(gunaChart1)
        ElseIf name = "MixedBarAndSteppedArea" Then
            BasicExamples.MixedBarAndSteppedArea.Example(gunaChart1)
        ElseIf name = "MixedBarAndSteppedLine" Then
            BasicExamples.MixedBarAndSteppedLine.Example(gunaChart1)
        ElseIf name = "MixedBarAndLine" Then
            BasicExamples.MixedBarAndLine.Example(gunaChart1)
        End If
    End Sub


End Class