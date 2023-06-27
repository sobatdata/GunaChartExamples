Imports System
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class Form2
    Private setupName As String = String.Empty

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim names As String() = {"Test", "Setup"}
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
                                         ReadCode(button.Text)
                                         panel2.Size = New Size(5, button.Height)
                                         panel2.Location = New Point(panel1.Width - 5, button.Top)
                                         panel2.BringToFront()
                                     End Sub

            panel1.Controls.Add(button)
        Next
    End Sub


    Private Sub ReadCode(ByVal name As String)
        If setupName = String.Empty Then
            richTextBox1.Text = String.Empty
        Else
            If name = "Setup" Then
                richTextBox1.Text = System.IO.File.ReadAllText(Application.StartupPath & "\BasicExamples\" & setupName & ".vb")
                SyntaxHighlighter(richTextBox1)
            Else
                richTextBox1.Text = vbCrLf & "public void Test" & vbCrLf & "{" & vbCrLf & "    BasicExamples." & setupName & ".Example(this.gunaChart1);" & vbCrLf & "}"
                SyntaxHighlighter(richTextBox1)
            End If
        End If
    End Sub

    Public Sub ShowForm(ByVal name As String)
        Text = name
        setupName = name
        Show()
        If TypeOf panel1.Controls(1) Is Button Then
            Dim button = DirectCast(panel1.Controls(1), Button)
            button.PerformClick()
        End If
    End Sub

    Private Sub ProcessRegex(ByVal richTextBox As RichTextBox, ByVal matches As MatchCollection, ByVal color As Color)
        For Each m As Match In matches
            richTextBox.SelectionStart = m.Index
            richTextBox.SelectionLength = m.Length
            richTextBox.SelectionColor = color
        Next
    End Sub

    Public Sub SyntaxHighlighter(ByVal richTextBox As RichTextBox)
        Dim keywordMatches As MatchCollection = Regex.Matches(richTextBox.Text, "\b(for|this|public|private|partial|static|namespace|class|using|void|foreach|in|new|int|float|double|string|bool|var|object|false|true)\b")
        Dim commentMatches As MatchCollection = Regex.Matches(richTextBox.Text, "//.*$", RegexOptions.Multiline)
        Dim stringMaches As MatchCollection = Regex.Matches(richTextBox.Text, """.+?""")
        Dim numberMaches As MatchCollection = Regex.Matches(richTextBox.Text, "\b(?:[0-9]*\.)?[0-9]+\b")
        Dim gunaMaches As MatchCollection = Regex.Matches(richTextBox.Text, "\b(GunaChart|GunaAreaDataset|GunaBarDataset|GunaBubbleDataset|GunaDoughnutDataset|GunaHorizontalBarDataset|GunaLineDataset|GunaPieDataset|GunaPolarAreaDataset|GunaRadarDataset|GunaRoundedBarDataset|GunaScatterDataset|GunaSplineDataset|GunaSplineAreaDataset|GunaStackedBarDataset|GunaStackedHorizontalBarDataset|GunaSteppedAreaDataset|GunaSteppedLine)\b")

        Dim tmpIndex As Integer = richTextBox.SelectionStart
        Dim tmplLength As Integer = richTextBox.SelectionLength

        richTextBox.SelectionStart = 0
        richTextBox.SelectionLength = richTextBox.Text.Length
        richTextBox.SelectionColor = Color.LightGray
        ProcessRegex(richTextBox, keywordMatches, Color.DodgerBlue)
        ProcessRegex(richTextBox, numberMaches, Color.FromArgb(197, 230, 147))
        ProcessRegex(richTextBox, commentMatches, Color.FromArgb(63, 131, 61))
        ProcessRegex(richTextBox, stringMaches, Color.FromArgb(255, 177, 146))
        ProcessRegex(richTextBox, gunaMaches, Color.FromArgb(92, 194, 154))
        richTextBox.SelectionStart = tmpIndex
        richTextBox.SelectionLength = tmplLength
        richTextBox.SelectionColor = Color.LightGray
    End Sub
End Class